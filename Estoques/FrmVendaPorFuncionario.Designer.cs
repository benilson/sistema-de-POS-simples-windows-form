namespace Estoques
{
    partial class FrmVendaPorFuncionario
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
            this.produtosEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_vendaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produtosEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produtosEstoqueBindingSource
            // 
            this.produtosEstoqueBindingSource.DataSource = typeof(Estoques.ProdutosEstoque);
            // 
            // tb_vendaBindingSource
            // 
            this.tb_vendaBindingSource.DataSource = typeof(Estoques.DAL.tb_venda);
            // 
            // tb_vendaDataGridView
            // 
            this.tb_vendaDataGridView.AllowUserToAddRows = false;
            this.tb_vendaDataGridView.AllowUserToDeleteRows = false;
            this.tb_vendaDataGridView.AutoGenerateColumns = false;
            this.tb_vendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_vendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tb_vendaDataGridView.DataSource = this.tb_vendaBindingSource;
            this.tb_vendaDataGridView.Location = new System.Drawing.Point(12, 173);
            this.tb_vendaDataGridView.Name = "tb_vendaDataGridView";
            this.tb_vendaDataGridView.ReadOnly = true;
            this.tb_vendaDataGridView.Size = new System.Drawing.Size(858, 357);
            this.tb_vendaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_venda";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor Pago";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_pessoa";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // FrmVendaPorFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 538);
            this.Controls.Add(this.tb_vendaDataGridView);
            this.Name = "FrmVendaPorFuncionario";
            this.Text = "FrmVendaPorFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.produtosEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource produtosEstoqueBindingSource;
        private System.Windows.Forms.BindingSource tb_vendaBindingSource;
        private System.Windows.Forms.DataGridView tb_vendaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}