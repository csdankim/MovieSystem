using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.UI;

namespace MovieSystem.Dashboard
{
    class GenreDashboard : IDashboard
    {
        public void ShowDashboard()
        {
            ManageGenre manageGenre = new ManageGenre();
            manageGenre.RunAsync();
        }
    }
}
