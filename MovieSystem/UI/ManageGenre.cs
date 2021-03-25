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
    class ManageGenre
    {
        private readonly GenreService genreService;
        public ManageGenre()
        {
            genreService = new GenreService();
        }
        #region sync
        void AddGenre()
        {
            Genre g = new Genre();

            Console.Write("Enter Genre Name = ");
            g.Name = Console.ReadLine();

            if (genreService.AddGenre(g) > 0)
            {
                Console.WriteLine("Genre added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void UpdateGenre()
        {
            Genre g = new Genre();

            Console.Write("Enter Genre Id = ");
            g.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Genre Name = ");
            g.Name = Console.ReadLine();

            if (genreService.UpdateGenre(g) > 0)
            {
                Console.WriteLine("Genre updated successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void DeleteGenre()
        {
            Console.Write("Enter Genre Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Genre g = genreService.GetById(id);

            if (genreService.DeleteGenre(id) > 0)
            {
                Console.WriteLine($"Genre Id: {id} Name: {g.Name} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void PrintAll()
        {
            IEnumerable<Genre> genreCollection = genreService.GetAll();
            foreach (var item in genreCollection)
            {
                Console.WriteLine(item.Id + "\t" + item.Name);
            }
        }
        void PrintById()
        {
            Console.Write("Enter Genre Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Genre g = genreService.GetById(id);

            if (g != null)
            {
                Console.WriteLine(g.Id + "\t" + g.Name);
            }
            else
            {
                Console.WriteLine("Cannot find Genre Id");
            }
        }
        public void Run()
        {
            int choice = 0;
            GenreMenu m = new GenreMenu();

            do
            {
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)GenreOption.Insert:
                        AddGenre();
                        break;
                    case (int)GenreOption.Update:
                        UpdateGenre();
                        break;
                    case (int)GenreOption.Delete:
                        DeleteGenre();
                        break;
                    case (int)GenreOption.PrintAll:
                        PrintAll();
                        break;
                    case (int)GenreOption.PrintById:
                        PrintById();
                        break;
                    case (int)GenreOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                if (choice != (int)GenreOption.Exit)
                {
                    Console.WriteLine("Press Enter to continue......");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (choice != (int)GenreOption.Exit);
        }
        #endregion

        #region async
        async Task AddGenreAsync()
        {
            Genre g = new Genre();

            Console.Write("Enter Genre Name = ");
            g.Name = Console.ReadLine();

            if (await genreService.AddGenreAsync(g) > 0)
            {
                Console.WriteLine("Genre added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task UpdateGenreAsync()
        {
            Genre g = new Genre();

            Console.Write("Enter Genre Id = ");
            g.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Genre Name = ");
            g.Name = Console.ReadLine();

            if (await genreService.UpdateGenreAsync(g) > 0)
            {
                Console.WriteLine("Genre updated successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task DeleteGenreAsync()
        {
            Console.Write("Enter Genre Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Genre g = await genreService.GetByIdAsync(id);

            if (await genreService.DeleteGenreAsync(id) > 0)
            {
                Console.WriteLine($"Genre Id: {id} Name: {g.Name} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task PrintAllAsync()
        {
            IEnumerable<Genre> genreCollection = await genreService.GetAllAsync();
            foreach (var item in genreCollection)
            {
                Console.WriteLine(item.Id + "\t" + item.Name);
            }
        }
        async Task PrintByIdAsync()
        {
            Console.Write("Enter Genre Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Genre g = await genreService.GetByIdAsync(id);

            if (g != null)
            {
                Console.WriteLine(g.Id + "\t" + g.Name);
            }
            else
            {
                Console.WriteLine("Cannot find Genre Id");
            }
        }
        public void RunAsync()
        {
            int choice = 0;
            GenreMenu m = new GenreMenu();
            do
            {
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)GenreOption.Insert:
                        AddGenreAsync().Wait();
                        break;
                    case (int)GenreOption.Update:
                        UpdateGenreAsync().Wait();
                        break;
                    case (int)GenreOption.Delete:
                        DeleteGenreAsync().Wait();
                        break;
                    case (int)GenreOption.PrintAll:
                        PrintAllAsync().Wait();
                        break;
                    case (int)GenreOption.PrintById:
                        PrintByIdAsync().Wait();
                        break;
                    case (int)GenreOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                if (choice != (int)GenreOption.Exit)
                {
                    Console.WriteLine("Press Enter to continue......");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (choice != (int)GenreOption.Exit);
        }


        #endregion
    }
}
