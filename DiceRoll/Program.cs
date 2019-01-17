using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            bool r = true;
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the Dice? (y/n)");
            r = AskToRoll();
        }



        public static int RollingDice()
        {
            var rolls = new Random();
            Console.WriteLine("How many sides should the die have?");
            int sides = int.Parse(Console.ReadLine());

            for (int i = 0; i <= sides; i++)
            {
                Console.WriteLine(rolls.Next(sides));
                rolls = RollingDice();
            }
            return RollingDice;
        }






        



        public static bool AskToRoll()
        {
            bool roll;
            Console.WriteLine("Do you want to continue? (y/n)");
            string input = Console.ReadLine();
            if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
            {
                roll = true;
            }
            else if (input.Equals("n", StringComparison.InvariantCultureIgnoreCase))
            {
                roll = false;
            }
            else
            {
                Console.WriteLine("Are you missing your Y and N keys? Try again.");
                roll = AskToRoll();
            }
            return roll;
        }
    }
}
