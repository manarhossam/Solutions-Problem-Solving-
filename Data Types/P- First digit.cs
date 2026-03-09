using System;
class Program
{
    static void Main()
    {
        String number = Console.ReadLine();
        int firstDigit = int.Parse(number[0].ToString());

        if (firstDigit % 2 == 0)
        {
            Console.WriteLine("EVEN");
        }
        else { Console.WriteLine("ODD"); }
    }
}