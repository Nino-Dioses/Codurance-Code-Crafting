namespace CCLibrary.PaymentGateway
{
    public interface IPayGateway
    {
        void ProcessPayment(string account, decimal amount);
    }
}