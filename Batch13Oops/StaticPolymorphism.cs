using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    class MathOperations
    {
        //Method overloading or static polymorphism or compile time polymorphism or Early binding
        //method name same class also same but different parameteres
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

    }

    internal class StaticPolymorphism
    {
        static void Main()
        {
            MathOperations math = new MathOperations();


            /// calling the overlaod methods

            int sum = math.Add(2, 4);
            double sum1 = math.Add(3.5, 6);

            Console.WriteLine("Sum of intergeres:"+ sum);
            Console.WriteLine("Sum of doubles:"+ sum1);

        }
    }
}
