using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Estoques
{
    public partial class FrmImprimirStoque : MetroFramework.Forms.MetroForm
    {
        List<ProdutosEstoque> _lista;
        String _total, _valorPago, _data, _hora, _atendente, _codigoVenda;

        private void FrmImprimirStoque_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void FrmImprimirStoque_Load(object sender, EventArgs e)
        {
            ProdutosEstoqueBindingSource.DataSource = _lista;

            ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[2];
            param[0] = new Microsoft.Reporting.WinForms.ReportParameter("pDataAtual", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            param[1] = new Microsoft.Reporting.WinForms.ReportParameter("pTotalGeral", _lista.Sum(x=> x.Total).ToString());

            this.reportViewer1.LocalReport.SetParameters(param);

            this.reportViewer1.RefreshReport();
        }

        public FrmImprimirStoque(List<ProdutosEstoque> produtosImpri)
        {

            InitializeComponent();
            _lista = produtosImpri;
        }
    }
}
