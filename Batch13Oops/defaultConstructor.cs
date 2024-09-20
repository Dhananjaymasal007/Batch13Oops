using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{

    public class DefaultConstructorExample
    {

        public int value;
        //default constructor 
        public DefaultConstructorExample()
        {
            value= 12;
        }
        //create another metod that we need to call

        public void Test()
        {
            Console.WriteLine("Test"+value);
        }

    }

    internal class defaultConstructor
    {
        static void Main()
        {
            DefaultConstructorExample obj = new DefaultConstructorExample();
            Console.WriteLine(obj.value);
            obj.Test();

        }
    }
}
