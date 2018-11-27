namespace Estoques
{
    partial class FrmProdutos
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
            this.components = new System.ComponentModel.Container();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tb_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DtvProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_produtoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.id_categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.tb_categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.LblCodigoDeBarras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(104, 182);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 49);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(286, 182);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(85, 49);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(377, 182);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 49);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(468, 182);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 49);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tb_produtoBindingSource
            // 
            this.tb_produtoBindingSource.DataSource = typeof(Estoques.DAL.tb_produto);
            // 
            // DtvProdutos
            // 
            this.DtvProdutos.AllowUserToAddRows = false;
            this.DtvProdutos.AllowUserToDeleteRows = false;
            this.DtvProdutos.AutoGenerateColumns = false;
            this.DtvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.DtvProdutos.DataSource = this.tb_produtoBindingSource;
            this.DtvProdutos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtvProdutos.Location = new System.Drawing.Point(20, 243);
            this.DtvProdutos.Name = "DtvProdutos";
            this.DtvProdutos.ReadOnly = true;
            this.DtvProdutos.Size = new System.Drawing.Size(705, 269);
            this.DtvProdutos.TabIndex = 5;
            this.DtvProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tb_produtoDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_produto";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ds_produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Produtos";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tb_categoria";
            this.dataGridViewTextBoxColumn5.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // ds_produtoTextBox
            // 
            this.ds_produtoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ds_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "ds_produto", true));
            this.ds_produtoTextBox.Location = new System.Drawing.Point(243, 58);
            this.ds_produtoTextBox.Name = "ds_produtoTextBox";
            this.ds_produtoTextBox.Size = new System.Drawing.Size(295, 20);
            this.ds_produtoTextBox.TabIndex = 6;
            this.ds_produtoTextBox.Visible = false;
            // 
            // valorTextBox
            // 
            this.valorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(243, 84);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(136, 20);
            this.valorTextBox.TabIndex = 8;
            this.valorTextBox.Visible = false;
            // 
            // id_categoriaComboBox
            // 
            this.id_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_produtoBindingSource, "id_categoria", true));
            this.id_categoriaComboBox.DataSource = this.tb_categoriaBindingSource;
            this.id_categoriaComboBox.DisplayMember = "ds_categoria";
            this.id_categoriaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_categoriaComboBox.FormattingEnabled = true;
            this.id_categoriaComboBox.Location = new System.Drawing.Point(243, 110);
            this.id_categoriaComboBox.Name = "id_categoriaComboBox";
            this.id_categoriaComboBox.Size = new System.Drawing.Size(219, 21);
            this.id_categoriaComboBox.TabIndex = 10;
            this.id_categoriaComboBox.ValueMember = "id_categoria";
            this.id_categoriaComboBox.Visible = false;
            // 
            // tb_categoriaBindingSource
            // 
            this.tb_categoriaBindingSource.DataSource = typeof(Estoques.DAL.tb_categoria);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(186, 61);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(51, 16);
            this.lblProduto.TabIndex = 11;
            this.lblProduto.Text = "Produto:";
            this.lblProduto.Visible = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(180, 114);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(62, 16);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.Visible = false;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(197, 84);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(40, 16);
            this.lblPreco.TabIndex = 13;
            this.lblPreco.Text = "Preço:";
            this.lblPreco.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(195, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtCodigoDeBarras
            // 
            this.TxtCodigoDeBarras.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "CodigoBarras", true));
            this.TxtCodigoDeBarras.Location = new System.Drawing.Point(243, 135);
            this.TxtCodigoDeBarras.Name = "TxtCodigoDeBarras";
            this.TxtCodigoDeBarras.Size = new System.Drawing.Size(219, 20);
            this.TxtCodigoDeBarras.TabIndex = 15;
            this.TxtCodigoDeBarras.Visible = false;
            // 
            // LblCodigoDeBarras
            // 
            this.LblCodigoDeBarras.AutoSize = true;
            this.LblCodigoDeBarras.Location = new System.Drawing.Point(147, 139);
            this.LblCodigoDeBarras.Name = "LblCodigoDeBarras";
            this.LblCodigoDeBarras.Size = new System.Drawing.Size(91, 13);
            this.LblCodigoDeBarras.TabIndex = 16;
            this.LblCodigoDeBarras.Text = "Codigo de Barras:";
            this.LblCodigoDeBarras.Visible = false;
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 532);
            this.Controls.Add(this.LblCodigoDeBarras);
            this.Controls.Add(this.TxtCodigoDeBarras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.id_categoriaComboBox);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.ds_produtoTextBox);
            this.Controls.Add(this.DtvProdutos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Name = "FrmProdutos";
            this.Text = "Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProdutos_FormClosed);
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.BindingSource tb_produtoBindingSource;
        private System.Windows.Forms.DataGridView DtvProdutos;
        private System.Windows.Forms.TextBox ds_produtoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.ComboBox id_categoriaComboBox;
        private System.Windows.Forms.BindingSource tb_categoriaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtCodigoDeBarras;
        private System.Windows.Forms.Label LblCodigoDeBarras;
    }
}