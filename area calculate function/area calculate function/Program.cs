using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_calculate_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width;
                int Area;
            Console.WriteLine("Enter Height");
            height = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Enter width");
            width = Convert.ToUInt16(Console.ReadLine());   
             Area = area(height, width);
            Console.WriteLine("Area is " + Area);
            int area( int h, int w)
            {
                int a;
                a = h * w;
                return a;
            }
            Console.ReadKey();
            {
                
                }
            }
        }
    }

