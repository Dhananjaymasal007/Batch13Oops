using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Batch13Oops
{
    internal class NonGenStack
    {
        static void Main()
        {

            //create a non- generic stack
           // LIFO- last in first out
            Stack st = new Stack();

            st.Push("TOP");
            st.Push(42);
            st.Push(false);
            st.Push(985554);
            st.Push(42);
            st.Push("Test");
            //remove items (pop)

            Console.WriteLine(st);

            Console.WriteLine("pop elements");
            object topelement = st.Pop();
            object secondelement = st.Pop();
            object thrirdelement = st.Pop();


            Console.WriteLine(topelement);
            Console.WriteLine(secondelement);
            Console.WriteLine(thrirdelement);
            Console.WriteLine("is stack empty:"+ (st.Count == 0));

        }
    }
}
