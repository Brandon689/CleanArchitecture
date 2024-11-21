namespace CleanArchitecture.Domain.Positions;

public sealed class Position
{
    public Guid Guid { get; }

    public Guid PortfolioId { get; private set; }
    public Guid CoinId { get; private set; }
    public decimal Quantity { get; private set; }
    public decimal AverageEntryPrice { get; private set; }
}
