using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Coins;
using CleanArchitecture.Infrastructure.Database;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace CleanArchitecture.Infrastructure.Repositories;


public class CoinsRepository : ICoinsRepository
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IDbConnection _dbConnection;

    public CoinsRepository(ApplicationDbContext dbContext, IConfiguration configuration)
    {
        _dbContext = dbContext;
        _dbConnection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
    }

    public async Task<Coin> GetByIdAsync(Guid id)
    {
        const string sql = @"
            SELECT Id, Name, Symbol, CoinImageURL, CurrentPrice, MarketCap, 
                   MarketCapRank, FullyDilutedValuation, TotalVolume, 
                   CirculatingSupply, TotalSupply, Ath, AthDate, Atl, AtlDate
            FROM Coins 
            WHERE Id = @Id";

        var coin = await _dbConnection.QuerySingleOrDefaultAsync<Coin>(
            sql,
            new { Id = id });

        return coin;
    }

    public async Task<List<Coin>> ListByPageAsync(int page, int pageSize)
    {
        const string sql = @"
            SELECT Id, Name, Symbol, CoinImageURL, CurrentPrice, MarketCap, 
                   MarketCapRank, FullyDilutedValuation, TotalVolume, 
                   CirculatingSupply, TotalSupply, Ath, AthDate, Atl, AtlDate
            FROM Coins
            ORDER BY MarketCapRank
            OFFSET @Offset
            LIMIT @PageSize";

        var offset = (page - 1) * pageSize;

        var coins = await _dbConnection.QueryAsync<Coin>(
            sql,
            new { Offset = offset, PageSize = pageSize });

        return coins.ToList();
    }

    public async Task<bool> ExistsAsync(Guid id)
    {
        const string sql = "SELECT COUNT(1) FROM Coins WHERE Id = @Id";

        var exists = await _dbConnection.ExecuteScalarAsync<int>(
            sql,
            new { Id = id });

        return exists > 0;
    }

    public Task AddCoinAsync(Coin coin)
    {
        _dbContext.Coins.Add(coin);
        return Task.CompletedTask;
    }

    public Task UpdateCoinAsync(Coin coin)
    {
        _dbContext.Coins.Update(coin);
        return Task.CompletedTask;
    }
}
