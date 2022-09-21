using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_08_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent P = new Parent();
            Parent p = new Child();
            Child c1 = new Child();
            //Child c = new Parent();
            //Child  c2 = (Child) new Parent();
            P.Method();
            p.Method();
            c1.Method();
            //c2.Method();
            Console.ReadKey();
        }
    }
    class Parent
    {
        public virtual void Method()
        {
            Console.WriteLine("Its Parent");
        }

    }
    class Child : Parent
    {
        public override void Method()
        {
            Console.WriteLine("Its Child");
        }
    }

}
