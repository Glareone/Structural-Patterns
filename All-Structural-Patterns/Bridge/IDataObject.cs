namespace Bridge
{
    public interface IDataObject<T>
    {
        /// <summary>
        /// Nexts the record.
        /// </summary>
        void NextRecord();

        /// <summary>
        /// Priors the record.
        /// </summary>
        void PriorRecord();

        /// <summary>
        /// Adds the record.
        /// </summary>
        /// <param name="t">The t.</param>
        void AddRecord(T t);

        /// <summary>
        /// Deletes the record.
        /// </summary>
        /// <param name="t">The t.</param>
        void DeleteRecord(T t);

        /// <summary>
        /// Gets the current record.
        /// </summary>
        /// <returns></returns>
        T GetCurrentRecord();
    }
}