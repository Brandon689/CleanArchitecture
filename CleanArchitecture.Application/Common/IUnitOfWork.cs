namespace CleanArchitecture.Application.Common;

public interface IUnitOfWork
{
    Task CommitChangesAsync();
}
