using System;

class Class1
{
    static void Main(string[] args)
    {
        int huvaagdagch = 0, huvaagch = 0, hariu = 0;
        try
        {
            hariu = huvaagdagch / huvaagch;
        }
        catch (System.DivideByZeroException zail)
        {
            Console.WriteLine("{0} exception ajillav", zail);
        }
        Console.ReadLine();
    }
}