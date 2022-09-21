using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of rows");
            int n = int.Parse(Console.ReadLine());
            for (int j = 1; j <=n; j++)
            {
                for(int k=1;k<=n-j+1;k++)
                    Console.Write(" ");
                for (int i = 1; i <=j; i++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            for(int i = 1; i <= n; i++)
            {
                for(int k=0;k<=i;k++)
                    Console.Write(" ");
                for (int j = n - i; j > 0; j--)
                    Console.Write("* ");
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
