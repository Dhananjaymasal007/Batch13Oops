using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
  
        //Dynamic polymorphism/ method overriding / late binding 
        //method name same  parameter also same but different class


        //base class

        class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a shape");
            }
        }
        
        //deriverd clas 1
        class circle : Shape
        {
            //override draw method
            public override void Draw() 
                        {
                Console.WriteLine("Driwing a circle");
            }
        }
       
        //derived class 2

        class Rectangle : Shape

        {
            //override draw method
            public override void Draw()
            {
                Console.WriteLine("Drawing Rectangle");
            }
        }

    internal class DynamicPolymorphism
    {
        static void Main()
        {
            //creating object of different classess
            
            Shape shape1 = new Shape();
            Shape shape2 = new circle();
            Shape shape3 = new Rectangle();

            //calling the draw method on each object

            shape1.Draw();
            shape2.Draw();
            shape3.Draw();
        }
    }
}
