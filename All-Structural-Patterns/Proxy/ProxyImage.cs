namespace Proxy
{
    public class ProxyImage : IImage
    {
        /// <summary>
        /// The image
        /// </summary>
        private RealImage _image;

        /// <summary>
        /// The filename
        /// </summary>
        private readonly string _filename;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyImage"/> class.
        /// </summary>
        /// <param name="filename">The filename.</param>
        public ProxyImage(string filename)
        {
            _filename = filename;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            if (_image == null)
            {
                _image = new RealImage(_filename);
            }
            _image.Display();
        }
    }
}