using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++ ) 
            {
                if (i == 5)
                    continue;
                Console.WriteLine($"Понеділок,івторок,середа,четверг,п'ятниця,субота,неділя{i}");

            }                
        }
    }
}
