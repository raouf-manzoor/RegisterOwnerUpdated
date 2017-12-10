﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem26_10_17
{
    public static class Base36Converter
    {
        public static string ConvertToBaseK(int val)
        {

            int size = val.ToString().Length;
            var baseDef = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var result = string.Empty;
            int targetBase = baseDef.Length;

            do
            {
                result = baseDef[val % targetBase] + result;
                val = val / targetBase;
            }
            while (val > 0);

            return result.ToString().PadLeft(size, '0');

        }

        public static int ConvertToBase10(string str)
        {
            var baseDef = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            double result = 0;
            for (int idx = 0; idx < str.Length; idx++)
            {
                var idxOfChar = baseDef.IndexOf(str[idx]);
                result += idxOfChar * System.Math.Pow(baseDef.Length, (str.Length - 1) - idx);
            }

            return (int)result;
        }
    }
}