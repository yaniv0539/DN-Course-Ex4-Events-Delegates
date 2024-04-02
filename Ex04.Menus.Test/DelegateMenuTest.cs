using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class DelegateMenuTest
    {
        private Delegates.MainMenu m_MainMenu;

        private DelegateMenuTest()
        {
            Delegates.MenuAction showDateItem = Delegates.MenuAction.CreateMenuAction("Show Date");
            showDateItem.OptionSelected += showDateItem_OptionSelected;

            Delegates.MenuAction showTimeItem = Delegates.MenuAction.CreateMenuAction("Show Time");
            showTimeItem.OptionSelected += showTimeItem_OptionSelected;

            Delegates.MenuAction countCapitalsItem = Delegates.MenuAction.CreateMenuAction("Count Capitals");
            countCapitalsItem.OptionSelected += countCapitalsItem_OptionSelected;

            Delegates.MenuAction showVersionItem = Delegates.MenuAction.CreateMenuAction("Show Version");
            showVersionItem.OptionSelected += showVersionItem_OptionSelected;

            Delegates.SubMenu showDateTimeMenu = Delegates.SubMenu.CreateSubMenu("Show Date/Time");
            showDateTimeMenu.Add(showDateItem);
            showDateTimeMenu.Add(showTimeItem);

            Delegates.SubMenu showVersionCountCapitalsMenu = Delegates.SubMenu.CreateSubMenu("Version and Capitals");
            showVersionCountCapitalsMenu.Add(countCapitalsItem);
            showVersionCountCapitalsMenu.Add(showVersionItem);

            Delegates.SubMenu delegateMenu = Delegates.SubMenu.CreateSubMenu("Delegates Main Menu");
            delegateMenu.Add(showDateTimeMenu);
            delegateMenu.Add(showVersionCountCapitalsMenu);

            m_MainMenu = Delegates.MainMenu.CreateMainMenu(delegateMenu);
        }

        public void Show()
        {
            m_MainMenu.Show();
        }

        public static DelegateMenuTest CreateDelegateMenuTest()
        {
            DelegateMenuTest delegateMainTest = new DelegateMenuTest();

            return delegateMainTest;
        }

        private void showDateItem_OptionSelected()
        {
            ShowDate.DisplayDate();
        }

        private void showTimeItem_OptionSelected()
        {
            ShowTime.DisplayTime();
        }

        private void showVersionItem_OptionSelected()
        {
            ShowVersion.DisplayVersion();
        }

        private void countCapitalsItem_OptionSelected()
        {
            CountCapitals.CountCapitalLettersInSentence();
        }
    }
}
