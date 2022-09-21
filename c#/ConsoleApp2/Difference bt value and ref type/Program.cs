using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_bt_value_and_ref_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
              int a = 10;
              int b = 20;
              Console.WriteLine("a is {0} b is {1}",a,b);

            

            modify(a, b);
            Console.WriteLine("After modification \n a is {0} b is {1}",a,b);

            Console.ReadLine();
            Console.Clear();
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < array1.Length; i++)
                Console.WriteLine(array1[i]);

            m2(array1);
            Console.WriteLine("After m2");

            for (int i = 0; i < array1.Length; i++)
                Console.WriteLine(array1[i]);

            Console.ReadLine();
        }
        static void modify(int a, int b)
        {
            a = 100;
            b = 200;
            Console.WriteLine("inside function \n a is {0} b is {1}", a, b);
        }
        static void m2(int[] ar)
        {
            ar[0] = 100;
            ar[1] = 200;
        }

    }
}

