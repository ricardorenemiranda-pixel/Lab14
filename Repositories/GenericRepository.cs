using lab08_ricardoquispea.Models;
using lab08_ricardoquispea.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lab08_ricardoquispea.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly LinqexampleContext _context;
    protected readonly DbSet<T> _dbSet;

    public GenericRepository(LinqexampleContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync() =>
        await _dbSet.ToListAsync();

    public async Task<T?> GetByIdAsync(int id) =>
        await _dbSet.FindAsync(id);

    public async Task AddAsync(T entity) =>
        await _dbSet.AddAsync(entity);

    public Task Update(T entity)
    {
        _dbSet.Update(entity);
        return Task.CompletedTask;
    }

    public Task Delete(T entity)
    {
        _dbSet.Remove(entity);
        return Task.CompletedTask;
    }
}