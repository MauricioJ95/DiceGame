using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            bool shouldContinue;

            int rollCount = 1;

            Console.WriteLine("Welcome to the Grand Circus Casino!");

            do
            {
                Console.WriteLine("How many sides should each die have?");

                int numberOfSides = int.Parse(Console.ReadLine());

                int firstValue = RollDice(numberOfSides);

                int secondValue = RollDice(numberOfSides);

                Console.WriteLine($"Roll {rollCount}");
                Console.WriteLine(firstValue);
                Console.WriteLine(secondValue);
                Console.WriteLine();

                Console.WriteLine("Roll again?");

                shouldContinue = AskToRoll();

                rollCount++;

            } while (shouldContinue);
        }

        private static int RollDice(int numberOfSides)
        {
            return random.Next(1, numberOfSides + 1);
        }

        public static bool AskToRoll()
        {
            bool shouldContinue;
            Console.WriteLine("Do you want to continue? (y/n)");
            string input = Console.ReadLine();
            if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
            {
                shouldContinue = true;
            }
            else if (input.Equals("n", StringComparison.InvariantCultureIgnoreCase))
            {
                shouldContinue = false;
            }
            else
            {
                Console.WriteLine("Are you missing your Y and N keys? Try again.");
                shouldContinue = AskToRoll();
            }
            return shouldContinue;
        }
    }
}
