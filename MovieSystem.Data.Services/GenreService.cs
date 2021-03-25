using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Data.Repository;
using MovieSystem.Data.Models;
using System.Threading.Tasks;

namespace MovieSystem.Data.Services
{
    public class GenreService
    {
        IRepository<Genre> genreRepository;
        public GenreService()
        {
            genreRepository = new GenreRepository();
        }
        public int AddGenre(Genre item)
        {
            return genreRepository.Insert(item);
        }

        public int UpdateGenre(Genre item)
        {
            return genreRepository.Update(item);
        }

        public int DeleteGenre(int id)
        {
            return genreRepository.Delete(id);
        }

        public IEnumerable<Genre> GetAll()
        {
            return genreRepository.GetAll();
        }

        public Genre GetById(int id)
        {
            return genreRepository.GetById(id);
        }

        //async
        public Task<int> AddGenreAsync(Genre item)
        {
            return genreRepository.InsertAsync(item);
        }

        public Task<int> UpdateGenreAsync(Genre item)
        {
            return genreRepository.UpdateAsync(item);
        }

        public Task<int> DeleteGenreAsync(int id)
        {
            return genreRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<Genre>> GetAllAsync()
        {
            return genreRepository.GetAllAsync();
        }

        public Task<Genre> GetByIdAsync(int id)
        {
            return genreRepository.GetByIdAsync(id);
        }
    }
}
