using CleanArchitecture.Application.Coins.Commands.AddCoin;
using MediatR;

namespace CleanArchitecture.API.Endpoints.Coins;

public static class AddCoinEndpoint
{
    public static void MapCoinEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/coins/addCoin", AddCoin)
            .WithName(nameof(AddCoin));
    }

    private static async Task<IResult> AddCoin(
        AddCoinCommand command,
        ISender mediator,
        IHttpContextAccessor httpContextAccessor)
    {
        //var command = new AddCoinCommand
        //{
        //    Name = request.Name,
        //    Symbol = request.Symbol,
        //    MarketCap = request.MarketCap,
        //    CurrentPrice = request.CurrentPrice,
        //    CoinImageURL = request.CoinImageURL,
        //    MarketCapRank = request.MarketCapRank,
        //    FullyDilutedValuation = request.FullyDilutedValuation,
        //    TotalVolume = request.TotalVolume,
        //    CirculatingSupply = request.CirculatingSupply,
        //    TotalSupply = request.TotalSupply,
        //    Ath = request.Ath,
        //    AthDate = request.AthDate,
        //    Atl = request.Atl,
        //    AtlDate = request.AtlDate
        //};

        var result = await mediator.Send(command);

        //return result.Match(
        //coin => Results.Created($"/api/coins/{coin.Id}", coin),
        //errors => Results.BadRequest(errors));

        return result.Match(
            coin => Results.Created($"/api/coins/{coin.Id}", coin),
            errors => ErrorHandling.ToProblemResult(errors));
    }
}
