using CleanArchitecture.Domain.Coins;

namespace CleanArchitecture.Application.Repositories;

public interface ICoinsRepository
{
    Task<Coin> GetByIdAsync(Guid id);
    Task<List<Coin>> ListByPageAsync(int page, int pageSize);
    Task AddCoinAsync(Coin coin);
    Task UpdateCoinAsync(Coin coin);
    Task<bool> ExistsAsync(Guid id);
}
