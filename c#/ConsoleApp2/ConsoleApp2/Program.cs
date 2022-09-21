using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in a)
                Console.WriteLine(i);
            modify(a);
            Console.WriteLine("After calling function");
            foreach(int i in a)
                Console.WriteLine(i);

            Console.WriteLine("Now Strings");
            string s = "SAMVID";
            string s1 = "SAMVID";
            if(object.ReferenceEquals(s, s1))
                Console.WriteLine("String is reference type");
            Console.ReadLine();
        }

        static void modify(int[] b)
        {
            b[0] = 10; b[1] = 20; b[2]=30;
        }
    }
}
