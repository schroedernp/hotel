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
    public partial class frmFornecedores : Form
    {
        FornecedoresDAL fdal = new FornecedoresDAL();

        public frmFornecedores()
        {
            InitializeComponent();
        }
        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            mkNIF.Enabled = true;
            CarregarGridViewTodosFornecedores();
            dgvFornecedores.Columns["id"].Visible = false;
     
            
        }

        private void CarregarGridViewTodosFornecedores()
        {
            List<Fornecedores> fornecedores_dgv = fdal.ListarTodosFornecedores();
            dgvFornecedores.DataSource = fornecedores_dgv;
        }


        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtNIF.Enabled = true;
            mkNIF.Enabled = true;
            mkNIF.Clear();
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            txtNome.Focus();
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtNIF.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtNome.Focus();
        }
        private void LimparCampos()
        {

            txtNome.Text = "";
            txtNIF.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtNome.Focus();
        }


        public Fornecedores setValoresFornecedores()
        {


            var fornecedor = dgvFornecedores.SelectedRows[0].DataBoundItem as Fornecedores;

        
            fornecedor.nome = txtNome.Text;
            fornecedor.nif = txtNIF.Text;
            fornecedor.telefone = txtTelefone.Text;
            fornecedor.endereco = txtEndereco.Text;
            fornecedor.email = txtEmail.Text;


            return fornecedor;
        }
        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            CarregarGridViewTodosFornecedores();


            dgvFornecedores.Columns["idCargo"].Visible = false;


        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            CarregarGridViewTodosFornecedores();
            HabilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha o nome do fornecedor", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtNIF.Text.ToString().Trim().Equals("000,000,000")) //Rever isso!
            {
                MessageBox.Show("Preencha o NIF do fornecedor", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNIF.Text = "";
                txtNIF.Focus();
                return;
            }

     
            
            int check = fdal.BuscarNIF(txtNIF.Text);
            if (check != 0)
            {
            
                Fornecedores fornecedor = new Fornecedores(txtNome.Text, txtNIF.Text, txtEndereco.Text, txtTelefone.Text, txtEmail.Text);
                int validar = fdal.InserirFornecedor(fornecedor);
                if (validar > 0)
                {
                    MessageBox.Show("Registro Preenchido com Sucesso da Base de Dados", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("O registo na base de dados falhou.", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Após o código para salvar:
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                LimparCampos();
                DesabilitarCampos();

                CarregarGridViewTodosFornecedores();   
            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.\n Este NIF já se encontra cadastrado.", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNIF.Text = "";
            }     
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha o nome do fornecedor", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtNIF.Text.ToString().Trim().Equals("   .   ."))
            {
                MessageBox.Show("Preencha o NIF do fornecedor", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNIF.Text = "";
                txtNIF.Focus();
                return;
            }


            var f = setValoresFornecedores();

            int check = fdal.EditarFornecedores(f);

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
            CarregarGridViewTodosFornecedores();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var f = setValoresFornecedores();
            int registo = fdal.ExcluirFornecedores(f);
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
            CarregarGridViewTodosFornecedores();
        }

        private void mkNIF_TextChanged(object sender, EventArgs e)
        {
            {
                if (mkNIF.Text.Equals("   .   .  "))
                {
                    CarregarGridViewTodosFornecedores();
                }
                else
                {
                    if (mkNIF.Text.Length == 11)
                    {
                        
                        //List<Fornecedores> lstFornecedorfiltrado = fdal.FiltrarFornecedorNIF(mkNIF.Text.Replace(" ",""));
                        List<Fornecedores> lstFornecedorfiltrado = fdal.FiltrarFornecedorNIF(mkNIF.Text);
                        dgvFornecedores.DataSource = lstFornecedorfiltrado;
                    }

                }

            }
        }

        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            if (dgvFornecedores.SelectedRows.Count > 0)
            {

                var f = dgvFornecedores.SelectedRows[0].DataBoundItem as Fornecedores; //var é uma variável mais moderna que reduz a dependencia do codigo.
                                                                                       //posso nao saber o tipo de dado e usa-lo. É uma variavel sem tipo, guarda a informacao em memoria, mas nao na compilacao. 

                txtNome.Text = f.nome;
                txtNIF.Text = f.nif;
                txtEndereco.Text = f.endereco;
                txtTelefone.Text = f.telefone;
                txtEmail.Text = f.email;


            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
        }
    }
}
