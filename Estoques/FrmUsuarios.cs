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
    public partial class FrmUsuarios : MetroFramework.Forms.MetroForm
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        public tb_usuario UsuarioCorrente
        {
            get
            {
                return (tb_usuario)this.tb_usuarioBindingSource.Current;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtUsuario.Text) ) {
                MessageBox.Show("O campo Usuario e obrigatorio");
                return;
            } else {
                if (txtSenha.Text != txtRepetir.Text) {
                    MessageBox.Show("As Senhas não são iguais por favor verifique");
                    return;
                } else {
                    if(nomeComboBox.SelectedValue != null) {
                        this.UsuarioCorrente.id_pessoa = (int)nomeComboBox.SelectedValue;

                    } else {
                        this.UsuarioCorrente.id_pessoa = this.UsuarioCorrente.id_pessoa;
                    }



                    tb_usuarioBindingSource.EndEdit();
                    DataContextFactory.DataContext.SubmitChanges();
                    dgvUsuarios.Refresh();
                    MessageBox.Show("Usuario Gravado com sucesso!");
                }
            }
            

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            List<tb_pessoa> listaDePessoas = DataContextFactory.DataContext.tb_pessoa.ToList();
            List<tb_usuario> usuarios = DataContextFactory.DataContext.tb_usuario.ToList();
            List<tb_pessoa> listaDePessoasSemUsuarios = new List<tb_pessoa>();
            bool temUsuario;

           //pesquisa se pessoas ja tem usuarios
            foreach ( var p in listaDePessoas) {
                temUsuario = true;
                foreach ( var u in usuarios ) {
                    if ( u.id_pessoa == p.id_pessoa ) {
                        temUsuario = false;
                    }
                }

                if (temUsuario) {
                    listaDePessoasSemUsuarios.Add(p);
                }

            }

            tb_pessoaBindingSource.DataSource = listaDePessoasSemUsuarios;
            tb_usuarioBindingSource.DataSource = DataContextFactory.DataContext.tb_usuario;
           // tb_usuarioBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            tb_usuarioBindingSource.AddNew();
        }

        private void tb_usuarioDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 2)
            {//pegando a propriedade categoria do objecto na celula 1 do DataGridView
                e.Value = ((tb_pessoa)e.Value).nome;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tb_usuarioBindingSource.CancelEdit();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                    this.tb_usuarioBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Usuario excluido com sucesso!");

            }
        }

        private void FrmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusForms.FrmUsuario = null;
        }
    }
}
