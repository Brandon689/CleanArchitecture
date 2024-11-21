namespace CleanArchitecture.Domain.Coins;

public class Coin
{
    public Coin(string name,
        string symbol,
        string coinImageURL,
        decimal currentPrice,
        decimal marketCap,
        int marketCapRank,
        decimal fullyDilutedValuation,
        decimal totalVolume,
        decimal circulatingSupply,
        decimal totalSupply,
        decimal ath,
        DateOnly athDate,
        decimal atl,
        DateOnly atlDate,
        Guid? id = null)
    {
        Id = id ?? Guid.NewGuid();
        Name = name;
        Symbol = symbol;
        CoinImageURL = coinImageURL;
        CurrentPrice = currentPrice;
        MarketCap = marketCap;
        MarketCapRank = marketCapRank;
        FullyDilutedValuation = fullyDilutedValuation;
        TotalVolume = totalVolume;
        CirculatingSupply = circulatingSupply;
        TotalSupply = totalSupply;
        Ath = ath;
        AthDate = athDate;
        Atl = atl;
        AtlDate = atlDate;
    }

    public Guid Id { get; }

    public string Name { get; init; }
    public string Symbol { get; init; }
    public string CoinImageURL { get; init; }

    public decimal CurrentPrice { get; init; }
    public decimal MarketCap { get; init; }
    public int MarketCapRank { get; init; }
    public decimal FullyDilutedValuation { get; init; }
    public decimal TotalVolume { get; init; }
    public decimal CirculatingSupply { get; init; }
    public decimal TotalSupply { get; init; }
    public decimal Ath { get; init; }
    public DateOnly AthDate { get; init; }
    public decimal Atl { get; init; }
    public DateOnly AtlDate { get; init; }



    private Coin() { }
}
