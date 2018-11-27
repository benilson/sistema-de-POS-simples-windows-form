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
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        public bool logado = false;

        public string Nome;
        public string NomeUsuario;
        public string Login;
        public string Perfil;
        public int Id_pessoaVendedor;
        public FrmLogin()
        {
            InitializeComponent();
        }

        public void EfectuarLogin()
        {
           
            var user = DataContextFactory.DataContext.tb_usuario.Count(
               x => x.usuario == TxtUsuario.Text && x.senha == TxtSenha.Text );
            
            var usuarios =  DataContextFactory.DataContext.tb_usuario;
           
            foreach (var usuarioLogado in usuarios)
            {
                if(usuarioLogado.usuario == TxtUsuario.Text && usuarioLogado.senha == TxtSenha.Text)
                {
                    Nome = usuarioLogado.tb_pessoa.nome;
                    NomeUsuario = usuarioLogado.usuario;
                    Perfil = usuarioLogado.Perfil;
                    Id_pessoaVendedor = usuarioLogado.tb_pessoa.id_pessoa;
                }
            }
            if ( user > 0) {
                this.logado = true;
                this.Dispose();
            } else {
                MessageBox.Show("Usuario ou Senha Inválidos!", "Erro");
            }
        }

        private void BtnEntrarSis_Click(object sender, EventArgs e)
        {
            EfectuarLogin();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TxtSenha.Focus();
            }
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)13)
            {
                EfectuarLogin();
            }
        }
    }
}
