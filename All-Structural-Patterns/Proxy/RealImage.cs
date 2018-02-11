using System;

namespace Proxy
{
    public class RealImage : IImage
    {
        /// <summary>
        /// The filename
        /// </summary>
        private readonly string _filename;

        /// <summary>
        /// Initializes a new instance of the <see cref="RealImage"/> class.
        /// </summary>
        /// <param name="filename">The filename.</param>
        public RealImage(string filename)
        {
            _filename = filename;
            LoadImageFromDisk();
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Displaying " + _filename);
        }

        /// <summary>
        /// Loads the image from disk.
        /// </summary>
        private void LoadImageFromDisk()
        {
            Console.WriteLine("Loading " + _filename);
        }
    }
}