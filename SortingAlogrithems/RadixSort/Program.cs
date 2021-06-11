using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 109, 100, 39, 19,10, 1, 3, 7, 2, 5, 21, 17, 11, 1009, 1000 };
            RadixSort.Sort(arr);
            Utilities.Utilities.PrintArray(arr);
        }
    }
}
