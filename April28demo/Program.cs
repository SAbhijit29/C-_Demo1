using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April28demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum of two numbers
            int n1, n2, sum ;
            Console.Write("Enter first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            //Sum of two numbers program

            sum = n1 + n2;
            Console.Write("\nSum of {0} and {1} is {2}\n", n1, n2, sum);

            Console.Write("Enter key to exit....");
            Console.Read();
        }
    }
}
