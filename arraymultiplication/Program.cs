using System;

namespace arraymultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int i, n,j;
            for (i = 0; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    n = a[i] * j;


                    Console.WriteLine(a[i]+" x "+j+" = "+n);
                }
            }
        } 
    }
}
