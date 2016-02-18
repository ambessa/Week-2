using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting2
{
    class Derived : Base 
    {
        public float derivedValue;
        public void DerivedMethod()
        {
            Console.WriteLine("DerivedMethod()");
        }
    }

}
