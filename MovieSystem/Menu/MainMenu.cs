using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Menu;
using MovieSystem.Menu.Options;

namespace MovieSystem.Menu
{
    class MainMenu
    {
        public int PrintMenu()
        {
            string[] names = Enum.GetNames(typeof(MainMenuOption));
            int length = names.Length;
            int[] values = (int[])Enum.GetValues(typeof(MainMenuOption));

            Console.WriteLine("This is Main Menu");

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
