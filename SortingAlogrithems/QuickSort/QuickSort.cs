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
            var pivotValue = arr[start];
            var a_i = start + 1;
            var b_i = end;
            while (a_i < b_i)
            {
                if (arr[a_i]<pivotValue)
                {
                    a_i++;
                }
                if (a_i != b_i && arr[b_i] > pivotValue)
                {
                    b_i--;
                }
                if (arr[a_i] > arr[b_i])
                {
                    Utilities.Utilities.Swap(arr, a_i, b_i);
                }
            }
            var swapInd = arr[a_i] < pivotValue ? a_i : (a_i - 1);
            Utilities.Utilities.Swap(arr, a_i, start);
            return swapInd;
        }
        public static int GetPartiton2(int[] arr, int start, int end)
        {
            var pivotValue = arr[end];
            int a_i = start;
            int b_i = end - 1;
            while (a_i < b_i)
            {
                if (arr[a_i] < pivotValue)
                {
                    a_i++;
                }
                if (a_i != b_i && arr[b_i] > pivotValue)
                {
                    b_i--;
                }
                if (arr[a_i] > arr[b_i])
                {
                    Utilities.Utilities.Swap(arr, a_i, b_i);
                }
            }

            var swapInd = arr[a_i] > pivotValue ? a_i : (a_i + 1);
            Utilities.Utilities.Swap(arr, swapInd, end);
            return swapInd;
        }
        public static int GetPartiton1(int[] arr, int start, int end)
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
