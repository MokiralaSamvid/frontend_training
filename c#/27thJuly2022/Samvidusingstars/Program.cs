using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samvidusingstars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" ");
            for (int i = 1; i <= 5; i++)
                Console.Write(" *");
            Console.WriteLine();

            for (int i = 1; i <= 2; i++)
                Console.WriteLine("  *");

            Console.Write(" ");
            for (int i = 1; i <= 5; i++)
                Console.Write(" *");
            Console.WriteLine();

            for (int i = 1; i <= 2; i++)
                Console.WriteLine("          *");

            Console.Write(" ");
            for (int i = 1; i <= 5; i++)
                Console.Write(" *");
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                
                for (int s = 5-i; s > 0; s--)
                    Console.Write(" ");
                
                //if (i == 3)
                //{
                //    for (int j = 0; j <i;j++)
                //        Console.Write("* ");
                //    continue;
                //}
                Console.Write(" *");
                for (int s =2*i-2;s>0;s--)
                    Console.Write(" ");
                Console.WriteLine("*");
            }
            int n = 5;
            Console.WriteLine("   ");
            for(int i= 1; i <= n; i++)
            {
                if (i == 1)
                {
                    for (int j = n; j >= 1; j--)
                        Console.Write(" *");
                    Console.WriteLine();
                    continue;
                }
                
                Console.WriteLine(" *   *   * ");
            }
            Console.WriteLine();
            for (int i = 5; i > 0; i--)
            {
                for (int s = 5 - i; s > 0; s--)
                    Console.Write(" ");
                Console.Write(" *");
                for (int s = 2 * i - 2; s > 0; s--)
                    Console.Write(" ");
                Console.WriteLine("*");
               

                //if (i == 3)
                //{
                //    for (int j = 0; j <i;j++)
                //        Console.Write("* ");
                //    continue;
                //}
               
            }
            Console.WriteLine();
            for(int i = 5; i > 0; i--)
            {
                for(int j=1;j<=5;j++)
                    Console.Write(" ");
                Console.Write("*");
                for (int j = 1; j <= 3; j++)
                    Console.Write(" ");
                Console.WriteLine();
            
            }
            for (int j = 1; j <=5; j++)
            {   if (j == 1 || j == 5)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.Write(" *");
                    }
                }
                else
                    Console.Write(" *        *");
                
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
}
