namespace Contracts.Interfaces
{
    public interface IProduct
    {
        string Name { get; }

        decimal Price { get; set; } // Added "setter" for demo. Normally, price can be given in this prop. 

        int Count { get; set; }
    }
}
