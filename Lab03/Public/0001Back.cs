using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03.Interface;

namespace Lab03.Public
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