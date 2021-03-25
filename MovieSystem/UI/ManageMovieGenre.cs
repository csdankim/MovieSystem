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
    class ManageMovieGenre
    {
        private readonly MovieGenreService mgService;
        public ManageMovieGenre()
        {
            mgService = new MovieGenreService();
        }

        #region sync
        void AddMovieGenre()
        {
            MovieGenre mg = new MovieGenre();

            Console.Write("Enter MovieId = ");
            mg.MovieId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter GenreId = ");
            mg.GenreId = Convert.ToInt32(Console.ReadLine());

            if (mgService.AddMovieGenre(mg) > 0)
            {
                Console.WriteLine("MovieGenre added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void UpdateMovieGenre()
        {
            MovieGenre mg = new MovieGenre();

            Console.Write("Enter MovieId = ");
            mg.MovieId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter GenreId = ");
            mg.GenreId = Convert.ToInt32(Console.ReadLine());

            if (mgService.UpdateMovieGenre(mg) > 0)
            {
                Console.WriteLine("MovieGenre updated successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void DeleteMovieGenre()
        {
            Console.WriteLine("Enter MovieId = " );
            int id = Convert.ToInt32(Console.ReadLine());
            MovieGenre mg = mgService.GetById(id);

            if (mgService.DeleteMovieGenre(id) > 0)
            {
                Console.WriteLine($"MovieGenre MovieId: {id} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void PrintAll()
        {
            IEnumerable<MovieGenre> mgCollection = mgService.GetAll();
            foreach (var item in mgCollection)
            {
                Console.WriteLine(item.MovieId + "\t" + item.GenreId);
            }
        }
        void PrintById()
        {
            Console.Write("Enter MovieId = ");
            int id = Convert.ToInt32(Console.ReadLine());
            MovieGenre mg = mgService.GetById(id);

            if (mg != null)
            {
                Console.WriteLine(mg.MovieId + "\t" + mg.GenreId);
            }
            else
            {
                Console.WriteLine("Cannot find MovieId");
            }
        }
        public void Run()
        {
            int choice = 0;
            MovieGenreMenu m = new MovieGenreMenu();
            do
            {
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)MovieGenreOption.Insert:
                        AddMovieGenre();
                        break;
                    case (int)MovieGenreOption.Update:
                        UpdateMovieGenre();
                        break;
                    case (int)MovieGenreOption.Delete:
                        DeleteMovieGenre();
                        break;
                    case (int)MovieGenreOption.PrintAll:
                        PrintAll();
                        break;
                    case (int)MovieGenreOption.PrintById:
                        PrintById();
                        break;
                    case (int)MovieGenreOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                if (choice != (int)MovieGenreOption.Exit)
                {
                    Console.WriteLine("Press Enter to continue......");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (choice != (int)MovieGenreOption.Exit);
        }
        #endregion

        #region async
        async Task AddMovieGenreAsync()
        {
            MovieGenre mg = new MovieGenre();

            Console.Write("Enter MovieId = ");
            mg.MovieId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter GenreId = ");
            mg.GenreId = Convert.ToInt32(Console.ReadLine());

            if (await mgService.AddMovieGenreAsync(mg) > 0)
            {
                Console.WriteLine("MovieGenre added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task UpdateMovieGenreAsync()
        {
            MovieGenre mg = new MovieGenre();

            Console.Write("Enter MovieId = ");
            mg.MovieId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter GenreId = ");
            mg.GenreId = Convert.ToInt32(Console.ReadLine());

            if (await mgService.UpdateMovieGenreAsync(mg) > 0)
            {
                Console.WriteLine("MovieGenre updated successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task DeleteMovieGenreAsync()
        {
            Console.WriteLine("Enter MovieId = ");
            int id = Convert.ToInt32(Console.ReadLine());
            MovieGenre mg = await mgService.GetByIdAsync(id);

            if (await mgService.DeleteMovieGenreAsync(id) > 0)
            {
                Console.WriteLine($"MovieGenre MovieId: {id} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task PrintAllAsync()
        {
            IEnumerable<MovieGenre> mgCollection = await mgService.GetAllAsync();
            foreach (var item in mgCollection)
            {
                Console.WriteLine(item.MovieId + "\t" + item.GenreId);
            }
        }
        async Task PrintByIdAsync()
        {
            Console.Write("Enter MovieId = ");
            int id = Convert.ToInt32(Console.ReadLine());
            MovieGenre mg = await mgService.GetByIdAsync(id);

            if (mg != null)
            {
                Console.WriteLine(mg.MovieId + "\t" + mg.GenreId);
            }
            else
            {
                Console.WriteLine("Cannot find MovieId");
            }
        }
        public void RunAsync()
        {
            int choice = 0;
            MovieGenreMenu m = new MovieGenreMenu();
            do
            {
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)MovieGenreOption.Insert:
                        AddMovieGenreAsync().Wait();
                        break;
                    case (int)MovieGenreOption.Update:
                        UpdateMovieGenreAsync().Wait();
                        break;
                    case (int)MovieGenreOption.Delete:
                        DeleteMovieGenreAsync().Wait();
                        break;
                    case (int)MovieGenreOption.PrintAll:
                        PrintAllAsync().Wait();
                        break;
                    case (int)MovieGenreOption.PrintById:
                        PrintByIdAsync().Wait();
                        break;
                    case (int)MovieGenreOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                if (choice != (int)MovieGenreOption.Exit)
                {
                    Console.WriteLine("Press Enter to continue......");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (choice != (int)MovieGenreOption.Exit);
        }

        #endregion
    }
}
