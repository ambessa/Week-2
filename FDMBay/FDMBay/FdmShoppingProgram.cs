using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMBay
{
    class FdmShoppingProgram
    {
        static void Main(string[] args)
        {
            ITarget adapter = new ThirdPartySupplierAdapter();
            foreach (string product in adapter.GetProducts())
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();
        }
    }
}
