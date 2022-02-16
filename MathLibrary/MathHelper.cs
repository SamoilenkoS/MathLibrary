using System;

namespace MathLibrary
{
    public class MathHelper
    {
        public static int Max(int a, int b, int c)
        {
            return a > b ? (a > c ? a : c) : (b > c ? b : c);
        }
    }
}
