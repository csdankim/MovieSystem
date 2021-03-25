using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.UI;

namespace MovieSystem.Dashboard
{
    class MovieCastDashboard : IDashboard
    {
        public void ShowDashboard()
        {
            ManageMovieCast manageMovieCast = new ManageMovieCast();
            manageMovieCast.RunAsync();
        }
    }
}
