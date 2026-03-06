using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace quran
{
    public class QuranManager
    {
        private static readonly string db_path = "Data Source=quran_database.sqlite";

        public static string GetVerse(int surahNumber,int verseNumber,enLanguage language = enLanguage.ar )
        {

            string query = $"select text_{language} from verses where" +
                $" surah_number=@surahNumber" +
                $" and number=@verseNumber";

            string verse = "";

            using (SQLiteConnection conn = new SQLiteConnection(db_path))
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn) )
            {
                cmd.Parameters.AddWithValue("@surahNumber", surahNumber);
                cmd.Parameters.AddWithValue("@verseNumber", verseNumber);

                try
                {
                    conn.Open();
                    verse = cmd.ExecuteScalar().ToString();
                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            return verse;
        }

        public static string GetArabicTafseer(int surahNumber, int verseNumber)
        {

            string query = $"SELECT nass FROM tafseer " +
                $" WHERE sura=@sura AND ayah=@ayah;";

            string tafseer = "";

            using (SQLiteConnection conn = new SQLiteConnection(db_path))
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@surahNumber", surahNumber);
                cmd.Parameters.AddWithValue("@verseNumber", verseNumber);

                try
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@sura", surahNumber);
                    cmd.Parameters.AddWithValue("@ayah", verseNumber);

                    tafseer = cmd.ExecuteScalar().ToString();
                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            return tafseer;
        }

        public static int SurahVersesCount(int surahNumber)
        {

            string query = $"select verses_count from surahs " +
                $"where number={surahNumber}";

            int Count = 0;

            using (SQLiteConnection conn = new SQLiteConnection(db_path))
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                try
                {

                    conn.Open();
                    Count = Convert.ToInt32( cmd.ExecuteScalar() );
                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            return Count;
        }

        public static List<string> GetSurahsNames(enLanguage language = enLanguage.ar)
        {
            string query = $"select name_{language} from surahs ";

            List<string> SurahNames = new List<string>();

            using (SQLiteConnection conn = new SQLiteConnection(db_path))
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                try
                {

                    conn.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        SurahNames.Add(reader.GetString(0));
                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            return SurahNames;
        }

        public static string GetArabicSurahsName(int surahNumber)
        {
            string query = $"SELECT name_ar FROM surahs WHERE number=@number";

            List<string> SurahNames = new List<string>();

            string ArabicSurahName = "";

            using (SQLiteConnection conn = new SQLiteConnection(db_path))
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@number", surahNumber);

                    ArabicSurahName = cmd.ExecuteScalar().ToString();
                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            return ArabicSurahName;
        }
    }
}
