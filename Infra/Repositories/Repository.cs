using Domain.Entities;
using Domain.Repositories;
using Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories;

public class Repository<T> : IRepository<T> where T : Entity
{
    public readonly AppDbContext _db;
    public readonly DbSet<T> dbSet;

    public Repository(AppDbContext db)
    {
        _db = db;
        dbSet = db.Set<T>();
    }

    public async Task<bool> AddAsync(T entity)
    {
        dbSet.Add(entity);
        return await SaveAsync();
    }

    public async Task<bool> DeleteAsync(T entity)
    {
        dbSet.Remove(entity);
        return await SaveAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        var exist = await dbSet.FirstOrDefaultAsync(_ => _.Id == id);
        if (exist == null) throw new Exception("Not found any entity with this ID");
        return exist;
    }

    public async Task<bool> UpdateAsync(T entity)
    {
        dbSet.Update(entity);
        return await SaveAsync();
    }

    private async Task<bool> SaveAsync()
    {
        try
        {
            return await _db.SaveChangesAsync() == 1 ? true : false;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
    public async Task<List<T>> GetAllAsync() => await dbSet.ToListAsync();
}
