using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string A = input[0];

            int NumA = Int32.Parse(A);

            if (90<=NumA && NumA <=100)
            {
                Console.WriteLine("A");
            }else if (80<=NumA && NumA<=89)
            {
                Console.WriteLine("B");
            }else if(70 <=NumA && NumA<=79)
            {
                Console.WriteLine("C");
            }else if (60 <= NumA && NumA <= 69)
            {
                Console.WriteLine("D");
            }else
            {
                Console.WriteLine("F");
            }
            
        }
    }
}

