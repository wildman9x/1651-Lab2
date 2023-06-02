using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04.Singleton
{
    public class ProductIDCount
    {
        private ProductIDCount()
        {
        }
        private static ProductIDCount _instance;
        private static readonly object _lock = new object();
        public static ProductIDCount Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ProductIDCount();
                    }
                    return _instance;
                }
            }
        }
        public int Count { get; set; } = 0;
        public void Increase()
        {
            this.Count++;
        }
        public void Decrease()
        {
            this.Count--;
        }
        
    }
}