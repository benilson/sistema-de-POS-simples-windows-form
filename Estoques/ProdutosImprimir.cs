using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoques
{
    public class ProdutosImprimir
    {
        public int ID { get; set; }
        public string Produto { get; set; }
        public int Qtd { get; set; }
        public decimal? preco { get; set; }
        public decimal Total { get; set; }
    }
}
