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
    class ManageReview
    {
        private readonly ReviewService reviewService;
        public ManageReview()
        {
            reviewService = new ReviewService();
        }

        #region sync
        void AddReview()
        {
            Review r = new Review();

            Console.Write("Enter MovieId = ");
            r.MovieId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter UserId = ");
            r.UserId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Rating = ");
            r.Rating = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter ReviewText = ");
            r.ReviewText = Console.ReadLine();

            if (reviewService.AddReview(r) > 0)
            {
                Console.WriteLine("Review added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void UpdateReview()
        {
            Review r = new Review();

            Console.Write("Enter MovieId = ");
            r.MovieId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter UserId = ");
            r.UserId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Rating = ");
            r.Rating = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter ReviewText = ");
            r.ReviewText = Console.ReadLine();

            if (reviewService.UpdateReview(r) > 0)
            {
                Console.WriteLine("Review updated successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void DeleteReview()
        {
            Console.Write("Enter MovieId = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Review r = reviewService.GetById(id);

            if (reviewService.DeleteReview(id) > 0)
            {
                Console.WriteLine($"MovieId: {id} UserId: {r.UserId} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        void PrintAll()
        {
            IEnumerable<Review> reviewCollection = reviewService.GetAll();
            foreach (var item in reviewCollection)
            {
                Console.WriteLine(item.MovieId + "\t" + item.UserId + "\t" + item.Rating + "\t" + item.ReviewText);
            }
        }
        void PrintById()
        {
            Console.Write("Enter MovieId = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Review r = reviewService.GetById(id);

            if (r != null)
            {
                Console.WriteLine(r.MovieId + "\t" + r.UserId + "\t" + r.Rating + "\t" + r.ReviewText);
            }
            else
            {
                Console.WriteLine("Cannot find MovieId");
            }
        }
        public void Run()
        {
            int choice = 0;
            do
            {
                ReviewMenu m = new ReviewMenu();
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)ReviewOption.Insert:
                        AddReview();
                        break;
                    case (int)ReviewOption.Update:
                        UpdateReview();
                        break;
                    case (int)ReviewOption.Delete:
                        DeleteReview();
                        break;
                    case (int)ReviewOption.PrintAll:
                        PrintAll();
                        break;
                    case (int)ReviewOption.PrintById:
                        PrintById();
                        break;
                    case (int)ReviewOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press Enter to continue......");
                Console.ReadLine();
                Console.Clear();
            } while (choice != (int)ReviewOption.Exit);
        }
        #endregion

        #region async
        async Task AddReviewAsync()
        {
            Review r = new Review();

            Console.Write("Enter MovieId = ");
            r.MovieId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter UserId = ");
            r.UserId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Rating = ");
            r.Rating = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter ReviewText = ");
            r.ReviewText = Console.ReadLine();

            if (await reviewService.AddReviewAsync(r) > 0)
            {
                Console.WriteLine("Review added successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task UpdateReviewAsync()
        {
            Review r = new Review();

            Console.Write("Enter MovieId = ");
            r.MovieId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter UserId = ");
            r.UserId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Rating = ");
            r.Rating = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter ReviewText = ");
            r.ReviewText = Console.ReadLine();

            if (await reviewService.UpdateReviewAsync(r) > 0)
            {
                Console.WriteLine("Review updated successfully");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task DeleteReviewAsync()
        {
            Console.Write("Enter MovieId = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Review r = await reviewService.GetByIdAsync(id);

            if (await reviewService.DeleteReviewAsync(id) > 0)
            {
                Console.WriteLine($"MovieId: {id} UserId: {r.UserId} deleted");
            }
            else
            {
                Console.WriteLine("Some error occurred");
            }
        }
        async Task PrintAllAsync()
        {
            IEnumerable<Review> reviewCollection = await reviewService.GetAllAsync();
            foreach (var item in reviewCollection)
            {
                Console.WriteLine(item.MovieId + "\t" + item.UserId + "\t" + item.Rating + "\t" + item.ReviewText);
            }
        }
        async Task PrintByIdAsync()
        {
            Console.Write("Enter MovieId = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Review r = await reviewService.GetByIdAsync(id);

            if (r != null)
            {
                Console.WriteLine(r.MovieId + "\t" + r.UserId + "\t" + r.Rating + "\t" + r.ReviewText);
            }
            else
            {
                Console.WriteLine("Cannot find MovieId");
            }
        }
        public void RunAsync()
        {
            int choice = 0;
            do
            {
                ReviewMenu m = new ReviewMenu();
                choice = m.PrintMenu();

                switch (choice)
                {
                    case (int)ReviewOption.Insert:
                        AddReviewAsync().Wait();
                        break;
                    case (int)ReviewOption.Update:
                        UpdateReviewAsync().Wait();
                        break;
                    case (int)ReviewOption.Delete:
                        DeleteReviewAsync().Wait();
                        break;
                    case (int)ReviewOption.PrintAll:
                        PrintAllAsync().Wait();
                        break;
                    case (int)ReviewOption.PrintById:
                        PrintByIdAsync().Wait();
                        break;
                    case (int)ReviewOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press Enter to continue......");
                Console.ReadLine();
                Console.Clear();
            } while (choice != (int)ReviewOption.Exit);
        }
        #endregion
    }
}
