using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation_solver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deg;
            Console.WriteLine("Enter Degree of Equation");
            deg=int.Parse(Console.ReadLine());


            float[] coeff = new float[deg+1];
            Console.WriteLine("Enter the Coefficients of Quadratic Equation ");
            for(int i = 0; i <= deg; i++)
            {
                coeff[i] = float.Parse(Console.ReadLine());
            }
            int j = deg;
            //foreach(int i in coeff)
            //{
            //    Console.Write(" +"+i+"x^("+(j)+")");j--;
            //}
            //Console.WriteLine();
            float a ,b ;
            Console.WriteLine("Enter The value for which Equation value is Greater than 0");
            a= float.Parse(Console.ReadLine());

            Console.WriteLine("Enter The value for which Equation value is Lessthan than 0");
            b = float.Parse(Console.ReadLine());

            Program P = new Program();
            Console.WriteLine( P.EqnSolver(a,b,coeff));
            
            Console.ReadLine();
            
        }

        public float EqnSolver(float a,float b, params float[] coeff)
        {
            
            Program P = new Program();
            float x1, y = 111111.111f;float value;
            do
            {
                x1 = (a + b) / 2;
                value = P.ValueCalculator(x1, coeff);
                if (value > 0)
                { y = a; a = x1; }
                if (value < 0)
                { y = b; b = x1; }
            } while (value != 0 && y != x1);

            Console.WriteLine("The value of the function at this root is {0} ", value);
            return x1;
            Console.WriteLine();
            Console.ReadKey();
        }

        public float ValueCalculator(float x,params float[] coeff)
        {

            float f1 = 0;
            int l = coeff.Length;
            int j = 1;
            foreach (int i in coeff)
            { f1 += i * (float)(Math.Pow(x, l - j)); j++; }
            return f1;
        }
    }
}
