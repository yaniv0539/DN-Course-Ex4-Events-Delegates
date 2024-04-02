using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCapitals : IOptionSelected
    {
        void IOptionSelected.Invoke()
        {
            CountCapitalLettersInSentence();
        }

        public static void CountCapitalLettersInSentence()
        {
            string userSentence;
            int numberOfCapitalLetters = 0;

            System.Console.WriteLine("Please enter your sentence");
            userSentence = Console.ReadLine();

            foreach(char c in userSentence)
            {
                if(char.IsUpper(c))
                {
                    numberOfCapitalLetters++;
                }
            }

            System.Console.WriteLine("There are {0} capitals in your sentence.", numberOfCapitalLetters);
        }
    }
}
