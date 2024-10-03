using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class HashSetExample
    {

        static void Main()
        {

            //create a hashset'
            HashSet<int> numbers = new HashSet<int>();

            //add element to the hashset
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(5);  //DUPLICATE ITEMS

            Console.Write("Hashset ELements");
            foreach(int i in numbers) 
            {
                Console.WriteLine(i);
            }

            //find purticular element in the hashset
            bool containstwo = numbers.Contains(2);
            Console.WriteLine("hasset contains 2:"+ containstwo);
            //remove element form the hashset
            numbers.Remove(3);
            Console.Write("After removal");
            foreach(int i in numbers) 
            {
                Console.WriteLine(i);
            }


            HashSet<int> hashtest = new HashSet<int> { 1, 2, 3, 4, 5 };

            numbers.UnionWith(hashtest);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


        }
    }
}
