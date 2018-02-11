using System;

namespace Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var document = "AA BB AB";
            var chars = document.ToCharArray();
            var f = new CharacterFactory();
            // position - this is external state
            var position = 0;
            // use for every symbol our flyweight-object (объект-приспособленец)
            foreach (var c in chars)
            {
                var character = f.GetCharacter(c);
                character.Display(position++);
            }

            Console.ReadLine();
        }
    }
}