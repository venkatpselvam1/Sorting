using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSort
    {
        internal static void Sort(int[] arr)
        {
            var length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length-i-1; j++)
                {
                    if (arr[j] >arr[j+1])
                    {
                        Swap(arr, i, j);
                    }
                }
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
