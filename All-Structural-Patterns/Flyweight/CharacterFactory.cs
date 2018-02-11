using System.Collections.Generic;

namespace Flyweight
{
    public class CharacterFactory
    {
        /// <summary>
        /// The chars
        /// </summary>
        private readonly Dictionary<char, Character> _chars = new Dictionary<char, Character>();

        /// <summary>
        /// Gets the character.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public Character GetCharacter(char key)
        {
            if (!_chars.ContainsKey(key))
            {
                if (key == ' ')
                {
                    _chars.Add(key, new Whitespace());
                }
                else
                {
                    _chars.Add(key, new Latin {Symbol = key});
                }
            }
            return _chars[key];
        }
    }
}