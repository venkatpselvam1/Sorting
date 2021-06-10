using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSort
    {
        public static void Sort(int[] arr)
        {
            SortArr(arr, 0, arr.Length-1);
        }
        public static void SortArr(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int mid = (start + end) / 2;
            SortArr(arr, start, mid);
            SortArr(arr, mid+1, end);
            MergeArr(arr, start, end);
        }
        public static void MergeArr(int[] arr, int start, int end)
        {
            var length = end - start + 1;
            int mid = (start + end) / 2;
            int[] tempArr = new int[length];
            int a_i = start;
            int b_i = mid + 1;
            for (int i = 0; i < length; i++)
            {
                if ((a_i <= mid && b_i <= end && arr[a_i] < arr[b_i]) || b_i > end)
                {
                    tempArr[i] = arr[a_i];
                    a_i++;
                }
                else
                {
                    tempArr[i] = arr[b_i];
                    b_i++;
                }
            }
            for (int i = 0; i < length; i++)
            {
                arr[i + start] = tempArr[i];
            }
        }
    }
}
