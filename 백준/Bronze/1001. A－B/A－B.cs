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
        public static int Minus(int A, int B)
        {
            return (A - B);
        }

        static void Main(string[] args)
        {

                string[] input = Console.ReadLine().Split();
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);

                int result = Minus(A, B);
                Console.WriteLine(result);                     
        }
    }
}

