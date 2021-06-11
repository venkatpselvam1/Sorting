using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Utilities
    {
        public static void Swap(int[] arr, int a, int b)
        {
            var temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        public static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public static int GetDigitCount(int num)
        {
            var ans = 0;
            while (num > 0)
            {
                ans++;
                num /= 10;
            }
            return ans;
        }
        public static int GetDigitValue(int num, int digitPlace)
        {
            int ans = (int)(num % Math.Pow(10, digitPlace) / Math.Pow(10, digitPlace - 1));
            
            return ans;
        }
    }
}
