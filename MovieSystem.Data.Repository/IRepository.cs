using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repository
{
    public interface IRepository<T> where T:class
    {
        int Insert(T item);
        int Update(T item);
        int Delete(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> GetAllWith();
        IEnumerable<T> GetByIdWith(int id);

        //async
        Task<int> InsertAsync(T item);
        Task<int> UpdateAsync(T item);
        Task<int> DeleteAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllWithAsync();
        Task<IEnumerable<T>> GetByIdWithAsync(int id);
    }
}
