using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Data.Models;
using MovieSystem.Data.Repository;

namespace MovieSystem.Data.Services
{
    public class MovieService
    {
        IRepository<Movie> movieRepository;
        public MovieService()
        {
            movieRepository = new MovieRepository();
        }

        public int AddMovie(Movie item)
        {
            return movieRepository.Insert(item);
        }

        public int UpdateMovie(Movie item)
        {
            return movieRepository.Update(item);
        }

        public int DeleteMovie(int id)
        {
            return movieRepository.Delete(id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return movieRepository.GetAll();
        }

        public Movie GetById(int id)
        {
            return movieRepository.GetById(id);
        }
    }
}
