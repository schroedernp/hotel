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
    public partial class frmFuncionarios : Form
    {
       
        FuncionarioDAL fdal = new FuncionarioDAL();
        Boolean data_checked = false;

        public frmFuncionarios()
        {
            InitializeComponent();
            
        }

        private void CarregarComboboxNomesFuncionarios()
        {
            
            Funcionarios temp = new Funcionarios();
            temp.id = 0;
            temp.cargo = "Selecione..."; //Ver pq nao ta dando...
            List<Funcionarios> listar_funcionarios = fdal.ListarTodosFuncionarios();
            listar_funcionarios.Insert(0 ,temp);
            cbBuscarNome.DisplayMember = "nome";
            cbBuscarNome.ValueMember = "id";
            cbBuscarNome.DataSource = listar_funcionarios;
        }

        private void CarregarComboboxTodosCargos()
        {
            CargoDAL dal = new CargoDAL();
            List<Cargos> list_cargo = dal.ListarTodosCargos(); 
            Cargos temp = new Cargos();
            temp.id = 0;
            temp.cargo = "Selecione...";
            list_cargo.Insert(0, temp);
            cbCargo.DisplayMember = "cargo"; //campo que será mostrado...Relacionamento entre os componentes
            cbCargo.ValueMember = "id"; //valor que mando para o banco de dado 
            cbCargo.DataSource = list_cargo;


        }

        private void CarregarGridViewTodosFuncionarios()
        {
            List<Funcionarios> funcionarios_dgv = fdal.ListarTodosFuncionarios();
            dgvFuncionarios.DataSource = funcionarios_dgv; 
        }

     
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            dtpDataNasc.Enabled = true;
            txtNIF.Enabled = true;
            txtEndereco.Enabled = true;
            cbCargo.Enabled = true;
            txtTelefone.Enabled = true;
            txtNome.Focus();
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            dtpDataNasc.Enabled = false; 
            txtNIF.Enabled = false;
            txtEndereco.Enabled = false;
            txtNIF.Enabled = false;
            cbCargo.Enabled = false;
            txtTelefone.Enabled = false;
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            dtpDataNasc.CustomFormat = " ";
            txtNIF.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            cbCargo.Text = "Selecione...";
        }


        public Funcionarios setValoresFuncionario()
        {


            var f = dgvFuncionarios.SelectedRows[0].DataBoundItem as Funcionarios;

            f.nome = txtNome.Text;
            f.dataNasc = dtpDataNasc.Value;
            f.nif = txtNIF.Text;
            f.endereco = txtEndereco.Text;
            f.telefone = txtTelefone.Text;
            var cargo = (Cargos)cbCargo.SelectedItem;
            f.idCargo = cargo.id;
            return f;
        }
        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            CarregarGridViewTodosFuncionarios();
            rbNome.Checked = true; 
            
            CarregarComboboxTodosCargos();
            dgvFuncionarios.Columns["idCargo"].Visible = false;
            CarregarComboboxNomesFuncionarios();

            //Deixa a data branca
            dtpDataNasc.CustomFormat = " ";
            dtpDataNasc.Format = DateTimePickerFormat.Custom;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha o Nome","Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtNIF.Text.ToString().Trim().Equals("000,000,000")) //Rever isso!
            {
                MessageBox.Show("Preencha o NIF", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNIF.Text = "";
                txtNIF.Focus();
                return;
            }

            //System.Diagnostics.Debug.WriteLine(dtpDataNasc.Text);


            //PROGRAMANDO O BOTAO SALVAR  
            var cargo_cb = (Cargos)cbCargo.SelectedItem; //Faço uma corversao do que eu tenho na minha CB para Cargos
            int check = fdal.VerificarNIF(txtNIF.Text);
            if ( check!= 0 || dtpDataNasc.CustomFormat != " ")
            {
                string data = (data_checked) ? dtpDataNasc.Value.ToString("yyyy-MM-dd") : " ";


                Funcionarios func = new Funcionarios(txtNome.Text, DateTime.Parse(data), txtNIF.Text, txtEndereco.Text, txtTelefone.Text, cargo_cb.id);
                int validar = fdal.InserirFuncionario(func);
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
                CarregarComboboxNomesFuncionarios();
                CarregarGridViewTodosFuncionarios();
                CarregarComboboxTodosCargos();
              
            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.\n Este NIF já se encontra cadastrado.", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            data_checked = false;
            //dTPDtConsulta.Value = DateTimePicker.;
            dtpDataNasc.CustomFormat = " ";
            dtpDataNasc.Format = DateTimePickerFormat.Custom;

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

            if (txtNIF.Text.ToString().Trim().Equals("   .   ."))
            {
                MessageBox.Show("Preencha o NIF", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNIF.Text = "";
                txtNIF.Focus();
                return;
            }


            var f = setValoresFuncionario();
         
            int check = fdal.EditarFuncionário(f);

            //Após o código para editar:
            if (check > 0)
            {
                MessageBox.Show("Registro Editado com Sucesso", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnNovo.Enabled=true;
            btnEditar.Enabled=false;
            btnExcluir.Enabled=false;
            LimparCampos();
            DesabilitarCampos();
            CarregarGridViewTodosFuncionarios();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var f = setValoresFuncionario();
            int registo = fdal.ExcluirFuncionario(f);
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
            CarregarGridViewTodosFuncionarios();


        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            cbBuscarNome.Visible = true;
            cbBuscarNome.Text = "";
            mkNIF.Visible = false;
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            cbBuscarNome.Visible = false;
            mkNIF.Visible = true;
            mkNIF.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CarregarGridViewTodosFuncionarios();

            if (cbCargo.Text.Equals(""))
            {
                MessageBox.Show("Cadastre antes um Cargo.", "Informativo Hotel Carmos ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            HabilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            
        }

     

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            HabilitarCampos();
            if (dgvFuncionarios.SelectedRows.Count > 0)
            {

                var f = dgvFuncionarios.SelectedRows[0].DataBoundItem as Funcionarios; //var é uma variável mais moderna que reduz a dependencia do codigo.
                                                                                       //posso nao saber o tipo de dado e usa-lo. É uma variavel sem tipo, guarda a informmacao em memoria, mas nao na compilacao. 

                txtNome.Text = f.nome;
                txtNIF.Text = f.nif;
                txtEndereco.Text = f.endereco;
                txtTelefone.Text = f.telefone;
                cbCargo.Text = f.cargo;


            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void cbBuscarNome_SelectedIndexChanged(object sender, EventArgs e)
        {
           LimparCampos();
           Funcionarios ff = (Funcionarios)cbBuscarNome.SelectedItem;
           List<Funcionarios> lstFuncionariofiltrado = fdal.FiltrarFuncionarioNome(ff);
           dgvFuncionarios.DataSource = lstFuncionariofiltrado;
        }

        private void mkCPF_TextChanged(object sender, EventArgs e)
        {
            if(mkNIF.Text.Equals("   .   .  "))
            {
                CarregarGridViewTodosFuncionarios();
            }
            else { 
            Funcionarios ff = new Funcionarios();
            ff.nif = mkNIF.Text;
            List<Funcionarios> lstFuncionariofiltrado = fdal.FiltrarFuncionarioNIF(ff);
            dgvFuncionarios.DataSource = lstFuncionariofiltrado;
            }

        }

       

        private void dtpDataNasc_ValueChanged(object sender, EventArgs e)
        {
            dtpDataNasc.CustomFormat = "dd/MM/yyyy";
            data_checked = true;
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
