using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{

    class MyVehical
    {

        public void start()
        {
            Console.WriteLine("The vehical is started");
        }
    }

    class Offriding : MyVehical
    {

        public void Drive()
        {
            Console.WriteLine("The car is driving");
        }

    }

    class SportCar : Offriding
    { 

        public void TurboBoost()
        {
            Console.WriteLine("the sport car is in the turbo mode");
        }
    }


    internal class MultiLevelnheritance
    {

        static void Main()
        {
            SportCar MySportCar = new SportCar();
            MySportCar.start();
            MySportCar.Drive();
            MySportCar.TurboBoost();



        }
    }
}
