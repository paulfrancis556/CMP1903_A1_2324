using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        public void test()
        {
            //Create the game object
            Game game = new Game();

            //Get the values back from the game object for debug.asset
            var valuesToTest = game.playGame();

            //Check the 3 individual die rolls
            for (int i = 0; i < 3; i++)
            {
                Debug.Assert(valuesToTest.Item1[i] > 0 && valuesToTest.Item1[i] < 7, "Die value is out of bounds.");
            }

            //check the sum
            Debug.Assert(valuesToTest.Item2 > 2 && valuesToTest.Item2 < 19, "Sum value is out of bounds.");

        }

    }
}
