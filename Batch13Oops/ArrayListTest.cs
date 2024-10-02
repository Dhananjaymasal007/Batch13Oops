using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class ArrayListTest
    {
        static void Main()
        {
            // creating object of an array list

            ArrayList lst = new ArrayList();

            ///adding elements in to array list

            lst.Add(1);
            lst.Add("Hello");
            lst.Add(false);

            //access the elements/items

            Console.WriteLine("Arraylist Elements:");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            // lst.(1);
            //lst.();
           // lst.Remove(false);
            Console.WriteLine("Reversed Arraylist Elements:");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }


        }


    }
}
