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
    class ManageCast
    {
        private readonly CastService castService;
        public ManageCast()
        {
            castService = new CastService();
        }
        #region sync
        void AddCast()
        {
            Cast c = new Cast();
            Console.Write("Enter Cast Name = ");
            c.Name = Console.ReadLine();

            Console.Write("Enter Cast Gender = ");
            c.Gender = Console.ReadLine();

            Console.Write("Enter Cast TmdbUrl = ");
            c.TmdbUrl = Console.ReadLine();

            Console.Write("Enter Cast ProfilePath = ");
            c.ProfilePath = Console.ReadLine();

            if (castService.AddCast(c) > 0)
            {
                Console.WriteLine("Cast added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void UpdateCast()
        {
            Cast c = new Cast();
            Console.Write("Enter Cast Id = ");
            c.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Cast Name = ");
            c.Name = Console.ReadLine();

            Console.Write("Enter Cast Gender = ");
            c.Gender = Console.ReadLine();

            Console.Write("Enter Cast TmdbUrl = ");
            c.TmdbUrl = Console.ReadLine();

            Console.Write("Enter Cast ProfilePath = ");
            c.ProfilePath = Console.ReadLine();

            if (castService.UpdateCast(c) > 0)
            {
                Console.WriteLine("Cast updated successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void DeleteCast()
        {
            Console.Write("Enter Cast Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Cast c = castService.GetById(id);

            if (castService.DeleteCast(id) > 0)
            {
                Console.WriteLine($"Cast Id: {id} Name: {c.Name} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void PrintAll()
        {
            IEnumerable<Cast> castCollection = castService.GetAll();
            foreach (var item in castCollection)
            {
                Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.Gender + "\t" + item.TmdbUrl + "\t" + item.ProfilePath);
            }
        }
        void PrintById()
        {
            Console.Write("Enter Cast Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Cast c = castService.GetById(id);

            if (c != null)
            {
                Console.WriteLine(c.Id + "\t" + c.Name + "\t" + c.Gender + "\t" + c.TmdbUrl + "\t" + c.ProfilePath);
            }
            else
            {
                Console.WriteLine("Cannot find Cast Id");
            }
        }
        public void Run()
        {
            int choice = 0;
            do
            {
                CastMenu m = new CastMenu();
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)CastOption.Insert:
                        AddCast();
                        break;
                    case (int)CastOption.Update:
                        UpdateCast();
                        break;
                    case (int)CastOption.Delete:
                        DeleteCast();
                        break;
                    case (int)CastOption.PrintAll:
                        PrintAll();
                        break;
                    case (int)CastOption.PrintById:
                        PrintById();
                        break;
                    case (int)CastOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press Enter to continue......");
                Console.ReadLine();
                Console.Clear();
            } while (choice != (int)CastOption.Exit);
        }
        #endregion

        #region async
        async Task AddCastAsync()
        {
            Cast c = new Cast();
            Console.Write("Enter Cast Name = ");
            c.Name = Console.ReadLine();

            Console.Write("Enter Cast Gender = ");
            c.Gender = Console.ReadLine();

            Console.Write("Enter Cast TmdbUrl = ");
            c.TmdbUrl = Console.ReadLine();

            Console.Write("Enter Cast ProfilePath = ");
            c.ProfilePath = Console.ReadLine();

            if (await castService.AddCastAsync(c) > 0)
            {
                Console.WriteLine("Cast added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task UpdateCastAsync()
        {
            Cast c = new Cast();
            Console.Write("Enter Cast Id = ");
            c.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Cast Name = ");
            c.Name = Console.ReadLine();

            Console.Write("Enter Cast Gender = ");
            c.Gender = Console.ReadLine();

            Console.Write("Enter Cast TmdbUrl = ");
            c.TmdbUrl = Console.ReadLine();

            Console.Write("Enter Cast ProfilePath = ");
            c.ProfilePath = Console.ReadLine();

            if (await castService.UpdateCastAsync(c) > 0)
            {
                Console.WriteLine("Cast updated successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task DeleteCastAsync()
        {
            Console.Write("Enter Cast Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Cast c = await castService.GetByIdAsync(id);

            if (await castService.DeleteCastAsync(id) > 0)
            {
                Console.WriteLine($"Cast Id: {id} Name: {c.Name} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task PrintAllAsync()
        {
            IEnumerable<Cast> castCollection = await castService.GetAllAsync();
            foreach (var item in castCollection)
            {
                Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.Gender + "\t" + item.TmdbUrl + "\t" + item.ProfilePath);
            }
        }
        async Task PrintByIdAsync()
        {
            Console.Write("Enter Cast Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Cast c = await castService.GetByIdAsync(id);

            if (c != null)
            {
                Console.WriteLine(c.Id + "\t" + c.Name + "\t" + c.Gender + "\t" + c.TmdbUrl + "\t" + c.ProfilePath);
            }
            else
            {
                Console.WriteLine("Cannot find Cast Id");
            }
        }
        public void RunAsync()
        {
            int choice = 0;
            do
            {
                CastMenu m = new CastMenu();
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)CastOption.Insert:
                        AddCastAsync().Wait();
                        break;
                    case (int)CastOption.Update:
                        UpdateCastAsync().Wait();
                        break;
                    case (int)CastOption.Delete:
                        DeleteCastAsync().Wait();
                        break;
                    case (int)CastOption.PrintAll:
                        PrintAllAsync().Wait();
                        break;
                    case (int)CastOption.PrintById:
                        PrintByIdAsync().Wait();
                        break;
                    case (int)CastOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press Enter to continue......");
                Console.ReadLine();
                Console.Clear();
            } while (choice != (int)CastOption.Exit);
        }
        #endregion
    }
}
