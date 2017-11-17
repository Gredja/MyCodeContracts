using System;
using System.Collections.Generic;
using MyCodeContracts.Model;

namespace MyCodeContracts
{
    class Program
    {
        static void Main(string[] args)
        {
            var paymentProcessor = new PaymentProcessor();
            paymentProcessor.Add(null);

            var payments = new List<Payment>
            {
                new Payment(),
                new Payment(),
                null
            };


            paymentProcessor.Add2(payments.ToArray());

            Console.ReadKey(true);

            Console.ReadKey();
        }
    }
}
