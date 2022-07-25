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
    public partial class frmservicos : Form
    {
        Servicos ser = new Servicos();
        ServicoDAL sdal = new ServicoDAL();
        public frmservicos()
        {
            InitializeComponent();
        }

        private void frmservicos_Load(object sender, EventArgs e)
        {
            CarregarGridViewTodosServiços();
        }

        public Servicos setValoresServicos()
        {
            var servico = dgvServicos.SelectedRows[0].DataBoundItem as Servicos;

            servico.nome_servico = txtNome.Text;
            servico.valor_servico = Decimal.Parse(txtValor.Text.Replace(".", ","));
            servico.id = Int32.Parse(dgvServicos.CurrentRow.Cells[0].Value.ToString());

            return servico;
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtValor.Enabled = true;
            txtNome.Focus();

        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtValor.Enabled = false;
           

        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtValor.Text = "";
       
        }
        private void CarregarGridViewTodosServiços()
        {
            
            List<Servicos> funcionarios_dgv = sdal.ListarTodosServicos();
            dgvServicos.DataSource = funcionarios_dgv;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha o nome do serviço", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtValor.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha o valor do serviço", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }
           

           
            int check = sdal.VerificarNome(txtNome.Text);
            if (check != 0)
            {
                //PROGRAMANDO O BOTAO SALVAR

                
                Servicos servico = new Servicos(txtNome.Text, Decimal.Parse(txtValor.Text.ToString().Replace(".", ",")));
                int validar = sdal.InserirServico(servico);
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
                CarregarGridViewTodosServiços();

            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.\nUsuario já existente.", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtNome.Focus();
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            if (dgvServicos.SelectedRows.Count > 0)
            {

                var ser = dgvServicos.SelectedRows[0].DataBoundItem as Servicos; //var é uma variável mais moderna que reduz a dependencia do codigo.
                                                                                 //posso nao saber o tipo de dado e usa-lo. É uma variavel sem tipo, guarda a informmacao em memoria, mas nao na compilacao. 
                txtNome.Text = ser.nome_servico;
                txtValor.Text = ser.valor_servico.ToString();
            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha o nome do serviço", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtValor.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha o valor do serviço", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }
            //Após o código para editar:
            Servicos servico = setValoresServicos();
            int check = sdal.EditarServicos(servico);

            //Após o código para editar:
            if (check > 0)
            {
                MessageBox.Show("Registro Editado com Sucesso", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            LimparCampos();
            DesabilitarCampos();
            CarregarGridViewTodosServiços();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Servicos servico = setValoresServicos();
            int registo = sdal.ExcluirServico(servico);
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
            CarregarGridViewTodosServiços();
        }
    }
}
