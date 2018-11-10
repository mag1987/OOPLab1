using System;
//using System.Drawing;
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
                {3, 5,  3,  10, 7},
                {1, 4,  5,  10, 8},
                {5, 6,  9,  6,  10}, 
                {7, 8,  12, 8,  11} //, {9,10,1,3,7}
            };
            int[] b = {4,3,67,2,7 };
            Console.WriteLine("{0} {1}",a.GetLength(0),a.GetLength(1));
            //Console.WriteLine(b.Min);

            Console.WriteLine("{0} {1}", GetMaxInMinInColumn(a).x, GetMaxInMinInColumn(a).y);
        }
        static Pair GetMaxInMinInColumn( int[,] a)
        {
            Pair t;
            t.x = 0;
            t.y = 0;
            int minCol = a[0,0];
            int maxRow = a[0, 0];
            int old =0;
            for (int j =0; j < a.GetLength(1); j++)
            {
                minCol = a[0,j];
                for (int i =0; i<a.GetLength(0); i++)
                {
                    if (minCol > a[i, j])
                    {
                        minCol = a[i, j];
                        t.x = i;
                        old = i;
                    }
                }
                if (j == 0)
                {
                    maxRow = minCol;
                    t.y = 0;
                }
                else
                {
                    if (maxRow < minCol)
                    {
                        maxRow = minCol;
                        t.y = j;
                        t.x = old;
                    }
                }
            }
            return t;
        }
        
    }
}
