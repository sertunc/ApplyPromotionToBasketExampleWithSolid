using Contracts.Models;

namespace Contracts.Interfaces
{
    public interface IBasketBusiness
    {
        void AddProduct(IProduct product);

        void AddPromotion(IPromotion promotion);

        CheckoutDto Checkout();
    }
}
