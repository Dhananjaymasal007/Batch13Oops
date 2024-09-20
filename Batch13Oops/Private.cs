using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{

    class PrivateClass
    {
        public int Privatefield;
        public  void setfield(int value)
        {
            Privatefield = value;
        }
        public void show()
        {

            Console.WriteLine("Private field value"+Privatefield);
        }

       
    }

     class Private
    {
       static void Main()
        {
            PrivateClass obj = new PrivateClass();
            obj.setfield(10);
            obj.show();


            //PublicClassExample obj = new PublicClassExample();
            //obj.PublicProperty = 1;
            //obj.Show();
            //obj.Display();



        }
    }
}
