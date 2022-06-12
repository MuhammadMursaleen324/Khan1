using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter the age of the person");
            age = Convert.ToInt32(Console.ReadLine());
            if ( age >= 18)
            {
                Console.WriteLine("The person is eligible for vote casting");
            }
            else
            {
                Console.WriteLine("The person is not eligible for the vote casting");
            }
            Console.ReadKey();
        }
    }
}
