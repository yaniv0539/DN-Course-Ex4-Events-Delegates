using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private string m_Name;

        public string Name
        {
            get
            {
                return m_Name;
            }
        }

        protected MenuItem(string i_Name)
        {
            m_Name = i_Name;
        }
    }
}
