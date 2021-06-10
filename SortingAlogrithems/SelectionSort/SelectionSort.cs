using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int smallest = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                Utilities.Utilities.Swap(arr, i, smallest);
            }
        }
    }
}
