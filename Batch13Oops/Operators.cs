using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class Operators
    {
        public static void Main()
        {


            PrivateClass obj  = new PrivateClass();
            obj.setfield(10);
            //Arithmetic Operator
            int a = 10;
            int b = 10;

            Console.WriteLine("Arithmetic Operator");
            Console.WriteLine($"Addition  {a + b}"); //addition  a+b=13
            Console.WriteLine($"{a - b}"); //sub
            Console.WriteLine($"Multiplication {a * b}");
            Console.WriteLine($"Division{a / b} ");
            Console.WriteLine($"Mod {a % b}");


            //Relational Operator
            Console.WriteLine("Relational Operator");
            Console.WriteLine($"a == b:{a == b}");
            Console.WriteLine($"a  !=b:{a != b}");
            Console.WriteLine($"a > b : {a > b}");
            Console.WriteLine($"a < b : {a < b}");
            Console.WriteLine($"a >= b : {a >= b}");
            Console.WriteLine($"a <= b : {a <= b}");

            //Logical Operator 
            bool x = true;
            bool y = false;

            Console.WriteLine("Logical Operators");
            Console.WriteLine($"x && y:{x && y }");
            Console.WriteLine($"x || y: {x || y}");
            Console.WriteLine($"!x: {!x}");

        }
    }
}
