using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //static을 붙여 줘야 하는 이유?
        public static double Divide(double A, double B)
        {
            return (A / B);
        }

        static void Main(string[] args)
        {

                string[] input = Console.ReadLine().Split();
            double A = double.Parse(input[0]);
            double B = double.Parse(input[1]);

            double result = Divide(A, B);
                Console.WriteLine(result);                     
        }
    }
}

