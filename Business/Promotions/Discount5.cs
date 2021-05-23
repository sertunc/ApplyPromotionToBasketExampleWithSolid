using Contracts.Interfaces;

namespace Business.Promotions
{
    public class Discount5 : IPromotion
    {
        public string Name => "Her siparişte 5 TL indirim!!!";

        public decimal Discount => 5;

        public decimal ApplyPromotion(decimal basketTotalPrice)
        {
            return basketTotalPrice - Discount;
        }
    }
}