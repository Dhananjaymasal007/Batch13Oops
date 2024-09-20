using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{

    public class PublicClassExample
    {
        private int PublicProperty { get; set; }

        private void Show()
        {
            Console.WriteLine("Public Ptoperty Value:"+PublicProperty);
        }


        public void Display()
        {
            Console.WriteLine("Hello");

        }

    }
    public class Public
    {
        static void Main()
        {

            PublicClassExample obj = new PublicClassExample();
          //  obj.PublicProperty = 1;
            //obj.Show();
        }
    }
}
