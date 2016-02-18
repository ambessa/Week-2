using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            EfficientWorker worker1 = new EfficientWorker();
            LazyWorker worker2 = new LazyWorker();
            RobotWorker worker3 = new RobotWorker();
           
            worker1.Eat();
            worker1.Work();

            worker2.Eat();
            worker2.Work();

            worker3.Eat();
            worker3.Work();

            Console.ReadLine();
        }
    }
}
