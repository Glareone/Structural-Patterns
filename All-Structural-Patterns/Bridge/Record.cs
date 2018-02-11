using System;

namespace Bridge
{
    // Refined Behavior class
    public class Record : RecordBase
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        public override void Get()
        {
            Console.WriteLine("==== Get Record ===");
            base.Get();
            Console.WriteLine("==== Finished ====");
        }
    }
}