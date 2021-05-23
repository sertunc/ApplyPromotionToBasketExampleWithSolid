using Contracts.Interfaces;
using Contracts.Models;
using System.Collections.Generic;

namespace Business
{
    public class BasketBusiness : IBasketBusiness
    {
        private List<IProduct> Products { get; set; }

        private List<IPromotion> Promotions { get; set; }

        public BasketBusiness()
        {
            Products = new List<IProduct>();
            Promotions = new List<IPromotion>();
        }

        public void AddProduct(IProduct product)
        {
            Products.Add(product);
        }

        public void AddPromotion(IPromotion promotion)
        {
            Promotions.Add(promotion);
        }

        public CheckoutDto Checkout()
        {
            decimal totalPrice = 0;
            decimal promotionalPrice = 0;

            foreach (var product in Products)
            {
                totalPrice += product.Count * product.Price;
            }

            for (int i = 0; i < Promotions.Count; i++)
            {
                promotionalPrice = i == 0 ? Promotions[i].ApplyPromotion(totalPrice) : Promotions[i].ApplyPromotion(promotionalPrice);
            }

            return new CheckoutDto
            {
                TotalPrice = totalPrice,
                PromotionalPrice = promotionalPrice,
            };
        }
    }
}
