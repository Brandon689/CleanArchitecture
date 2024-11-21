using ErrorOr;

namespace CleanArchitecture.Domain
{
    public static class PortfolioErrors
    {
        public static readonly Error MaxPositionsReached = Error.Validation(
            "Portfolio.MaxPositionsReached",
            "Portfolio has reached maximum allowed positions");

        public static readonly Error InsufficientBalance = Error.Validation(
            "Portfolio.InsufficientBalance",
            "Insufficient balance for this operation");

        public static readonly Error PortfolioLimitExceeded = Error.Validation(
            "Portfolio.PortfolioLimitExceeded",
            "User has reached maximum allowed portfolios");
    }
}
