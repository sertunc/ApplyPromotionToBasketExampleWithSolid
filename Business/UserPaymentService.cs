using Contracts.Interfaces;

namespace Business
{
    public class UserPaymentService : IUserPaymentService
    {
        public bool HasUserRegisteredCreditCard()
        {
            // check db does the user have a registered credit card
            return true;
        }
    }
}
