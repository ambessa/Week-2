using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting
{
    class Square : Shape
    {

        public Square()
        {
        }

        public Square(int x, int y): base(x,y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a square at postion x,y = ({0}, {1})", m_xpos, m_ypos);
        }
        
        public void Move()
        {
            Console.WriteLine("Moving a square to postion x,y = ({0}, {1})", m_xpos, m_ypos);
        }
    }
}
