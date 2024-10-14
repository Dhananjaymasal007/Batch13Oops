using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class GenericDelegates
    {

        //Func Delegate


        public static double AddNumber1(int a, float b, double c)
        {

            return a + b + c;
            //  Console.WriteLine(a + b + c);
        }


        //Action Delegate

        public static void AddNumbers2(int x, float y, double z)
        {
            Console.WriteLine(x+y+x);
        }

        //Predicate delegate


        public static bool checklength(string str)
        {
            if (str.Length>5)
                return true;

            return false;
        }

        static void Main()
        {

            //funt Deletegate
            Func<int, float, double, double> obj1 = AddNumber1;
            double result = obj1.Invoke(100, 125, 102.35);
            Console.WriteLine(result);

            //Action delegate

            Action<int, float, double> obj2 = AddNumbers2;
            obj2.Invoke(200, 125, 225.21);


            //Predicate Delegate


            Predicate<string> obj3 = checklength;
            bool status = obj3.Invoke("helloworld");
            Console.WriteLine(status);


        }


    }
}
