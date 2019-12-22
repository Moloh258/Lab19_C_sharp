using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab19_4
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

            for (int i = 0; i < n; i++)
            {
                WriteLine("\n");
                for (int j = 0; j < m; j++)
                {
                    Write("{0} ", a[i, j]);
                }
            }
            WriteLine();

            int t;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    if (a[i, 1] > a[j, 1])
                    {
                        for (int q = 0; q < n; q++)
                        {
                            t = a[i, q];
                            a[i, q] = a[j, q];
                            a[j, q] = t;
                        }
                    }

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
