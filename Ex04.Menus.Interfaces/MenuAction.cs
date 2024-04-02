using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuAction : MenuItem
    {
        private IOptionSelected m_Action;

        private MenuAction(string i_ActionName, IOptionSelected i_Action) : base(i_ActionName)
        {
            m_Action = i_Action;
        }

        public static MenuAction CreateMenuAction(string i_DesiredActionName, IOptionSelected i_DesiredAction)
        {
            return new MenuAction(i_DesiredActionName, i_DesiredAction);
        }

        public void ExecuteAction()
        {
            m_Action.Invoke();
        }
    }
}
