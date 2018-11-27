using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoques.DAL
{
    public class DataContextFactory
    {
        private static EstoqueDataContext dataContext;
        public static EstoqueDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new EstoqueDataContext();

                return dataContext;
            }
        }
    }
}
