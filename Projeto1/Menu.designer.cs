namespace Projeto1
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasESaídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.novaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadroDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCheckInOut = new System.Windows.Forms.ToolStripMenuItem();
            this.novoServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lbOcupados = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbReservas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbDisponivel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuProdutos,
            this.MenuMovimentacoes,
            this.MenuReservas,
            this.MenuCheckInOut,
            this.MenuRelatorios,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1701, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.hospedesToolStripMenuItem,
            this.quartosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.cargoToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.MenuCadastro.Image = ((System.Drawing.Image)(resources.GetObject("MenuCadastro.Image")));
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(112, 28);
            this.MenuCadastro.Text = "Cadastros";
            this.MenuCadastro.Click += new System.EventHandler(this.MenuCadastro_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click_1);
            // 
            // hospedesToolStripMenuItem
            // 
            this.hospedesToolStripMenuItem.Name = "hospedesToolStripMenuItem";
            this.hospedesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hospedesToolStripMenuItem.Text = "Hospedes";
            // 
            // quartosToolStripMenuItem
            // 
            this.quartosToolStripMenuItem.Name = "quartosToolStripMenuItem";
            this.quartosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quartosToolStripMenuItem.Text = "Quartos";
            this.quartosToolStripMenuItem.Click += new System.EventHandler(this.quartosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // cargoToolStripMenuItem
            // 
            this.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            this.cargoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cargoToolStripMenuItem.Text = "Cargo";
            this.cargoToolStripMenuItem.Click += new System.EventHandler(this.cargoToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoProdutoToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.MenuProdutos.Image = ((System.Drawing.Image)(resources.GetObject("MenuProdutos.Image")));
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(106, 28);
            this.MenuProdutos.Text = "Produtos";
            this.MenuProdutos.Click += new System.EventHandler(this.MenuProdutos_Click);
            // 
            // novoProdutoToolStripMenuItem
            // 
            this.novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            this.novoProdutoToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.novoProdutoToolStripMenuItem.Text = "Novo Produto";
            this.novoProdutoToolStripMenuItem.Click += new System.EventHandler(this.novoProdutoToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVendaToolStripMenuItem,
            this.novoServiçoToolStripMenuItem,
            this.entradasESaídasToolStripMenuItem});
            this.MenuMovimentacoes.Image = ((System.Drawing.Image)(resources.GetObject("MenuMovimentacoes.Image")));
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(152, 28);
            this.MenuMovimentacoes.Text = "Movimentações";
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.novaVendaToolStripMenuItem.Text = "Nova Venda";
            // 
            // novoServiçoToolStripMenuItem
            // 
            this.novoServiçoToolStripMenuItem.Name = "novoServiçoToolStripMenuItem";
            this.novoServiçoToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.novoServiçoToolStripMenuItem.Text = "Novo Serviço";
            // 
            // entradasESaídasToolStripMenuItem
            // 
            this.entradasESaídasToolStripMenuItem.Name = "entradasESaídasToolStripMenuItem";
            this.entradasESaídasToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.entradasESaídasToolStripMenuItem.Text = "Entradas e Saídas";
            // 
            // MenuReservas
            // 
            this.MenuReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaReservaToolStripMenuItem,
            this.quadroDeReservasToolStripMenuItem,
            this.consultarReservasToolStripMenuItem});
            this.MenuReservas.Image = ((System.Drawing.Image)(resources.GetObject("MenuReservas.Image")));
            this.MenuReservas.Name = "MenuReservas";
            this.MenuReservas.Size = new System.Drawing.Size(104, 28);
            this.MenuReservas.Text = "Reservas";
            // 
            // novaReservaToolStripMenuItem
            // 
            this.novaReservaToolStripMenuItem.Name = "novaReservaToolStripMenuItem";
            this.novaReservaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.novaReservaToolStripMenuItem.Text = "Nova Reserva";
            // 
            // quadroDeReservasToolStripMenuItem
            // 
            this.quadroDeReservasToolStripMenuItem.Name = "quadroDeReservasToolStripMenuItem";
            this.quadroDeReservasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quadroDeReservasToolStripMenuItem.Text = "Quadro de Reservas";
            // 
            // consultarReservasToolStripMenuItem
            // 
            this.consultarReservasToolStripMenuItem.Name = "consultarReservasToolStripMenuItem";
            this.consultarReservasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.consultarReservasToolStripMenuItem.Text = "Consultar Reservas";
            // 
            // MenuCheckInOut
            // 
            this.MenuCheckInOut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoServiçosToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.MenuCheckInOut.Image = ((System.Drawing.Image)(resources.GetObject("MenuCheckInOut.Image")));
            this.MenuCheckInOut.Name = "MenuCheckInOut";
            this.MenuCheckInOut.Size = new System.Drawing.Size(132, 28);
            this.MenuCheckInOut.Text = "Check In/Out";
            // 
            // novoServiçosToolStripMenuItem
            // 
            this.novoServiçosToolStripMenuItem.Name = "novoServiçosToolStripMenuItem";
            this.novoServiçosToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.novoServiçosToolStripMenuItem.Text = "Check In";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("MenuRelatorios.Image")));
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(114, 28);
            this.MenuRelatorios.Text = "Relatórios";
            // 
            // MenuSair
            // 
            this.MenuSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem});
            this.MenuSair.Image = ((System.Drawing.Image)(resources.GetObject("MenuSair.Image")));
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(72, 28);
            this.MenuSair.Text = "Sair";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logToolStripMenuItem.Text = "Logout";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTop.Controls.Add(this.button7);
            this.pnlTop.Controls.Add(this.button6);
            this.pnlTop.Controls.Add(this.button5);
            this.pnlTop.Controls.Add(this.button4);
            this.pnlTop.Controls.Add(this.button3);
            this.pnlTop.Controls.Add(this.button2);
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Location = new System.Drawing.Point(0, 39);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1385, 110);
            this.pnlTop.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(988, 2);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 96);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(827, 2);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 96);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(665, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 96);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(492, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 96);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(322, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 96);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(164, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 96);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 96);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRight.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlRight.Controls.Add(this.lbOcupados);
            this.pnlRight.Controls.Add(this.label16);
            this.pnlRight.Controls.Add(this.label10);
            this.pnlRight.Controls.Add(this.lbReservas);
            this.pnlRight.Controls.Add(this.label12);
            this.pnlRight.Controls.Add(this.pictureBox3);
            this.pnlRight.Controls.Add(this.lbDisponivel);
            this.pnlRight.Controls.Add(this.label14);
            this.pnlRight.Controls.Add(this.label9);
            this.pnlRight.Controls.Add(this.lblUsuario);
            this.pnlRight.Controls.Add(this.pictureBox2);
            this.pnlRight.Controls.Add(this.lblCargo);
            this.pnlRight.Controls.Add(this.label7);
            this.pnlRight.Controls.Add(this.pictureBox1);
            this.pnlRight.Controls.Add(this.lblDataHora);
            this.pnlRight.Controls.Add(this.label4);
            this.pnlRight.Controls.Add(this.label5);
            this.pnlRight.Location = new System.Drawing.Point(1209, 28);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(665, 830);
            this.pnlRight.TabIndex = 3;
            this.pnlRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRight_Paint);
            // 
            // lbOcupados
            // 
            this.lbOcupados.AutoSize = true;
            this.lbOcupados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOcupados.ForeColor = System.Drawing.Color.White;
            this.lbOcupados.Location = new System.Drawing.Point(377, 449);
            this.lbOcupados.Name = "lbOcupados";
            this.lbOcupados.Size = new System.Drawing.Size(18, 20);
            this.lbOcupados.TabIndex = 19;
            this.lbOcupados.Text = "5";
            this.lbOcupados.Click += new System.EventHandler(this.lbOcupados_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(144, 444);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(207, 29);
            this.label16.TabIndex = 18;
            this.label16.Text = "Quartos Ocupados: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(144, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "Reservas:";
            // 
            // lbReservas
            // 
            this.lbReservas.AutoSize = true;
            this.lbReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReservas.ForeColor = System.Drawing.Color.White;
            this.lbReservas.Location = new System.Drawing.Point(375, 343);
            this.lbReservas.Name = "lbReservas";
            this.lbReservas.Size = new System.Drawing.Size(18, 20);
            this.lbReservas.TabIndex = 16;
            this.lbReservas.Text = "5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-7, 473);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(662, 31);
            this.label12.TabIndex = 15;
            this.label12.Text = "______________________________________________________";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 359);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // lbDisponivel
            // 
            this.lbDisponivel.AutoSize = true;
            this.lbDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisponivel.ForeColor = System.Drawing.Color.White;
            this.lbDisponivel.Location = new System.Drawing.Point(370, 394);
            this.lbDisponivel.Name = "lbDisponivel";
            this.lbDisponivel.Size = new System.Drawing.Size(27, 20);
            this.lbDisponivel.TabIndex = 13;
            this.lbDisponivel.Text = "10";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(142, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(216, 29);
            this.label14.TabIndex = 12;
            this.label14.Text = "Quartos Disponíveis:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(139, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nome:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(243, 179);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(131, 24);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Marcos Lenine";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 180);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(243, 223);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(78, 24);
            this.lblCargo.TabIndex = 7;
            this.lblCargo.Text = "Gerente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(142, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cargo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.ForeColor = System.Drawing.Color.White;
            this.lblDataHora.Location = new System.Drawing.Point(140, 55);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(123, 37);
            this.lblDataHora.TabIndex = 0;
            this.lblDataHora.Text = "13:00:00";
            this.lblDataHora.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-71, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(662, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "______________________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-71, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(662, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "______________________________________________________";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 850);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.Text = "Hotel Do Carmo ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Resize += new System.EventHandler(this.frmMenu_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem novoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasESaídasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuReservas;
        private System.Windows.Forms.ToolStripMenuItem novaReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadroDeReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCheckInOut;
        private System.Windows.Forms.ToolStripMenuItem novoServiçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbReservas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbDisponivel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbOcupados;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
    }
}