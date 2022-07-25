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
    public partial class frmGestaoQuartos : Form
    {
        GQuartos gq = new GQuartos();
        GQuartosDAL gqDAL = new GQuartosDAL();
        Quartos quartos = new Quartos();
        QuartosDAL quartosDAL = new QuartosDAL();
        //private int _id_qua = 0;
        public frmGestaoQuartos()
        {
            InitializeComponent();
        }

        private void frmGestaoQuartos_Load(object sender, EventArgs e)
        {
            CarregarComboboxQuartos();
            DesabilitarCampos();
        }


    

        private void cbCodQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var qua = (Quartos)cbCodQuarto.SelectedItem;

            gq.id_quarto = qua.id_quarto;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            CarregarDGVgquarto();


        }
        private void CarregarComboboxQuartos()
        {
            QuartosDAL dalgc = new QuartosDAL();

            List<Quartos> listarcodQuartos = dalgc.ListarCodQuartos();

            cbCodQuarto.DisplayMember = "cod_quarto";
            cbCodQuarto.ValueMember = "id_quarto";
            cbCodQuarto.DataSource = listarcodQuartos;
        }
        private void HabilitarCampos()
        {
            
            cbCodQuarto.Enabled = true;
            txtObs.Enabled = true;
            ckOcupado.Enabled = true;
            dtPLimpezaDate.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;


        }

        private void DesabilitarCampos()
        {
            cbCodQuarto.Enabled = false;
            txtObs.Enabled = false;
            ckOcupado.Enabled = false;
            dtPLimpezaDate.Enabled = false;
        }
        private void LimparCampos()
        {

            cbCodQuarto.SelectedItem = 000;
            txtObs.Text = "";
            ckOcupado.Checked = false;
            dtPLimpezaDate.Text = "";
        }

        private void CarregarDGVgquarto()
        {
            List<GQuartos> gq = gqDAL.ListarTodosQuartos();
            dgvQuartos.DataSource = gq;
            dgvQuartos.Columns["id"].Visible = false;
            dgvQuartos.Columns["id_quarto"].Visible = false;
            dgvQuartos.Columns["cod_quarto"].HeaderCell.Value = "Quarto";
            dgvQuartos.Columns["num_pessoas"].HeaderCell.Value = "Capacidade";
            dgvQuartos.Columns["ocupado"].HeaderCell.Value = "Ocupado";
            dgvQuartos.Columns["hora_limpeza"].HeaderCell.Value = "Data/Hora Limpeza";
            dgvQuartos.Columns["observacao"].HeaderCell.Value = "Observação";
          
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //PROGRAMANDO O BOTAO SALVAR 
            var qua = (Quartos)cbCodQuarto.SelectedItem;

            gq.id_quarto = qua.id_quarto;


            if (ckOcupado.Checked)
            {
                gq.ocupado = true;
            }
            else
            {
                gq.ocupado = false;
            }
            gq.observacao = txtObs.Text;


            gq.hora_limpeza = (dtPLimpezaDate.Value.Date + dtpLimpezaTime.Value.TimeOfDay);
           
            int validar = gqDAL.RegistarGQuarto(gq);
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
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            LimparCampos();
            DesabilitarCampos();;
            CarregarDGVgquarto();
            //CarregarComboboxTodosCargos();

            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            

            var quartoSelecionado = setValoresGQuartos();
            int check = gqDAL.EditarQuartos(quartoSelecionado);
             

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
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = true;
            LimparCampos();
            DesabilitarCampos(); ;
            CarregarDGVgquarto();
        }

        public GQuartos setValoresGQuartos()
        {
            var quartoSelecionado = dgvQuartos.SelectedRows[0].DataBoundItem as GQuartos;

            var qua = (Quartos)cbCodQuarto.SelectedItem;

             quartoSelecionado.id_quarto = qua.id_quarto;


            if (ckOcupado.Checked)
            {

                quartoSelecionado.ocupado = true;

            }
            else
            {
                quartoSelecionado.ocupado = false;
            }
            quartoSelecionado.observacao = txtObs.Text;

            quartoSelecionado.hora_limpeza = dtPLimpezaDate.Value.Date;
           // quartoSelecionado.hora_limpeza = dtpLimpezaTime.Value.TimeOfDay;
            DateTime datetime = new DateTime() + quartoSelecionado.hora_limpeza.TimeOfDay;
            datetime = Convert.ToDateTime(dtpLimpezaTime.Value.ToString());
            
            return quartoSelecionado;
            
            
        }

        private void dgvQuartos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cbCodQuarto_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var gq = setValoresGQuartos();
            int registo = gqDAL.ExcluirGQuartos(gq);
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
            CarregarDGVgquarto();
            CarregarComboboxQuartos();
        }

        private void dgvQuartos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            if (dgvQuartos.SelectedRows.Count > 0)
            {

                var gc = dgvQuartos.SelectedRows[0].DataBoundItem as GQuartos; //var é uma variável mais moderna que reduz a dependencia do codigo.
               
                cbCodQuarto.SelectedValue = gc.id_quarto;  //SelectedValue =  "id_quarto"
              
                                                                       //posso nao saber o tipo de dado e usa-lo. É uma variavel sem tipo, guarda a informmacao em memoria, mas nao na compilacao. 

                if (gc.ocupado)
                {
                    ckOcupado.Checked = true;
                }
                else
                {
                    ckOcupado.Checked = false;
                }
                txtObs.Text = gc.observacao;
                
                dtPLimpezaDate.Value = gc.hora_limpeza.Date;
                dtpLimpezaTime.Value = Convert.ToDateTime(gc.hora_limpeza.ToString()); //Pegamos o TimeSpan convertemos em String e depois em DateTime.
               
                
       
                //MessageBox.Show(dtpLimpezaTime.Value.ToString());

               
            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
        }
    }
}
