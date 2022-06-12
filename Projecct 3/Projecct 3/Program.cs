using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecct_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());   
            if(number/2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else if(number/2 != 0)
            {
                Console.WriteLine("the number is Odd");
            }
            Console.ReadKey();
        }
    }
}
