using System.Linq.Expressions;
using Dominio.Entities.Principales;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly TallerContext _context;
    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<(int totalRegistros, IEnumerable<T> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(T entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}