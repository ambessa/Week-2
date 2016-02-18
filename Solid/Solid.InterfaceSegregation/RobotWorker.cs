using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregation
{
    public class RobotWorker: Worker
    {
        public void Work()
        {
            Console.WriteLine("I work 24/7");
        }

        //Interface Pollution
        //This method will never be called, it will sit empty
        public void Eat()
        {
            Console.WriteLine();
        }
    }
}
