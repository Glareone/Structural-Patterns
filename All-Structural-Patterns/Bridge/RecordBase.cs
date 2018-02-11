using System;

namespace Bridge
{
    public class RecordBase
    {
        /// <summary>
        /// Gets or sets the data object.
        /// </summary>
        /// <value>
        /// The data object.
        /// </value>
        public IDataObject<string> DataObject { get; set; }

        /// <summary>
        /// Nexts this instance.
        /// </summary>
        public virtual void Next()
        {
            DataObject.NextRecord();
        }

        /// <summary>
        /// Priors this instance.
        /// </summary>
        public virtual void Prior()
        {
            DataObject.PriorRecord();
        }

        /// <summary>
        /// Adds the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        public virtual void Add(string name)
        {
            DataObject.AddRecord(name);
        }

        /// <summary>
        /// Deletes the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        public virtual void Delete(string name)
        {
            DataObject.DeleteRecord(name);
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        public virtual void Get()
        {
            var customer = DataObject.GetCurrentRecord();
            Console.WriteLine(customer);
        }
    }
}