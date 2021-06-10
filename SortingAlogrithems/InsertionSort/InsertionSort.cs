using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace InsertionSort
{
    public class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                bool canSwap = false;
                for (int j = 0; j < i; j++)
                {
                    if (!canSwap && arr[j] > arr[i])
                    {
                        canSwap = true;
                    }
                    if (canSwap)
                    {
                        Utilities.Utilities.Swap(arr, j, i);
                    }
                }
            }
        }
    }
}
