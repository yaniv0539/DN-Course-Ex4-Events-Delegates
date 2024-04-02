using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowVersion : IOptionSelected
    {
        void IOptionSelected.Invoke()
        {
            DisplayVersion();
        }

        public static void DisplayVersion()
        {
            System.Console.WriteLine("Version: 24.1.4.9633");
        }
    }
}
