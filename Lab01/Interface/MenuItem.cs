using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01.Interface
{
    public interface MenuItem
    {
        public string GetName();
        public void Run();
    }
}