namespace ExceptionTutorial
{
     class TryCatchDemo1
     {
          public static void Main(string[] args)
          {
               Console.WriteLine("Start Recruiting ...");
               Console.WriteLine("Check your Age");
               int age = 50;
               try
               {
                    AgeUtils.checkAge(age);
                    Console.WriteLine("You pass!");
               }
               catch (TooYoungException e)
               {
                    Console.WriteLine("You are too young, not pass!");
                    Console.WriteLine(e.Message);
               }
               catch (TooOldException e)
               {
                    Console.WriteLine("You are too old, not pass!");
                    Console.WriteLine(e.Message);
               }
               Console.Read();
          }
     }
}