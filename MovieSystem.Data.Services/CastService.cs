using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Data.Repository;
using MovieSystem.Data.Models;
using System.Threading.Tasks;

namespace MovieSystem.Data.Services
{
    public class CastService
    {
        IRepository<Cast> castRepository;

        public CastService()
        {
            castRepository = new CastRepository();
        }

        public int AddCast(Cast item)
        {
            return castRepository.Insert(item);
        }

        public int UpdateCast(Cast item)
        {
            return castRepository.Update(item);
        }

        public int DeleteCast(int id)
        {
            return castRepository.Delete(id);
        }

        public IEnumerable<Cast> GetAll()
        {
            return castRepository.GetAll();
        }

        public Cast GetById(int id)
        {
            return castRepository.GetById(id);
        }

        //async
        public Task<int> AddCastAsync(Cast item)
        {
            return castRepository.InsertAsync(item);
        }

        public Task<int> UpdateCastAsync(Cast item)
        {
            return castRepository.UpdateAsync(item);
        }

        public Task<int> DeleteCastAsync(int id)
        {
            return castRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<Cast>> GetAllAsync()
        {
            return castRepository.GetAllAsync();
        }

        public Task<Cast> GetByIdAsync(int id)
        {
            return castRepository.GetByIdAsync(id);
        }
    }
}
