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
    class ManageUser
    {
        private readonly UserService userService;
        public ManageUser()
        {
            userService = new UserService();
        }

        #region sync
        void AddUser()
        {
            User u = new User();

            Console.Write("Enter FirstName = ");
            u.FirstName = Console.ReadLine();

            Console.Write("Enter LastName = ");
            u.LastName = Console.ReadLine();

            Console.Write("Enter DateOfBirth = ");
            u.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Email = ");
            u.Email = Console.ReadLine();

            Console.Write("Enter HashedPassword = ");
            u.HashedPassword = Console.ReadLine();

            Console.Write("Enter Salt = ");
            u.Salt = Console.ReadLine();

            Console.Write("Enter PhoneNumber = ");
            u.PhoneNumber = Console.ReadLine();

            Console.Write("Enter TwoFactorEnabled = ");
            u.TwoFactorEnabled = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter LockoutEndDate = ");
            u.LockoutEndDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter LastLoginDateTime = ");
            u.LastLoginDateTime = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter IsLocked = ");
            u.IsLocked = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter AccessFailedCount = ");
            u.AccessFailedCount = Convert.ToInt32(Console.ReadLine());

            if (userService.AddUser(u) > 0)
            {
                Console.WriteLine("User added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void UpdateUser()
        {
            User u = new User();

            Console.Write("Enter User Id = ");
            u.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter FirstName = ");
            u.FirstName = Console.ReadLine();

            Console.Write("Enter LastName = ");
            u.LastName = Console.ReadLine();

            Console.Write("Enter DateOfBirth = ");
            u.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Email = ");
            u.Email = Console.ReadLine();

            Console.Write("Enter HashedPassword = ");
            u.HashedPassword = Console.ReadLine();

            Console.Write("Enter Salt = ");
            u.Salt = Console.ReadLine();

            Console.Write("Enter PhoneNumber = ");
            u.PhoneNumber = Console.ReadLine();

            Console.Write("Enter TwoFactorEnabled = ");
            u.TwoFactorEnabled = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter LockoutEndDate = ");
            u.LockoutEndDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter LastLoginDateTime = ");
            u.LastLoginDateTime = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter IsLocked = ");
            u.IsLocked = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter AccessFailedCount = ");
            u.AccessFailedCount = Convert.ToInt32(Console.ReadLine());

            if (userService.UpdateUser(u) > 0)
            {
                Console.WriteLine("User updated successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void DeleteUser()
        {
            Console.Write("Enter User Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            User u = userService.GetById(id);

            if (userService.DeleteUser(id) > 0)
            {
                Console.WriteLine($"User Id: {id} Name: {u.FirstName + " " + u.LastName} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void PrintAll()
        {
            IEnumerable<User> userCollection = userService.GetAll();
            string format1 = "MM-dd-yyyy";
            string format2 = "MM-dd-yyyy hh:mm:ss";
            foreach (var item in userCollection)
            {
                Console.WriteLine(item.Id + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.DateOfBirth.ToString(format1) + "\t" + item.Email + "\t" + item.PhoneNumber + "\t" + item.LastLoginDateTime.ToString(format2));
            }
        }

        void PrintById()
        {
            Console.Write("Enter Movie Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            User u = userService.GetById(id);
            string format1 = "MM-dd-yyyy";
            string format2 = "MM-dd-yyyy hh:mm:ss";

            if (u != null)
            {
                Console.WriteLine(u.Id + "\t" + u.FirstName + "\t" + u.LastName + "\t" + u.DateOfBirth.ToString(format1) + "\t" + u.Email + "\t" + u.PhoneNumber + "\t" + u.LastLoginDateTime.ToString(format2));
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
                UserMenu m = new UserMenu();
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)UserOption.Insert:
                        AddUser();
                        break;
                    case (int)UserOption.Update:
                        UpdateUser();
                        break;
                    case (int)UserOption.Delete:
                        DeleteUser();
                        break;
                    case (int)UserOption.PrintAll:
                        PrintAll();
                        break;
                    case (int)UserOption.PrintById:
                        PrintById();
                        break;
                    case (int)UserOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                if (choice != (int)UserOption.Exit)
                {
                    Console.WriteLine("Press Enter to continue......");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (choice != (int)UserOption.Exit);
        }
        #endregion

        #region async
        async Task AddUserAsync()
        {
            User u = new User();

            Console.Write("Enter FirstName = ");
            u.FirstName = Console.ReadLine();

            Console.Write("Enter LastName = ");
            u.LastName = Console.ReadLine();

            Console.Write("Enter DateOfBirth = ");
            u.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Email = ");
            u.Email = Console.ReadLine();

            Console.Write("Enter HashedPassword = ");
            u.HashedPassword = Console.ReadLine();

            Console.Write("Enter Salt = ");
            u.Salt = Console.ReadLine();

            Console.Write("Enter PhoneNumber = ");
            u.PhoneNumber = Console.ReadLine();

            Console.Write("Enter TwoFactorEnabled = ");
            u.TwoFactorEnabled = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter LockoutEndDate = ");
            u.LockoutEndDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter LastLoginDateTime = ");
            u.LastLoginDateTime = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter IsLocked = ");
            u.IsLocked = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter AccessFailedCount = ");
            u.AccessFailedCount = Convert.ToInt32(Console.ReadLine());

            if (await userService.AddUserAsync(u) > 0)
            {
                Console.WriteLine("User added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task UpdateUserAsync()
        {
            User u = new User();

            Console.Write("Enter User Id = ");
            u.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter FirstName = ");
            u.FirstName = Console.ReadLine();

            Console.Write("Enter LastName = ");
            u.LastName = Console.ReadLine();

            Console.Write("Enter DateOfBirth = ");
            u.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Email = ");
            u.Email = Console.ReadLine();

            Console.Write("Enter HashedPassword = ");
            u.HashedPassword = Console.ReadLine();

            Console.Write("Enter Salt = ");
            u.Salt = Console.ReadLine();

            Console.Write("Enter PhoneNumber = ");
            u.PhoneNumber = Console.ReadLine();

            Console.Write("Enter TwoFactorEnabled = ");
            u.TwoFactorEnabled = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter LockoutEndDate = ");
            u.LockoutEndDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter LastLoginDateTime = ");
            u.LastLoginDateTime = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter IsLocked = ");
            u.IsLocked = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter AccessFailedCount = ");
            u.AccessFailedCount = Convert.ToInt32(Console.ReadLine());

            if (await userService.UpdateUserAsync(u) > 0)
            {
                Console.WriteLine("User updated successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task DeleteUserAsync()
        {
            Console.Write("Enter User Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            User u = await userService.GetByIdAsync(id);

            if (await userService.DeleteUserAsync(id) > 0)
            {
                Console.WriteLine($"User Id: {id} Name: {u.FirstName + " " + u.LastName} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task PrintAllAsync()
        {
            IEnumerable<User> userCollection = await userService.GetAllAsync();
            string format1 = "MM-dd-yyyy";
            string format2 = "MM-dd-yyyy hh:mm:ss";
            foreach (var item in userCollection)
            {
                Console.WriteLine(item.Id + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.DateOfBirth.ToString(format1) + "\t" + item.Email + "\t" + item.PhoneNumber + "\t" + item.LastLoginDateTime.ToString(format2));
            }
        }

        async Task PrintByIdAsync()
        {
            Console.Write("Enter Movie Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            User u = await userService.GetByIdAsync(id);
            string format1 = "MM-dd-yyyy";
            string format2 = "MM-dd-yyyy hh:mm:ss";

            if (u != null)
            {
                Console.WriteLine(u.Id + "\t" + u.FirstName + "\t" + u.LastName + "\t" + u.DateOfBirth.ToString(format1) + "\t" + u.Email + "\t" + u.PhoneNumber + "\t" + u.LastLoginDateTime.ToString(format2));
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
                UserMenu m = new UserMenu();
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)UserOption.Insert:
                        AddUserAsync().Wait();
                        break;
                    case (int)UserOption.Update:
                        UpdateUserAsync().Wait();
                        break;
                    case (int)UserOption.Delete:
                        DeleteUserAsync().Wait();
                        break;
                    case (int)UserOption.PrintAll:
                        PrintAllAsync().Wait();
                        break;
                    case (int)UserOption.PrintById:
                        PrintByIdAsync().Wait();
                        break;
                    case (int)UserOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                if (choice != (int)UserOption.Exit)
                {
                    Console.WriteLine("Press Enter to continue......");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (choice != (int)UserOption.Exit);
        }
        #endregion
    }
}
