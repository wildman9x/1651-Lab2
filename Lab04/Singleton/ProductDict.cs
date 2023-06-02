using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04.Model;

namespace Lab04.Singleton
{
    public class ProductDict
    {
        private ProductDict()
        {
        }
        private static ProductDict _instance;
        private static readonly object _lock = new object();
        public static ProductDict Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ProductDict();
                    }
                    return _instance;
                }
            }
        }
        public Dictionary<int, Product> Products { get; set; } = new ();
        public void Add(Product product)
        {
            this.Products.Add(product.ID, product);
        }
        public void Remove(int id)
        {
            this.Products.Remove(id);
        }
        public void Update(int id, Product product)
        {
            this.Products[id] = product;
        }
        public Product Get(int id)
        {
            return this.Products[id];
        }
        public List<Product> GetAll()
        {
            return this.Products.Values.ToList();
        }

    }
}