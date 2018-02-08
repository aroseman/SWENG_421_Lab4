using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company2
{
    class Program
    {
        static void Main(string[] args)
        {
            XYZ company = new XYZ(new Utility());
            company.AddProduct(new Product("AHX123", "Red Shoe", 12.50));
            
        }
    }
}
