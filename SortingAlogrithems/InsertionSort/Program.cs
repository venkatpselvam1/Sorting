﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 10, 1, 3, 7, 2, 5, 21, 17, 11 };
            InsertionSort.Sort(arr);
            Utilities.Utilities.PrintArray(arr);
        }
    }
}
