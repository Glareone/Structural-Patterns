using System;

namespace Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an object  with refined behavior
            // Bind With Concrete Realization
            var record = new Record {DataObject = new ListData()};

            // indirectly launch the methods of a particular implementation
            record.Get();
            record.Next();
            record.Get();

            Console.ReadLine();
        }
    }
}