using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(); // 두 정수 입력
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        int result = A + B;
        Console.WriteLine(result); // 결과 출력
    }
}
