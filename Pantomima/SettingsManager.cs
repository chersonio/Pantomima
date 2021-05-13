using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantomima
{
    public class SettingsManager
    {
        public bool sounds { get; set; } = false;
        public int seconds { get; set; } = 60;
        public string difficulty { get; set; } = "Easy";
        public string extraMovieFilePath { get; set; } = null;
        public string MovieFilePath { get; set; } 
        public int numberOfMovieChoices { get; set; }
        public string themeColors { get; set; } = null;
        public int timesHitChoose { get; set; } = 0;

        public SettingsManager()
        { }

        public static SettingsManager Load()
        {
            string settingsFilepath = ConfigurationManager.AppSettings["SettingsFilePath"];
            string settingsStr = File.ReadAllText(Directory.GetCurrentDirectory() + settingsFilepath);
            var result = JsonConvert.DeserializeObject<SettingsManager>(settingsStr);
            return result;
        }

        public void Save()
        {
            string settingsFilePath = Directory.GetCurrentDirectory() + ConfigurationManager.AppSettings["SettingsFilePath"];
            var settingsStr = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            System.IO.File.WriteAllText(settingsFilePath, settingsStr);
        }
    }
}
