using System;
using System.Windows.Forms;

namespace quran
{
    public partial class Verse : Form
    {
        public Verse()
        {
            InitializeComponent();
        }

        AppSettings Settings { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            Settings = AppSettingsHelper.LoadFromFile();

            FillcbSurahsNames();

            ChangeSurah(Settings.CurrentSurahNumber);

            rtbVerse.SelectAll();
            rtbVerse.SelectionAlignment = HorizontalAlignment.Center;

            ShowVerse(Settings.CurrentSurahNumber,Settings.CurrentVerseNumber);

            cbSurahsNames.SelectedIndexChanged += cbSurahsNames_SelectedIndexChanged;
        }

        private void ChangeSurah(int SurahNumber)
        {
            cbSurahsNames.SelectedIndex = SurahNumber - 1;
        }

        private void ShowVerse(int SurahNumber, int VerseNumber)
        {
            Settings.CurrentSurahNumber = SurahNumber;
            Settings.CurrentVerseNumber = VerseNumber;

            rtbVerse.Text = QuranManager.GetArabicVerse(Settings.CurrentSurahNumber, Settings.CurrentVerseNumber);

            lbVerseNumber.Text = Settings.CurrentVerseNumber.ToString();
            lbVerseNumber.Focus();
        }

        private void btnNextVerse_Click(object sender, EventArgs e)
        {
            if (Settings.CurrentVerseNumber >= QuranManager.SurahVersesCount(Settings.CurrentSurahNumber)) return;

            Settings.CurrentVerseNumber++;

            ShowVerse(Settings.CurrentSurahNumber,Settings.CurrentVerseNumber);
        }

        private void btnPrevVerse_Click(object sender, EventArgs e)
        {
            if (Settings.CurrentVerseNumber <= 1) return;

            Settings.CurrentVerseNumber--;

            ShowVerse(Settings.CurrentSurahNumber, Settings.CurrentVerseNumber);
        }

        private void FillcbSurahsNames()
        {
            cbSurahsNames.Items.AddRange(QuranManager.ArabicSurahsNames().ToArray());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppSettingsHelper.SaveToFile(Settings);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            BringToFront();
            Show();
            CenterToScreen();
            Activate();
        }

        private void cbSurahsNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.CurrentVerseNumber = 1;
            ShowVerse(cbSurahsNames.SelectedIndex + 1,Settings.CurrentVerseNumber);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
                btnPrevVerse_Click(null, null);
            else if (keyData == Keys.Right)
                btnNextVerse_Click(null, null);

            if (keyData == (Keys.Control | Keys.W))
                Close();

            if(cbSurahsNames.Focused)
            {
                if (keyData == Keys.Up)
                    Settings.CurrentSurahNumber--;
                else if (keyData == Keys.Down)
                    Settings.CurrentSurahNumber++;

                if (Settings.CurrentSurahNumber > 114)
                    Settings.CurrentSurahNumber = 114;
                else if(Settings.CurrentSurahNumber < 1)
                    Settings.CurrentSurahNumber = 1;

                ChangeSurah(Settings.CurrentSurahNumber);
            }

            return true;
        }
    }
}
