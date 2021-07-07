using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public static class CyclicRotation
    {
        public static int[] GetCyclicRotation(int[] a, int b)
        {
            var c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c [(i + b % a.Length)] = a[i];
            }
            return c;
        }
    }
}
