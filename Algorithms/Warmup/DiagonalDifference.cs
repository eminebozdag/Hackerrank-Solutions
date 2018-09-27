using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i,j;
            int sum1 = 0;
            int sum2 = 0;

            int[,] ar = new int[n,n];
            for (i = 0; i <n; i++) //enter number
            {
                for ( j = 0; j < n; j++) 
                    ar[i, j] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n;  i++) //read number
            {
                 for ( j = 0; j < n; j++)
                {
                    if (i == j)
                        sum1 += ar[i, j];                                          
                }
            }
            sum2 = ar[0, 2] + ar[1, 1] + ar[2, 0];
            int tot = sum1 - sum2;
            if (tot < 0)
                Console.WriteLine(tot * -1);
            else
                Console.WriteLine(tot);
            Console.ReadLine();
        }
    }
}
