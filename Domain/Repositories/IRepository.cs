using Domain.Entities;

namespace Domain.Repositories;

public interface IRepository<T> where T : Entity
{
    Task<bool> AddAsync(T entity);
    Task<bool> DeleteAsync(T entity);
    Task<bool> UpdateAsync(T entity);
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
}
