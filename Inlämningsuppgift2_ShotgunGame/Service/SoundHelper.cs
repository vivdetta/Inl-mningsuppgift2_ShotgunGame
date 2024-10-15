using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift2_ShotgunGame.Service
{
    public static class SoundHelper
    {
        // Play main music track
        public static void PlayBackgroundMusic()
        {
            string musicFilePath = GetSoundFilePath("The Terminator.wav");

            // Check if the file exists before playing
            if (File.Exists(musicFilePath))
            {
                SoundPlayer musicPlayer = new SoundPlayer(musicFilePath);
                musicPlayer.PlayLooping(); 
            }
            else
            {
                Console.WriteLine("Music file not found: " + musicFilePath);
            }
        }

        //Play shotgun sound effect
        public static void PlaySoundEffect(string fileName)
        {
            string soundFilePath = GetSoundFilePath(fileName);

            // Check if the file exists before playing
            if (File.Exists(soundFilePath))
            {
                SoundPlayer soundPlayer = new SoundPlayer(soundFilePath);
                soundPlayer.Play();  
            }
            else
            {
                Console.WriteLine("Sound file not found: " + soundFilePath);
            }
        }

        // Getting the path to sound files
        private static string GetSoundFilePath(string fileName)
        {
            // Base directory of your project (adjust if necessary)
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Folder where your sound files are stored (adjust as needed)
            string soundFolder = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\Sounds"));

            // Return the full file path for the requested sound file
            return Path.Combine(soundFolder, fileName);
        }
    }
}
