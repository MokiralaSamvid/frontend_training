using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28th_July_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            //Console.WriteLine(obj.MethodAdd(10, 20));
            //Console.WriteLine(obj.MethodAdd(10, 20,30));
            //Console.WriteLine(obj.MethodAdd(10, 20, 30,40,100,200,300));
            //Console.WriteLine(obj.MethodDifference(10, 20));
            Console.WriteLine("no of neg values in array are: "+obj.NegArray(10, -20, 30, 40, -50, 60, -6));

            int[] arr = new int[5];
            Console.ReadKey();
        }
    }
    class A
    {
        public int MethodAdd(params int[] arr)
        {
            int sum=0;
            foreach (int i in arr)
                sum+=i;
            return sum;

        }
        public int MethodDifference(params int[] arr) {
            int diff = 2*arr[0];
            foreach (int i in arr)
            {
                diff -= i;
                Console.WriteLine(diff);
            } 
            return diff;
        }
        public int NegArray(params int[] arr)
        {
            int c = 0;
            foreach (int i in arr)
            {
                if (i < 0) c++;
            }
            return c;
        }
    }
}
