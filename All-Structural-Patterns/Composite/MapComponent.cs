using System;

namespace Composite
{
    public class MapComponent : IComponent
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Draws this instance.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine(Title);
        }

        /// <summary>
        /// Finds the specified title.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <returns></returns>
        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }
    }
}