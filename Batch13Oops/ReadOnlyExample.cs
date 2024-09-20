using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{


    class ReadOnlyEx
    {
        //property fields
        public readonly int intitialvalue;
        public static readonly double pi;
        public string test = "test";
        public ReadOnlyEx(int initialvalue)
        {
            intitialvalue = initialvalue;
            intitialvalue =20;

        }
        static ReadOnlyEx()
        {
            pi = 3.1585;
        }


        public void PrintValues()
        {

            Console.WriteLine($"Initial Values:{intitialvalue}");
            Console.WriteLine($"Value of Pi:{pi}");

        }

    }
        internal class ReadOnlyExample
        {

            static void Main()
            {
                ReadOnlyEx read = new ReadOnlyEx(10);
                read.PrintValues();

            }
        }

    
}