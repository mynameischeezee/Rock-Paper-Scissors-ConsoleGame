﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class ArrayExtension
    {
        public static IEnumerable<T> SliceRow<T>(this T[,] array, int row)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                yield return array[row, i];
            }
        }
    }
}
