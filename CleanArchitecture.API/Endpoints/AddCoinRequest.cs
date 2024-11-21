namespace CleanArchitecture.API.Endpoints;

public record AddCoinRequest
{
    public required string Name { get; init; }
    public required string Symbol { get; init; }
    public required decimal MarketCap { get; init; }
    public required decimal CurrentPrice { get; init; }
    public required string CoinImageURL { get; init; }
    public required int MarketCapRank { get; init; }
    public required decimal FullyDilutedValuation { get; init; }
    public required decimal TotalVolume { get; init; }
    public required decimal CirculatingSupply { get; init; }
    public required decimal TotalSupply { get; init; }
    public required decimal Ath { get; init; }
    public required DateOnly AthDate { get; init; }
    public required decimal Atl { get; init; }
    public required DateOnly AtlDate { get; init; }
}