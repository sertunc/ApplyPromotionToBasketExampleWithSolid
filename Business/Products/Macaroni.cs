using Contracts.Interfaces;

namespace Business.Products
{
    public class Macaroni : IProduct
    {
        public string Name => "Spagetti Makarna";

        public decimal Price { get; set; }

        public int Count { get; set; }
    }
}
