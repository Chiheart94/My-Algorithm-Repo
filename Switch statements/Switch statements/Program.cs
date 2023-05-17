using System;

namespace switchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOfTheWeek = 5;

            switch(daysOfTheWeek)
            {
                case 1:
                    Console.WriteLine("chichi");
                    break;
                    case 2:
                    Console.WriteLine("monday");
                    break;
                    case 3:
                    Console.WriteLine("tuesday");
                    break;
                    case 4:
                    Console.WriteLine("wednesday");
                    break;
                    case 5:
                    Console.WriteLine("thursday");
                    break;
                    case 6:
                    Console.WriteLine("friday");
                    break;
                    case 7:
                    Console.WriteLine("saturday");
                    break;


            }
        }
    }
}