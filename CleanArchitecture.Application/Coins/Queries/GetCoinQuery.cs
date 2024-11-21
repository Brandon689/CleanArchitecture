using CleanArchitecture.Domain.Coins;
using ErrorOr;
using MediatR;

namespace CleanArchitecture.Application.Coins.Queries;

public record GetCoinQuery(Guid CoinId) : IRequest<ErrorOr<Coin>>;