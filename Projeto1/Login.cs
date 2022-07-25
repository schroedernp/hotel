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
    public partial class frmLogin : Form
    {
        UsuarioDAL udal = new UsuarioDAL();
        
        

        public frmLogin() //Construtor da classe
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e) //posso chamar o formulario pelo nome dele ou this.
        {
           
            //Point éum parametro do Location 
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);  //metade da tela e reduzo o tamanho do meu do panel
            pnlLogin.Visible = true;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 114, 160); //Aqui eu vou passar 3 parametros para colocar no botao as cores desejadas
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e) //Chamo o login tanto qdo aperto no botao como qdo aperto ENTER
        {
            ChamarLogin();

        }


        //Pra chamar este evento devo habilitar como true nas propriedades: Keypreviews
        private void frmLogin_KeyDown(object sender, KeyEventArgs e) //Evento pra qdo uma tecla é selecionada 
        {
            //e = o evento que eu chamei
            if (e.KeyCode == Keys.Enter) //se o eventou que eu chamei tiver como keycode = enter...
            {
                ChamarLogin();
            }
        }


        private void ChamarLogin()
        {
            if (txtlogin.Text.ToString().Trim().Equals("")) //Trim ignora qualquer espaço vazio que esteja na text box
            {
                MessageBox.Show("Preencha o Usuário","Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlogin.Text = "";
                txtlogin.Focus();
                return;
            }

            if (txtSenha.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Preencha a Senha", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }

            //AQUI VAI O CÓDIGO PARA O LOGIN
            Usuarios user = new Usuarios(txtlogin.Text, txtSenha.Text);
            int check;
             Usuarios user_BD = new Usuarios();

            (user_BD, check) = udal.Login(user); //Vejo se tem o usuario ou nao...

            if (check == 0) //tem usuario
            {
               
                MessageBox.Show("Bem-vindo ao Hotel Carmo, " + user_BD.nome +"!\n" + "Login de " + user_BD.usuario + " Efetuado com Sucesso.",  "Rececção Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenu menu = new frmMenu(user_BD); //Instancio o objeto pra poder usar as propriedades 
                Limpar();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos", "Informatico Hotel Carmo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtlogin.Text = "";
                txtlogin.Focus();
                txtSenha.Text = "";
                return;
            }
           

        }
        private void Limpar()
        {
            txtlogin.Text = "";
            txtSenha.Text = "";
            txtlogin.Focus();
        }

        private void frmLogin_Activated(object sender, EventArgs e) //logo apos o frmLogin ser ativado ele sera limpo 
        {
            Limpar();
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);  //Toda vez que redimensionou o forme ele arruma a localizacao do meu panel
        }
    }
}
