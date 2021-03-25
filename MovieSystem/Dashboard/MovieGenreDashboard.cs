using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.UI;

namespace MovieSystem.Dashboard
{
    class MovieGenreDashboard : IDashboard
    {
        public void ShowDashboard()
        {
            ManageMovieGenre manageMovieGenre = new ManageMovieGenre();
            manageMovieGenre.RunAsync();
        }
    }
}
