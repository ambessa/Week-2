using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moq
{
    public class DatabaseReader
    {
        public virtual int ReadQuantity()
        {//in real life database will be accessed here but for now return int
           return 0;
        }
    }
}
