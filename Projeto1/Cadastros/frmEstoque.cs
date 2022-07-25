using Projeto1.DAL;
using Projeto1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1.Cadastros
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            CarregarComboBoxTodosFornecedores();
        }

        private void CarregarComboBoxTodosFornecedores()
        {
            FornecedoresDAL dal = new FornecedoresDAL();
            List<Fornecedores> list_fornecedores = dal.ListarTodosFornecedores();
            Fornecedores temp = new Fornecedores();
            temp.id = 0;
            temp.nome = "Selecione...";
            list_fornecedores.Insert(0, temp);
            cbFornecedor.DisplayMember = "nome"; //campo que será mostrado...Relacionamento entre os componentes
            cbFornecedor.ValueMember = "id"; //valor que mando para o banco de dado 
            cbFornecedor.DataSource = list_fornecedores;
        }

        private void HabilitarCampos()
        {
            //txtProduto.Enabled = true;
            txtValor.Enabled = true;
            txtValor.Enabled = true;
            cbFornecedor.Enabled = true;
            //txtEstoque.Enabled = true;
            txtQuantidade.Enabled = true;
            txtQuantidade.Focus();
            btnSalvar.Enabled = true;

        }

        private void DesabilitarCampos()
        {
            txtProduto.Enabled = false;
            txtValor.Enabled = false;
            txtValor.Enabled = false;
            cbFornecedor.Enabled = false;
            txtEstoque.Enabled = false;
            txtQuantidade.Enabled = false;
            txtQuantidade.Focus();
            btnSalvar.Enabled = false;

        }
        private void LimparCampos()
        {
            txtProduto.Text = "";
            txtValor.Text = "";
            txtValor.Text = "";
            cbFornecedor.Text = "Selecione...";
            txtEstoque.Text = "";
            txtQuantidade.Text = "";
            txtQuantidade.Focus();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();

            Program.chamadaProdutos = "estoque";
            Cadastros.frmProdutos form = new Cadastros.frmProdutos();
            form.Show();
        }

        private void frmEstoque_Activated(object sender, EventArgs e)
        {
            FornecedoresDAL fdal = new FornecedoresDAL();
            txtEstoque.Text = Program.estoqueProduto;
            txtProduto.Text = Program.nomeProduto;
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha o nome do produto", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProduto.Text = "";
                txtProduto.Focus();
                return;
            }
            
        
            if (cbFornecedor.Text.Equals("Selecione..."))
            {
                MessageBox.Show("Preencha o fornecedor", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProduto.Text = "";
                txtProduto.Focus();
                return;
            }

            if (txtQuantidade.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha a quantidade do produto", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantidade.Text = "";
                txtQuantidade.Focus();
                return;
            }
            //Após o código para editar:
            //var fornecedor_cb = (Fornecedores)cbFornecedor.SelectedItem;
            Produtos p = new Produtos(Program.idProduto, (Int32.Parse(txtQuantidade.Text) + Int32.Parse(txtEstoque.Text)), Program.fornecedor.id, Decimal.Parse(txtValor.Text));


            ProdutosDAL pdal = new ProdutosDAL();

            int check = pdal.AtualizarEstoque(p);

            //Após o código para editar:
            if (check > 0)
            {
                MessageBox.Show("Lançamento de estoque feito com sucesso!", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("O lançamento falhou", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimparCampos();
            DesabilitarCampos();
       
        }

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
