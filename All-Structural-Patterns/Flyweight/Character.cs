namespace Flyweight
{
    /// <summary>
    /// Abstract base class of characters
    /// </summary>
    public abstract class Character
    {
        /// <summary>
        /// Displays the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        public abstract void Display(int position);
    }
}