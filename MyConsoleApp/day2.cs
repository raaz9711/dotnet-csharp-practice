namespace MyConsoleApp
{
    public static class Day2
    {
       public static void P1()
    {
        Console.WriteLine("Guess the Number :");

        int inputNum = Convert.ToInt32(Console.ReadLine());
        Random random = new();
        int genNum = random.Next(1,11);

        if(inputNum == genNum)
            {
                Console.WriteLine("WIN");
            }
        else if(inputNum > genNum)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Too Low!");
            }
    } 
    public static void P2()
        {
            Console.WriteLine("How many Fibanacci Numbers ?");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=== Fibanaci Series");

            long a = 0, b = 1;

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"{a}");
                long next = a + b;
                a = b;
                b = next;
            }
        }
    }
}