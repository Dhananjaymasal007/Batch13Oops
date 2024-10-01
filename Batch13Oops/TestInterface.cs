using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{

    internal interface ITestInterface
    {
        // Method Declaration 
       
        void MakePayment(decimal amount);
        void RefundPayment(decimal amount);

        //public ITestInterface()
        //{
        //    Console.WriteLine("Test");

        //}

    }

    internal interface ITestinterface1
    {
        void MakeUPIPayment(decimal amount);

    }

    public class CreditCardPayment : ITestInterface,ITestinterface1
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Creadit Card payment of {amount} has beeen made");
        }

        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Creadit Card Refund of {amount} has beeen made");
        }

        public void MakeUPIPayment(decimal amount)
        {
            Console.WriteLine($"UI payment  {amount} has beeen made");

        }
    }


    public class PaypalPayment : ITestInterface
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Paypal payment of {amount} has beeen made");
        }

        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Paypal payment Refund of {amount} has beeen made");
        }
    }
    public class TestInterface
    {
        static void Main()
        {
            // creditcardpayment class
            ITestInterface creditcard = new CreditCardPayment();
            creditcard.MakePayment(100.5m);
            creditcard.RefundPayment(50.5m);
            ITestinterface1  craditcard1 = new CreditCardPayment();
            craditcard1.MakeUPIPayment(60.35m);

             //paypal class
             ITestInterface paypal = new PaypalPayment();
            paypal.MakePayment(60.52m);
            paypal.RefundPayment(30.50m);


        }
    }
}
