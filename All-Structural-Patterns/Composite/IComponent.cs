namespace Composite
{
    public interface IComponent
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        string Title { get; set; }

        /// <summary>
        /// Draws this instance.
        /// </summary>
        void Draw();

        /// <summary>
        /// Finds the specified title.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <returns></returns>
        IComponent Find(string title);
    }
}