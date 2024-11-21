namespace CleanArchitecture.Domain.Forecasts;

public sealed class Forecast
{
    public Guid Id { get; }

    public TimeSpan Period { get; private set; }
    public float PercentageMove { get; private set; }
    public int Stakes { get; private set; }
}
