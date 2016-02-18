using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moq
{
    public class StockChecker
    {
        private DatabaseReader _reader;

        public StockChecker(DatabaseReader reader)
        {
            _reader = reader;
        }

        public void NumberOfDvdsInStock()
        {
            _reader.ReadQuantity();
        }
    }
}
