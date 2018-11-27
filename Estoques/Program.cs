using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoques
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin FormLogin = new FrmLogin();
            FormLogin.ShowDialog();

            if ( FormLogin.logado == true)
            {
                FrmPrincipal.Nome = FormLogin.Nome;
                FrmPrincipal.NomeUsuario = FormLogin.NomeUsuario;
                FrmPrincipal.perfil = FormLogin.Perfil;
                FrmPrincipal.Id_pessoaVendedor = FormLogin.Id_pessoaVendedor;
                Application.Run(new FrmPrincipal());
            }
          
        }
    }
}
