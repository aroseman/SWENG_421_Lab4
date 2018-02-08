using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company2
{
    class Product : ProductIF
    {
        private string ID;
        private string Name;
        private double Price;

        public Product(string id, string name, double price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }
        public string GetID()
        {
            return this.ID;
        }

        public string GetName()
        {
            return this.Name;
        }

        public double GetPrice()
        {
            return this.Price;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetPrice(double price)
        {
            this.Price = price;
        }
    }
}
