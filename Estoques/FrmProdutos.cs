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
    public partial class FrmProdutos : MetroFramework.Forms.MetroForm
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusForms.FormProduto = null;
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            this.tb_produtoBindingSource.DataSource = DataContextFactory.DataContext.tb_produto;
            this.tb_categoriaBindingSource.DataSource = DataContextFactory.DataContext.tb_categoria;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ds_produtoTextBox.Visible = true;
            valorTextBox.Visible = true;
            id_categoriaComboBox.Visible = true;
            TxtCodigoDeBarras.Visible = true;


            LblCodigoDeBarras.Visible = true;
            lblProduto.Visible = true;
            lblCategoria.Visible = true;
            lblPreco.Visible = true;

            this.tb_produtoBindingSource.AddNew();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.tb_produtoBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            DtvProdutos.Refresh();
            MessageBox.Show("Produto Armazenado com sucesso!");           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tb_produtoBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
             
                    this.tb_produtoBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Produto excluido com sucesso!");
               
            }
        }

        private void tb_produtoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
            {//pegando a propriedade categoria do objecto na celula 4 do DataGridView
                e.Value = ((tb_categoria)e.Value).ds_categoria;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds_produtoTextBox.Visible = true;
            valorTextBox.Visible = true;
            id_categoriaComboBox.Visible = true;
            TxtCodigoDeBarras.Visible = true;

            lblProduto.Visible = true;
            lblCategoria.Visible = true;
            lblPreco.Visible = true;
        }
    }
}
