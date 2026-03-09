using System;
internal class Program
{
    static void Main(string[] args)
    {
        String[] input = Console.ReadLine().Split(' ');
        long A = long.Parse(input[0]);
        long B = long.Parse(input[1]);
        long C = long.Parse(input[2]);
        long D = long.Parse(input[3]);
        long result = 0;
        result = (A % 100) * (B % 100) * (C % 100) * (D % 100);
        Console.WriteLine((result % 100).ToString("D2"));

    }
}
