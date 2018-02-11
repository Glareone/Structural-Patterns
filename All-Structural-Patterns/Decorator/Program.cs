using System;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // element by default
            IElement element = new Element { Text = "Demo" };
            element.Draw();

            PrintSeparator();

            // decorated
            IElement ei = new ElementWithIndent(element) { Indent = 4 };
            ei.Draw();

            PrintSeparator();

            IElement eb = new ElementWithBrackets(ei);
            eb.Draw();

            Console.ReadLine();
        }

        /// <summary>
        /// Prints the separator.
        /// </summary>
        private static void PrintSeparator()
        {
            Console.WriteLine("\n===========");
        }
    }
}