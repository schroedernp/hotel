using Projeto1.Cadastros;
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

namespace Projeto1
{
    public partial class frmMenu : Form
    {
        Boolean flag;
        
        public frmMenu(Usuarios user)
        {
            InitializeComponent();
            lblUsuario.Text = user.nome;
            lblCargo.Text = user.cargo;
            DateTime dateTime = DateTime.Now;
            lblDataHora.Text = dateTime.ToString();
    

            if (user.cargo == "Supervisor" || user.cargo == "Gerente" || user.cargo == "Relações Humanas")
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

        }
        
        private void frmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; //Volta a maximizar sempre que for redimensionado
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlTop.BackColor = Color.FromArgb(230, 230, 230);
            pnlRight.BackColor = Color.FromArgb(130, 130, 130);
            GQuartosDAL  gqDAL = new GQuartosDAL();
            lbOcupados.Text = gqDAL.QuartosOcupados().ToString();
            lbDisponivel.Text = gqDAL.QuartosDisponivel().ToString();
            lbReservas.Text = gqDAL.QuartosOcupados().ToString();



        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }



        private void MenuCadastro_Click(object sender, EventArgs e)
        {

        }



        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                frmCargos cargo = new frmCargos();
                cargo.Show();
            }
            else
            {
                MessageBox.Show("Permissão Negada.", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            frmProdutos produtos = new frmProdutos();
            produtos.Show();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos produtos = new frmProdutos();
            produtos.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                frmUsuarios user = new frmUsuarios();
                user.Show();
            }
            else
            {
                MessageBox.Show("Permissão Negada..", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ;
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void funcionáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (flag == true)
            {
                frmFuncionarios funcionarios = new frmFuncionarios();
                funcionarios.Show();
            }
            else
            {
                MessageBox.Show("Permissão Negada.", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void quartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestaoQuartos gestaoQuartos = new frmGestaoQuartos();
            gestaoQuartos.Show();
        }

        private void lbOcupados_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedores fornecedores = new frmFornecedores();
            fornecedores.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frmEstoque form = new Cadastros.frmEstoque();
            form.Show();
        }

    
        private void MenuProdutos_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frmservicos form = new Cadastros.frmservicos();
            form.Show();
        }
    }
}
