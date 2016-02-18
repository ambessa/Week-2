using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting2
{
    class Program
    {
        static void Main()
        {
            Base b = new Base ();
            Derived d = new Derived ();
            b = d;
            //d = (Derived)b;

            double db = 100.25;
            int num = (int)db; //explicit, data loss which alerts
            db = num; //implicit, no data loss

            Console.ReadLine();
        }
    }
}
