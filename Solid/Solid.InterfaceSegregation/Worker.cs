using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregation
{
    public interface Worker
    {
        void Work();
        //void Eat();
    }
    
    public interface Eater
    {
        void Eat();
    }
}
