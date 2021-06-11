using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class ShellSort
    {
        public static void Sort(int[] arr)
        {
            var length = arr.Length;
            var halfLength = length / 2;
            for (int k = halfLength; k > 0; k=k/2)
            {
                for (int i = 0; i < length; i++)
                {
                    var smallestInd = i;
                    for (int j = i + k; j < length; j=j+k)
                    {
                        if (arr[smallestInd] > arr[j])
                        {
                            smallestInd = j;
                        }
                    }
                    Utilities.Utilities.Swap(arr, i, smallestInd);
                }
            }
        }
    }
}
