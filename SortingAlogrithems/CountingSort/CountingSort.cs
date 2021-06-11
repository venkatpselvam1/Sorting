using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort
{
    class CountingSort
    {
        public static void Sort(int[] arr)
        {
            Array.Sort(arr);
            var max = Utilities.Utilities.GetMax(arr);
            var countArr = new int[max + 1];

            int length = arr.Length;
            for (int j = 0; j < length; j++)
            {
                countArr[arr[j]]++;
            }
            for (int i = 1; i <= max; i++)
            {
                countArr[i] += countArr[i - 1];
            }
            for (int i = 0; i <= max; i++)
            {
                if(countArr[i] > 0)
                {
                    arr[countArr[i]-1] = i;
                }
            }
        }
    }
}
