using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitution
{
    public class XmlFileReader : FileReader
    {
        public override void Read()
        {
            Console.WriteLine("Reading from Xml file...");
        }
    }
}
