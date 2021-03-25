﻿using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Menu.Options;

namespace MovieSystem.Menu
{
    public class CastMenu
    {
        public int PrintMenu()
        {
            string[] names = Enum.GetNames(typeof(CastOption));
            int length = names.Length;
            int[] values = (int[])Enum.GetValues(typeof(CastOption));

            Console.WriteLine("This is Cast Menu");

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
