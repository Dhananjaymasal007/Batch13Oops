using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{

    class Vehical //Base Class or parent class or super class
    {
        public string Brand { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Brand}is Driving");
        }
    }


    class car : Vehical // dervied class or chield class or sub class
    {
        public int NumberofDoors { get; set; }

        public void ShowCarInfo()
        {
            Console.WriteLine($"{Brand} car has {NumberofDoors} door");
        }
    }


    internal class SingleInheritance
    {
        static void Main()
        {
                car mycar = new car();
                mycar.Brand = "Hundai";
                mycar.NumberofDoors = 4;
                mycar.Drive();
                mycar.ShowCarInfo();

        }
    }
}
