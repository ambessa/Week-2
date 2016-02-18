using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosedDependancyInversion
{
    //Bad Trade Controller - Violates Open Close principle
    public class TradeController
    {
        public void TradeShare(Share shareToTrade)
        {
            int value = shareToTrade.value;
        }

        public void TradeBond(Bond bondToTrade)
        {
            int value = bondToTrade.value;
        }
        
        //Violated Open/closed responsibilty
        public void TradeFE(ForeignExchange feToTrade)
        {
            int value = feToTrade.value;
        }
    }
}
