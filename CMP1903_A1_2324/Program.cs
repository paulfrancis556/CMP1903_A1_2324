using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            /// <summary>
            /// This file has the class Program and the method Main. 
            /// This simply instantiates the Testing class and calls the test() method to start the game.
            /// </summary>

            Testing game = new Testing();

            game.test();

            Console.ReadLine();
        }
    }
}
