using System;
   public class Program
    {
        public static void Main(string[] args)
        {
			string string_line;
            string_line = Convert.ToString(Console.ReadLine());
            int counter = 0;
            foreach (char c in string_line)
            {
                if (c == '+')
                {
                    counter++;
                }
                else if (c == '*')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
