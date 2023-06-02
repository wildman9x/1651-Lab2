using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04.Interface;

namespace Lab04
{
    public class Context
    {
        private IMenuItem MenuItem { get; set; }
        public Context()
        {
        }
        public Context(IMenuItem menuItem)
        {
            this.MenuItem = menuItem;
        }
        public void SetStrategy(IMenuItem menuItem)
        {
            this.MenuItem = menuItem;
        }
        public void RunStrategy()
        {
            this.MenuItem.Run();
        }

    }
}