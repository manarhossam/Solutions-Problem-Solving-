namespace ConsoleAppode
{
 class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int password = int.Parse(Console.ReadLine());
                if (password == 1999) { 
                    Console.WriteLine("Correct");
                break; }
                else {
                    Console.WriteLine("Wrong");
                    }
            }
        }
    }
}
