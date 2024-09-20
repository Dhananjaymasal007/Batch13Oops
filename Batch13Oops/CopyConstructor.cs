using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{

    public class CopyConstructorExample
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string NameNew { get; set; }
        public int AgeNew { get; set; }



        // Parameterised Constructor
        public CopyConstructorExample(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //copy  constructor
        public CopyConstructorExample(CopyConstructorExample copyex)
        {
            NameNew = copyex.Name;
            AgeNew = copyex.Age;

        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name},Age:{Age}");
           
        }

        public void DisplayInfoNew()
        {
            
            Console.WriteLine($"NewName:{NameNew},NewAge:{AgeNew}");
        }

    }

    internal class CopyConstructor
    {
        static void Main()
        {

            // creating object with pass the value  for parameterized constructor
            CopyConstructorExample obj = new CopyConstructorExample("Ajay", 25);
            obj.DisplayInfo();

            //creating another object using copy constructor
            CopyConstructorExample obj2 = new CopyConstructorExample(obj);
            obj2.DisplayInfoNew();
        }
    }
}
