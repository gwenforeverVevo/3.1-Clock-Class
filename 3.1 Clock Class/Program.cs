namespace _3._1_Clock_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();


            for (int i = 0; i < 3600; i++)
            {
                clock.tick();
                Console.WriteLine(clock.getTime());
            }

        }
    }
}
