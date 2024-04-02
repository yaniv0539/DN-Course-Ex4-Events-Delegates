using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class InterfaceMenuTest
    {
        private Interfaces.MainMenu m_MainMenu;

        private InterfaceMenuTest()
        {
            ShowDate showDate = new ShowDate();
            Interfaces.MenuAction showDateItem = Interfaces.MenuAction.CreateMenuAction("Show Date", showDate);

            ShowTime showTime = new ShowTime();
            Interfaces.MenuAction showTimeItem = Interfaces.MenuAction.CreateMenuAction("Show Time", showTime);

            CountCapitals countCapitals = new CountCapitals();
            Interfaces.MenuAction countCapitalsItem = Interfaces.MenuAction.CreateMenuAction("Count Capitals", countCapitals);

            ShowVersion showVersion = new ShowVersion();
            Interfaces.MenuAction showVersionItem = Interfaces.MenuAction.CreateMenuAction("Show Version", showVersion);

            Interfaces.SubMenu showDateTimeMenu = Interfaces.SubMenu.CreateSubMenu("Show Date/Time");
            showDateTimeMenu.Add(showDateItem);
            showDateTimeMenu.Add(showTimeItem);

            Interfaces.SubMenu showVersionCountCapitalsMenu = Interfaces.SubMenu.CreateSubMenu("Version and Capitals");
            showVersionCountCapitalsMenu.Add(countCapitalsItem);
            showVersionCountCapitalsMenu.Add(showVersionItem);

            Interfaces.SubMenu interfaceMenu = Interfaces.SubMenu.CreateSubMenu("Interfaces Main Menu");
            interfaceMenu.Add(showDateTimeMenu);
            interfaceMenu.Add(showVersionCountCapitalsMenu);

            m_MainMenu = Interfaces.MainMenu.CreateMainMenu(interfaceMenu);
        }

        public void Show()
        {
            m_MainMenu.Show();
        }

        public static InterfaceMenuTest CreateInterfaceMenuTest()
        {
            InterfaceMenuTest interfaceMenuTest = new InterfaceMenuTest();

            return interfaceMenuTest;
        }
    }
}
