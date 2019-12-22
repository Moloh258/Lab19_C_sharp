using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab19_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Write("Введите M: ");
            m = int.Parse(ReadLine());

            int[,] a = new int[50, 50];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Write("A[{0}][{1}] = ", i, j);
                    a[i, j] = int.Parse(ReadLine());
                }
            }
            int s;
            for (int i = m - 1; i > 0; i--)
            {
                s = 0;
                for (int j = 0; j < i; j++)
                {
                    s += a[m - (i - j), j];
                }
                WriteLine(s);
            }

            for (int i = 1; i < m; i++)
            {
                s = 0;
                for (int j = 0; j < i; j++)
                {
                    s += a[j, m - (i - j)];
                }
                WriteLine(s);
            }


            for (int i = 0; i < m; i++)
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
