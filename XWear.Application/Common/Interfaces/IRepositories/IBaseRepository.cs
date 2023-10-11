namespace XWear.Application.Common.Interfaces.IRepositories;

public interface IBaseRepository<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken);

    Task AddAsync(TEntity entity, CancellationToken cancellationToken);
}
