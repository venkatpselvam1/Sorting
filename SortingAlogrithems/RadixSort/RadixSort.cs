using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    class RadixSort
    {
        public static void Sort(int[] arr)
        {
            var maxVal = Utilities.Utilities.GetMax(arr);
            var maxDigit = Utilities.Utilities.GetDigitCount(maxVal);
            for (int i = 1; i <= maxDigit; i++)
            {
                SortByDigit(arr, i);
                Utilities.Utilities.PrintArray(arr);
            }
        }
        public static void SortByDigit(int[] arr, int digitPlace)
        {
            var length = arr.Length;
            for (int i = 0; i < length-1; i++)
            {
                var minInd = i;
                for (int j = i+1; j < length; j++)
                {
                    if (Utilities.Utilities.GetDigitValue(arr[minInd], digitPlace) > Utilities.Utilities.GetDigitValue(arr[j], digitPlace))
                    {
                        minInd = j;
                    }
                }
                Utilities.Utilities.Swap(arr, i, minInd);
            }
        }
    }
}
