using System;

namespace Flyweight
{
    public class Whitespace : Character
    {
        /// <summary>
        /// Displays the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        public override void Display(int position)
        {
            Console.WriteLine($"_ (position {position})");
        }
    }
}