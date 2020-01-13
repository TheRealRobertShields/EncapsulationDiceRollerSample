using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDiceRollerSample
{
    /// <summary>
    /// Represents a single 6-sided die.
    /// </summary>
    class Die
    {
        // static fields get shared across all instances of this class.
        // all die have access to the same random object.
        private static Random rand;
        
        /// <summary>
        /// Static constructor. Only runs once. Random object should only be initialized once.
        /// </summary>
        static Die()
        {
            rand = new Random();
        }

        public Die()
        {
            Roll();
        }

        /// <summary>
        /// The current value of the die (1-6).
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// Die that are held are not to be rolled.
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Generates a new random face value.
        /// Sets the face value and returns the generated value.
        /// </summary>
        public byte Roll()
        {
            //If current die is held, return the current value.
            if (IsHeld)
            {
                return FaceValue;
            }

            const byte MinValue = 1;
            const byte MaxValue = 6;
            const byte Offset = 1;  // because Random.Next() upperbound parameter is exclusive.
            
            byte newFaceValue = (byte)rand.Next(MinValue, MaxValue + Offset);
            FaceValue = newFaceValue;
            return newFaceValue;
        }
        
    }
}
