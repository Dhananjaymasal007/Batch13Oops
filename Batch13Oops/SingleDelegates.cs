using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{

    public delegate void AddDelegate(int a, int b);
    public delegate string  DisplayDelegate(string str);

    
    class Mydelegate
    {

        public void AddNumbers(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public static string Display(string str)
        {
            return "Hello"+ str;
        }
    }

    internal class SingleDelegates
    {

        static void Main()
        {

            Mydelegate md = new Mydelegate();
            AddDelegate ad = new AddDelegate(md.AddNumbers);
            ad(100, 200);


            DisplayDelegate dp = new DisplayDelegate(Mydelegate.Display);
            string str = dp("Hello");
            Console.WriteLine(str);
        }
    }
}
