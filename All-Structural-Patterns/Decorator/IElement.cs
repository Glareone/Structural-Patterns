namespace Decorator
{
    public interface IElement
    {
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        string Text { get; set; }

        /// <summary>
        /// Draws this instance.
        /// </summary>
        void Draw();
    }
}