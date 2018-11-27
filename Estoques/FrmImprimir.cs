using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Estoques
{
    public partial class FrmImprimir : MetroFramework.Forms.MetroForm
    {
        List<ProdutosImprimir> _lista;
        String _total, _valorPago, _data, _hora, _atendente, _codigoVenda, _cliente;

        private void FrmImprimir_Load_1(object sender, EventArgs e)
        {

            ProdutosImprimirBindingSource.DataSource = _lista;

            ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[7];
            param[0] = new Microsoft.Reporting.WinForms.ReportParameter("pTotal", string.Format("{0:#,###.##}", _total));
            param[1] = new Microsoft.Reporting.WinForms.ReportParameter("pValorPago", _valorPago);
            param[2] = new Microsoft.Reporting.WinForms.ReportParameter("pData", _data);
            param[3] = new Microsoft.Reporting.WinForms.ReportParameter("pHora", _hora);
            param[4] = new Microsoft.Reporting.WinForms.ReportParameter("pAtendente", _atendente);
            param[5] = new Microsoft.Reporting.WinForms.ReportParameter("pCodigoVenda", _codigoVenda);
            param[6] = new Microsoft.Reporting.WinForms.ReportParameter("pCliente", _cliente);
            this.reportViewer1.LocalReport.SetParameters(param);


            this.reportViewer1.RefreshReport();
        }

        public FrmImprimir(List<ProdutosImprimir> dataSource, string total, string valorPago, string data, string hora, string atendente, string codigoVenda, string cliente)
        {
            InitializeComponent();
            _lista = dataSource;
            _total = total;
            _valorPago = valorPago;
            _data = data;
            _hora = hora;
            _atendente = atendente;
            _codigoVenda = codigoVenda;
            _cliente = cliente;
        }

        private void FrmImprimir_Load(object sender, EventArgs e)
        {

        }
    }
}
