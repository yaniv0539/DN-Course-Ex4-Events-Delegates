using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowDate : IOptionSelected
    {
        void IOptionSelected.Invoke()
        {
            DisplayDate();
        }

        public static void DisplayDate()
        {
            DateTime currentDateTime = DateTime.Now;

            System.Console.WriteLine("The Date is: {0}", currentDateTime.ToShortDateString());
        }
    }
}
