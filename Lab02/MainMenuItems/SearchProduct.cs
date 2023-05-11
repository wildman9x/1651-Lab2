using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;

namespace Lab02.MainMenuItems
{
    public class SearchProduct : MainMenuItem
    {
        public string GetName()
        {
            return "Search for a Product by name";
        }

        public void Run()
        {
            Public.MenuDict.PrepareMenu(Public.MenuDict.GetMenu(typeof(SearchProducts)), false);
        }
    }
}