using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitution
{
    public class FileReader
    {
        public virtual void Read()
        {
            Console.WriteLine("Reading a normal file...");
        }
    }
}
