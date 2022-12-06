﻿using System;
// A Simple game project named " Rock Paper Scissors "in C# //
// V1.1
// Gülmez Evan M1 ESI

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a random number generator to use for the computer's choices   
            Random random = new Random();

            // Counter of the number of wins for the player and computer
            int PlayerWins = 0;
            int ComputerWins = 0;

            // Play only 3 rounds
            for (int i = 0; i < 3; i++) 
            {
                // Let the player to enter their choice
                Console.WriteLine("Enter your choice (Rock, Paper, or Scissors):");
                // Pass the string in Lowercase 
                string PlayerChoice = Console.ReadLine().ToLower();
                // Add the random choice
                int ComputerChoiceNum = random.Next(1, 4);
                string ComputerChoice = "";

                if (ComputerChoiceNum == 1)
                {
                    ComputerChoice = "rock";
                }
                else if (ComputerChoiceNum == 2)
                {
                    ComputerChoice = "paper";
                }
                else
                {
                    ComputerChoice = "scissors";
                }

                // Choices
                Console.WriteLine("Player chose: " + PlayerChoice);
                Console.WriteLine("Computer chose: " + ComputerChoice);

                // Determine the winner of the round
                if (PlayerChoice == "rock" && ComputerChoice == "scissors")
                {
                    Console.WriteLine("Player Wins!");
                    PlayerWins++;
                }
                else if (PlayerChoice == "rock" && ComputerChoice == "paper")
                {
                    Console.WriteLine("Computer Wins!");
                    ComputerWins++;
                }
                else if (PlayerChoice == "paper" && ComputerChoice == "rock")
                {
                    Console.WriteLine("Player Wins!");
                    PlayerWins++;
                }
                else if (PlayerChoice == "paper" && ComputerChoice == "scissors")
                {
                    Console.WriteLine("Computer Wins!");
                    ComputerWins++;
                }
                else if (PlayerChoice == "scissors" && ComputerChoice == "rock")
                {
                    Console.WriteLine("Computer Wins!");
                    ComputerWins++;
                }
                else if (PlayerChoice == "scissors" && ComputerChoice == "paper")
                {
                    Console.WriteLine("Player Wins!");
                    PlayerWins++;
                }
                else
                {
                    Console.WriteLine("We have an Equality !");
                }

                Console.WriteLine();
            
            }
        }
    }
}