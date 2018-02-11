namespace Decorator
{
    public class ElementDecorator : IElement
    {
        /// <summary>
        ///     The component
        /// </summary>
        protected readonly IElement Component;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ElementDecorator" /> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public ElementDecorator(IElement component)
        {
            Component = component;
        }

        /// <summary>
        ///     Gets or sets the text.
        /// </summary>
        /// <value>
        ///     The text.
        /// </value>
        public virtual string Text
        {
            get => Component.Text;
            set => Component.Text = value;
        }

        /// <summary>
        ///     Draws this instance.
        /// </summary>
        public virtual void Draw()
        {
            Component.Draw();
        }
    }
}