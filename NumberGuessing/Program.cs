internal class Program
{
    private static void Main(string[] args)
    {
        Random num = new Random();
        int minNum = num.Next(0, 100);

        bool win = false;

        do
        {
            Console.WriteLine("Quess a number in range 0 and 100");
            string a = Console.ReadLine();

            int i = int.Parse(a);

            if(i > minNum)
            {
                Console.WriteLine("Too high");
            } else if (i<minNum) {
                Console.WriteLine("Too low");

            } else if (i == minNum)
            {
                Console.WriteLine("Congrats! You wiiiiin! ");
                win = true;
            }

        } while (win == false);

        Console.WriteLine("Thanks for playing. :)");

    }
}