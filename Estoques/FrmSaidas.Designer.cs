namespace Estoques
{
    partial class FrmSaidas
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
            System.Windows.Forms.Label id_vendaLabel;
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.tb_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModePagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtIdSaida = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_saidasProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.gpbPendente = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            id_vendaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_saidasProdutoBindingSource)).BeginInit();
            this.gpbPendente.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_vendaLabel
            // 
            id_vendaLabel.AutoSize = true;
            id_vendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_vendaLabel.Location = new System.Drawing.Point(293, 80);
            id_vendaLabel.Name = "id_vendaLabel";
            id_vendaLabel.Size = new System.Drawing.Size(100, 15);
            id_vendaLabel.TabIndex = 2;
            id_vendaLabel.Text = "Codigo Venda:";
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_vendaBindingSource, "id_venda", true));
            this.txtCodigoVenda.Location = new System.Drawing.Point(396, 78);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoVenda.TabIndex = 3;
            // 
            // tb_vendaBindingSource
            // 
            this.tb_vendaBindingSource.DataSource = typeof(Estoques.DAL.tb_venda);
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_vendaBindingSource, "Data", true));
            this.dtpDataVenda.Enabled = false;
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(177, 79);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(100, 20);
            this.dtpDataVenda.TabIndex = 4;
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AutoGenerateColumns = false;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.ModePagamento,
            this.Pendente});
            this.dgvVendas.DataSource = this.tb_vendaBindingSource;
            this.dgvVendas.Location = new System.Drawing.Point(12, 175);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.Size = new System.Drawing.Size(929, 214);
            this.dgvVendas.TabIndex = 4;
            this.dgvVendas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tb_vendaDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_venda";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "desconto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Desconto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor_pago";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor pago";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tb_pessoa";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ModePagamento
            // 
            this.ModePagamento.DataPropertyName = "ModePagamento";
            this.ModePagamento.HeaderText = "Pagamento";
            this.ModePagamento.Name = "ModePagamento";
            this.ModePagamento.ReadOnly = true;
            // 
            // Pendente
            // 
            this.Pendente.DataPropertyName = "Pendente";
            this.Pendente.HeaderText = "Estado";
            this.Pendente.Name = "Pendente";
            this.Pendente.ReadOnly = true;
            this.Pendente.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reemprimir Factura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_vendaBindingSource, "Data", true));
            this.dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDateTimePicker.Location = new System.Drawing.Point(91, 137);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(0, 20);
            this.dataDateTimePicker.TabIndex = 9;
            this.dataDateTimePicker.TabStop = false;
            // 
            // txtIdSaida
            // 
            this.txtIdSaida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_vendaBindingSource, "id_venda", true));
            this.txtIdSaida.Location = new System.Drawing.Point(24, 35);
            this.txtIdSaida.Name = "txtIdSaida";
            this.txtIdSaida.Size = new System.Drawing.Size(0, 20);
            this.txtIdSaida.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(98, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Por data";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tb_saidasProdutoBindingSource
            // 
            this.tb_saidasProdutoBindingSource.DataSource = typeof(Estoques.DAL.tb_saidasProduto);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 34);
            this.button3.TabIndex = 12;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 27);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Cartão";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(80, 27);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(65, 17);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Dinheiro";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(151, 29);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(57, 17);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "Pago?";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // gpbPendente
            // 
            this.gpbPendente.Controls.Add(this.button3);
            this.gpbPendente.Controls.Add(this.checkBox4);
            this.gpbPendente.Controls.Add(this.checkBox2);
            this.gpbPendente.Controls.Add(this.checkBox3);
            this.gpbPendente.Location = new System.Drawing.Point(12, 395);
            this.gpbPendente.Name = "gpbPendente";
            this.gpbPendente.Size = new System.Drawing.Size(326, 60);
            this.gpbPendente.TabIndex = 16;
            this.gpbPendente.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 31);
            this.button4.TabIndex = 17;
            this.button4.Text = "Imprimir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmSaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 528);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.gpbPendente);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtIdSaida);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(id_vendaLabel);
            this.Controls.Add(this.txtCodigoVenda);
            this.Name = "FrmSaidas";
            this.Text = ":: Saidas ::";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSaidas_FormClosed);
            this.Load += new System.EventHandler(this.FrmSaidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_saidasProdutoBindingSource)).EndInit();
            this.gpbPendente.ResumeLayout(false);
            this.gpbPendente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tb_vendaBindingSource;
        private System.Windows.Forms.TextBox txtCodigoVenda;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource tb_saidasProdutoBindingSource;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox txtIdSaida;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModePagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pendente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox gpbPendente;
        private System.Windows.Forms.Button button4;
    }
}