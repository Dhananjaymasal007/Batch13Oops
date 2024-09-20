using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class Array
    {

        public static void Main()
        {
            // Declare the Array

            //string[] Mobile = new string[4];


            ////Assigning Values 
            //Mobile[0] = "Apple";
            //Mobile[1] = "Samsung";
            //Mobile[2] = "Nokia";
            //Mobile[3] = "OnePlus";

            ////Access arrays value
            //Console.WriteLine("Mobiles in Array  index:");

            //for (int i = 0; i< Mobile.Length; i++)
            //{
            //    Console.WriteLine(Mobile[i]);
            //}

            //// reverse number

            //int[] Numbers = { 1, 2, 3, 4, 5 };

            ////print original array


            //Print(Numbers);

            //// Reverse Number

            //Reverse(Numbers);

            //Console.WriteLine("Print Reverse array");

            //Print(Numbers);


            //initialize  Multidimentional array
            int[,] matrix = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            //accessing the elements  from arrya

            Console.WriteLine("Element at (0,0):"+ matrix[0, 0]);  //1
            Console.WriteLine("Element at (1,2) : " + matrix[1, 2]);


            // print all the elements in array

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j]+ " ");
                }

                Console.WriteLine();

            }


            //jagged array
            //declaration of the jagged array

            int[][] jaggeedArray = new int[][]
            {
                new int [] {1,2},
                new int [] {3,4,5},
                new int [] {6,7,8,9 }

            };

            // Accesssing eleents in jagged array
            Console.WriteLine("Element at [0][1]:" + jaggeedArray[0][1]);
            Console.WriteLine("Element at [2)[3]: " + jaggeedArray[2][3]);


            //looging through a  jagged array

            for (int i = 0; i < jaggeedArray.Length; i++)
            {

                for (int j = 0; j <jaggeedArray[i].Length; j++)
                {

                    Console.Write(jaggeedArray[i][j]+" ");
                }

                Console.WriteLine();
            }

            //string 

            string str = "Hello World";
            Console.WriteLine(str);
            str = "test";
            Console.WriteLine(str);

            string Firstname = "Sachin ";
            string lastName = "Patil";

            string name = Firstname + lastName;
            Console.WriteLine(name);

            // string builder

            // creasting object for stirng builder
            StringBuilder sb = new StringBuilder();

            sb.Append("Hello  fdsfasf dsfsadf sadfas");
            sb.Append(",");
            sb.Append("World there fdsafdfa");
            sb.Append("fsdaf");

            sb.Remove(2, 5);


            //  Console.WriteLine(result);


            //to add the value in specific index
            sb.Insert(5, "there");


            //replace a string 

            sb.Replace("World", "C# Developer");

            string result = sb.ToString();
            Console.WriteLine(result.ToString());

            sb.Clear();

            // boxing 

            int num = 30; //value type (int)
            object obj = num; // boxing it will convert value to  object(reference)

            /// un boxing

            object objnew = 35; //boxed intger value
            int num1 = (int) objnew;



        }

        public static void Print(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.WriteLine(num+ " ");
            }

        }

        public static void Reverse(int[] arr)
        {
            int start = 0;
            int end = arr.Length  - 1;

            while (start < end)
            {
                //element swaping
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }


        }
    }
}
