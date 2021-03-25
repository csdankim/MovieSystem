using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Data.Models;
using MovieSystem.Data.Services;
using System.Threading.Tasks;
using MovieSystem.Menu;
using MovieSystem.Menu.Options;

namespace MovieSystem.UI
{
    class ManageMovie
    {
        private readonly MovieService movieService;
        public ManageMovie()
        {
            movieService = new MovieService();
        }
        #region sync
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
                Console.WriteLine("Movie updated successfully");
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
            string format = "MM-dd-yyyy";
            foreach (var item in movieCollection)
            {
                Console.WriteLine(item.Id + "\t" + item.Title + "\t" + item.Overview + "\t" + item.ReleaseDate.ToString(format) + "\t" + item.ImdbUrl + "\t" + item.PosterUrl + "\t" + item.Revenue);
            }
        }
        void PrintById()
        {
            Console.Write("Enter Movie Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Movie m = movieService.GetById(id);
            string format = "MM-dd-yyyy";

            if (m != null)
            {
                Console.WriteLine(m.Id + "\t" + m.Title + "\t" + m.Overview + "\t" + m.ReleaseDate.ToString(format) + "\t" + m.ImdbUrl + "\t" + m.PosterUrl + "\t" + m.Revenue);
            }
            else
            {
                Console.WriteLine("Cannot find Movie Id");
            }
        }
        public void Run()
        {
            int choice = 0;
            do
            {
                MovieMenu m = new MovieMenu();
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)MovieOption.Insert:
                        AddMovie();
                        break;
                    case (int)MovieOption.Update:
                        UpdateMovie();
                        break;
                    case (int)MovieOption.Delete:
                        DeleteMovie();
                        break;
                    case (int)MovieOption.PrintAll:
                        PrintAll();
                        break;
                    case (int)MovieOption.PrintById:
                        PrintById();
                        break;
                    case (int)MovieOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press Enter to continue......");
                Console.ReadLine();
                Console.Clear();
            } while (choice != (int)MovieOption.Exit);
        }
        #endregion

        #region async
        async Task AddMovieAsync()
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

            if (await movieService.AddMovieAsync(m) > 0)
            {
                Console.WriteLine("Movie added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task UpdateMovieAsync()
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

            if (await movieService.UpdateMovieAsync(m) > 0)
            {
                Console.WriteLine("Movie updated successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task DeleteMovieAsync()
        {
            Console.Write("Enter Movie Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Movie m = await movieService.GetByIdAsync(id);

            if (await movieService.DeleteMovieAsync(id) > 0)
            {
                Console.WriteLine($"Movie Id: {id} Title: {m.Title} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task PrintAllAsync()
        {
            var movieCollection = await movieService.GetAllAsync();
            string format = "MM-dd-yyyy";
            foreach (var item in movieCollection)
            {
                Console.WriteLine(item.Id + "\t" + item.Title + "\t" + item.Overview + "\t" + item.ReleaseDate.ToString(format) + "\t" + item.ImdbUrl + "\t" + item.PosterUrl + "\t" + item.Revenue);
            }
        }
        async Task PrintByIdAsync()
        {
            Console.Write("Enter Movie Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Movie m = await movieService.GetByIdAsync(id);
            string format = "MM-dd-yyyy";

            if (m != null)
            {
                Console.WriteLine(m.Id + "\t" + m.Title + "\t" + m.Overview + "\t" + m.ReleaseDate.ToString(format) + "\t" + m.ImdbUrl + "\t" + m.PosterUrl + "\t" + m.Revenue);
            }
            else
            {
                Console.WriteLine("Cannot find Movie Id");
            }
        }

        public void RunAsync()
        {
            int choice = 0;
            do
            {
                MovieMenu m = new MovieMenu();
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)MovieOption.Insert:
                        AddMovieAsync().Wait();
                        break;
                    case (int)MovieOption.Update:
                        UpdateMovieAsync().Wait();
                        break;
                    case (int)MovieOption.Delete:
                        DeleteMovieAsync().Wait();
                        break;
                    case (int)MovieOption.PrintAll:
                        PrintAllAsync().Wait();
                        break;
                    case (int)MovieOption.PrintById:
                        PrintByIdAsync().Wait();
                        break;
                    case (int)MovieOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press Enter to continue......");
                Console.ReadLine();
                Console.Clear();
            } while (choice != (int)MovieOption.Exit);
        }

        #endregion
    }
}
