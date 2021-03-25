using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.UI;

namespace MovieSystem.Dashboard
{
    class ReviewDashboard : IDashboard
    {
        public void ShowDashboard()
        {
            ManageReview manageReview = new ManageReview();
            manageReview.RunAsync();
        }
    }
}
