namespace Exception
{
    class HelloException
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Three");
            int value = 10 / 2; // This division no problem.
            Console.WriteLine("Two");
            value = 10 / 1; // This division no problem.
            Console.WriteLine("One");
            int d = 0;
            try
            {
                value = 10 / d; // This division has problem, divided by 0.
            }
            catch (DivideByZeroException e){
                Console.WriteLine("Error " + e.Message);
            }
            Console.WriteLine("Let's go!");
            Console.Read();
        }
    }
}
