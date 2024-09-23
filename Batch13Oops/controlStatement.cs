using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class controlStatement
    {
        static void Main()
        {
            //if statement
            int number = -5;
            if (number == 0)
            {
                Console.WriteLine("The Number is Positive");
            }

            // if else statement 

            if (number > 0)
            {
                Console.WriteLine("The Number is Positive");
            }
            else
            {
                Console.WriteLine("The Number is Negative");
            }

            // if else if statement

            if (number > 0)
            {
                Console.WriteLine("The Number is Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("The Number is Negative");
            }
            else
            {
                Console.WriteLine("The Number is Zero");
            }

            //switch statement
            int Day = 3;

            switch (Day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("other day");
                    break;
            }

            //Looping statement


            for (int n = 0; n < 5; n++)
            {

                Console.WriteLine("Iteration:"+ n);
            }


            //while loop - Entry control loop

            int i = 0;
            while (i > 5)
            {
                Console.WriteLine("Iteration on while loop:"+i);
                i++;

            }


            // do while -- Exit control loop

            int j = 0;
            do
            {
                Console.WriteLine("iteration on do while loop" + j);
                j++;
            } while (j > 5);



            //for each 
            string[] fruits = { "Apple", "Banana", "Mango", "Kivi", "Grapes", "Jackfruit", "Strawberry", "Watermelon", "Pinapple" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine("The Fruit Name is " + fruit);
            }


            //continue statement

            for (i=0; i< 5; i++)
            {
                if (i==3)
                {
                    continue;
                }
                Console.WriteLine("Iterations :" + i);

            }


            //Go To Statement

            int count = 0;
        test:

            if (count < 5)
            {
                Console.WriteLine($"Count is {count}");
                count++;
               goto test;
            }

            Console.WriteLine("Loop with goto is  fininshed");

            //break statement 
            int num = 2;
            switch (num)
            {
                case 1:
                    Console.WriteLine("ONE");
                    break;
                case 2:
                    Console.WriteLine("TWO");
                    goto case 3;
                case 3:
                    Console.WriteLine("THREE");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
               
                default:
                    Console.WriteLine("OTHER");
                    break;

            }

        }
    }
}
