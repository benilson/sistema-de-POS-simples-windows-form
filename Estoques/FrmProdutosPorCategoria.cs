using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estoques.DAL;
namespace Estoques
{
    public partial class FrmProdutosPorCategoria : MetroFramework.Forms.MetroForm
    {
        private BindingSource tb_produtoBindingSource;
        private IContainer components;
        private Label label1;
        private Button btnPesquisar;
        private ComboBox CboCategoria;
        private BindingSource tb_categoriaBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridView tb_produtoDataGridView;

        public FrmProdutosPorCategoria()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_produtoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.tb_categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_produtoBindingSource
            // 
            this.tb_produtoBindingSource.DataSource = typeof(Estoques.DAL.tb_produto);
            // 
            // tb_produtoDataGridView
            // 
            this.tb_produtoDataGridView.AllowUserToAddRows = false;
            this.tb_produtoDataGridView.AllowUserToDeleteRows = false;
            this.tb_produtoDataGridView.AutoGenerateColumns = false;
            this.tb_produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_produtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tb_produtoDataGridView.DataSource = this.tb_produtoBindingSource;
            this.tb_produtoDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_produtoDataGridView.Location = new System.Drawing.Point(20, 158);
            this.tb_produtoDataGridView.Name = "tb_produtoDataGridView";
            this.tb_produtoDataGridView.ReadOnly = true;
            this.tb_produtoDataGridView.Size = new System.Drawing.Size(534, 220);
            this.tb_produtoDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(457, 92);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // CboCategoria
            // 
            this.CboCategoria.DataSource = this.tb_categoriaBindingSource;
            this.CboCategoria.DisplayMember = "ds_categoria";
            this.CboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(125, 94);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(326, 24);
            this.CboCategoria.TabIndex = 5;
            this.CboCategoria.ValueMember = "id_categoria";
            // 
            // tb_categoriaBindingSource
            // 
            this.tb_categoriaBindingSource.DataSource = typeof(Estoques.DAL.tb_categoria);
            // 
            // FrmProdutosPorCategoria
            // 
            this.ClientSize = new System.Drawing.Size(574, 398);
            this.Controls.Add(this.CboCategoria);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_produtoDataGridView);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmProdutosPorCategoria";
            this.Text = ":: Produtos por Categorias ::";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProdutosPorCategoria_FormClosed);
            this.Load += new System.EventHandler(this.FrmProdutosPorCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmProdutosPorCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusForms.FormProdutosPorCategoria = null;
        }

        private void FrmProdutosPorCategoria_Load(object sender, EventArgs e)
        {
            this.tb_categoriaBindingSource.DataSource = DataContextFactory.DataContext.tb_categoria;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)CboCategoria.SelectedValue);
        }

        public void Pesquisar( int codigoCategoria)
        {
            this.tb_produtoBindingSource.DataSource = DataContextFactory.DataContext.tb_produto.Where(x => x.id_categoria == codigoCategoria);
        }
    }
}
