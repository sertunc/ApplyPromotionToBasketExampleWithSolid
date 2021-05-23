using Contracts.Interfaces;

namespace Business.Promotions
{
    public class Discount50Percent : IPromotion
    {
        public string Name => "Bir gün değil, her gün indirim!!!";

        public decimal Discount => 50;

        private const decimal basketTotalPriceLimit = 30;

        public decimal ApplyPromotion(decimal basketTotalPrice)
        {
            // Rules for the promotion to apply
            // 1- The user must have a credit card registered in the system TODO: implement user payment service
            // 2- The total price of the basket must be 30 TL or less

            if (basketTotalPrice <= basketTotalPriceLimit)
            {
                return basketTotalPrice * Discount / 100;
            }

            return basketTotalPrice;
        }
    }
}
