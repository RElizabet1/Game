using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGame
{
    class Quiz
    {
        static public List<string> list = new List<string>();
        static public int gameDuration = 0;
        static public int musicDuration = 0;
        static public bool randomStart = false;
        static public string lastFolder = "";
        static public bool allDirectories = false;

            static public void ReadMusic()
        {
            try 
            { 
            string[] musicFile = Directory.GetFiles(lastFolder, "*.mp3", allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            list.Clear();
            list.AddRange(musicFile);
            }
            catch
            {
            }
        }

        static string regKayName = "Software\\Game\\MusicGame";

        public static void WtiteParam()
        {
            RegistryKey key = null;
            try
            {
                key = Registry.CurrentUser.CreateSubKey(regKayName);
                if (key == null) return;
                key.SetValue("LastFolder", lastFolder);
                key.SetValue("RandomStart", randomStart);
                key.SetValue("GameDuration", gameDuration);
                key.SetValue("MusicDitation", musicDuration);
                key.SetValue("AllDirectories", allDirectories);
            }
            finally
            {
                if (key != null) key.Close();
            }
        }


        public static void ReadParam()
        {
            RegistryKey key = null;
            try
            {
                key = Registry.CurrentUser.OpenSubKey(regKayName);
                if (key != null)
                {
                    lastFolder = (string)key.GetValue("LastFolder");
                    randomStart= Convert.ToBoolean(key.GetValue("RandomStart", false ));
                    gameDuration = (int)key.GetValue("GameDuration");
                    musicDuration = (int)key.GetValue("MusicDitation");
                    allDirectories = Convert.ToBoolean( key.GetValue("AllDirectories"));
                }
            }
            finally
            {
                if (key != null) key.Close();
            }
        }

    }
}
