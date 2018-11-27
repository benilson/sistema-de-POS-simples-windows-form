using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estoques.DAL;
using System.Globalization;

namespace Estoques
{
    public partial class FrmSaidas : MetroFramework.Forms.MetroForm
    {
        public FrmSaidas()
        {
            InitializeComponent();
        }

        string dataPesquisada = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataPesquisada) && string.IsNullOrEmpty(txtCodigoVenda.Text))
            {
                this.tb_vendaBindingSource.DataSource = DataContextFactory.DataContext.tb_venda.Where(p => p.Data == dtpDataVenda.Text);
            }
            else if ((string.IsNullOrEmpty(dataPesquisada)) && !string.IsNullOrEmpty(txtCodigoVenda.Text))
            {
                this.tb_vendaBindingSource.DataSource = DataContextFactory.DataContext.tb_venda.Where(p => p.id_venda == Convert.ToInt32(txtCodigoVenda.Text));
            }
            else if (!string.IsNullOrEmpty(dataPesquisada) && !string.IsNullOrEmpty(txtCodigoVenda.Text))
            {
                this.tb_vendaBindingSource.DataSource = DataContextFactory.DataContext.tb_venda.Where(p => p.id_venda == Convert.ToInt32(txtCodigoVenda.Text) && p.Data == dtpDataVenda.Text );
            }
            else if ( string.IsNullOrEmpty(dataPesquisada) && string.IsNullOrEmpty(txtCodigoVenda.Text))
            {
                this.tb_vendaBindingSource.DataSource = DataContextFactory.DataContext.tb_venda;
            } else
            {
                this.tb_vendaBindingSource.DataSource = DataContextFactory.DataContext.tb_venda;
            }
            dtpDataVenda.Text = null;
            txtCodigoVenda.Text = null;
            dgvVendas.Refresh();
        }

        private void FrmSaidas_Load(object sender, EventArgs e)
        {
            if (FrmPrincipal.perfil == "Usuario") {
                tb_vendaBindingSource.DataSource = DataContextFactory.DataContext.tb_venda.Where(v => v.id_pessoaVendedor == FrmPrincipal.Id_pessoaVendedor).OrderByDescending(v => v.id_venda);
                dtpDataVenda.Text = null;
            } else {
                tb_vendaBindingSource.DataSource = DataContextFactory.DataContext.tb_venda.OrderByDescending(v => v.id_venda);
                dtpDataVenda.Text = null;
            }
            
        }

        private void tb_vendaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 4)
            {//pegando a propriedade categoria do objecto na celula 1 do DataGridView
                e.Value = ((tb_pessoa)e.Value).nome;
            }
        }

        private void FrmSaidas_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusForms.FrmSaidas = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<ProdutosImprimir> produtosImprimirLista = new List<ProdutosImprimir>();
            List<tb_itens_venda> Listatensvenda = DataContextFactory.DataContext.tb_itens_venda.ToList();
            List<tb_venda> vendas = DataContextFactory.DataContext.tb_venda.ToList();
            int? idPessoa = 0;
            string cliente = "";
            foreach ( var s in Listatensvenda)
            {
                if( s.id_venda == Convert.ToInt32(txtIdSaida.Text))
                {
                    
                    ProdutosImprimir pdImprimir = new ProdutosImprimir();
                    pdImprimir.Produto = ((tb_produto)s.tb_produto).ds_produto;
                    pdImprimir.preco = ((tb_produto)s.tb_produto).valor;
                    pdImprimir.ID = s.id_produto;
                    pdImprimir.Qtd = s.quantidade;
                    pdImprimir.Total = s.quantidade * s.valor;
                    produtosImprimirLista.Add(pdImprimir);
                }
            }

            foreach ( var s in vendas ) {
                if(s.id_venda == Convert.ToInt32(txtIdSaida.Text))
                {
                    idPessoa = s.id_pessoa;
                }
            }
            List<tb_pessoa> pessoas = DataContextFactory.DataContext.tb_pessoa.ToList();
            foreach( var p in pessoas)
            {
                if(p.id_pessoa == idPessoa)
                {
                    cliente = p.nome;
                }
            }
            
            using (FrmImprimir frm = new FrmImprimir(produtosImprimirLista, string.Format("{0:#,###.##}", produtosImprimirLista.Sum(p=> p.Total)), string.Format("{0:#,###.##}", produtosImprimirLista.Sum(p => p.Total)), dataDateTimePicker.Text, String.Format("{0:HH:mm}", DateTime.Now.Hour.ToString()), FrmPrincipal.Nome, txtIdSaida.Text, cliente))
            {
                frm.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if( checkBox1.CheckState == CheckState.Checked)
            {
                dtpDataVenda.Enabled = true;
                dataPesquisada = dtpDataVenda.Text;
                txtCodigoVenda.Enabled = false;
            }
            else
            {
                dtpDataVenda.Enabled = false;
                dataPesquisada = null;
            }
        }
           
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
