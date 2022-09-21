using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27thJuly2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* INTEGER IS A VALUE TYPE */ 
            int a = 10;
            int b;
            b = a;
            Console.WriteLine("The value of a is " + a + " the value of b is  " + b);
            if (!object.ReferenceEquals(a, b))
                Console.WriteLine("References of a and b are not same \nHence int is Value type");
            Console.Read();
            Console.Clear();
           
            /* STRING IS A REFERENCE TYPE */
            string s1 = "SAM";
            string s2;
            s2 = "SAM";
            Console.WriteLine($"The value of s1 is {s1} and the value of s2 is {s2}");
            if (object.ReferenceEquals(s1, s2))
                Console.WriteLine("References of s1 and s2 are same \nHence string is ref type");
            Console.ReadKey();
            Console.Clear();

            /* ARRAY IS REFERENCE TYPE */ 
            int[] ar = { 1, 2, 3, 4, 5, 6, 7 };
            int[] br = ar;
            Console.WriteLine("The values of array 'ar' are: ");
            foreach (int i in ar)
                Console.Write(i+" ");
            Console.WriteLine("\nThe values of array 'br' are: ");
            foreach(int i in br)
                Console.Write(i+" ");
            Console.WriteLine();
            if(object.ReferenceEquals (br, ar))
                Console.WriteLine("References of ar and br are same \nHence array is ref type");
            

            br[0] = 100;
            br[1] = 200;
            Console.WriteLine("After changing br see how ar got changed \nThe array ar is:");
            foreach(int i in ar)
                Console.Write(i+" ");
            
            Console.ReadKey();
            Console.Clear ();

            /* StringBUilder is a reference type */
            StringBuilder s3 = new StringBuilder("SAMVID");
            StringBuilder s4 = s3;
            Console.WriteLine($"The value of s3 is: {s3} and \nThe value of s4 is: {s4}");
            if(object.ReferenceEquals(s3, s4))
                Console.WriteLine("String buider is reference type");
            s4.Append("SHARMA");
            Console.WriteLine($"After changing s4 The value of s3 is: {s3} and \nThe value of s4 is: {s4}");
            Console.ReadKey();
        }
    }
}
