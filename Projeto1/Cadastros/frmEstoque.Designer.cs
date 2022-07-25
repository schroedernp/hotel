namespace Projeto1.Cadastros
{
    partial class frmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEstoque
            // 
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(101, 71);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(83, 22);
            this.txtEstoque.TabIndex = 98;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.Enabled = false;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(447, 16);
            this.cbFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(196, 24);
            this.cbFornecedor.TabIndex = 93;
            this.cbFornecedor.SelectedIndexChanged += new System.EventHandler(this.cbFornecedor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 97;
            this.label6.Text = "Fornecedor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 96;
            this.label5.Text = "Estoque :";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(518, 71);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(125, 22);
            this.txtValor.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 95;
            this.label4.Text = "Valor :";
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(101, 18);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(175, 22);
            this.txtProduto.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 99;
            this.label1.Text = "Produto:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(326, 71);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(96, 22);
            this.txtQuantidade.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "Quantidade:";
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Location = new System.Drawing.Point(304, 16);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(26, 26);
            this.btnProduto.TabIndex = 103;
            this.btnProduto.Text = "+";
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(650, -10);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(169, 138);
            this.btnSalvar.TabIndex = 104;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(823, 140);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Activated += new System.EventHandler(this.frmEstoque_Activated);
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnSalvar;
    }
}