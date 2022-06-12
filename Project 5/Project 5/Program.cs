using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("Enter first Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third Number");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The first Number is the maximuum" + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The second Number is the maximum " + num2);
            }
            else
            {
                Console.WriteLine("The third Number is maxiums" + num3);
            }
            Console.ReadKey();
        }
    }
}
