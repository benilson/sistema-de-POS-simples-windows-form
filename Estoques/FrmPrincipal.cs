using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoques
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        //adicionar variavel para receber o nome do usuario
        public static string NomeUsuario;
        public static string Nome;
        public static string perfil;
        public static int Id_pessoaVendedor;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusForms.FormCategoria == null)
                MeusForms.FormCategoria = new FrmCategoria();

            MeusForms.FormCategoria.Show();//  Mostra formularios categoria
            MeusForms.FormCategoria.Focus();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusForms.FormProduto == null)
                MeusForms.FormProduto = new FrmProdutos();

            MeusForms.FormProduto.Show();//  Mostra formularios categoria
            MeusForms.FormProduto.Focus();
        }

        private void produtosPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusForms.FormProdutosPorCategoria == null)
                MeusForms.FormProdutosPorCategoria = new FrmProdutosPorCategoria();

            MeusForms.FormProdutosPorCategoria.Show();//  Mostra formularios categoria
            MeusForms.FormProdutosPorCategoria.Focus();
        }

        private void pessoasFisicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusForms.FormPessoaFisica == null)
                MeusForms.FormPessoaFisica = new FrmPessoaFisica();

            MeusForms.FormPessoaFisica.Show();//  Mostra formularios categoria
            MeusForms.FormPessoaFisica.Focus();
        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MeusForms.FormVenda == null)
                MeusForms.FormVenda = new FrmVenda();

            MeusForms.FormVenda.Show();//  Mostra formularios ca
            MeusForms.FormVenda.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MeusForms.FormRelatorioProdutos == null)
                MeusForms.FormRelatorioProdutos = new FrmRelatorioProdutos();

            MeusForms.FormRelatorioProdutos.Show();//  Mostra formularios ca
            MeusForms.FormRelatorioProdutos.Focus();
        }

        private void estoqueAtualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( MeusForms.FormStoqueAtual == null)
                 MeusForms.FormStoqueAtual = new FrmStoqueAtual();

            MeusForms.FormStoqueAtual.Show();//  Mostra formularios ca
            MeusForms.FormStoqueAtual.Focus();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusForms.FrmEntradas == null)
                MeusForms.FrmEntradas = new FrmEntradas();

            MeusForms.FrmEntradas.Show();//  Mostra formularios ca
            MeusForms.FrmEntradas.Focus();
        }

        private void saidasDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusForms.FrmSaidas == null)
                MeusForms.FrmSaidas = new FrmSaidas();

            MeusForms.FrmSaidas.Show();//  Mostra formularios ca
            MeusForms.FrmSaidas.Focus();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusForms.FrmUsuario == null)
                MeusForms.FrmUsuario = new FrmUsuarios();

            MeusForms.FrmUsuario.Show();//  Mostra formularios ca
            MeusForms.FrmUsuario.Focus();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            label1.Text = NomeUsuario;
        }
    }
}
