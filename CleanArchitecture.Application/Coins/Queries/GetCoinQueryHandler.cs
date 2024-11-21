using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Coins;
using ErrorOr;
using MediatR;

namespace CleanArchitecture.Application.Coins.Queries;

public class GetCoinQueryHandler : IRequestHandler<GetCoinQuery, ErrorOr<Coin>>
{
    private readonly ICoinsRepository _coinsRepository;

    public GetCoinQueryHandler(ICoinsRepository CoinsRepository)
    {
        _coinsRepository = CoinsRepository;
    }

    public async Task<ErrorOr<Coin>> Handle(GetCoinQuery request, CancellationToken cancellationToken)
    {
        if (await _coinsRepository.GetByIdAsync(request.CoinId) is not Coin Coin)
        {
            return Error.NotFound(description: "Coin not found");
        }

        return Coin;
    }
}