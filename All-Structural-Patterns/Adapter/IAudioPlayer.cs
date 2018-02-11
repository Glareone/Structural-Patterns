using System;

namespace Adapter
{
    public interface IAudioPlayer: IDisposable
    {
        /// <summary>
        /// Loads the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        void Load(string file);
        /// <summary>
        /// Plays this instance.
        /// </summary>
        void Play();
    }
}