using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{


    class MyShape // Base class
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    class Circle : MyShape  //derived class
    {
        public void DrawCricle()
        {

            Console.WriteLine("drawaing a circle");
        }

    }

    class MyRectangle : MyShape
    {

        public void DrawRectangle()
        {

            Console.WriteLine("drawing a rectange");
        }
    }


    class Trangle : MyShape
    {

        public void DrawRectangle()
        {
            {
                Console.WriteLine("Drawing a trangle");
            }
        }
    }

        internal class HirarchicalInheritane
        {
            static void Main()
            {

                Circle Mycircle = new Circle();
                Mycircle.Draw();  //inhite from base
                Mycircle.DrawCricle(); //inherite from derived


                MyRectangle Myrect = new MyRectangle();
                Myrect.Draw();
                Myrect.DrawRectangle();
                

                Trangle mytrangel = new Trangle();
                mytrangel.Draw();
                mytrangel.DrawRectangle();

            }
        }
    
}