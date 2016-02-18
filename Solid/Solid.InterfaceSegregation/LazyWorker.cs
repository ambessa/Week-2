using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregation
{
    public class LazyWorker : Worker
    {
        public void Work()
        {
            Console.WriteLine("I work little!");
        }

        public void Eat()
        {
            Console.WriteLine("I eat all day");
        }
    }
}
