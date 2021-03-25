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
    class ManageMovieCast
    {
        private readonly MovieCastService mcService;
        public ManageMovieCast()
        {
            mcService = new MovieCastService();
        }

        #region sync
        void AddMovieCast()
        {
            MovieCast mc = new MovieCast();
            Console.Write("Enter Movie Id = ");
            mc.MovieId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Cast Id = ");
            mc.CastId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Cast Character = ");
            mc.Character = Console.ReadLine();

            if (mcService.AddMovieCast(mc) > 0)
            {
                Console.WriteLine("Cast added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void UpdateMovieCast()
        {
            MovieCast mc = new MovieCast();
            Console.Write("Enter Movie Id = ");
            mc.MovieId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Cast Id = ");
            mc.CastId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Cast Character = ");
            mc.Character = Console.ReadLine();

            if (mcService.UpdateMovieCast(mc) > 0)
            {
                Console.WriteLine("Cast added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void DeleteMovieCast()
        {
            Console.Write("Enter Movie Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            MovieCast mc = mcService.GetById(id);

            if (mcService.DeleteMovieCast(id) > 0)
            {
                Console.WriteLine($"Movie Id: {id} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void PrintAll()
        {
            IEnumerable<MovieCast> mcCollection = mcService.GetAll();
            foreach (var item in mcCollection)
            {
                Console.WriteLine(item.MovieId + "\t" + item.CastId + "\t" + item.Character);
            }
        }
        void PrintById()
        {
            Console.Write("Enter Movie Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            MovieCast mc = mcService.GetById(id);

            if (mc != null)
            {
                Console.WriteLine(mc.MovieId + "\t" + mc.CastId + "\t" + mc.Character);
            }
            else
            {
                Console.WriteLine("Cannot find Movie Id");
            }
        }
        /*void GetMovieCastAllWithMovieCast()
        {
            IEnumerable<MovieCast> mcCollection = mcService.GetMovieCastAllWithMovieCast();
            string format = "MM-dd-yyyy";

            foreach (var item in mcCollection)
            {
                Console.WriteLine(item.MovieId + " " + item.Movie.Title + " " + item.Movie.ReleaseDate.ToString(format) + " " +
                                  item.Movie.Budget + " " + item.Movie.Revenue + " " + item.CastId + " " + item.Character + " " + item.Cast.Name);
            }
        }
        void GetMovieCastByIdWithMovieCast()
        {
            Console.Write("Enter MovieId = ");
            int id = Convert.ToInt32(Console.ReadLine());
            IEnumerable<MovieCast> mcCollection = mcService.GetMovieCastByIdWithMovieCast(id);
            string format = "MM-dd-yyyy";

            if (mcCollection != null)
            {
                foreach (var item in mcCollection)
                {
                    Console.WriteLine(item.MovieId + " " + item.Movie.Title + " " + item.Movie.ReleaseDate.ToString(format) + " " +
                                  item.Movie.Budget + " " + item.Movie.Revenue + " " + item.CastId + " " + item.Character + " " + item.Cast.Name);
                }
            }
            else
            {
                Console.WriteLine("Cannot find Movie Id");
            }
        }*/

        public void Run()
        {
            int choice = 0;
            do
            {
                MovieCastMenu m = new MovieCastMenu();
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)MovieCastOption.Insert:
                        AddMovieCast();
                        break;
                    case (int)MovieCastOption.Update:
                        UpdateMovieCast();
                        break;
                    case (int)MovieCastOption.Delete:
                        DeleteMovieCast();
                        break;
                    case (int)MovieCastOption.PrintAll:
                        PrintAll();
                        break;
                    case (int)MovieCastOption.PrintById:
                        PrintById();
                        break;
                    case (int)MovieCastOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press Enter to continue......");
                Console.ReadLine();
                Console.Clear();
            } while (choice != (int)MovieCastOption.Exit);
        }
        #endregion

        #region async
        async Task AddMovieCastAsync()
        {
            MovieCast mc = new MovieCast();
            Console.Write("Enter Movie Id = ");
            mc.MovieId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Cast Id = ");
            mc.CastId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Cast Character = ");
            mc.Character = Console.ReadLine();

            if (await mcService.AddMovieCastAsync(mc) > 0)
            {
                Console.WriteLine("Cast added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task UpdateMovieCastAsync()
        {
            MovieCast mc = new MovieCast();
            Console.Write("Enter Movie Id = ");
            mc.MovieId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Cast Id = ");
            mc.CastId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Cast Character = ");
            mc.Character = Console.ReadLine();

            if (await mcService.UpdateMovieCastAsync(mc) > 0)
            {
                Console.WriteLine("Cast added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task DeleteMovieCastAsync()
        {
            Console.Write("Enter Movie Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            MovieCast mc = await mcService.GetByIdAsync(id);

            if (await mcService.DeleteMovieCastAsync(id) > 0)
            {
                Console.WriteLine($"Movie Id: {id} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }

        public async Task PrintAllAsync()
        {
            var mcCollection = await mcService.GetAllAsync();
            foreach (var item in mcCollection)
            {
                Console.WriteLine(item.MovieId + "\t" + item.CastId + "\t" + item.Character);
            }
        }

        public async Task PrintByIdAsync()
        {
            Console.Write("Enter Movie Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            MovieCast mc = await mcService.GetByIdAsync(id);

            if (mc != null)
            {
                Console.WriteLine(mc.MovieId + "\t" + mc.CastId + "\t" + mc.Character);
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
                MovieCastMenu m = new MovieCastMenu();
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)MovieCastOption.Insert:
                        AddMovieCastAsync().Wait();
                        break;
                    case (int)MovieCastOption.Update:
                        UpdateMovieCastAsync().Wait();
                        break;
                    case (int)MovieCastOption.Delete:
                        DeleteMovieCastAsync().Wait();
                        break;
                    case (int)MovieCastOption.PrintAll:
                        PrintAllAsync().Wait();
                        break;
                    case (int)MovieCastOption.PrintById:
                        PrintByIdAsync().Wait();
                        break;
                    case (int)MovieCastOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press Enter to continue......");
                Console.ReadLine();
                Console.Clear();
            } while (choice != (int)MovieCastOption.Exit);
        }
        #endregion
    }
}
