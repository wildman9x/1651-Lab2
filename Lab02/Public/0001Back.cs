using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;

namespace Lab02.Public
{
    public class Back : MenuItem
    {
        public string GetName()
        {
            return "Back";
        }

        public void Run()
        {
            return;
        }
    }
}