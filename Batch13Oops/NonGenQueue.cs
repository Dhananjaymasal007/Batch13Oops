using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Batch13Oops
{
    internal class NonGenQueue
    {

        static void Main()
        {
            Queue qu = new Queue();
            // FIFO - first in first out
            //enqueue - it is basically used to add the elements in to the queue
            
            qu.Enqueue("Ajay");
            qu.Enqueue(9890332288);
            qu.Enqueue(true);


            //deque - to remove elements
            object firstelement = qu.Dequeue();
            object SecondElement = qu.Dequeue();
            object ThirdElement = qu.Dequeue();


            //DIsplay the items 

            Console.WriteLine("Dequeued Elements");
            Console.WriteLine(firstelement);
            Console.WriteLine(SecondElement);
            Console.WriteLine(ThirdElement);





        }

    }
}
