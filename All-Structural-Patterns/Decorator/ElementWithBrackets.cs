using System;

namespace Decorator
{
    public class ElementWithBrackets : ElementDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementWithBrackets"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public ElementWithBrackets(IElement component) : base(component)
        {
        }

        /// <summary>
        /// Draws this instance.
        /// </summary>
        public override void Draw()
        {
            Console.Write("[");
            base.Draw();
            Console.Write("]");
        }
    }
}