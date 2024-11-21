using ErrorOr;

namespace CleanArchitecture.Domain.Positions;

public static class PositionErrors
{
    public static readonly Error PositionAlreadyExists = Error.Conflict(
        "Position.AlreadyExists",
        "Position for this crypto already exists in portfolio");

    public static readonly Error InsufficientQuantity = Error.Validation(
        "Position.InsufficientQuantity",
        "Insufficient quantity for this operation");

    public static readonly Error ExceedsMaxAllocation = Error.Validation(
        "Position.ExceedsMaxAllocation",
        "Position would exceed maximum allowed allocation percentage");
}
