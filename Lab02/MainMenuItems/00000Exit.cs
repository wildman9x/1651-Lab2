using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;

namespace Lab02.MainMenuItems
{
    public class Exit : MainMenuItem
    {
        public string GetName()
        {
            return "Exit";
        }

        public void Run()
        {
            Environment.Exit(0);
        }
    }
}