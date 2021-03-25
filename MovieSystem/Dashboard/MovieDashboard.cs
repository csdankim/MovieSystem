using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.UI;

namespace MovieSystem.Dashboard
{
    class MovieDashboard : IDashboard
    {
        public void ShowDashboard()
        {
            ManageMovie manageMovie = new ManageMovie();
            manageMovie.RunAsync();
        }
    }
}
