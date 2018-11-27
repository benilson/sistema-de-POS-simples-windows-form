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
    public partial class FrmCategoria : MetroFramework.Forms.MetroForm
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusForms.FormCategoria = null;

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            //Objecto usada para manipular o Gridview
            this.tbcategoriaBindingSource.DataSource = DataContextFactory.DataContext.tb_categoria;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            TxtCategoria.Visible = true;
            LblCategoria.Visible = true;
            this.tbcategoriaBindingSource.AddNew();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if ( this.Valida() )
            {
                this.tbcategoriaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria Armazenada com sucesso!");
            }
            
        }

        public bool Valida()
        {
            if( TxtCategoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo categoria é obrigatorio!");
                TxtCategoria.Focus();
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tbcategoriaBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.CategoriaPossuiProduto(this.CategoriaCorrente)) {
                    MessageBox.Show("Não possivel excluir uma categoria que possui produtos!");
                } else  {
                    this.tbcategoriaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria excluida com sucesso!");
                }
                
            }

        }

        public tb_categoria CategoriaCorrente
        {
            get
            {
                return (tb_categoria)this.tbcategoriaBindingSource.Current;
            }
        }

        private bool CategoriaPossuiProduto( tb_categoria categoria )
        {
            //verifica se existem produtos relacionados com esta categoria
            var produtos = DataContextFactory.DataContext.tb_produto.Where(x => x.id_categoria == categoria.id_categoria);
            if (produtos.Count() > 0)
                return true;
            else
                return false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TxtCategoria.Visible = true;
            LblCategoria.Visible = true;
        }
    }
}
