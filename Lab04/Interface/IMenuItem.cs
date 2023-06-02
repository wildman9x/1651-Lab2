using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04.Interface
{
    public interface IMenuItem
    {
        public string Name {get;}
        public void Run();
    }
}