using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Data.Repository;
using MovieSystem.Data.Models;
using System.Threading.Tasks;

namespace MovieSystem.Data.Services
{
    public class MovieGenreService
    {
        IRepository<MovieGenre> mgRepository;
        public MovieGenreService()
        {
            mgRepository = new MovieGenreRepository();
        }
        public int AddMovieGenre(MovieGenre item)
        {
            return mgRepository.Insert(item);
        }

        public int UpdateMovieGenre(MovieGenre item)
        {
            return mgRepository.Update(item);
        }

        public int DeleteMovieGenre(int id)
        {
            return mgRepository.Delete(id);
        }

        public IEnumerable<MovieGenre> GetAll()
        {
            return mgRepository.GetAll();
        }

        public MovieGenre GetById(int id)
        {
            return mgRepository.GetById(id);
        }

        // async
        public Task<int> AddMovieGenreAsync(MovieGenre item)
        {
            return mgRepository.InsertAsync(item);
        }

        public Task<int> UpdateMovieGenreAsync(MovieGenre item)
        {
            return mgRepository.UpdateAsync(item);
        }

        public Task<int> DeleteMovieGenreAsync(int id)
        {
            return mgRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<MovieGenre>> GetAllAsync()
        {
            return mgRepository.GetAllAsync();
        }

        public Task<MovieGenre> GetByIdAsync(int id)
        {
            return mgRepository.GetByIdAsync(id);
        }
    }
}
