using System.Collections.Generic;
using System.Threading.Tasks;

namespace apiTestUnipCore.Repository
{
    public interface IRepository<T> where T : new() 
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(string id);
        Task Create(T item);
        Task Update(string id, T item);
        Task<bool> Delete(string id);
    }
}