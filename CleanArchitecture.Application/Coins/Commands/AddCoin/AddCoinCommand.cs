using CleanArchitecture.Domain.Coins;
using ErrorOr;
using MediatR;

namespace CleanArchitecture.Application.Coins.Commands.AddCoin;

public record AddCoinCommand(Guid CoinId, string Name, string Symbol, decimal MarketCap, decimal CurrentPrice)
    : IRequest<ErrorOr<Coin>>;