using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class ExceptionHandlings
    {
        static void Main()
        {
            int[] Numbers = { 1, 2, 3 };
            int index = 2;

            try
            {
                int value = Numbers[index];  //IndexOutof bound
                Console.WriteLine($"value at index {index} is : {value}");
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error : {ex.Message}: Index is out of range.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error occoured:{ex.Message}", ex);
            }
            finally
            {

                Console.WriteLine("This code always execute");
            }


            //Divide by Zero


            int num = 10;
            int deno = 0;
            double result = 0;

            try
            {
                result = num/deno;
                Console.WriteLine($"Result of division:{result}");
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine($"Error: {ex.Message}cannot be divide by zero");
            }


            try
            {
                //logical code we need implement

            }

            catch (Exception ex)
            {
                //after exception
            }
            finally
            {
                //instance/object deallocation/ memory deallaocation/ clean up

            }



            //custom exception

            try
            {
                Dattaprocessing(null);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}argument cannot be null");
            }
        }

        static void Dattaprocessing(string data)
        {

            if (data == null)
            {

                throw new ArgumentNullException(nameof(data), "data cannot be null");
            }

        }


















    }
}
