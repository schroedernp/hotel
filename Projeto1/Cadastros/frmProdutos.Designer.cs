namespace Projeto1.Cadastros
{
    partial class frmProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.cbBuscarNomeProduto = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Buscar : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nome :";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(140, 63);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(319, 22);
            this.txtNome.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 77;
            this.label3.Text = "Descrição :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 78;
            this.label4.Text = "Valor :";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(556, 146);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 22);
            this.txtValor.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "Estoque :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "Fornecedor :";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.Enabled = false;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(140, 140);
            this.cbFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(319, 24);
            this.cbFornecedor.TabIndex = 74;
            this.cbFornecedor.SelectedIndexChanged += new System.EventHandler(this.cbFornecedor_SelectedIndexChanged_1);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome_prod,
            this.descricao,
            this.estoque,
            this.nome_fornecedor,
            this.fornecedor,
            this.valor_venda,
            this.valor_compra,
            this.data,
            this.imagem});
            this.dgvProdutos.Location = new System.Drawing.Point(12, 238);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidth = 62;
            this.dgvProdutos.RowTemplate.Height = 28;
            this.dgvProdutos.Size = new System.Drawing.Size(1065, 352);
            this.dgvProdutos.TabIndex = 81;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick_1);
            this.dgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellDoubleClick);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(556, 108);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(120, 22);
            this.txtEstoque.TabIndex = 90;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(140, 103);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(319, 22);
            this.txtDescricao.TabIndex = 91;
            // 
            // btnImg
            // 
            this.btnImg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImg.Enabled = false;
            this.btnImg.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnImg.FlatAppearance.BorderSize = 2;
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg.Location = new System.Drawing.Point(1004, 176);
            this.btnImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(53, 46);
            this.btnImg.TabIndex = 93;
            this.btnImg.Text = "+";
            this.btnImg.UseVisualStyleBackColor = false;
            // 
            // cbBuscarNomeProduto
            // 
            this.cbBuscarNomeProduto.FormattingEnabled = true;
            this.cbBuscarNomeProduto.Location = new System.Drawing.Point(484, 17);
            this.cbBuscarNomeProduto.Name = "cbBuscarNomeProduto";
            this.cbBuscarNomeProduto.Size = new System.Drawing.Size(286, 24);
            this.cbBuscarNomeProduto.TabIndex = 94;
            this.cbBuscarNomeProduto.SelectedIndexChanged += new System.EventHandler(this.cbBuscarNomeProduto_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 6;
            // 
            // nome_prod
            // 
            this.nome_prod.DataPropertyName = "nome";
            this.nome_prod.HeaderText = "Nome";
            this.nome_prod.MinimumWidth = 6;
            this.nome_prod.Name = "nome_prod";
            this.nome_prod.ReadOnly = true;
            this.nome_prod.Width = 200;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 6;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 200;
            // 
            // estoque
            // 
            this.estoque.DataPropertyName = "estoque";
            this.estoque.HeaderText = "Estoque";
            this.estoque.MinimumWidth = 6;
            this.estoque.Name = "estoque";
            this.estoque.ReadOnly = true;
            this.estoque.Width = 80;
            // 
            // nome_fornecedor
            // 
            this.nome_fornecedor.DataPropertyName = "nome_fornecedor";
            this.nome_fornecedor.HeaderText = "Fornecedor";
            this.nome_fornecedor.MinimumWidth = 6;
            this.nome_fornecedor.Name = "nome_fornecedor";
            this.nome_fornecedor.ReadOnly = true;
            // 
            // fornecedor
            // 
            this.fornecedor.DataPropertyName = "fornecedor";
            this.fornecedor.HeaderText = "fornecedor";
            this.fornecedor.MinimumWidth = 6;
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Visible = false;
            this.fornecedor.Width = 6;
            // 
            // valor_venda
            // 
            this.valor_venda.DataPropertyName = "valor_venda";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.valor_venda.DefaultCellStyle = dataGridViewCellStyle1;
            this.valor_venda.HeaderText = "Valor de venda";
            this.valor_venda.MinimumWidth = 6;
            this.valor_venda.Name = "valor_venda";
            this.valor_venda.ReadOnly = true;
            // 
            // valor_compra
            // 
            this.valor_compra.DataPropertyName = "valor_compra";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.valor_compra.DefaultCellStyle = dataGridViewCellStyle2;
            this.valor_compra.HeaderText = "Valor de compra";
            this.valor_compra.MinimumWidth = 6;
            this.valor_compra.Name = "valor_compra";
            this.valor_compra.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.MinimumWidth = 6;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // imagem
            // 
            this.imagem.DataPropertyName = "imagem";
            this.imagem.HeaderText = "Imagem";
            this.imagem.MinimumWidth = 6;
            this.imagem.Name = "imagem";
            this.imagem.ReadOnly = true;
            this.imagem.Width = 80;
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(787, 17);
            this.img.Margin = new System.Windows.Forms.Padding(4);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(209, 204);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 92;
            this.img.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(668, 615);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(123, 96);
            this.btnExcluir.TabIndex = 88;
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
            this.btnEditar.Location = new System.Drawing.Point(528, 615);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(123, 96);
            this.btnEditar.TabIndex = 87;
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
            this.btnSalvar.Location = new System.Drawing.Point(382, 615);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 96);
            this.btnSalvar.TabIndex = 86;
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
            this.btnNovo.Location = new System.Drawing.Point(240, 615);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(123, 96);
            this.btnNovo.TabIndex = 85;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1089, 722);
            this.Controls.Add(this.cbBuscarNomeProduto);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.img);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.ComboBox cbBuscarNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagem;
    }
}