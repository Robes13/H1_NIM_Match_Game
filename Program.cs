using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H1_Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating infinite loop
            while (true)
            {
                // Clearing console at first, so when game restarts its all clear.
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                // Game started
                Console.WriteLine("Game started\n");
                // Creating new random
                Random random = new Random();
                // Deciding who starts
                int who_starts = random.Next(1, 3);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                // Explaining the rules
                Console.WriteLine("R-u-L-e-S");
                Console.WriteLine("You have to always take at least one match! If there is only one left\nand its your turn, " +
                                  "you lose!\nYou are playing against the computer\nand its a 50/50 who starts. " +
                                  "You can only take 1, 2 or 3 matches at a time. Have fun!\n");
                Console.Write("And the one who starts is  .");
                // Created cool . . . . Creation for revealing who is starting
                for (int i = 0; i < 4; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(" .");
                }
                // Revealing that the players starts if who_starts is 1
                if (who_starts == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nYou are starting!");
                }
                // Revealing that the computer starts if who_starts is 2
                else if (who_starts == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\nThe computer is starting!");
                }
                // Else in case there is an error, then player will start.
                else
                {
                    who_starts = 1;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nYou are starting!");
                }
                // Setting matches to 7
                int matches = 7;
                // Asking user for input
                if (who_starts == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please enter a number from 1 to 3. If you there is only 2 or 3 matches left, you can only take 1 or 2.");
                    Console.WriteLine("There is " + matches + " left");
                }
                // Setting up turns to decide who won the game
                byte user_turns = 0;
                byte computer_turns = 0;
                Console.ForegroundColor = ConsoleColor.White;
                // While matches not 1 loop
                while (matches != 1)
                {
                    // If its the first turn, setting the who starts to 0.
                    if (who_starts == 1 || who_starts == 0)
                    {
                        if (who_starts > 0)
                        {
                            who_starts = 0;
                        }
                        // Variable for how many matches the user takes.
                        int match_take_user = 0;
                        // Testing if the user input is an int
                        bool answer = int.TryParse(Console.ReadLine(), out match_take_user);
                        // If answer = true, go into this >
                        if (answer)
                        {
                            // Statement with parameters 
                            if (matches - match_take_user != 0 && matches - match_take_user >= 1 && match_take_user <= 3 && match_take_user != 0)
                            {
                                // Giving user feedback that they took x amount of matches.
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("You took " + match_take_user + " matches");
                                // Subtracting match_take_user from matches.
                                matches = matches - match_take_user;
                                Console.ForegroundColor = ConsoleColor.White;
                                // Telling the user how many matches is left.
                                Console.WriteLine("There is " + matches + " matches left");
                                // Adding one turn to computer
                                user_turns += 1;
                                // If it has been the computers turn already, minus computer_turns
                                if (computer_turns != 0)
                                {
                                    computer_turns -= 1;
                                }
                            }
                            // If user input is wrong, but still an interger
                            else if (match_take_user > 3 || match_take_user == 0 || match_take_user < 0)
                            {
                                Console.WriteLine("Please enter a number from 1 to 3. If you there is only 2 or 3 matches left, you can only take 1 or 2.");
                                Console.WriteLine("There is " + matches + " left");
                                continue;
                            }
                        }
                        // If it isnt an interget
                        else if (!answer)
                        {
                            Console.WriteLine("Please enter a number from 1 to 3. If you there is only 2 or 3 matches left, you can only take 1 or 2.");
                            Console.WriteLine("There is " + matches + " left");
                            continue;
                        }
                    }
                    // Again, testing if its the computers turn first
                    if (who_starts == 2 || who_starts == 0)
                    {
                        // Creating my variables
                        int temp_matches = 0;
                        int match_take_computer = 0;
                        // If its the first turn, set who_starts to 0
                        if (who_starts > 0)
                        {
                            who_starts = 0;
                        }
                        /* All theese following blocks of code is 
                         * the different choices the computer can have
                         * I made it like this so it chooses it strategically.
                         */
                        if (matches == 7)
                        {
                            match_take_computer = 2;
                            temp_matches = matches - match_take_computer;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("The computer took " + match_take_computer + " matches");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("There is " + temp_matches + " left");
                            matches = matches - match_take_computer;
                        }
                        else if (matches == 6)
                        {
                            match_take_computer = 1;
                            temp_matches = matches - match_take_computer;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("The computer took " + match_take_computer + " matches");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("There is " + temp_matches + " left");
                            matches = matches - match_take_computer;
                        }
                        else if (matches == 5)
                        {
                            match_take_computer = 1;
                            temp_matches = matches - match_take_computer;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("The computer took " + match_take_computer + " matches");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("There is " + temp_matches + " left");
                            matches = matches - match_take_computer;
                        }
                        else if (matches == 4)
                        {
                            match_take_computer = 3;
                            temp_matches = matches - match_take_computer;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("The computer took " + match_take_computer + " matches");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("There is " + temp_matches + " left");
                            matches = matches - match_take_computer;
                        }
                        else if (matches == 3)
                        {
                            match_take_computer = 2;
                            temp_matches = matches - match_take_computer;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("The computer took " + match_take_computer + " matches");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("There is " + temp_matches + " left");
                            matches = matches - match_take_computer;
                        }
                        else if (matches == 2)
                        {
                            match_take_computer = 1;
                            temp_matches = matches - match_take_computer;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("The computer took " + match_take_computer + " matches");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("There is " + temp_matches + " left");
                            matches = matches - match_take_computer;
                        }
                        // break if matches == 1
                        else if (matches == 1)
                        {
                            break;
                        }
                        // Using this else as a defualt block to just take 1 match.
                        else
                        {
                            match_take_computer = 1;
                            temp_matches = matches - match_take_computer;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("The computer took " + match_take_computer + " matches");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("There is " + temp_matches + " left");
                            matches = matches - match_take_computer;
                        }
                        // Adding one to computer turns, and subtracting one from user_turns.
                        computer_turns += 1;
                        if (user_turns != 0)
                        {
                            user_turns -= 1;
                        }
                    }
                }
                // The one that has 1 turn in the end, wins. Becuase it means that the computer/user had the last turn, and therefore won.
                // User win announcement
                if (user_turns > computer_turns)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations!! You won!");
                }
                // Computer win announcement
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("How bad can you be... You lost to the computer :(");
                }
                // Telling user that they can press any key to play again.
                Console.WriteLine("Press any key to play again..");
                // Waiting for user to press any key.
                Console.ReadKey();
            }
        }
    }
}