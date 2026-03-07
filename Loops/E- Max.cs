namespace ConsoleAppode
{
 class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            String[] input = Console.ReadLine().Split(' ');
            int max = 0;
            for (int i = 0; i < number; i++)
            {
                int x = int.Parse(input[i]);

                if (x > max)
                {
                    max = x;

                }


            }
            Console.WriteLine(max);
        

    }
    }
}
