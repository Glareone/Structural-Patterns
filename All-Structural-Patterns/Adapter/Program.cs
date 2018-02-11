using System;

namespace Adapter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var filePath = "C:\\Windows\\Media\\tada.wav";
            using (IAudioPlayer player = new PlayerAdapter(filePath))
            {
                player.Play();
            }

            Console.ReadLine();
        }
    }
}