namespace Projeto1.Cadastros
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbNIF = new System.Windows.Forms.RadioButton();
            this.mkNIF = new System.Windows.Forms.MaskedTextBox();
            this.cbBuscarNome = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar : ";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(148, 124);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(528, 27);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nome :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(809, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "NIF :";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(148, 183);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(528, 27);
            this.txtEndereco.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Endereço :";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(964, 185);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefone.Mask = "(999) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(206, 27);
            this.txtTelefone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(764, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Telefone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 263);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Cargo :";
            // 
            // cbCargo
            // 
            this.cbCargo.Enabled = false;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(148, 255);
            this.cbCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(220, 28);
            this.cbCargo.TabIndex = 5;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.dataNasc,
            this.nif,
            this.endereco,
            this.telefone,
            this.data,
            this.id_cargo,
            this.cargo});
            this.dgvFuncionarios.Location = new System.Drawing.Point(11, 322);
            this.dgvFuncionarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersWidth = 62;
            this.dgvFuncionarios.RowTemplate.Height = 28;
            this.dgvFuncionarios.Size = new System.Drawing.Size(1172, 271);
            this.dgvFuncionarios.TabIndex = 61;
            this.dgvFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellClick);
            this.dgvFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 8;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 400;
            // 
            // dataNasc
            // 
            this.dataNasc.DataPropertyName = "dataNasc";
            this.dataNasc.HeaderText = "Data Nasc";
            this.dataNasc.MinimumWidth = 8;
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.ReadOnly = true;
            this.dataNasc.Width = 150;
            // 
            // nif
            // 
            this.nif.DataPropertyName = "nif";
            this.nif.HeaderText = "NIF";
            this.nif.MinimumWidth = 8;
            this.nif.Name = "nif";
            this.nif.ReadOnly = true;
            this.nif.Width = 150;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.MinimumWidth = 8;
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Width = 400;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.MinimumWidth = 8;
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 150;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.MinimumWidth = 8;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 150;
            // 
            // id_cargo
            // 
            this.id_cargo.DataPropertyName = "id_cargo";
            this.id_cargo.HeaderText = "idCargo";
            this.id_cargo.MinimumWidth = 8;
            this.id_cargo.Name = "id_cargo";
            this.id_cargo.ReadOnly = true;
            this.id_cargo.Visible = false;
            this.id_cargo.Width = 150;
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "cargo";
            this.cargo.HeaderText = "Cargo";
            this.cargo.MinimumWidth = 8;
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 170;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rbNome.Location = new System.Drawing.Point(148, 12);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(66, 24);
            this.rbNome.TabIndex = 62;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = false;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // rbNIF
            // 
            this.rbNIF.AutoSize = true;
            this.rbNIF.Location = new System.Drawing.Point(148, 50);
            this.rbNIF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbNIF.Name = "rbNIF";
            this.rbNIF.Size = new System.Drawing.Size(57, 24);
            this.rbNIF.TabIndex = 63;
            this.rbNIF.TabStop = true;
            this.rbNIF.Text = "NIF";
            this.rbNIF.UseVisualStyleBackColor = true;
            this.rbNIF.CheckedChanged += new System.EventHandler(this.rbCPF_CheckedChanged);
            // 
            // mkNIF
            // 
            this.mkNIF.Enabled = false;
            this.mkNIF.Location = new System.Drawing.Point(262, 27);
            this.mkNIF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mkNIF.Mask = "000,000,000";
            this.mkNIF.Name = "mkNIF";
            this.mkNIF.Size = new System.Drawing.Size(135, 27);
            this.mkNIF.TabIndex = 64;
            this.mkNIF.Visible = false;
            this.mkNIF.TextChanged += new System.EventHandler(this.mkCPF_TextChanged);
            this.mkNIF.DoubleClick += new System.EventHandler(this.cbBuscarNome_SelectedIndexChanged);
            // 
            // cbBuscarNome
            // 
            this.cbBuscarNome.FormattingEnabled = true;
            this.cbBuscarNome.Location = new System.Drawing.Point(577, 24);
            this.cbBuscarNome.Name = "cbBuscarNome";
            this.cbBuscarNome.Size = new System.Drawing.Size(286, 28);
            this.cbBuscarNome.TabIndex = 69;
            this.cbBuscarNome.SelectedIndexChanged += new System.EventHandler(this.cbBuscarNome_SelectedIndexChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(774, 630);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(169, 138);
            this.btnExcluir.TabIndex = 68;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(376, 630);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(169, 138);
            this.btnSalvar.TabIndex = 66;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(179, 630);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(169, 138);
            this.btnNovo.TabIndex = 65;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(577, 630);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(169, 138);
            this.btnEditar.TabIndex = 67;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.cbBuscarNome);
            this.panel1.Controls.Add(this.rbNIF);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbNome);
            this.panel1.Controls.Add(this.mkNIF);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 100);
            this.panel1.TabIndex = 70;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Location = new System.Drawing.Point(907, 121);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(263, 27);
            this.dtpDataNasc.TabIndex = 71;
            this.dtpDataNasc.Value = new System.DateTime(2022, 5, 6, 18, 34, 46, 0);
            this.dtpDataNasc.ValueChanged += new System.EventHandler(this.dtpDataNasc_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(703, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "Data Nascimento :";
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(907, 263);
            this.txtNIF.Mask = "000,000,000";
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(152, 27);
            this.txtNIF.TabIndex = 73;
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1202, 768);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Funcionarios";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbNIF;
        private System.Windows.Forms.MaskedTextBox mkNIF;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cbBuscarNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nif;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.MaskedTextBox txtNIF;
    }
}