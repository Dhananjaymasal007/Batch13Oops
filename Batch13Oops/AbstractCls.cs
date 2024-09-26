using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{

    //Abstract Class
    public abstract class Animal
    {
        public int a,b;
        //abstract method (no implementation)
        public abstract void MakeSound();
        //non abstract method (that has implementation)

        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

        public Animal()
        {
            Console.WriteLine("test");
        }

    }

    //derived class dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog  barks");
        }
    }
    //derived class cat
    public class Cat : Animal
    {
        //implementation of the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("cat Meows");
        }
    }


    internal class AbstractCls
    {

        static void Main()
        {
            //creating object of derived class

   
            Dog dog = new Dog();
            Cat cat = new Cat();

            //call method
            dog.MakeSound();
            dog.Eat();

            cat.MakeSound();
            cat.Eat();  


        }
    }
}
