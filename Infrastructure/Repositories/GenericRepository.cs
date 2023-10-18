using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly NotiAPIContext _context;
    public GenericRepository(NotiAPIContext context)
    {
        _context = context;
    }

    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> GetAllAsync()
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

    public void RemoveRange(IEnumerable<T> entity)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}