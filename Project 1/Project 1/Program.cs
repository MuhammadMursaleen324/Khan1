using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Please enter the first Number");
            num1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Both numbers are equal");
            }
            else
            { 
                Console.WriteLine("Both numbers are not equal");
            }
            Console.ReadKey();
        }
    }
}
