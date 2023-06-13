using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Interface;
using Lab05.Models;
using Lab05.Singleton;

namespace Lab05.Context
{
    public class ProductSearchContext
    {
        private Dictionary<int, Product> Products { get; set; } = ProductDict.Instance.Products;
        public ProductSearchStrategy Strategy { get; private set; }

        public void RunStrategy(){
            this.Strategy.Search(this.Products);
        }
    }
}