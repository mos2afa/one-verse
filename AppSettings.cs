using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace quran
{
    public class AppSettings
    {
        public int CurrentSurahNumber { get; set; }
        public int CurrentVerseNumber { get; set; }

        public static AppSettings Default()
        {
            return new AppSettings
            {
                CurrentSurahNumber = 1,
                CurrentVerseNumber = 1,
            };
        }
    }
    public class AppSettingsHelper
    {
        public readonly static string JsonPath = "settings.json";

        private static string Serialize(AppSettings appSettings)
        {
            return JsonSerializer.Serialize(appSettings);
        }

        private static AppSettings Deserialize(string jsonString)
        {
            return JsonSerializer.Deserialize<AppSettings>(jsonString);
        }

        public static AppSettings LoadFromFile()
        {
            if(!File.Exists(JsonPath))
            {
                using (File.Create(JsonPath)) { }
                SaveToFile(AppSettings.Default());
            }

            string JsonString = File.ReadAllText(JsonPath);
            return Deserialize(JsonString);
        }
        public static void SaveToFile(AppSettings appSettings)
        {
            string JsonString = Serialize(appSettings);
            File.WriteAllText(JsonPath, JsonString);
        }
    }
}
