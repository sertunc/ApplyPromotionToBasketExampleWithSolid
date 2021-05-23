using Business.Products;
using Business.Promotions;
using Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BasketController : ControllerBase
    {
        private readonly IBasketBusiness basketBusiness;

        public BasketController(IBasketBusiness basketBusiness)
        {
            this.basketBusiness = basketBusiness ?? throw new ArgumentNullException(nameof(basketBusiness));
        }

        [HttpPost("Checkout")]
        public IActionResult Post()
        {
            // product and promotion list come from viewmodel
            IProduct product1 = new Macaroni { Count = 1, Price = 24 };
            IProduct product2 = new Salad { Count = 1, Price = 6 };

            basketBusiness.AddProduct(product1);
            basketBusiness.AddProduct(product2);

            // priority can be added if it is important which discount will be applied first.
            basketBusiness.AddPromotion(new Discount50Percent());
            basketBusiness.AddPromotion(new Discount5());

            var result = basketBusiness.Checkout();

            return Ok(result);
        }
    }
}
