using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting
{
    class Circle : Shape
    {

        public Circle()
        {
        }

        public Circle(int x, int y): base(x,y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a circle at postion x,y = ({0}, {1})", m_xpos, m_ypos);
        }
        
        public void Move()
        {
            Console.WriteLine("Moving a circle to postion x,y = ({0}, {1})", m_xpos, m_ypos);
        }
    }
}
