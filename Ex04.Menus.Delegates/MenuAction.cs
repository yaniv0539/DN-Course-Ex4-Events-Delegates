using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public delegate void SelectEventHandler();

    public class MenuAction : MenuItem
    {
        public event SelectEventHandler OptionSelected;

        private MenuAction(string i_ActionName) : base(i_ActionName)
        {
        }

        public static MenuAction CreateMenuAction(string i_DesiredActionName)
        {
            return new MenuAction(i_DesiredActionName);
        }

        protected virtual void OnOptionSelected()
        {
            if(OptionSelected != null)
            {
                OptionSelected.Invoke();
            }
        }

        public void doWhenOptionWasSelected()
        {
            OnOptionSelected();
        }
    }
}
