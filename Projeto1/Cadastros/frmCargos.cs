using MySql.Data.MySqlClient;
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
    public partial class frmCargos : Form
    {
        CargoDAL dal = new CargoDAL();
      
      

        public frmCargos()
        {
            InitializeComponent();
        }
        
        public void ListarCargos()
        {
            CargoDAL dal = new CargoDAL();
            List<Cargos> list_cargos = dal.ListarTodosCargos();
            dgvCargo.DataSource = list_cargos;
            dgvCargo.Columns["id"].Visible = false;
   

        } 

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCargo.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            txtNome.Text = "";
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Atenção! Campo vazio. \nPreencha o Nome", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCargo.Text = "";
                txtCargo.Focus();
                return;
            }

            //PROGRAMANDO O BOTÃO SALVAR

            Cargos cargo = new Cargos(txtCargo.Text.ToString());

            int registro = dal.InserirCargo(cargo);
            if (registro > 0)
            {

                MessageBox.Show("Registo guardado na base de dados com sucesso!", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.");
            }



            //Após o código para salvar:
            btnNovo.Enabled = true;
            btnSalvar.Enabled= false;
            txtCargo.Text = "";
            txtCargo.Enabled= false;
            ListarCargos();
        }

    

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Atenção! Campo vazio. \nPreencha o Nome", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCargo.Text = "";
                txtCargo.Focus();
                return;
            }
            

            //CÓDIGO PARA O BOTAO EDITAR:
            Cargos c = new Cargos();
            c.id = Int32.Parse(dgvCargo.CurrentRow.Cells[0].Value.ToString()); //Recupero o id da gridview
            c.cargo = txtCargo.Text;
            int registro = dal.EditarCargo(c);
            if (registro > 0)
            {

                MessageBox.Show("Registro Editado com Sucesso", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.");
            }
           
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled= false;
            btnEditar.Enabled = false;
            txtCargo.Text = "";
            txtCargo.Enabled = false;
            ListarCargos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cargos c = new Cargos();
            c.id = Int32.Parse(dgvCargo.CurrentRow.Cells[0].Value.ToString());
            int registro = dal.ExcluirCargo(c.id);
            if (registro > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Informatico Hotel Carmo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Resultado Eliminado com Sucesso", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //Após o código para excluir:
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            txtCargo.Text = "";
            txtCargo.Enabled = false;
            ListarCargos(); 
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            ListarCargos();
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            Cargos c = new Cargos();
            txtCargo.Enabled=true;
            c.id = Int32.Parse(dgvCargo.CurrentRow.Cells[0].Value.ToString()); //Recupero o id da gridview
            c.cargo = dgvCargo.CurrentRow.Cells[1].Value.ToString(); //Recupero o nome da gridview
            txtCargo.Text = c.cargo;

        }

        private void dgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
