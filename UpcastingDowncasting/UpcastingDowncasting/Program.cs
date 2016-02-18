using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Shape sh = new Shape(0, 0);
            //sh.Draw();

            //Shape ci = new Circle(1, 1);
            //ci.Draw();

            //Shape sq = new Square(2, 2);
            //sq.Draw();


            ////Using polymorphism array code
            Shape[] shapes = new Shape[3];
            shapes[0] = new Shape(0, 0);
            shapes[1] = new Circle(1, 1);
            shapes[2] = new Square(2, 2);


            //Two methods of Upcasting available
            Shape s = new Circle(1, 1);
            
            
            //illegal upcasting
            //Circle = new Shape(0, 0);



            //Downcasting
            //s.Move();
            //We cannot call the s.Move() until Shape downcasted to Circle;
           
            //Declare the var c and explicitly cast s to type
            Circle c;
            c = (Circle)s;

            //Calling c.Move() method as 
            c.Move();


            //Here we test the shape to be drawn before we downcast to avoid runtime errors
            foreach (Shape shape in shapes)
            {
                shape.Draw();

                //The type of shape needed to downcast if the Move using 'is'
                if (shape is Circle)
                    ((Circle)shape).Move();
            


                //Using 'as' operator 
                //Circle c1 = shape as Circle;
                //if (c1 != null)
                //{
                //    c1.Move();
                //}
                
            }

            Console.ReadLine();
        }
    }
}
