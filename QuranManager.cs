using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace quran
{
    public class QuranManager
    {
        private static readonly string db_path = "Data Source=quran_database.sqlite";

        public static string GetArabicVerse(int surahNumber,int verseNumber )
        {

            string query = $"select text_ar from verses where" +
                $" surah_number={surahNumber}" +
                $" and number={verseNumber}";

            string ar_verse = "";

            using (SQLiteConnection conn = new SQLiteConnection(db_path))
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn) )
            {
                try
                {

                    conn.Open();
                    ar_verse = cmd.ExecuteScalar().ToString();
                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            return ar_verse;
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

        public static List<string> ArabicSurahsNames()
        {
            string query = $"select name_ar from surahs ";

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

    }
}
