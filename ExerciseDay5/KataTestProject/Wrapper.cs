using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataTestProject
{
    public class Wrapper
    {
        private int columnNumber;
        private string sentence;
        
        public Wrapper()
        {

        }

        public Wrapper(string sentence, int columnNumber)
        {
            this.columnNumber = columnNumber;
            this.sentence = sentence;
        }
   

    }
}
