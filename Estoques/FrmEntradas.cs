using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estoques.DAL;

namespace Estoques
{
    public partial class FrmEntradas : MetroFramework.Forms.MetroForm
    {
        public FrmEntradas()
        {
            InitializeComponent();
        }

        public tb_entradasProduto EntradaCorrente
        {
            get
            {
                return (tb_entradasProduto)this.tb_entradasProdutoBindingSource.Current;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.EntradaCorrente.id_produto = Convert.ToInt32(txtIdProduto.Text);
            this.EntradaCorrente.qtdAnterior = Convert.ToInt32(txtQtd.Text);
            txtQtd.Text = (Convert.ToInt32(txtQtd.Text) + Convert.ToInt32(txtQtdEntrada.Text)).ToString();
            this.EntradaCorrente.data = dtPicker.Text;
            this.tb_produtoBindingSource.EndEdit();
            this.tb_entradasProdutoBindingSource.EndEdit();


            DataContextFactory.DataContext.SubmitChanges();
            gvdEntradas.Refresh();
        }

        private void FrmEntradas_Load(object sender, EventArgs e)
        {
            this.tb_entradasProdutoBindingSource.DataSource = DataContextFactory.DataContext.tb_entradasProduto;

            this.tb_produtoBindingSource.DataSource = DataContextFactory.DataContext.tb_produto;

            this.tb_entradasProdutoBindingSource.AddNew();
        }

        private void tb_produtoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 4)
            {//pegando a propriedade categoria do objecto na celula 1 do DataGridView
                e.Value = ((tb_categoria)e.Value).ds_categoria;
            }
        }

        private void gvdEntradas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 2)
            {//pegando a propriedade categoria do objecto na celula 1 do DataGridView
                e.Value = ((tb_produto)e.Value).ds_produto;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ( !string.IsNullOrEmpty(txtCodigoDeBarras.Text) && string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                this.tb_produtoBindingSource.DataSource = DataContextFactory.DataContext.tb_produto.Where(p => p.CodigoBarras == Convert.ToInt32(txtCodigoDeBarras.Text));
            }
            else if ( string.IsNullOrEmpty(txtCodigoDeBarras.Text) && !string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                this.tb_produtoBindingSource.DataSource = DataContextFactory.DataContext.tb_produto.Where(p => p.ds_produto.Contains(txtNomeProduto.Text));
            }
            else if( !string.IsNullOrEmpty(txtCodigoDeBarras.Text) && !string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                this.tb_produtoBindingSource.DataSource = DataContextFactory.DataContext.tb_produto.Where(p => p.CodigoBarras == Convert.ToInt32(txtCodigoDeBarras.Text) && p.ds_produto.Contains(txtNomeProduto.Text));
            }
            else if ( string.IsNullOrEmpty(txtCodigoDeBarras.Text) && string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                this.tb_produtoBindingSource.DataSource = DataContextFactory.DataContext.tb_produto;
            }

            dgvProdutos.Refresh();
        }

        private void FrmEntradas_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusForms.FrmEntradas = null;
        }
    }
}
