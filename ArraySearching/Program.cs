using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySearching
{
    class Program
    {
        struct Pair
        {
            public int x;
            public int y;
        };
        static void Main(string[] args)
        {
            int[,] a = 
            {
                {3, 5,  3,  10, 5},
                {1, 4,  5,  10, 8},
                {5, 6,  9,  6,  10}, 
                {7, 8,  12, 8,  11} 
            };
            Console.WriteLine("{0} {1}", MaxOfMinInColumns(a).x, MaxOfMinInColumns(a).y);

        }
        static Pair MinInColumn(int[,] a, int col)
        {
            Pair t;
            t.x = 0;
            t.y = col;
            int min = a[t.x, t.y];
            for (int i = 1; i < a.GetLength(0); i++)
            {
                if (min > a[i, col])
                {
                    min = a[i, col];
                    t.x = i;
                }
            }
            return t;
        }
        static Pair MaxOfMinInColumns(int[,] a)
        {
            Pair t;
            t.x = MinInColumn(a, 0).x;
            t.y = 0;
            int max = a[t.x, t.y];
            for (int i = 1; i < a.GetLength(1); i++)
            {
                int xTemp = MinInColumn(a,i).x;
                if (max < a[xTemp, i])
                {
                    t.x = xTemp;
                    t.y = i;
                    max = a[t.x, t.y];
                }
            }
            return t;

        }

    }
}
