using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1,  f = 1;
            while (f < 6)
            {
                fact = fact * f;
                f++;
            }
            System.Console.WriteLine("The factorial of 6 is " + fact);

            int a = 0, b = 1,c;
            System.Console.Write(a + ", ");
            while (b < 20)
            {
                System.Console.Write(b + ", ");
                c = b + a;
                a = b;
                b = c;
            }
            System.Console.ReadLine();
        }
    }
}
