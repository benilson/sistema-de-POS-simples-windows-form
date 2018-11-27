namespace Estoques
{
    partial class FrmEntradas
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
            System.Windows.Forms.Label ds_produtoLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label valorCompraLabel;
            System.Windows.Forms.Label label5;
            this.txtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_produtoTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gvdEntradas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_entradasProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtQtdEntrada = new System.Windows.Forms.TextBox();
            this.valorCompraTextBox = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.tb_saidasProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ds_produtoLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            valorCompraLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_entradasProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_saidasProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ds_produtoLabel
            // 
            ds_produtoLabel.AutoSize = true;
            ds_produtoLabel.Location = new System.Drawing.Point(128, 317);
            ds_produtoLabel.Name = "ds_produtoLabel";
            ds_produtoLabel.Size = new System.Drawing.Size(78, 13);
            ds_produtoLabel.TabIndex = 7;
            ds_produtoLabel.Text = "Nome Produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(176, 353);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(27, 13);
            label4.TabIndex = 11;
            label4.Text = "Qtd:";
            // 
            // valorCompraLabel
            // 
            valorCompraLabel.AutoSize = true;
            valorCompraLabel.Location = new System.Drawing.Point(315, 354);
            valorCompraLabel.Name = "valorCompraLabel";
            valorCompraLabel.Size = new System.Drawing.Size(88, 13);
            valorCompraLabel.TabIndex = 13;
            valorCompraLabel.Text = "Valor de Compra:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(119, 378);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 13);
            label5.TabIndex = 16;
            label5.Text = "Data de Compra:";
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(240, 87);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(168, 20);
            this.txtCodigoDeBarras.TabIndex = 0;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(240, 113);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(168, 20);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo de Barras:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pesquisar por:";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5});
            this.dgvProdutos.DataSource = this.tb_produtoBindingSource;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 145);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(722, 151);
            this.dgvProdutos.TabIndex = 7;
            this.dgvProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tb_produtoDataGridView_CellFormatting);
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "qtd";
            this.dataGridViewTextBoxColumn6.HeaderText = "Qtd";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tb_categoria";
            this.dataGridViewTextBoxColumn7.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CodigoBarras";
            this.dataGridViewTextBoxColumn5.HeaderText = "Codigo de Barras";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // tb_produtoBindingSource
            // 
            this.tb_produtoBindingSource.DataSource = typeof(Estoques.DAL.tb_produto);
            // 
            // ds_produtoTextBox
            // 
            this.ds_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "ds_produto", true));
            this.ds_produtoTextBox.Location = new System.Drawing.Point(209, 314);
            this.ds_produtoTextBox.Name = "ds_produtoTextBox";
            this.ds_produtoTextBox.ReadOnly = true;
            this.ds_produtoTextBox.Size = new System.Drawing.Size(296, 20);
            this.ds_produtoTextBox.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gvdEntradas
            // 
            this.gvdEntradas.AllowUserToAddRows = false;
            this.gvdEntradas.AllowUserToDeleteRows = false;
            this.gvdEntradas.AutoGenerateColumns = false;
            this.gvdEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvdEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.gvdEntradas.DataSource = this.tb_entradasProdutoBindingSource;
            this.gvdEntradas.Location = new System.Drawing.Point(12, 413);
            this.gvdEntradas.Name = "gvdEntradas";
            this.gvdEntradas.ReadOnly = true;
            this.gvdEntradas.Size = new System.Drawing.Size(722, 290);
            this.gvdEntradas.TabIndex = 12;
            this.gvdEntradas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvdEntradas_CellFormatting);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_entrada";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "qtdEtrada";
            this.dataGridViewTextBoxColumn9.HeaderText = "Qtd Entrada";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 90;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "tb_produto";
            this.dataGridViewTextBoxColumn14.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "qtdAnterior";
            this.dataGridViewTextBoxColumn11.HeaderText = "Qtd Anterior";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 90;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "data";
            this.dataGridViewTextBoxColumn12.HeaderText = "Data";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 90;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "valorCompra";
            this.dataGridViewTextBoxColumn13.HeaderText = "Valor de Compra";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 120;
            // 
            // tb_entradasProdutoBindingSource
            // 
            this.tb_entradasProdutoBindingSource.DataSource = typeof(Estoques.DAL.tb_entradasProduto);
            // 
            // txtQtdEntrada
            // 
            this.txtQtdEntrada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_entradasProdutoBindingSource, "qtdEtrada", true));
            this.txtQtdEntrada.Location = new System.Drawing.Point(209, 350);
            this.txtQtdEntrada.Name = "txtQtdEntrada";
            this.txtQtdEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtQtdEntrada.TabIndex = 13;
            // 
            // valorCompraTextBox
            // 
            this.valorCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_entradasProdutoBindingSource, "valorCompra", true));
            this.valorCompraTextBox.Location = new System.Drawing.Point(405, 350);
            this.valorCompraTextBox.Name = "valorCompraTextBox";
            this.valorCompraTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorCompraTextBox.TabIndex = 14;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "id_produto", true));
            this.txtIdProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIdProduto.Location = new System.Drawing.Point(-4, 125);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.ReadOnly = true;
            this.txtIdProduto.Size = new System.Drawing.Size(0, 13);
            this.txtIdProduto.TabIndex = 0;
            this.txtIdProduto.TabStop = false;
            // 
            // txtQtd
            // 
            this.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "qtd", true));
            this.txtQtd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQtd.Location = new System.Drawing.Point(-4, 161);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.ReadOnly = true;
            this.txtQtd.Size = new System.Drawing.Size(0, 13);
            this.txtQtd.TabIndex = 0;
            this.txtQtd.TabStop = false;
            // 
            // dtPicker
            // 
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker.Location = new System.Drawing.Point(209, 377);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(100, 20);
            this.dtPicker.TabIndex = 15;
            // 
            // tb_saidasProdutoBindingSource
            // 
            this.tb_saidasProdutoBindingSource.DataSource = typeof(Estoques.DAL.tb_saidasProduto);
            // 
            // FrmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 717);
            this.Controls.Add(label5);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(valorCompraLabel);
            this.Controls.Add(this.valorCompraTextBox);
            this.Controls.Add(this.txtQtdEntrada);
            this.Controls.Add(this.gvdEntradas);
            this.Controls.Add(label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(ds_produtoLabel);
            this.Controls.Add(this.ds_produtoTextBox);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtCodigoDeBarras);
            this.Name = "FrmEntradas";
            this.Text = "::Entradas Produtos::";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEntradas_FormClosed);
            this.Load += new System.EventHandler(this.FrmEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_entradasProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_saidasProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoDeBarras;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tb_produtoBindingSource;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox ds_produtoTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource tb_entradasProdutoBindingSource;
        private System.Windows.Forms.DataGridView gvdEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.TextBox txtQtdEntrada;
        private System.Windows.Forms.TextBox valorCompraTextBox;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.BindingSource tb_saidasProdutoBindingSource;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}