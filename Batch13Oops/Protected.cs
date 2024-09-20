using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    class BaseClass
    {
       private int Privatefield;
        protected int Protectedfield;
       public int Publicfield = 10;

        public void SetFiled(int value)
        {

            Privatefield = value;
            Protectedfield = value;

            Console.WriteLine("protected Field"+ Protectedfield);
            Console.WriteLine("Private Field"+ Privatefield);
            Console.WriteLine("Public field"+Publicfield);
        }
    }
    class DerivedClass : BaseClass
    { 

        public int Display(int value)
        {
            Console.WriteLine("Display"+ Protectedfield);
            //   Console.WriteLine("Display "+ Privatefield);
           Console.WriteLine("Public field"+ Publicfield);
            return 1;
        } 

    }
    class DerivedClassnew :DerivedClass
    {
        public void Show()
        {

            Console.WriteLine("Show" +  Protectedfield);
        }
    }

    class Protected
    {

        static void Main()
        {

            DerivedClassnew obj = new DerivedClassnew();
            obj.Show();


        }

    }
}
