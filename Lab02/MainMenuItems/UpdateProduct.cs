using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;

namespace Lab02.MainMenuItems
{
    public class UpdateProduct : MainMenuItem
    {
        public string GetName()
        {
            return "Update a Product";
        }

        public void Run()
        {
            Public.MenuDict.PrepareMenu(Public.MenuDict.GetMenu(typeof(UpdateProduct)), false);
        }
    }
}