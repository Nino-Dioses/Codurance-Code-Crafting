using CCLibrary.PaymentGateway;
using FakeItEasy;
using System;
using System.Collections.Generic;
using Xunit;

namespace CCLibrary.Tests.PaymentGateway
{
    public class PaymentService_should
    {
        [Fact]
        public void Explode_when_no_user_found()
        {
            var mockGateway = A.Fake<IPayGateway>();
            var paymentSvc = new PaymentService(mockGateway);
            User user = null;
            var details = new List<PaymentDetail>() { new PaymentDetail("mesa", 100) };
            var payDetail = new PaymentDetails(details);

            Assert.Throws<ArgumentNullException>(() => paymentSvc.ProcessPay(user, payDetail));
        }

        [Fact]
        public void Process_one_pay_processed_with_one_detail()
        {
            var mockGateway = A.Fake<IPayGateway>();
            var paymentSvc = new PaymentService(mockGateway);
            User user = new User("Nicolas","IBAN0000");
            var details = new List<PaymentDetail>() { new PaymentDetail("mesa", 100)};
            var payDetail = new PaymentDetails(details);

            paymentSvc.ProcessPay(user, payDetail);

            A.CallTo(() => mockGateway.ProcessPayment("IBAN0000",100)).MustHaveHappened();

        }

        [Fact]
        public void Not_process_a_payment_with_two_details_with_error()
        {
            var mockGateway = A.Fake<IPayGateway>();
            var paymentSvc = new PaymentService(mockGateway);
            User user = new User("Nicolas", "IBAN0000");
            var details = new List<PaymentDetail>() {
                new PaymentDetail("mesa", 100),
                new PaymentDetail("silla", 200),
            };
            var payDetail = new PaymentDetails(details);

            paymentSvc.ProcessPay(user, payDetail);

            A.CallTo(() => mockGateway.ProcessPayment("IBAN0000", 100)).MustNotHaveHappened();

        }

        [Fact]
        public void Process_a_payment_with_two_details()
        {
            var mockGateway = A.Fake<IPayGateway>();
            var paymentSvc = new PaymentService(mockGateway);
            User user = new User("Nicolas", "IBAN0000");
            var details = new List<PaymentDetail>() {
                new PaymentDetail("mesa", 100),
                new PaymentDetail("silla", 200),
            };
            var payDetail = new PaymentDetails(details);

            paymentSvc.ProcessPay(user, payDetail);

            A.CallTo(() => mockGateway.ProcessPayment("IBAN0000", 300)).MustHaveHappened();

        }
    }


}
