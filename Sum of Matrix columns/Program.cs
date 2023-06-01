using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Matrix_columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the row of metrix:");
            int m= Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("enter the column of metrix:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the matrix");
            int[,] a = new int[m,n];
            int[] sum = new int[n];
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    a[i,j]= Convert.ToInt32( Console.ReadLine() );
                    Console.WriteLine("\b" );
                }
                Console.WriteLine("\n");
            }

            
                for(int j = 0; j < n; j++)
                {
                    for(int  i = 0; i < m;i++)
                    {
                        sum[j] += a[i,j];
                    }
                }
            

            Console.WriteLine("sum of columns are :\n");
            foreach(int i in sum) {
                Console.WriteLine(i);
                
            }
        }
    }
}
