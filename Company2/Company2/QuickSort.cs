using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company2
{
    class QuickSort : Sort
    {
        Product[] productArray;
        public QuickSort(string sortName) : base(sortName)
        {
        }

        public override List<ProductIF> Sort(List<Product> data)
        {
            //turns the product list into an array for easier sorting. 
            productArray = data.ToArray();

            if (SortName != null)
            {
                Console.WriteLine("Does the QuickSort");



            }
            return null;
        }
        private void mySort(int left, int right)
        {
            if (left < right)
            {
                int pivot = parti(left, right);

                if (pivot > 1)
                {
                    mySort(left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    mySort(pivot + 1, right);
                }
            }



        }
        private int parti(int left, int right)
        {
            int pivot = productArray[left].GetID();
            while (true)
            {
                while (productArray[left].GetID() < pivot)
                {
                    left++;
                }
                while (productArray[right].GetID() > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (productArray[left] == productArray[right])
                        return right;

                    Product temp = productArray[left];
                    productArray[left] = productArray[right];
                    productArray[right] = temp;
                }
                else
                {
                    return right;
                }





            }
        }
    }
}
