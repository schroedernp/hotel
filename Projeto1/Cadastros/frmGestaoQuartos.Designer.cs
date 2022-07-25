namespace Projeto1.Cadastros
{
    partial class frmGestaoQuartos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestaoQuartos));
            this.dgvQuartos = new System.Windows.Forms.DataGridView();
            this.cod_quarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_pessoas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_limpeza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblOcupado = new System.Windows.Forms.Label();
            this.cbCodQuarto = new System.Windows.Forms.ComboBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.ckOcupado = new System.Windows.Forms.CheckBox();
            this.dtPLimpezaDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtpLimpezaTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuartos
            // 
            this.dgvQuartos.AllowUserToAddRows = false;
            this.dgvQuartos.AllowUserToDeleteRows = false;
            this.dgvQuartos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_quarto,
            this.num_pessoas,
            this.ocupado,
            this.hora_limpeza,
            this.observacao});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuartos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuartos.Location = new System.Drawing.Point(144, 181);
            this.dgvQuartos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvQuartos.Name = "dgvQuartos";
            this.dgvQuartos.RowHeadersWidth = 62;
            this.dgvQuartos.RowTemplate.Height = 28;
            this.dgvQuartos.Size = new System.Drawing.Size(933, 345);
            this.dgvQuartos.TabIndex = 62;
            this.dgvQuartos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuartos_CellClick);
            this.dgvQuartos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuartos_CellContentClick);
            this.dgvQuartos.Click += new System.EventHandler(this.cbCodQuarto_Click);
            // 
            // cod_quarto
            // 
            this.cod_quarto.DataPropertyName = "cod_quarto";
            this.cod_quarto.HeaderText = "Código";
            this.cod_quarto.MinimumWidth = 8;
            this.cod_quarto.Name = "cod_quarto";
            this.cod_quarto.Width = 125;
            // 
            // num_pessoas
            // 
            this.num_pessoas.DataPropertyName = "num_pessoas";
            this.num_pessoas.HeaderText = "Pessoas";
            this.num_pessoas.MinimumWidth = 6;
            this.num_pessoas.Name = "num_pessoas";
            this.num_pessoas.Width = 125;
            // 
            // ocupado
            // 
            this.ocupado.DataPropertyName = "ocupado";
            this.ocupado.HeaderText = "Ocupado";
            this.ocupado.MinimumWidth = 8;
            this.ocupado.Name = "ocupado";
            this.ocupado.Width = 125;
            // 
            // hora_limpeza
            // 
            this.hora_limpeza.DataPropertyName = "hora_limpeza";
            this.hora_limpeza.HeaderText = "Limpeza";
            this.hora_limpeza.MinimumWidth = 8;
            this.hora_limpeza.Name = "hora_limpeza";
            this.hora_limpeza.Width = 150;
            // 
            // observacao
            // 
            this.observacao.DataPropertyName = "observacao";
            this.observacao.HeaderText = "Observação";
            this.observacao.MinimumWidth = 8;
            this.observacao.Name = "observacao";
            this.observacao.Width = 350;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Código Quarto:";
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(286, 117);
            this.txtObs.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(352, 26);
            this.txtObs.TabIndex = 94;
            // 
            // lblOcupado
            // 
            this.lblOcupado.AutoSize = true;
            this.lblOcupado.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupado.Location = new System.Drawing.Point(574, 24);
            this.lblOcupado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOcupado.Name = "lblOcupado";
            this.lblOcupado.Size = new System.Drawing.Size(81, 20);
            this.lblOcupado.TabIndex = 95;
            this.lblOcupado.Text = "Ocupado:";
            // 
            // cbCodQuarto
            // 
            this.cbCodQuarto.Enabled = false;
            this.cbCodQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodQuarto.FormattingEnabled = true;
            this.cbCodQuarto.Location = new System.Drawing.Point(286, 21);
            this.cbCodQuarto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbCodQuarto.Name = "cbCodQuarto";
            this.cbCodQuarto.Size = new System.Drawing.Size(237, 28);
            this.cbCodQuarto.TabIndex = 92;
            this.cbCodQuarto.SelectedIndexChanged += new System.EventHandler(this.cbCodQuarto_SelectedIndexChanged);
            this.cbCodQuarto.Click += new System.EventHandler(this.cbCodQuarto_Click);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(167, 123);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(108, 20);
            this.lblObservacao.TabIndex = 91;
            this.lblObservacao.Text = "Observação:";
            // 
            // ckOcupado
            // 
            this.ckOcupado.AutoSize = true;
            this.ckOcupado.Location = new System.Drawing.Point(663, 27);
            this.ckOcupado.Name = "ckOcupado";
            this.ckOcupado.Size = new System.Drawing.Size(18, 17);
            this.ckOcupado.TabIndex = 98;
            this.ckOcupado.UseVisualStyleBackColor = true;
            // 
            // dtPLimpezaDate
            // 
            this.dtPLimpezaDate.CustomFormat = "MM/dd/yyyy hh:mm:";
            this.dtPLimpezaDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPLimpezaDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPLimpezaDate.Location = new System.Drawing.Point(945, 21);
            this.dtPLimpezaDate.Name = "dtPLimpezaDate";
            this.dtPLimpezaDate.Size = new System.Drawing.Size(132, 26);
            this.dtPLimpezaDate.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(715, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Data da Limpeza: ";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(767, 547);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(123, 96);
            this.btnExcluir.TabIndex = 104;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(627, 547);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(123, 96);
            this.btnEditar.TabIndex = 103;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(481, 547);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 96);
            this.btnSalvar.TabIndex = 102;
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
            this.btnNovo.Location = new System.Drawing.Point(339, 547);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(123, 96);
            this.btnNovo.TabIndex = 101;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtpLimpezaTime
            // 
            this.dtpLimpezaTime.CustomFormat = "HH:mm";
            this.dtpLimpezaTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLimpezaTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLimpezaTime.Location = new System.Drawing.Point(945, 117);
            this.dtpLimpezaTime.Name = "dtpLimpezaTime";
            this.dtpLimpezaTime.ShowUpDown = true;
            this.dtpLimpezaTime.Size = new System.Drawing.Size(132, 26);
            this.dtpLimpezaTime.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(715, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 106;
            this.label2.Text = "Hora da Limpeza: ";
            // 
            // frmGestaoQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1231, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpLimpezaTime);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPLimpezaDate);
            this.Controls.Add(this.ckOcupado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblOcupado);
            this.Controls.Add(this.cbCodQuarto);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.dgvQuartos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmGestaoQuartos";
            this.Text = "Gestão dos Quartos";
            this.Load += new System.EventHandler(this.frmGestaoQuartos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuartos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblOcupado;
        private System.Windows.Forms.ComboBox cbCodQuarto;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.CheckBox ckOcupado;
        private System.Windows.Forms.DateTimePicker dtPLimpezaDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DateTimePicker dtpLimpezaTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_quarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_pessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupado;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_limpeza;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
    }
}