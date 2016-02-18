using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMBay
{
    public class ThirdPartySupplierAdaptee
    {
        public List<string> aListOfProducts()
        {
            List<string> product = new List<string>();
           
            product.Add("Gaming Console");
            product.Add("Television");
            product.Add("Books");
            product.Add("Musical Instruments");

            return product;
        }
    }

}
