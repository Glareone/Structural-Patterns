using System;

namespace Decorator
{
    public class Element : IElement
    {
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text { get; set; }

        /// <summary>
        /// Draws this instance.
        /// </summary>
        public void Draw()
        {
            Console.Write($"Element text = {Text}");
        }
    }
}