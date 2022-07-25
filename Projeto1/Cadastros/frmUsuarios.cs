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
    public partial class frmUsuarios : Form
    {

        UsuarioDAL udal = new UsuarioDAL();


        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CarregarComboboxTodosCargos();
            CarregarGridViewTodosUser();
            CarregarComboboxTodosUsuarios();
        }

        private void CarregarComboboxTodosUsuarios()
        {
            Usuarios temp = new Usuarios();
            temp.id = 0;
            temp.nome = "Selecione..."; //Ver pq nao ta dando...
            List<Usuarios> lstUser = udal.ListarTodosUsuarios();
            lstUser.Insert(0, temp);
            cbBuscarNome.DisplayMember = "nome";
            cbBuscarNome.ValueMember = "id";
            cbBuscarNome.DataSource = lstUser;
        }


        private void HabilitarCampos()
        {
            cbNomeUsuario.Enabled = true;
            txtUsuario.Enabled = true;
            cbCargo.Enabled = true;
            txtSenha.Enabled = true;

        }

        private void DesabilitarCampos()
        {
            cbNomeUsuario.Enabled = false;
            txtUsuario.Enabled = false;
            cbCargo.Enabled = false;
            txtSenha.Enabled = false;

        }
        private void LimparCampos()
        {
            cbNomeUsuario.Text = " ";
            txtUsuario.Text = "";
            txtSenha.Text = "";

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

        private void CarregarGridViewTodosUser()
        {

            List<Usuarios> user_dgv = udal.ListarTodosUsuarios();
            dgvUsuarios.DataSource = user_dgv;

        }


        public Usuarios getValoresUsuarios()
        {
          
            int id = Int32.Parse(txtId.Text);
            string nome = cbNomeUsuario.SelectedItem.ToString();
            var cargo = (Cargos)cbCargo.SelectedItem;

            Usuarios us = new Usuarios(id, nome, cargo.id, txtUsuario.Text, txtSenha.Text, DateTime.Now);

            var nome_funci = (Funcionarios) cbNomeUsuario.SelectedItem;
            us.nome = nome_funci.nome;

            var cargo_ = (Cargos) cbCargo.SelectedItem;
            us.cargo = cargo_.cargo;
          
            us.usuario = txtUsuario.Text;
            us.senha = txtSenha.Text;

            return us;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
            CarregarGridViewTodosUser();

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cbNomeUsuario.Text.Equals("Selecione..."))
            {
                MessageBox.Show("Preencha o Nome", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cbCargo.Text.Equals("Selecione..."))
            {
                MessageBox.Show("Preencha o Cargo", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            
            var user = getValoresUsuarios();
            int check = udal.EditarUsuario(user);

            

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
            CarregarGridViewTodosUser();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var user = dgvUsuarios.SelectedRows[0].DataBoundItem as Usuarios;
            user.id = int.Parse(txtId.Text);
   
            user.nome = (cbBuscarNome.SelectedItem.ToString());

            user.usuario = txtUsuario.Text;
            user.senha = txtSenha.Text;
     
            var cargo = (Cargos)cbCargo.SelectedItem;
            user.idcargo = cargo.id;
            

            int registo = udal.ExcluirUsuario(user);
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
            cbBuscarNome.Text = "Selecione..."; 
            cbBuscarNome.Enabled = false;
            CarregarGridViewTodosUser();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha o Usuario", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                return;
            }

            if (txtSenha.Text.ToString().Trim().Equals("")) 
            {
                MessageBox.Show("Preencha a Senha", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }
            if (cbCargo.Text.Equals("Selecione...")) 
            {
                MessageBox.Show("Escolha um Cargo...", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbCargo.Text = "Selecione...";
                return;
            }
            if (cbNomeUsuario.Text.Equals("Selecione...")) 
            {
                MessageBox.Show("Escolha um Funcionário...", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbNomeUsuario.Text = "Selecione...";
                return;
            }

            UsuarioDAL udal = new UsuarioDAL();
            int check = udal.Verificar(txtUsuario.Text);
            if (check != 0)
            {
                //PROGRAMANDO O BOTAO SALVAR

                var cargo_cb = (Cargos)cbCargo.SelectedItem; //Faço uma corversao do que eu tenho na minha CB para Cargos

                DateTime data = DateTime.Now;
                var func_nome = (Funcionarios)cbNomeUsuario.SelectedItem;
                Usuarios user = new Usuarios(func_nome.nome, cargo_cb.id, txtUsuario.Text, txtSenha.Text, data);
                int validar = udal.InserirUsuario(user);
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
                CarregarGridViewTodosUser();
                CarregarComboboxTodosCargos();
            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.\nUsuario já existente.", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtUsuario.Focus();
            }
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargoDAL cdal = new CargoDAL();
            var hcargo = (Cargos)cbCargo.SelectedItem;
            cbNomeUsuario.Text = "";
            List<Funcionarios> list_func = cdal.ListarFuncionario(hcargo.id);

            Funcionarios func_temp = new Funcionarios();
            func_temp.id = 0;
            func_temp.nome = "Selecione...";
            list_func.Insert(0, func_temp);

            cbNomeUsuario.DisplayMember = "nome";
            cbNomeUsuario.ValueMember = "id";
            cbNomeUsuario.DataSource = list_func;
            CarregarGridViewTodosUser();
        }

        private void cbNomeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            if (dgvUsuarios.SelectedRows.Count > 0)
            {

                var user = dgvUsuarios.SelectedRows[0].DataBoundItem as Usuarios; //var é uma variável mais moderna que reduz a dependencia do codigo.
                                                                                  //posso nao saber o tipo de dado e usa-lo. É uma variavel sem tipo, guarda a informmacao em memoria, mas nao na compilacao. 
                txtId.Text = user.id.ToString();
                cbNomeUsuario.Text = user.nome;
                cbCargo.Text = user.cargo;
                txtUsuario.Text = user.usuario;
                txtSenha.Text = user.senha; 


            }

            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbBuscarNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            Usuarios us = (Usuarios)cbBuscarNome.SelectedItem;
            List<Usuarios> lstUsuarios = udal.FiltrarUsuarioNome(us);
            dgvUsuarios.DataSource = lstUsuarios;


        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

