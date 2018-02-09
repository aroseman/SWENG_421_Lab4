using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company2
{
    class BubbleSort : Sort
    {
        public BubbleSort(String sortName) : base(sortName) { }
        
        public  override List<ProductIF> sort(List<ProductIF> data)
        {

            ProductIF temp;

            for (int write = 0; write < data.Count; write++)
            {
                for (int sort = 0; sort < data.Count - 1; sort++)
                {
                    if (data[sort].GetPrice() > data[sort + 1].GetPrice())
                    {
                        temp = data[sort + 1];
                        data[sort + 1] = data[sort];
                        data[sort] = temp;
                    }
                }
            }
            return data;
        }

        

    }
}
