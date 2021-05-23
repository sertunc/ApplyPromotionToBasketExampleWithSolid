using Contracts.Interfaces;

namespace Business.Products
{
    public class Salad : IProduct
    {
        public string Name => "Mevsim Salata";

        public decimal Price { get; set; }

        public int Count { get; set; }
    }
}
