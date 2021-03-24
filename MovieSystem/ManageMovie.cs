using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Data.Models;
using MovieSystem.Data.Services;

namespace MovieSystem
{
    class ManageMovie
    {
        private readonly MovieService movieService;
        public ManageMovie()
        {
            movieService = new MovieService();
        }
        void AddMovie()
        {
            Movie m = new Movie();
            Console.Write("Enter Movie Title = ");
            m.Title = Console.ReadLine();

            Console.Write("Enter Movie Overview = ");
            m.Overview = Console.ReadLine();

            Console.Write("Enter Movie Tagline = ");
            m.Tagline = Console.ReadLine();

            Console.Write("Enter Movie Budget = ");
            m.Budget = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Movie Revenue = ");
            m.Revenue = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Movie ImdbUrl = ");
            m.ImdbUrl = Console.ReadLine();

            Console.Write("Enter Movie TmdbUrl = ");
            m.TmdbUrl = Console.ReadLine();

            Console.Write("Enter Movie PosterUrl = ");
            m.PosterUrl = Console.ReadLine();

            Console.Write("Enter Movie BackdropUrl = ");
            m.BackdropUrl = Console.ReadLine();

            Console.Write("Enter Movie Original Language = ");
            m.OriginalLanguage = Console.ReadLine();

            Console.Write("Enter Movie Release Date = ");
            m.ReleaseDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Movie Running Time = ");
            m.RunTime = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Movie Price = ");
            m.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Movie Created Date = ");
            m.CreatedDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Movie Updated Date = ");
            m.UpdatedDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Movie Updated By = ");
            m.UpdatedBy = Console.ReadLine();

            Console.Write("Enter Movie Created By = ");
            m.CreatedBy = Console.ReadLine();

            if (movieService.AddMovie(m) > 0)
            {
                Console.WriteLine("Movie added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void UpdateMovie()
        {
            Movie m = new Movie();

            Console.Write("Enter Movie Id = ");
            m.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Movie Title = ");
            m.Title = Console.ReadLine();

            Console.Write("Enter Movie Overview = ");
            m.Overview = Console.ReadLine();

            Console.Write("Enter Movie Tagline = ");
            m.Tagline = Console.ReadLine();

            Console.Write("Enter Movie Budget = ");
            m.Budget = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Movie Revenue = ");
            m.Revenue = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Movie ImdbUrl = ");
            m.ImdbUrl = Console.ReadLine();

            Console.Write("Enter Movie TmdbUrl = ");
            m.TmdbUrl = Console.ReadLine();

            Console.Write("Enter Movie PosterUrl = ");
            m.PosterUrl = Console.ReadLine();

            Console.Write("Enter Movie BackdropUrl = ");
            m.BackdropUrl = Console.ReadLine();

            Console.Write("Enter Movie Original Language = ");
            m.OriginalLanguage = Console.ReadLine();

            Console.Write("Enter Movie Release Date = ");
            m.ReleaseDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Movie Running Time = ");
            m.RunTime = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Movie Price = ");
            m.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Movie Created Date = ");
            m.CreatedDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Movie Updated Date = ");
            m.UpdatedDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Movie Updated By = ");
            m.UpdatedBy = Console.ReadLine();

            Console.Write("Enter Movie Created By = ");
            m.CreatedBy = Console.ReadLine();

            if (movieService.UpdateMovie(m) > 0)
            {
                Console.WriteLine("Movie added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void DeleteMovie()
        {
            Console.Write("Enter Movie Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Movie m = movieService.GetById(id);

            if (movieService.DeleteMovie(id) > 0)
            {
                Console.WriteLine($"Movie Id: {id} Title: {m.Title} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void PrintAll()
        {
            IEnumerable<Movie> movieCollection = movieService.GetAll();
            foreach (var item in movieCollection)
            {
                Console.WriteLine(item.Id + "\t" + item.Title + "\t" + item.Overview + "\t" + item.ReleaseDate + "\t" + item.ImdbUrl + "\t" + item.PosterUrl + "\t" + item.Revenue);
            }
        }
        void PrintById()
        {
            Console.Write("Enter Movie Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Movie m = movieService.GetById(id);

            if (m != null)
            {
                Console.WriteLine(m.Id + "\t" + m.Title + "\t" + m.Overview + "\t" + m.ReleaseDate + "\t" + m.ImdbUrl + "\t" + m.PosterUrl + "\t" + m.Revenue);
            }
            else
            {
                Console.WriteLine("Cannot find Movie Id");
            }
        }
        public void Run()
        {
            PrintById();
        }
    }
}
