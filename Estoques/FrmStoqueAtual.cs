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
    public partial class FrmStoqueAtual : MetroFramework.Forms.MetroForm
    {
        public FrmStoqueAtual()
        {
            InitializeComponent();
        }

        private void FrmStoqueAtual_Load(object sender, EventArgs e)
        {
            this.tb_produtoBindingSource.DataSource = DataContextFactory.DataContext.tb_produto;
            foreach (DataGridViewRow dg in dgvProdutos.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subtotal = v1 * v2;
                dg.Cells[4].Value = subtotal;
            }
        }

        private void tb_produtoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 6)
            {//pegando a propriedade categoria do objecto na celula 4 do DataGridView
                e.Value = ((tb_categoria)e.Value).ds_categoria;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDe.Visible = true;
            txtPara.Visible = true;
            lblDe.Visible = true;
            lblPara.Visible = true;
            btnImprimir.Visible = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.tb_produtoBindingSource.DataSource = DataContextFactory.DataContext.tb_produto
                .Where(p=> p.id_produto >= Convert.ToInt32(txtDe.Text) && p.id_produto <= Convert.ToInt32(txtPara.Text));

            List<ProdutosEstoque> produtosImprimirLista = new List<ProdutosEstoque>();
            foreach (DataGridViewRow dg in dgvProdutos.Rows)
            {
                ProdutosEstoque pdImprimir = new ProdutosEstoque();
                pdImprimir.id_produto = Convert.ToInt32(dg.Cells[0].Value);
                pdImprimir.ds_produto = Convert.ToString(dg.Cells[1].Value);
                pdImprimir.valor = Convert.ToDecimal(dg.Cells[2].Value);
                pdImprimir.qtd = Convert.ToInt32(dg.Cells[3].Value);
                pdImprimir.Total = pdImprimir.valor * pdImprimir.qtd;
                pdImprimir.codigoBarras = Convert.ToInt32(dg.Cells[5].Value);
                pdImprimir.categoria = ((tb_categoria)dg.Cells[6].Value).ds_categoria;
                produtosImprimirLista.Add(pdImprimir);
            }


            using (FrmImprimirStoque frm = new FrmImprimirStoque(produtosImprimirLista))
            {
                frm.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<ProdutosEstoque> produtosImprimirLista = new List<ProdutosEstoque>();
            foreach (DataGridViewRow dg in dgvProdutos.Rows)
            {
                ProdutosEstoque pdImprimir = new ProdutosEstoque();
                pdImprimir.id_produto = Convert.ToInt32(dg.Cells[0].Value);
                pdImprimir.ds_produto = Convert.ToString(dg.Cells[1].Value);
                pdImprimir.valor = Convert.ToDecimal(dg.Cells[2].Value);
                pdImprimir.qtd = Convert.ToInt32(dg.Cells[3].Value);
                pdImprimir.Total = pdImprimir.valor * pdImprimir.qtd;
                pdImprimir.codigoBarras = Convert.ToInt32(dg.Cells[5].Value);
                pdImprimir.categoria = ((tb_categoria)dg.Cells[6].Value).ds_categoria;
                produtosImprimirLista.Add(pdImprimir);
            }


            using (FrmImprimirStoque frm = new FrmImprimirStoque(produtosImprimirLista))
            {
                frm.ShowDialog();
            }
        }

        private void FrmStoqueAtual_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusForms.FormStoqueAtual = null;
        }
    }
}
