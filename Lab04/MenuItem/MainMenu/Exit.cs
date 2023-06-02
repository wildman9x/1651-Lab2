using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04.Interface;

namespace Lab04.MenuItem.MainMenu
{
    public class Exit : IMenuItem
    {
        public string Name => "Exit";

        public void Run()
        {
            Environment.Exit(0);
        }
    }
}