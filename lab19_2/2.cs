using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Write("Введите N: ");
            n = int.Parse(ReadLine());
            Write("Введите M: ");
            m = int.Parse(ReadLine());

            int[,] a = new int[50, 50];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Write("A[{0}][{1}] = ", i, j);
                    a[i, j] = int.Parse(ReadLine());
                }
            }
            int max = int.MinValue;
            int min = int.MaxValue;
            int maxj = 0, minj = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        maxj = j;
                    }
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        minj = j;
                    }
                }
            }
            int t;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    t = a[i, minj];
                    a[i, minj] = a[i, maxj];
                    a[i, maxj] = t;
                }
            }


            for (int i = 0; i < n; i++)
            {
                WriteLine("\n");
                for (int j = 0; j < m; j++)
                {
                    Write("{0} ", a[i, j]);
                }
            }
        }
    }
}
