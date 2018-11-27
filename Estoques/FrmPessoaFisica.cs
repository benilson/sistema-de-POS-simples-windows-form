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
    public partial class FrmPessoaFisica : MetroFramework.Forms.MetroForm
    {
        public FrmPessoaFisica()
        {
            InitializeComponent();
        }

        private void FrmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusForms.FormPessoaFisica = null;
        }

        private void FrmPessoaFisica_Load(object sender, EventArgs e)
        {
            this.tb_pessoaBindingSource.DataSource = DataContextFactory.DataContext.tb_pessoa_fisica.Select( x => x.tb_pessoa );
        }

        public tb_pessoa PessoaCorrente
        {
            get
            {
                return (tb_pessoa)this.tb_pessoaBindingSource.Current;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            this.tb_pessoaBindingSource.AddNew();
            this.PessoaCorrente.tb_pessoa_fisica = new tb_pessoa_fisica() {
                rg = DateTime.Now.Second.ToString()
            };

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.tb_pessoaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            tb_pessoaDataGridView.Refresh();
            MessageBox.Show("Pessoa Fisica Cadastrada Com Sucesso!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tb_pessoaBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                            
                    this.tb_pessoaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Pessoa excluida com sucesso!");               
            }
        }

        private void tb_pessoaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 4)
            {//pegando a propriedade cpf do objecto na celula 5 do DataGridView
                e.Value = ((tb_pessoa_fisica)e.Value).cpf;
            }
        }
    }
}
//quando cadastrar o rg consultar o rg anterior adicionar um para não ter chaves duplicadas