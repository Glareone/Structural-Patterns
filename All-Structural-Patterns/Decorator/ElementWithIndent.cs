using System;

namespace Decorator
{
    public class ElementWithIndent : ElementDecorator
    {
        public int Indent { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElementWithIndent"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public ElementWithIndent(IElement component) : base(component)
        {
        }

        /// <summary>
        /// Draws this instance.
        /// </summary>
        public override void Draw()
        {
            MakeIndent();
            base.Draw();
            MakeIndent();
        }

        /// <summary>
        /// Makes the indent.
        /// </summary>
        private void MakeIndent()
        {
            Console.Write(new string(' ', Indent));
        }
    }
}