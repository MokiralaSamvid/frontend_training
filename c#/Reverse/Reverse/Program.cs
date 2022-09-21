using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter the no of inputs");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter inputs");
            p.Reverse(n, 0);
        }
        
        void Reverse(int n,int data) 
        {
            if (n == 0)
                return;
            else
            {
                Console.WriteLine("Enter next input");
                data = int.Parse(Console.ReadLine());
                
                n--;
                Reverse(n, data);
                Console.Write(data+" ");
                Console.ReadKey();
                
            }
            
        }
    }

}
