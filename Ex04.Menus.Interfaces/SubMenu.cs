using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private const int k_InitialMenuLevel = 1;
        private const int k_FirstOptionIndex = 1;
        private const int k_QuitThisMenuIndex = 0;

        private List<MenuItem> m_MenuItems;
        private int m_Level;

        private SubMenu(string i_MenuTitle, int i_MenuLevel) : base(i_MenuTitle)
        {
            m_MenuItems = new List<MenuItem>();
            m_Level = i_MenuLevel;
        }

        public static SubMenu CreateSubMenu(string i_DesiredMenuTitle)
        {
            return new SubMenu(i_DesiredMenuTitle, k_InitialMenuLevel);
        }

        public void Add(MenuItem i_MenuItemToAdd)
        {
            SubMenu subMenu = i_MenuItemToAdd as SubMenu;

            if(subMenu != null)
            {
                subMenu.m_Level = this.m_Level + 1;
            }

            m_MenuItems.Add(i_MenuItemToAdd);
        }

        public void Show()
        {
            bool quitThisMenu = false;
            bool parsable = false;
            string userInput;

            while(!quitThisMenu) 
            {
                printMenu();
                userInput = System.Console.ReadLine();
                System.Console.Clear();

                parsable = int.TryParse(userInput, out int userIndexSelection);

                if(!parsable || !isValidIndexInRange(userIndexSelection))
                {
                    System.Console.WriteLine("Invalid Input! Please try again...");
                    System.Console.WriteLine();
                    continue;
                }

                if(userIndexSelection == k_QuitThisMenuIndex)
                {
                    quitThisMenu = true;
                }
                else
                {
                    executeUserSelection(userIndexSelection);
                }
            }
        }

        private bool isValidIndexInRange(int i_IndexToCheck)
        {
            return (i_IndexToCheck >= k_QuitThisMenuIndex && i_IndexToCheck <= m_MenuItems.Count);
        }

        private void printMenu()
        {
            int optionIndex = k_FirstOptionIndex;
            StringBuilder sb = new StringBuilder();
            string quitOption = getQuitStringOption();

            sb.AppendLine(string.Format("**{0}**", base.Name));
            sb.AppendLine("------------------------------");

            foreach(MenuItem item in m_MenuItems)
            {
                sb.AppendLine(string.Format("{0} -> {1}", optionIndex, item.Name));
                optionIndex++;
            }

            sb.AppendLine(string.Format("{0} -> {1}", k_QuitThisMenuIndex, quitOption));
            sb.AppendLine("------------------------------");
            sb.AppendLine(string.Format("Enter your request: ({0} to {1} or press '0' to {2}).",
                k_FirstOptionIndex, m_MenuItems.Count, quitOption));

            System.Console.Write(sb.ToString());
        }

        private string getQuitStringOption()
        {
            string quitOption;

            if(m_Level == k_InitialMenuLevel)
            {
                quitOption = "Exit";
            }
            else
            {
                quitOption = "Back";
            }

            return quitOption;
        }

        private void executeUserSelection(int i_UserSelectionIndex)
        {
            int i_UserSelectionIndexInList = i_UserSelectionIndex - 1;
            SubMenu subMenu = m_MenuItems[i_UserSelectionIndexInList] as SubMenu;
            MenuAction menuAction = m_MenuItems[i_UserSelectionIndexInList] as MenuAction;

            if(subMenu != null)
            {
                subMenu.Show();
            }
            else
            {
                menuAction.ExecuteAction();
                System.Console.WriteLine();
            }
        }
    }
}
