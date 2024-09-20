using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Batch13Oops
{

    class BasicOperations
    {
        static void Main()
        {
            // Test Message to display 
            //  Console.WriteLine("Test Message");

            //Int - Dataype 
            //variable declaration

            int num1 = 60;
            int num2 = 20;
            int sum = num1 + num2;
            Console.WriteLine(" Int - The Additon of Two  No is  "+sum);

            //string datatpe
            string myString = "Welcome";
            Console.WriteLine("String - "+ myString);

            //boolean
            bool status = true;
            Console.WriteLine("Boolean:"+ status);


            //Double 
            double mydouble = 12.55;
            Console.WriteLine("Double:"+ mydouble);

            char myChar = 'A';
            Console.WriteLine("Character" + myChar);

            long myLong = 12345678L;
            Console.WriteLine("long:" + myLong);
        }
    }

}