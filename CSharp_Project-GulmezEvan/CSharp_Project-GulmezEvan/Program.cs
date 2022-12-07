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
            // Create a random number generator to use for the computer's choices   
            Random random = new Random();

            // Counter of the number of wins for the player and computer
            int PlayerWins = 0;
            int ComputerWins = 0;

            // Play only 3 rounds
            for (int i = 0; i < 3; i++) 
            {
                string PlayerChoice=" ";
                // Variables of Try catch Verification
                bool passed = false;
                bool verify = false;
                
                while (passed == false)
                {
                    // Let the player to enter their choice
                    Console.WriteLine("Enter your choice (Rock, Paper, or Scissors):");
                    try
                    {
                        // Pass the string in Lowercase 
                        PlayerChoice = Console.ReadLine().ToLower();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Missing Fields");
                    }
                    finally
                    {
                        string[] data = new string[3];
                        data[0] = "rock";
                        data[1] = "paper";
                        data[2] = "scissors";
                        for (int n = 0; n <3 ; n++) 
                        {
                            if (data[n] == PlayerChoice)
                            {
                                verify = true;
                            }
                        }

                        if (!verify)
                        {
                            Console.WriteLine("Missing Fields");
                            passed = false;
                        }
                        else
                        {
                            passed = true;
                        }
                    }
                }
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
                else if (ComputerChoiceNum == 3)
                {
                    ComputerChoice = "scissors";
                }


                // Display Choices
                Console.WriteLine(Environment.NewLine + "Player chose: " + PlayerChoice);
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
                else if (PlayerChoice == "scissors" && ComputerChoice == "scissors" || PlayerChoice == "paper" && ComputerChoice == "paper" || PlayerChoice == "rock" && ComputerChoice == "rock")
                {
                    Console.WriteLine("We have an Equality !");
                }
                else
                {
                    Console.WriteLine("Missing fields");
                }

                Console.WriteLine();

                // Display the overall winner
                Console.WriteLine("Player wins: " + PlayerWins);
                Console.WriteLine("Computer wins: " + ComputerWins);
            }

            // Determinate who win between the player or the computer
            if (PlayerWins > ComputerWins)
            {
                Console.WriteLine(Environment.NewLine +"C################ PLAYER WINS THE GAME ! C###################");
            }
            else if (PlayerWins < ComputerWins)
            {
                Console.WriteLine(Environment.NewLine + "C################ COMPUTER WINS THE GAME ! C###################");
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "C################ THE GAME ENDED BY AN EQUALITY ! C###################");
            }
        }
    }
}
