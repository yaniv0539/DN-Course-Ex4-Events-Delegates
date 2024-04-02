using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowTime : IOptionSelected
    {
        void IOptionSelected.Invoke()
        {
            DisplayTime();
        }

        public static void DisplayTime()
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedTime = currentDateTime.ToString("HH:mm:ss");

            Console.WriteLine("The Hour is: {0}", formattedTime);
        }
    }
}
