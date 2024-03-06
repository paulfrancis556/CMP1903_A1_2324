using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        /// <summary>
        /// Game class contains playGame() Method. playGame() Rolls instantiates and 
        /// creates 3 die objects which then call the roll method. These are done in a loop and loaded in to a list. 
        /// Outcome of the die and the sum are outputted to the console.
        /// Finally the method returns two values. A list of 3 dice and the sum of all die. These can then be used in the testing class.
        /// </summary>

        //Methods
        public (List<int>, int) playGame()
        {

            //Define our list to hold the dice objects
            var dice = new List<int>();

            //Create three dice objects
            for (int i = 0; i < 3; i++)
            {
                //Create a die object
                Die die = new Die();

                //Insert our die to the dice list
                dice.Add(die.Roll());

                //Output each die roll
                Console.WriteLine("Roll: " + (i+1) + ". Outcome: "+ dice[i]);

            }

            //Output the sum
            Console.WriteLine("Sum: " + dice.Sum());

            //Return the dice list and dice sum for testing
            return (dice, dice.Sum());

        }

    }
}
