using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    enum HTTPStatusCode
    {
        OK = 200,
        BadRequest =400,
        Unauthorized =401,
        forbideen = 500,
        NotFound = 400
    }


    internal class EnumExample
    {
        static void Main()
        {
            DerivedClass bs = new DerivedClass();
            bs.SetFiled(10);
            Console.WriteLine();


            BaseClass obj = new BaseClass();

            Console.WriteLine("public field"+ obj.Publicfield);
          //  Console.WriteLine("public field"+ obj.Protectedfield);


            obj.SetFiled(10);


            //Days today = Days.Sunday;

            ////week days

            //switch (today)
            //{
            //    case Days.Sunday:
            //        Console.WriteLine("Today is Sunday");
            //        break;
            //    case Days.Monday:
            //        Console.WriteLine("Today is Monday");
            //        break;
            //    case Days.Tuesday:
            //        Console.WriteLine("Today is Tuesday");
            //        break;
            //    case Days.Wednesday:
            //        Console.WriteLine("Today is Wednesday");
            //        break;
            //    case Days.Thursday:
            //        Console.WriteLine("Today is Tuesday");
            //        break;
            //    case Days.Friday:
            //        Console.WriteLine("Today is Friday");
            //        break;
            //    case Days.Saturday:
            //        Console.WriteLine("Today is Saturday");
            //        break;
            //}

            //// To  check week end 
            ////Console.BackgroundColor = ConsoleColor.Cyan;
            //if (today == Days.Saturday || today == Days.Friday)
            //{
            //    Console.WriteLine("it'S weekend");
            //}
            //else
            //{
            //    Console.WriteLine("it's weekdays");
            //}

            //// Console.BackgroundColor = ConsoleColor.Magenta;

            //HTTPStatusCode code = HTTPStatusCode.BadRequest;
            //Console.WriteLine("HTTP status code:" + code);

            //int codenumber = (int)code;
            //Console.WriteLine("HTTP staus code Number:"+ codenumber);

        }

    }
}
