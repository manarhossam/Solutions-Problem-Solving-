

using System;
class Program
{
    static void Main()
    {
        String[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        char mathe = char.Parse(input[1]);
        int B = int.Parse(input[2]);
        char equal = char.Parse(input[3]);
        int C = int.Parse(input[4]);
        int result = 0;
        if (mathe == '+')
            result = A + B;
        else if (mathe == '-')
            result = A - B;
        else if (mathe == '*')
            result = A * B;
        if (result == C)
            Console.WriteLine("Yes");
        else Console.WriteLine(result);
    }

}
