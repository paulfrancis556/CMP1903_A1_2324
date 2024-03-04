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

        //Methods

        public void GameLoop()
        {

            int i = 1;
            var list = new List<int> { };

            //amount to roll
            int amountToRoll = 3;

            //Roll Die
            while (i <= amountToRoll)
            {
                Die die = new Die();
                Testing debug = new Testing();

                int roll = die.rollDie();

                Console.WriteLine($"Die: " + i + ": " + roll);

                debug.assert(roll);

                list.Add(roll);

                System.Threading.Thread.Sleep(1);

                i++;

            }
            //for reveiw
            Testing sumCheck = new Testing();
            int sum = 0;
            foreach (var item in list) { sum += item; }
            Console.WriteLine($"Sum: " + sum);
            sumCheck.assertSum(sum);

        }

    }
}
