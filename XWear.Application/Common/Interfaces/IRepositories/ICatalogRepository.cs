using XWear.Domain.Entities;

namespace XWear.Application.Common.Interfaces.IRepositories;

public interface ICatalogRepository
{
    List<Catalog> GetCatalogs();
}
