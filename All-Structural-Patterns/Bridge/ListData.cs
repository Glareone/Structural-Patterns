using System.Collections.Generic;

namespace Bridge
{
    public class ListData : IDataObject<string>
    {
        /// <summary>
        /// The records
        /// </summary>
        private readonly List<string> _records;

        /// <summary>
        /// The current
        /// </summary>
        private int _current;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListData"/> class.
        /// </summary>
        public ListData()
        {
            _records = new List<string> {"Jim Jones", "Samuel Jackson"};
        }

        /// <summary>
        /// Nexts the record.
        /// </summary>
        public void NextRecord()
        {
            if (_current < _records.Count - 1)
            {
                _current++;
            }
        }

        /// <summary>
        /// Priors the record.
        /// </summary>
        public void PriorRecord()
        {
            if (_current > 0)
            {
                _current--;
            }
        }

        /// <summary>
        /// Adds the record.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public void AddRecord(string customer)
        {
            _records.Add(customer);
        }

        /// <summary>
        /// Deletes the record.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public void DeleteRecord(string customer)
        {
            _records.Remove(customer);
        }

        /// <summary>
        /// Gets the current record.
        /// </summary>
        /// <returns></returns>
        public string GetCurrentRecord()
        {
            return _records[_current];
        }
    }
}