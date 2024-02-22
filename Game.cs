using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace programming
{
    internal class Game
    {
        public Game()
        {
            int points = 0;
            while (true)
            {
                Console.WriteLine($"Welcome to the calculator game made by mogus... You have {points} points\n" +
                    "What difficulty would you like to play on? 1-Easy, 2-Medium, 3-Hard or 4-Impossible? Type exit to close");
                string difficulty = Console.ReadLine();
                if (difficulty == "exit")
                {
                    break;
                }
                while (!int.TryParse(difficulty, out int n) || int.Parse(difficulty) < 1 || int.Parse(difficulty) > 4)
                {
                    Console.WriteLine("That is not a valid difficulty! Try again:");
                    difficulty = Console.ReadLine();
                }
                Console.WriteLine("If you at any point in time want to go back to choosing a difficulty, simply write 'back'");
                Console.WriteLine("What type of calculation would you like to play? 1-Addition 2-Subtraction 3-Multiplication 4-Division");
                switch (Console.ReadLine())
                {
                    case "1":
                        if (Calculation(difficulty, "+"))
                        {
                            points += int.Parse(difficulty);
                        }
                        break;

                    case "2":
                        if (Calculation(difficulty, "-"))
                        {
                            points += int.Parse(difficulty);
                        }
                        break;

                    case "3":
                        if (Calculation(difficulty, "*"))
                        {
                            points += int.Parse(difficulty);
                        }
                        break;

                    case "4":
                        if (Calculation(difficulty, "/"))
                        {
                            points += int.Parse(difficulty);
                        }
                        break;

                    case "back":
                        break;
                }
            }
        }

        static bool Calculation(string difficulty, string type)
        {
            
            Random rand = new Random();
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            for (int i = 0; i < 10; i++)
            {
                switch (difficulty)
                {
                    case "1":
                        num1 = rand.Next(1, 11);
                        num2 = rand.Next(1, 11);
                        break;

                    case "2":
                        num1 = rand.Next(1, 101);
                        num2 = rand.Next(1, 101);
                        break;

                    case "3":
                        num1 = rand.Next(1, 1001);
                        num2 = rand.Next(1, 1001);
                        break;

                    case "4":
                        num1 = rand.Next(1, 10000);
                        num2 = rand.Next(1, 10000);
                        break;
                }
                if (type == "+")
                {
                    num3 = num1 + num2;
                }
                else if (type == "-")
                {
                    num3 = num1 - num2;
                }
                else if (type == "*")
                {
                    num3 = num1 * num2;
                }
                else
                {
                    num3 = num1 / num2;
                }
                Console.WriteLine($"What is {num1} {type} {num2}?");
                string answer = Console.ReadLine();
                if (answer == "back")
                {
                    return false;
                }
                int tries = 3;
                while (int.Parse(answer) != num3 && tries > 0)
                {
                    tries--;
                    Console.WriteLine("Incorrect! Try again:");
                    answer = Console.ReadLine();
                    if (answer == "back")
                    {
                        return false;
                    }
                }
                if (tries == 0)
                {
                    Console.WriteLine($"You failed, the answer was: {num3}. Skipping...");
                }
            }
            return true;
        }
    }
}
