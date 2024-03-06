using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        /// <summary>
        /// Die class contains Roll() Method. Die.Roll() Returns a random number from 1 to 6.
        /// </summary>

        //Property
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        //Use static to refer to the type its self rather than an instance - prevents the seed issue when using random at a rapid rate and getting the same value every time
        private static Random random = new Random();

        //Method
        public int Roll()
        {
            number = random.Next(1, 7);
            return number;
        }

    }

}
