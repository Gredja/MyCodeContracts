using System;
using System.Collections.Generic;
using CC = System.Diagnostics.Contracts;
using MyCodeContracts.Model;

namespace MyCodeContracts
{
    public class PaymentProcessor
    {
        private readonly List<Payment> _payments = new List<Payment>();

        public void Add(Payment payment)
        {
            CC.Contract.Requires(payment != null);
            CC.Contract.Requires(!string.IsNullOrEmpty(payment.Name));
            CC.Contract.Requires(payment.Date <= DateTime.Now);
            CC.Contract.Requires(payment.Amount > 0);

            _payments.Add(payment);
        }

        public void Add2(Payment[] payments)
        {
            CC.Contract.Requires(payments != null && CC.Contract.ForAll(payments, payment => payment != null));

            foreach (var payment in payments)
            {
                _payments.Add(payment);
            }
        }
    }
}
