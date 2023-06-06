using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04.Interface;

namespace Lab04.MenuItem.SubMenu
{
    public class Back : IMenuItem
    {
        public string Name => "Back";
        public void Run() {
            return;
        }
    }
}