using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company2
{
    abstract class Sort : Utility
    {
        public Sort(string sortName) : base(sortName)
        {
        }

        public abstract List<ProductIF> sort(List<ProductIF> data);

    }
}
