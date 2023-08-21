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

            int NewYear = Int32.Parse(input[0]);

            Console.WriteLine(NewYear - 543);
  
        }
    }
}

