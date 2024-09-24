using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class DemoAddtion
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public static void Main(string[] args)
        {
            DemoAddtion demoAddtion = new DemoAddtion();
            int c = demoAddtion.add(1, 2);
            Console.WriteLine("Addition : " + c);
        }
    }
}
