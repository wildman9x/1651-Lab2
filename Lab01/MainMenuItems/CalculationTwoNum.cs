using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;
using Lab01.Public;

namespace Lab01.MainMenuItems
{
    public class CalculationTwoNum : MainMenuItem
    {
        public string GetName()
        {
            return "Calculation of two numbers";
        }

        public void Run()
        {
            Dictionary<int, Type> calculationTwoNumMenuItems = MenuDict.GetMenu(typeof(CalculationTwoNumMenuItem));
            PrintMenu.Run(calculationTwoNumMenuItems);
            Option.Choose(calculationTwoNumMenuItems, pressKey: false);
        }
    }
}