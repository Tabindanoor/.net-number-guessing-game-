using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(name);
            string appdata = "number guessor";
            string version = "1.0.0";
            string author = "tabinda noor";
            Console.WriteLine("{0} : version {1} by {2}", appdata, version, author);
            Console.ResetColor();

            //getting name from the user
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("what is your name ");
            string inputNum=Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("my name is {0}", inputNum);

            //starting game 


            while (true)
            {

                int correct = 21;
                int guess = 0;
                Console.WriteLine("hey lets play a game ");
                Console.WriteLine("Guess the correct number between 1 and 1000");

                //when user does not enter right number
                while (guess != correct)
                {
                    string input = Console.ReadLine();

                    //if user enters string 

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("hey what happened to you man, it,s a number guessig game & you are entering the string");
                        Console.ResetColor();
                        continue;

                    }

                    //user enters wrong number 

                    guess = Int32.Parse(input);
                    if (guess != correct)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("hey you are wrong");
                        Console.ResetColor();
                    }

                }
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("here you guessed the right number my friend ");
                Console.ResetColor();

                Console.WriteLine("do you want to play again [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer=="Y")
                {
                    continue;
                }
                else if(answer=="N")
                {
                    return;
                }
                else
                {
                    return;
                }


            }

        }
    }
}
