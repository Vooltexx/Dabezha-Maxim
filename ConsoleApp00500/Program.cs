using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp00500
{
    class Program
    {
        static void Main(string[] args)
        {
            double lowerBound = 0;
            double upperBound = 2;
            double stepSize = 0.2;


            Console.WriteLine("x\tf(x)");
            for (double x = lowerBound; x <= upperBound; x += stepSize)      
            {      
                double result = (x);
                Console.WriteLine(Math.Sqrt(x) / (x + 1));
                Console.WriteLine($"{x}\t{result}");
            }
                Console.ReadKey();
        }
    }
}
