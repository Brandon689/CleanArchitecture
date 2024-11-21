using CleanArchitecture.Domain.Coins;
using ErrorOr;
using MediatR;

namespace CleanArchitecture.Application.Coins.Commands.AddCoin;

public record AddCoinCommand : IRequest<ErrorOr<Coin>>
{
    public string Name { get; init; }
    public string Symbol { get; init; }
    public decimal MarketCap { get; init; }
    public decimal CurrentPrice { get; init; }
    public string CoinImageURL { get; init; }
    public int MarketCapRank { get; init; }
    public decimal FullyDilutedValuation { get; init; }
    public decimal TotalVolume { get; init; }
    public decimal CirculatingSupply { get; init; }
    public decimal TotalSupply { get; init; }
    public decimal Ath { get; init; }
    public DateOnly AthDate { get; init; }
    public decimal Atl { get; init; }
    public DateOnly AtlDate { get; init; }
}