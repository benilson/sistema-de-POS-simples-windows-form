using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estoques
{
  public class ProdutosEstoque
    {
        public int id_produto { get; set; }
        public string ds_produto { get; set; }
        public decimal? valor { get; set; }
        public int? codigoBarras { get; set; }
        public int? qtd { get; set; }
        public decimal? Total { get; set; }
        public string categoria { get; set; }
        
    }
}
