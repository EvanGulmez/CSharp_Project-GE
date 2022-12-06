using System;
// A Simple game project named " Rock Paper Scissors "in C# //
// V1.1
// Gülmez Evan M1 ESI

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();

            int Player = 0;
            int Computer = 0;

            for (int i = 0; i < 3; i++) 
            {
                int Choice = random.Next(1, 4);
            }
        }
    }
}