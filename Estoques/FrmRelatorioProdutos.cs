using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Estoques
{
    public partial class FrmRelatorioProdutos : MetroFramework.Forms.MetroForm
    {
        public FrmRelatorioProdutos()
        {
            InitializeComponent();
        }

        private void FrmRelatorioProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusForms.FormRelatorioProdutos = null;
        }
    }
}
