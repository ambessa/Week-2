using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosedDependancyInversion
{

    //This is a good trade contorller
    //It can be exctended upon without changing any of its code
    public class DependancyInversionController
    {
        public void Trade(Stock stocktoTrade)
        {
            int value = stocktoTrade.value;

            Console.WriteLine(value);
        }

    }
}
