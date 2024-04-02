using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private SubMenu m_Menu;

        private MainMenu(SubMenu i_Menu)
        {
            m_Menu = i_Menu;
        }

        public static MainMenu CreateMainMenu(SubMenu i_DesiredMenu)
        {
            return new MainMenu(i_DesiredMenu);
        }

        public void Show()
        {
            m_Menu.Show();
        }
    }
}
