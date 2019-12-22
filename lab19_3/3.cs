using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab19_3
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
            int t;
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < m / 2; j++)
                {
                    t = a[i, j];
                    a[i, j] = a[i + n / 2, j + m / 2];
                    a[i + n / 2, j + m / 2] = t;
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
