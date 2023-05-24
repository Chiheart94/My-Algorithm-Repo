using System;

namespace switchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char daysOfTheWeek = 'D';

            switch(daysOfTheWeek)
            {
                case 'A':
                    Console.WriteLine("chichi");
                    break;
                    case 'B':
                    Console.WriteLine("monday");
                    break;
                    case 'C':
                    Console.WriteLine("tuesday");
                    break;
                    case 'D':
                    Console.WriteLine("wednesday");
                    break;
                    case 'E':
                    Console.WriteLine("thursday");
                    break;
                    case 'F':
                    Console.WriteLine("friday");
                    break;
                    case 'G':
                    Console.WriteLine("saturday");
                    break;


            }
        }
    }
}