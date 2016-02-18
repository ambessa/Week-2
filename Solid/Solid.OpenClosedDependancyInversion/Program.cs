using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosedDependancyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Share shareToTrade = new Share();
            shareToTrade.value = 10;

            Bond bondToTrade = new Bond();
            bondToTrade.value = 20;

            DependancyInversionController dpc = new DependancyInversionController();
            dpc.Trade(shareToTrade);
            dpc.Trade(bondToTrade);

            Console.ReadLine();
        }
    }
}
