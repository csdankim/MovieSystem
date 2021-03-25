using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.UI;

namespace MovieSystem.Dashboard
{
    class CastDashboard : IDashboard
    {
        public void ShowDashboard()
        {
            ManageCast manageCast = new ManageCast();
            manageCast.RunAsync();
        }
    }
}
