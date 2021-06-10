using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSort
    {
        public static void Sort(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            QuickSortArr(arr, start, end);
        }
        public static void QuickSortArr(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pi = GetPartiton(arr, start, end);
                QuickSortArr(arr, start, pi - 1);
                QuickSortArr(arr, pi + 1, end);
            }
        }
        public static int GetPartiton(int[] arr, int start, int end)
        {
            var pivotValue = arr[end];
            int j = start - 1;
            for (int i = start; i < end; i++)
            {
                if (arr[i] > pivotValue)
                {
                    j++;
                    Utilities.Utilities.Swap(arr, i, j);
                }
            }
            Utilities.Utilities.Swap(arr, j+1, end);
            return j + 1;
        }
    }
}
