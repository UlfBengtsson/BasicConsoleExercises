using System;

namespace BasicConsoleExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepAlive = true;

            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter excercise number (or -1 to exit): ");
                    int selection = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;

                    switch (selection)
                    {
                        case 1:
                            RunExcerciseOne();
                            break;
                        case 2:
                            RunExcerciseTwo();
                            break;
                        case 3:
                            // Call your method for the third excercise here.
                            break;

                        // keep adding cases for the excercises.

                        case -1:
                            keepAlive = false;
                            break;
                        case -2:
                            AskForNumber();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Not a valid number selection.");
                            break;
                    }

                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exception as bin catched!");
                    Console.ResetColor();
                }
            }
        }

        static void RunExcerciseTwo()
        {
            throw new NotImplementedException();
        }

        static void RunExcerciseOne()
        {
            throw new NotImplementedException();
        }

        static string AskUserFor(string whatFor)
        {
            Console.Write("Please enter " + whatFor + ": ");
            return Console.ReadLine();
        }

        static double AskForNumber()
        {
            double number = 0;
            bool wasNumber;

            do
            {
                wasNumber = double.TryParse(AskUserFor("number"), out number);
                if ( ! wasNumber)
                {
                    Console.WriteLine("was not a number, please try once more.");
                }

            } while (wasNumber != true);

            return number;
        }
    }
}
