using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Menu.Options;

namespace MovieSystem.Menu
{
    class MovieGenreMenu
    {
        public int PrintMenu()
        {
            string[] names = Enum.GetNames(typeof(MovieGenreOption));
            int length = names.Length;
            int[] values = (int[])Enum.GetValues(typeof(MovieGenreOption));

            Console.WriteLine("This is MovieGenre Menu");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Press " + values[i] + " for " + names[i]);
            }

            Console.Write("Enter your choice => ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}
