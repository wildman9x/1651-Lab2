using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04.Interface;

namespace Lab04.Singleton
{
    public class Context
    {
        private IMenuItem MenuItem { get; set; }
        public Context()
        {
        }
        private static Context _instance;
        private static readonly object _lock = new object();
        public static Context Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Context();
                    }
                    return _instance;
                }
            }
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