using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.UI;

namespace MovieSystem.Dashboard
{
    class UserDashboard : IDashboard
    {
        public void ShowDashboard()
        {
            ManageUser manageUser = new ManageUser();
            manageUser.RunAsync();
        }
    }
}
