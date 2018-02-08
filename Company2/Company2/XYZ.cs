using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company2
{
    class XYZ
    {
        private List<ProductIF> Products;
        private Utility Utility;

        public XYZ(Utility util)
        {
            this.Utility = util;
            Products = new List<ProductIF>();
        }
        public void AddProduct(ProductIF p)
        {
            Products.Add(p);
        }
        public void AddProduct(List<ProductIF> p)
        {
            foreach (ProductIF product in p){
                Products.Add(product);
            }
        }
        public List<ProductIF> GetProducts()
        {
            return Products;
        }

    }
}
