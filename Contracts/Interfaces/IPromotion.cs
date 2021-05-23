namespace Contracts.Interfaces
{
    public interface IPromotion
    {
        string Name { get; }

        decimal Discount { get; }

        decimal ApplyPromotion(decimal basketTotalPrice);
    }
}
