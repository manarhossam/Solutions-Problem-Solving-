namespace ConsoleAppode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 2)
            {
                Console.WriteLine(-1);
            }
            else
            {
                for (int i = 2; i <= number; i += 2)
                {
                    Console.WriteLine(i);

                }
            }
        
    }
    }
}
