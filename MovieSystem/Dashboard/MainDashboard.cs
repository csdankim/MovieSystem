using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Menu;
using MovieSystem.Menu.Options;

namespace MovieSystem.Dashboard
{
    class MainDashboard : IDashboard
    {
        public void ShowDashboard()
        {
            int choice = 0;
            IDashboard dashboard;
            MainMenu m = new MainMenu();

            do
            {
                //MainMenu m = new MainMenu();
                choice = m.PrintMenu();
                switch (choice)
                {
                    case (int)MainMenuOption.Movie:
                        dashboard = new MovieDashboard();
                        dashboard.ShowDashboard();
                        break;
                    case (int)MainMenuOption.MovieCast:
                        dashboard = new MovieCastDashboard();
                        dashboard.ShowDashboard();
                        break;
                    case (int)MainMenuOption.Cast:
                        dashboard = new CastDashboard();
                        dashboard.ShowDashboard();
                        break;
                    case (int)MainMenuOption.MovieGenre:
                        dashboard = new MovieGenreDashboard();
                        dashboard.ShowDashboard();
                        break;
                    case (int)MainMenuOption.Genre:
                        dashboard = new GenreDashboard();
                        dashboard.ShowDashboard();
                        break;
                    case (int)MainMenuOption.User:
                        dashboard = new UserDashboard();
                        dashboard.ShowDashboard();
                        break;
                    case (int)MainMenuOption.Review:
                        dashboard = new ReviewDashboard();
                        dashboard.ShowDashboard();
                        break;
                    case (int)MainMenuOption.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                if (choice != (int)MainMenuOption.Exit)
                {
                    Console.WriteLine("Press Enter to continue......");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (choice != (int)MainMenuOption.Exit);
        }
    }
}
