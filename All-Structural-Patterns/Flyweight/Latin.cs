using System;

namespace Flyweight
{
    public class Latin : Character
    {
        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public char Symbol { get; set; }

        /// <summary>
        /// Displays the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        public override void Display(int position)
        {
            Console.WriteLine("{0} (position {1})", Symbol, position);
        }
    }
}