using System;
using System.Collections.Generic;

namespace Composite
{
    public class Map : IComponent
    {
        /// <summary>
        /// The map
        /// </summary>
        private readonly List<IComponent> _map = new List<IComponent>();

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Adds the component.
        /// </summary>
        /// <param name="component">The component.</param>
        public void AddComponent(IComponent component)
        {
            _map.Add(component);
        }

        /// <summary>
        /// Draws this instance.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine(Title);
            foreach (var component in _map)
            {
                component.Draw();
            }
        }

        /// <summary>
        /// Finds the specified title.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <returns></returns>
        public IComponent Find(string title)
        {
            if (Title == title)
            {
                return this;
            }
            foreach (var component in _map)
            {
                var found = component.Find(title);
                if (found != null)
                {
                    return found;
                }
            }
            return null;
        }
    }
}