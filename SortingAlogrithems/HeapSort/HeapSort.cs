using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    public class HeapSort
    {
        public static void Sort(int[] arr)
        {
            var length = arr.Length;
            var half = length / 2 - 1;
            for (int i = half; i >= 0; i--)
            {
                Heapify(arr, length - 1, i);
            }
            for (int i = length - 1; i >= 0; i--)
            {
                Swap(arr, i, 0);
                Heapify(arr, i-1, 0);
            }
        }
        public static void Heapify(int[] arr, int n, int ind)
        {
            int leftInd = 2 * ind + 1;
            int rightInd = 2 * ind + 2;
            int largetInd = ind;
            if ( leftInd <= n && arr[leftInd] > arr[largetInd])
            {
                largetInd = leftInd;
            }

            if (rightInd <= n && arr[rightInd] > arr[largetInd])
            {
                largetInd = rightInd;
            }

            if (largetInd != ind)
            {
                Swap(arr, ind, largetInd);
                Heapify(arr, n, largetInd);
            }
        }
        public static void Swap(int[] arr, int a, int b)
        {
            var temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
