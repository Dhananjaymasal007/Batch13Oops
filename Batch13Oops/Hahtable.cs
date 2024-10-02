using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class Hahtable
    {
       static void Main()
       
        {
            Hashtable ht = new Hashtable();

            //add key-value paring to the hashtable

            ht.Add(101, "JAVA");
            ht.Add(102, "DOTNET");
            ht.Add(103, 9890);
            ht.Add(104, true);


           
            //accesssing the elements although typecasting

            string value1 = (string)ht[101];
            string value2 = (string)ht[102];
            string value3 = Convert.ToString((int)ht[103]);
            bool value4= (bool)ht[104];

            //display value
            Console.WriteLine($"101:{value1}");

            Console.WriteLine($"102:{value2}");

            Console.WriteLine($"103:{value3}");

            Console.WriteLine($"104:{value4}");

            ht[103] = "AWS";


        }
    }
}
