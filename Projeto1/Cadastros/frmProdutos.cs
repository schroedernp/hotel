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
    public partial class frmProdutos : Form
    {
        FornecedoresDAL fdal = new FornecedoresDAL();
        ProdutosDAL pdal = new ProdutosDAL();
        public frmProdutos() //Construtor
        {
            InitializeComponent();
        }
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            cbFornecedor.Enabled = true;
            txtEstoque.Enabled = true;
            btnImg.Enabled = true;
            cbBuscarNomeProduto.Enabled = true;
            txtNome.Focus();

        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            cbFornecedor.Enabled = false;
            txtEstoque.Enabled = false;
            btnImg.Enabled = false;
            cbBuscarNomeProduto.Enabled = true;

        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtEstoque.Text = "";
            LimparFoto();
        }
       
        private void LimparFoto()
        {
            //Aqui é onde eu passo o caminho para a foto... Não passo a extensão...
            img.Image = Properties.Resources.sem_foto;
        }
        private void frmProdutos_Load(object sender, EventArgs e)
        {
            LimparFoto();
            CarregarComboBoxTodosFornecedores();
            CarregarComboBoxTodosProdutos();
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
        private void CarregarComboBoxTodosProdutos()
        {
            ProdutosDAL pdal = new ProdutosDAL();
            List<Produtos> list_produtos = pdal.ListarTodosProdutos();
            Produtos temp = new Produtos();
            temp.id = 0;
            temp.nome = "Selecione...";
            list_produtos.Insert(0, temp);
            cbBuscarNomeProduto.DisplayMember = "nome"; //campo que será mostrado...Relacionamento entre os componentes
            cbBuscarNomeProduto.ValueMember = "id"; //valor que mando para o banco de dado 
            cbBuscarNomeProduto.DataSource = list_produtos;
        }
        private void CarregarGridViewTodosProdutos()
        {
            List<Produtos> funcionarios_dgv = pdal.ListarTodosProdutos();
            dgvProdutos.DataSource = funcionarios_dgv;
        }


        public Produtos setValoresProdutos()
        {
            var p = dgvProdutos.SelectedRows[0].DataBoundItem as Produtos;
            
            p.nome = txtNome.Text;
            p.descricao = txtDescricao.Text;
            p.estoque = Int32.Parse(txtEstoque.Text);
            var fornecedor_cb = (Fornecedores)cbFornecedor.SelectedItem;
            p.fornecedor = fornecedor_cb.id;
            p.valor_venda = Decimal.Parse(txtValor.Text.Replace(".",","));
            // var cargo = (Cargos)cbCargo.SelectedItem;
            //f.idCargo = cargo.id;
            return p;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CarregarGridViewTodosProdutos();

            if (cbFornecedor.Text.Equals(""))
            {
                MessageBox.Show("Cadastre antes um Fornecedor.", "Informativo Hotel Carmos ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            HabilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var p = setValoresProdutos();
            int registo = pdal.ExcluirProdutos(p);
            if (registo > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Informatico Hotel Carmo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Resultado Eliminado com Sucesso", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("A eliminação da base de dados falhou.", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //Após o código para excluir:
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;
            LimparCampos();
            DesabilitarCampos();
            CarregarGridViewTodosProdutos();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha o Nome", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtValor.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha o Valor do Produto", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }
            //Após o código para editar:
            var prod = setValoresProdutos();

            int check = pdal.EditarProduto(prod);

            //Após o código para editar:
            if (check > 0)
            {
                MessageBox.Show("Registro Editado com Sucesso", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            LimparCampos();
            DesabilitarCampos();
            CarregarGridViewTodosProdutos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha o Nome", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtValor.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha o Valor do Produto", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }
            var fornecedor_cb = (Fornecedores)cbFornecedor.SelectedItem; ////Faço uma corversao do que eu tenho na minha CB para Fornecedores

            int check = pdal.VerificarNome(txtNome.Text);
            if (check != 0)
            {
                Produtos prod = new Produtos(txtNome.Text, txtDescricao.Text, fornecedor_cb.id, Decimal.Parse(txtValor.Text.Replace(".", ",")));
                int validar = pdal.InserirProduto(prod);
                if (validar > 0)
                {
                    MessageBox.Show("Registro Preenchido com Sucesso da Base de Dados", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("O registo na base de dados falhou.", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            //Após o código para salvar:
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            LimparCampos();
            DesabilitarCampos();
            CarregarGridViewTodosProdutos();
            CarregarComboBoxTodosFornecedores();

        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog(); //Criei um objeto do tipo caixa de diálogo onde busco arquivos
            
            //Filtro as informações recebidas por esta caixa de diálogo, é qdo abro uma imagem para ser aberta e escolho a extensão, isso é filtrar...
            //A primeira informação define o que está escrito lá e a segunda o que realmente será filtrado
            dialog.Filter = "Arquivos de Imagens(*.jpg; *.png)|*.jpg;*.png|All files (*.*)|*.*";
            // dialog.Filter = "Arquivos JPG(*.jpg)|*.jpg|Arquivos PNG(*.png)|*.png|All files (*.*)|*.*";  
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString(); //Aqui é a localização onde ela carregou o meu arquivo
                //MessageBox.Show(foto);
                img.ImageLocation = foto;//ImageLocation fornece o caminho da minha foto
            }
        }

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparCampos();
            Fornecedores fornecedores = (Fornecedores)cbFornecedor.SelectedItem;
            List<Fornecedores> lstFonecedorfiltrado = fdal.FiltrarFornecedoroNome(fornecedores);
            dgvProdutos.DataSource = lstFonecedorfiltrado;
   

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProdutos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            if (dgvProdutos.SelectedRows.Count > 0)
            {

                var p = dgvProdutos.SelectedRows[0].DataBoundItem as Produtos; //var é uma variável mais moderna que reduz a dependencia do codigo.
                                                                                       //posso nao saber o tipo de dado e usa-lo. É uma variavel sem tipo, guarda a informmacao em memoria, mas nao na compilacao. 

                txtNome.Text = p.nome;
                txtDescricao.Text = p.descricao;
                txtEstoque.Text = p.estoque.ToString();
                cbFornecedor.Text = p.nome_fornecedor;
                txtValor.Text = p.valor_venda.ToString();


            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBuscarNomeProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparCampos();
            Produtos prod = (Produtos)cbBuscarNomeProduto.SelectedItem;
            List<Produtos> lstprodutofiltrado = pdal.FiltrarProdutoNome(prod);
            dgvProdutos.DataSource = lstprodutofiltrado;
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Program.chamadaProdutos == "estoque")
            {
                Program.nomeProduto = txtNome.Text;
                Program.estoqueProduto = txtEstoque.Text;
                Program.idProduto = Int32.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
                Program.fornecedor = (Fornecedores)cbFornecedor.SelectedItem;

                Close();
            }
        }

        private void cbFornecedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    
}
