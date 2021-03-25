using System;
using MovieSystem.UI;
using MovieSystem.Dashboard;


namespace MovieSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IDashboard dashboard = new MainDashboard();
            dashboard.ShowDashboard();

            Console.Read();
        }
    }
}
