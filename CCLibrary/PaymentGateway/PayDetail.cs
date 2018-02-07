using System;
using System.Collections.Generic;

namespace CCLibrary.PaymentGateway
{
    public class PaymentDetails
    {
        private List<PaymentDetail> details;

        public PaymentDetails(List<PaymentDetail> details)
        {
            this.details = details;
        }

        internal decimal GetTotalAmount()
        {
            decimal amount = 0;

            foreach (PaymentDetail item in details)
            {
                amount += item.GetAmount();
            }

            return amount;
        }
    }
}