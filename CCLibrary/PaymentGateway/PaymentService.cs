using System;

namespace CCLibrary.PaymentGateway
{
    public class PaymentService
    {
        private IPayGateway gateway;

        public PaymentService(IPayGateway gateway)
        {
            this.gateway = gateway;
        }

        public void ProcessPay(User user, PaymentDetails payDetail)
        {

            if (user == null)
                throw new ArgumentNullException();

            gateway.ProcessPayment(user.GetAccount(), payDetail.GetTotalAmount());



        }
    }
}
