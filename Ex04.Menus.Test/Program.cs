﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            DelegateMenuTest delegateMainMenuTest = DelegateMenuTest.CreateDelegateMenuTest();
            InterfaceMenuTest interfaceMainMenuTest = InterfaceMenuTest.CreateInterfaceMenuTest();

            delegateMainMenuTest.Show();
            interfaceMainMenuTest.Show();
        }
    }
}
