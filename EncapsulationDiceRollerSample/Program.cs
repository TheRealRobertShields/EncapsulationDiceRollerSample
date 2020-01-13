using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDiceRollerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Die[] dice = new Die[5];
            InitDice(dice);
            PrintDieFaceValues(dice);

            // Hold first 3 dice
            dice[0].IsHeld = true;
            dice[1].IsHeld = true;
            dice[2].IsHeld = true;

            Console.WriteLine("\n\nHolding first 3, rerolling\n\n");

            RollAllDice(dice);

            PrintDieFaceValues(dice);

            Console.ReadKey();
        }

        /// <summary>
        /// Rolls all die in a given array.
        /// </summary>
        /// <param name="dice"></param>
        private static void RollAllDice(Die[] dice)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Roll();
            }
        }

        /// <summary>
        /// Prints face value for all die in a given array.
        /// </summary>
        /// <param name="dice"></param>
        private static void PrintDieFaceValues(Die[] dice)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                Console.WriteLine(dice[i].FaceValue);
            }
        }

        /// <summary>
        /// Initializes all die in a given array.
        /// Assumes array has been given a length.
        /// </summary>
        /// <param name="dice"></param>
        private static void InitDice(Die[] dice)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }
    }
}
