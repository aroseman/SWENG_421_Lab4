using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company2
{
    class Utility
    {
        String SortName;
        public Utility(string sortName)
        {
            this.SortName = sortName; 
        }
        public List<ProductIF> Sort(List<ProductIF> data)
        {
            List<ProductIF> sortedList = new List<ProductIF>();
            if(SortName != null)
            {
                var type = Type.GetType(SortName);
                Sort sorter = (Sort)Activator.CreateInstance(type);
                sortedList = sorter.sort(data);
            }
            else
            {
                Sort sorter = new QuickSort();
                sortedList = sorter.sort(data);
            }
            return sortedList;
        }
    }
}
