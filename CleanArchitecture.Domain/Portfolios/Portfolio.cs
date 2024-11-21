namespace CleanArchitecture.Domain.Portfolios;

public sealed class Portfolio
{
    public Guid Id { get; }

    public Guid UserId { get; init; }
    public decimal TotalValue { get; init; }
    public DateOnly CreatedAt { get; init; }
    public DateOnly LastUpdated { get; init; }
}
