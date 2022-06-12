using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Assingment_no_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter First Numbers");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second Numbers");
            y = Convert.ToInt16(Console.ReadLine());
            max(x, y);
                Console.WriteLine();
            void max(int a, int b)
            {
                if (a > b)
                {
                    Console.WriteLine("Maximium number is " + a);
                }
                else
                {
                    Console.WriteLine("Maximium number is " + b);
                }
                Console.ReadKey();
            }
       
        }
        }
    }

