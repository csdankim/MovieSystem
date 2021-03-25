using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Data.Models;
using MovieSystem.Data.Repository;
using System.Threading.Tasks;

namespace MovieSystem.Data.Services
{
    public class MovieCastService
    {
        IRepository<MovieCast> mcRepository;
        public MovieCastService()
        {
            mcRepository = new MovieCastRepository();
        }
        public int AddMovieCast(MovieCast item)
        {
            return mcRepository.Insert(item);
        }

        public int UpdateMovieCast(MovieCast item)
        {
            return mcRepository.Update(item);
        }

        public int DeleteMovieCast(int id)
        {
            return mcRepository.Delete(id);
        }

        public IEnumerable<MovieCast> GetAll()
        {
            return mcRepository.GetAll();
        }

        public MovieCast GetById(int id)
        {
            return mcRepository.GetById(id);
        }
        /*public IEnumerable<MovieCast> GetMovieCastAllWithMovieCast()
        {
            return mcRepository.GetAllWith();
        }
        public IEnumerable<MovieCast> GetMovieCastByIdWithMovieCast(int id)
        {
            return mcRepository.GetByIdWith(id);
        }*/

        // async
        public Task<int> AddMovieCastAsync(MovieCast item)
        {
            return mcRepository.InsertAsync(item);
        }

        public Task<int> UpdateMovieCastAsync(MovieCast item)
        {
            return mcRepository.UpdateAsync(item);
        }

        public Task<int> DeleteMovieCastAsync(int id)
        {
            return mcRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<MovieCast>> GetAllAsync()
        {
            return mcRepository.GetAllAsync();
        }

        public Task<MovieCast> GetByIdAsync(int id)
        {
            return mcRepository.GetByIdAsync(id);
        }
    }
}
