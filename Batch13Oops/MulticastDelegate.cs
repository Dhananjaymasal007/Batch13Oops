using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{

    public delegate void Notify();

    class MDelegate
    {

        public void StartProcess()
        {
            Console.WriteLine("Process Started......!");
        }

        public void StopProcess()
        {
            Console.WriteLine("Process Ended.....!");

        }
    }
    internal class MulticastDelegate
    {
        static void Main()
        {
            MDelegate MD = new MDelegate();




            //MD.StartProcess();
            //MD.StopProcess();
            //create the delegate instance and assign the startprocess funciton/method
            Notify notifydelegates = MD.StartProcess;

            notifydelegates +=MD.StopProcess;


            notifydelegates +=() => Console.WriteLine("All processes are stopped");

            notifydelegates();



        }

    }
}
