using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toyshop
{
    public class StockChecker
    {
        //Make a space in the StockChecker that hold DbReader
        DataBaseReader dbReader;

        //When the stockchecker is isnstantiated give it a database reader
        public StockChecker(DataBaseReader DbReader)
        {   //fill database reader space with databasereader given
            dbReader = DbReader;
        }
        public int CheckNumberInStock(int numberInStock)
        {
            return dbReader.ReadQuantity(0);
        }
    }
}
