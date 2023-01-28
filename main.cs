using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("What day of the week is it =?");
        //int day = 1;
        string day = Console.ReadLine();
        switch (day)
        {
            case "1":
                Console.WriteLine("Monday is");
                Console.WriteLine("?");
                break;
            case "2":
                Console.WriteLine("Tuesday is");
                Console.WriteLine("!");
                break;
            case "3":
                Console.WriteLine("Whdnesday is");
                Console.WriteLine("@");
                break;
            case "4":
                Console.WriteLine("Thursday is");
                Console.WriteLine("$");
                break;
            case "5":
                Console.WriteLine("Friday is");
                Console.WriteLine("|");
                break;
            case "6":
                Console.WriteLine("Saturday is");
                Console.WriteLine("&");
                break;
            case "7":
                Console.WriteLine("Sunday is");
                Console.WriteLine("%");
                break;
        }
    }
}