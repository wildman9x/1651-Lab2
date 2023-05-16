using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03.Interface;
using Lab03.Public;

namespace Lab03.Menu
{
    public class SearchStudent : MainMenuItem
    {
        public string GetName()
        {
            return "Search Student";
        }

        public void Run()
        {
            MenuDict.PrepareMenu(MenuDict.GetMenu(typeof(SearchStudentMenuItem)), false);
        }
    }
}