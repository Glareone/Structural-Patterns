using System.Media;

namespace Adapter
{
    internal class PlayerAdapter : IAudioPlayer
    {
        // adapting object from System.Media.SoundPlayer
        private readonly SoundPlayer _player;

        /// <summary>
        ///     Initializes a new instance of the <see cref="PlayerAdapter" /> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public PlayerAdapter(string filePath)
        {
            _player = new SoundPlayer(filePath);
        }

        /// <summary>
        ///     Loads the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        public void Load(string file)
        {
            _player.SoundLocation = file;
            _player.Load();
        }

        /// <summary>
        ///     Plays this instance.
        /// </summary>
        public void Play()
        {
            _player.Play();
        }

        /// <summary>
        /// Dispose implementation
        /// </summary>
        public void Dispose()
        {
            _player?.Dispose();
        }
    }
}