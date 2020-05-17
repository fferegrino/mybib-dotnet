namespace MyBib.WebApi.Services
{
    public interface IPaymentService
    {
        string GetMessage();
    }

    public class PaymentService : IPaymentService
    {
        public string GetMessage() => "Pay me!";
    }

    public class ExternalPaymentService : IPaymentService
    {
        public string GetMessage() => "Pay me! I am an external service!";
    }
}