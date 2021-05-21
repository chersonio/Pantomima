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
    /// <summary>
    /// Manages the settings from the Settings.json
    /// </summary>
    public class SettingsManager
    {
        #region Initialize setting properties
        public bool sounds { get; set; } = false;
        public int seconds { get; set; }
        public string difficulty { get; set; } = "Easy";
        public string extraMovieFilePath { get; set; } = null;
        public string MovieFilePath { get; set; } 
        public int numberOfMovieChoices { get; set; }
        public string themeColors { get; set; } = null;
        public int timesHitChoose { get; set; } = 0;
        #endregion

        /// <summary>
        /// Loads the Settings.json file in the current directory.
        /// </summary>
        /// <returns></returns>
        public static SettingsManager Load()
        {
            string settingsFilepath = ConfigurationManager.AppSettings["SettingsFilePath"];
            string settingsStr = File.ReadAllText(Directory.GetCurrentDirectory() + settingsFilepath);
            var result = JsonConvert.DeserializeObject<SettingsManager>(settingsStr);
            return result;
        }

        /// <summary>
        /// Saves the Settings.json file from the current directory.
        /// </summary>
        public void Save()
        {
            string settingsFilePath = Directory.GetCurrentDirectory() + ConfigurationManager.AppSettings["SettingsFilePath"];
            var settingsStr = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            System.IO.File.WriteAllText(settingsFilePath, settingsStr);
        }
    }
}
