using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Models;

namespace Lab05.Interface
{
    public interface ProductSearchStrategy
    {
        public void Search (Dictionary<int, Product> products);
    }
}