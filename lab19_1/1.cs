using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab19_1
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
            int min = int.MaxValue;
            int max = int.MinValue;
            int maxi = 0, maxj = 0, mini = 0, minj = 0, t;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        mini = i;
                        minj = j;
                    }
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        maxi = i;
                        maxj = j;
                    }
                }
                t = a[maxi, maxj];
                a[maxi, maxj] = a[mini, minj];
                a[mini, minj] = t;
                min = int.MaxValue;
                max = int.MinValue;
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
