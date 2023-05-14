using TodoListAPI.Domain.Entities;

namespace TodoListAPI.Domain.Interfaces;

public interface IRepository <T> where T : BaseEntity
{
    Task AddAsync(T entity);

    Task UpdateAsync(T entity);

    Task DeleteAsync(T entity);

    Task<T?> GetAsync(Guid id);

    Task<IEnumerable<T>> GetAllAsync();
}
