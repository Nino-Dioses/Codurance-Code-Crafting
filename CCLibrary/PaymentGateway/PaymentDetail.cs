using System;

namespace CCLibrary.PaymentGateway
{
    public class PaymentDetail
    {
        private string name;
        private decimal amount;

        public PaymentDetail(string name , decimal amount)
        {
            this.name = name;
            this.amount = amount;
        }

        internal decimal GetAmount()
        {
            return amount;
        }
    }
}