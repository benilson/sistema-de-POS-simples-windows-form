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
using System.Globalization;

namespace Estoques
{
    public partial class FrmVenda : MetroFramework.Forms.MetroForm
    {
        public FrmVenda() 
        {
            InitializeComponent();
        }

        private void FrmVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusForms.FormVenda = null;
        }

        public tb_venda VendaCorrente
        {
            get
            {
                return (tb_venda)this.tb_vendaBindingSource.Current;
            }
        }

        public tb_itens_venda ItemCorrente
        {
            get
            {
                return (tb_itens_venda)this.tb_itens_vendaBindingSource.Current;
            }
        }

        List<tb_produto> produtoslista1;
        private void FrmVenda_Load(object sender, EventArgs e)
        {
            List<tb_pessoa> listaDePessoas = DataContextFactory.DataContext.tb_pessoa.ToList();
            List<tb_usuario> usuarios = DataContextFactory.DataContext.tb_usuario.ToList();
            List<tb_pessoa> listaDePessoasSemUsuarios = new List<tb_pessoa>();
            bool temUsuario;
            //pesquisa se pessoas ja tem usuarios
            foreach (var p in listaDePessoas)
            {
                temUsuario = true;
                foreach (var u in usuarios) {
                    if (u.id_pessoa == p.id_pessoa) {
                        temUsuario = false;
                    }
                }

                if (temUsuario) {
                    listaDePessoasSemUsuarios.Add(p);
                }

            }

            this.tb_pessoaBindingSource.DataSource = listaDePessoasSemUsuarios;

            this.tb_vendaBindingSource.DataSource = DataContextFactory.DataContext.tb_venda;

            this.tb_produtoBindingSource.DataSource = DataContextFactory.DataContext.tb_produto;
             
            this.tb_vendaBindingSource.AddNew();

            produtoslista1 = DataContextFactory.DataContext.tb_produto.ToList();
        }

        //Nova venda----------------------------------------------------------------------------------------------------------
        string cliente;
        private void button1_Click(object sender, EventArgs e)
        {
            this.tb_vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            cliente = ((tb_pessoa)id_pessoaComboBox.SelectedItem).nome;
            this.VendaCorrente.id_pessoaVendedor = FrmPrincipal.Id_pessoaVendedor;
            this.VendaCorrente.ModePagamento = FormaPagamento;
            this.VendaCorrente.Pendente = Pendente;
            id_pessoaComboBox.Enabled = false;
            
            groupBox1.Visible = true;
            button1.Enabled = false;
            //Mostra todos os produtos da venda atual
            this.tb_itens_vendaBindingSource.DataSource = 
            DataContextFactory.DataContext.tb_itens_venda.Where(x => x.id_produto == this.VendaCorrente.id_venda);
            NovoItem();
            textBox1.Focus();
        }

        private void NovoItem()
        {
            this.tb_itens_vendaBindingSource.AddNew();
            this.ItemCorrente.id_venda = this.VendaCorrente.id_venda; 
            this.ItemCorrente.quantidade = 1;
        }


        //Novo item
        private void BtnNovoItem_Click(object sender, EventArgs e)
        {
            this.tb_itens_vendaBindingSource.EndEdit();
            DtvItens.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();
        }


        private void DtvItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
            {//pegando a propriedade categoria do objecto na celula 1 do DataGridView
                e.Value = ((tb_produto)e.Value).ds_produto;
            }
        }


        private void MostraSomaValores()
        {
            decimal total = 0;
            foreach ( DataGridViewRow dg in DtvItens.Rows)
            {
                decimal v1 = Convert.ToDecimal( dg.Cells[2].Value );
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subtotal = v1 * v2;
                dg.Cells[4].Value = subtotal;
                total = total + subtotal;
            }
            this.VendaCorrente.valor = total;

        }

        private void BtnFinPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar essa venda?\n Não sera possivel adicionar mais produtos", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.tb_itens_vendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.desconto = 0;

                textBox1.Enabled = false;
                TxtQuantidade.Enabled = false;
                TxtCodigoVenda.Enabled = false;

                TxtDesconto.ReadOnly = false;
                TxtDesconto.Focus();

                BtnFinPedido.Enabled = false;
                BtnFinaliVenda.Enabled = true;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        string FormaPagamento;
        string Pendente;

        private void BtnFinaliVenda_Click(object sender, EventArgs e)
        {           
            //List<tb_produto> produtoslista2 = new List<tb_produto>();

            foreach (DataGridViewRow dg in DtvItens.Rows)
            {

                foreach (var p in produtoslista1)
                {
                    if (p.id_produto == Convert.ToInt32(dg.Cells[0].Value))
                    {
                        int? qtd = p.qtd - Convert.ToInt32(dg.Cells[2].Value);
                        produtoslista1.Where(x => x.id_produto == Convert.ToInt32(dg.Cells[0].Value)).First().qtd = qtd;
                    }
                }

            }

            tb_produtoBindingSource.DataSource = produtoslista1;

            this.VendaCorrente.desconto = Convert.ToDecimal( TxtDesconto.Text );
            this.VendaCorrente.valor_pago = (decimal)(this.VendaCorrente.valor - this.VendaCorrente.desconto);
            this.VendaCorrente.Data = DateTime.Now.ToString("dd/MM/yyyy");
            this.VendaCorrente.Pendente = Pendente;
            this.VendaCorrente.ModePagamento = FormaPagamento;
            this.tb_vendaBindingSource.EndEdit();

            DataContextFactory.DataContext.SubmitChanges();
            TxtDesconto.Enabled = false;

            BtnFinaliVenda.Enabled = false;
            BtnImprimir.Enabled = true;
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            List<ProdutosImprimir> produtosImprimirLista = new List<ProdutosImprimir>();
            foreach (DataGridViewRow dg in DtvItens.Rows)
            {
                ProdutosImprimir pdImprimir = new ProdutosImprimir();
                pdImprimir.ID = Convert.ToInt32(dg.Cells[0].Value);
                pdImprimir.Produto = ((tb_produto)dg.Cells[1].Value).ds_produto;
                pdImprimir.Qtd = Convert.ToInt32(dg.Cells[2].Value);
                pdImprimir.preco = Convert.ToDecimal(dg.Cells[3].Value);
                pdImprimir.Total = Convert.ToDecimal(dg.Cells[4].Value);
                produtosImprimirLista.Add(pdImprimir);
            }


            using (FrmImprimir frm = new FrmImprimir(produtosImprimirLista, string.Format(CultureInfo.GetCultureInfo("pt-pt"), "{0:N}", TxtValorItens.Text), string.Format(CultureInfo.GetCultureInfo("pt-pt"), "{0:N}", TxtValorPago.Text), DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), String.Format("{0:HH:mm}", DateTime.Now.Hour.ToString()), FrmPrincipal.Nome, TxtCodigoVenda.Text, cliente))
            {
                frm.ShowDialog();
            }

            this.Close();
        }

        tb_produto produtoEncontrado;

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string codigoDeBarras = textBox1.Text;
            if (e.KeyCode == Keys.Enter)
            {

                textBox1.Text = "";
                var produtos = DataContextFactory.DataContext.tb_produto;
                
                foreach (var p in produtos) {
                    if (p.CodigoBarras == Convert.ToInt64(codigoDeBarras))
                    {
                        produtoEncontrado = p;
                        LblProdutoPesquisado.Visible = true;
                        LblProdutoPesquisado.Text = produtoEncontrado.ds_produto;
                        TxtValor.Text = Convert.ToString(produtoEncontrado.valor);
                    }                                          
                }
                TxtQuantidade.Enabled = true;
                TxtQuantidade.Focus();
                button2.Enabled = true;
                btnExcluir.Enabled = true;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.ItemCorrente.id_produto = (int)produtoEncontrado.id_produto;
            this.ItemCorrente.valor = (decimal)produtoEncontrado.valor;
            List<tb_produto> produtosComPoucasQuantidades = new List<tb_produto>();


            foreach (DataGridViewRow dg in DtvItens.Rows)
            {
                foreach (var p in produtoslista1)
                {
                    if (p.id_produto == Convert.ToInt32(dg.Cells[0].Value))
                    {
                        var naoExisteQuantidade = produtosComPoucasQuantidades.Where(pro => pro.id_produto == Convert.ToInt32(dg.Cells[0].Value) && pro.qtd < Convert.ToInt32(dg.Cells[2].Value)).ToList();

                        if (naoExisteQuantidade.Count > 0)
                        {
                            MessageBox.Show("O este item contem apenas " + naoExisteQuantidade.Last().qtd + "UN em Estoque não e possivel retirar " + TxtQuantidade.Text + "UN reduza a quantidade ");
                            return;
                        }
                        //verifica se a quantidade digitada e menor no banco de dados
                        if (p.qtd < Convert.ToInt32(dg.Cells[2].Value))
                        {

                            string qtdTexto = Convert.ToString(p.qtd);
                            MessageBox.Show("O este item contem apenas " + qtdTexto + "UN em Estoque não e possivel retirar " + TxtQuantidade.Text + "UN reduza a quantidade ");

                            return;
                        }
                        else if (p.qtd == 0)
                        {
                            MessageBox.Show("E ste item esta com o Estoque esgotado não e possivel  adicioná-lo");

                            return;
                        }//verifica se a quantidade digitada e maior no banco de dados
                        if (p.qtd > Convert.ToInt32(dg.Cells[2].Value))
                        {
                            tb_produto produ = p;

                            produ.qtd -= Convert.ToInt32(dg.Cells[2].Value);//reduz quantidade no produto adquirido
                            produtosComPoucasQuantidades.Add(produ);

                        }
                    }
                }

            }


            LblProdutoPesquisado.Visible = false;
            this.tb_itens_vendaBindingSource.EndEdit();
            DtvItens.Refresh();


            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();
            TxtValor.Text = "";
            textBox1.Text = "";
            textBox1.Focus();
            button2.Enabled = false;
            TxtQuantidade.Enabled = false;
           
        }//fim adicionar

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    this.tb_itens_vendaBindingSource.RemoveCurrent();
                    ///DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Item removido!");
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MeusForms.FormPessoaFisica == null)
                MeusForms.FormPessoaFisica = new FrmPessoaFisica();

            MeusForms.FormPessoaFisica.Show();//  Mostra formularios categoria
            MeusForms.FormPessoaFisica.Focus();
        }

        private void id_pessoaComboBox_DropDown(object sender, EventArgs e)
        {
            List<tb_pessoa> listaDePessoas = DataContextFactory.DataContext.tb_pessoa.ToList();
            List<tb_usuario> usuarios = DataContextFactory.DataContext.tb_usuario.ToList();
            List<tb_pessoa> listaDePessoasSemUsuarios = new List<tb_pessoa>();
            bool temUsuario;
            //pesquisa se pessoas ja tem usuarios
            foreach (var p in listaDePessoas)
            {
                temUsuario = true;
                foreach (var u in usuarios)
                {
                    if (u.id_pessoa == p.id_pessoa)
                    {
                        temUsuario = false;
                    }
                }

                if (temUsuario)
                {
                    listaDePessoasSemUsuarios.Add(p);
                }

            }

            this.tb_pessoaBindingSource.DataSource = listaDePessoasSemUsuarios;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked) {
                gbPagamento.Enabled = true;
                FormaPagamento = "Dinheiro"; 
            } else {
                gbPagamento.Enabled = false;
                
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked) {
                gbPagamento.Enabled = true;
                FormaPagamento = "Cartão";
            } else {
                gbPagamento.Enabled = false;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked) {
                TxtValorPago.Enabled = false;
                gbPagamento.Enabled = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                Pendente = "Pendente";
            } else {
                gbPagamento.Enabled = false;
                Pendente = "Pago";
            }
        }

        //private void TxtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //}//fim adicionar quantidade e adicionar
    }
}
