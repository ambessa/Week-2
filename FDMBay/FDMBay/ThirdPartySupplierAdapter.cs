using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMBay
{   //Compositon method
    class ThirdPartySupplierAdapter : ThirdPartySupplierAdaptee, ITarget //ThirdPartySupplierAdaptee, for Inheritance method
    {
       public List<string> GetProducts()
       {
           //hirdPartySupplierAdaptee adaptee = new ThirdPartySupplierAdaptee();
           return aListOfProducts();
       }
    }   
}
