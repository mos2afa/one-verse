using System;
using System.Windows.Forms;

namespace quran
{
    public partial class OneVerse : Form
    {
        public OneVerse()
        {
            InitializeComponent();
        }

        AppSettings Settings { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            Settings = AppSettingsHelper.LoadFromFile();

            FillcbSurahsNames();

            rtbVerse.SelectAll();
            rtbVerse.SelectionAlignment = HorizontalAlignment.Center;
            btnLang.Text = Settings.Language.ToString();

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

            RefreshTextBox();

            lbVerseNumber.Text = $"{Settings.CurrentVerseNumber} / {QuranManager.SurahVersesCount(Settings.CurrentSurahNumber)}";
            lbVerseNumber.Focus();
        }

        void RefreshTextBox()
        {
            rtbVerse.Text = QuranManager.GetVerse(Settings.CurrentSurahNumber, Settings.CurrentVerseNumber,Settings.Language);
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
            cbSurahsNames.Items.Clear();
            cbSurahsNames.Items.AddRange(QuranManager.GetSurahsNames(Settings.Language).ToArray());

            cbSurahsNames.RightToLeft = Settings.Language == enLanguage.ar ? RightToLeft.Yes : RightToLeft.No;

            ChangeSurah(Settings.CurrentSurahNumber);
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

            return true;
        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            cbSurahsNames.SelectedIndexChanged -= cbSurahsNames_SelectedIndexChanged;// prevent returning to verse 1.

            Settings.Language = Settings.Language == enLanguage.ar ? enLanguage.en : enLanguage.ar;
            btnLang.Text = Settings.Language.ToString();

            FillcbSurahsNames();

            RefreshTextBox();

            cbSurahsNames.SelectedIndexChanged += cbSurahsNames_SelectedIndexChanged;
        }

        private void showTafseerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Tafseer = QuranManager.GetArabicTafseer(Settings.CurrentSurahNumber, Settings.CurrentVerseNumber)+"\n";

            string SurahName = QuranManager.GetArabicSurahsName(Settings.CurrentSurahNumber);

            frmTafseer frmTafseer = new frmTafseer(SurahName, Settings.CurrentVerseNumber, Tafseer); ;
            frmTafseer.ShowDialog();
        }

        private void rtbVerse_MouseDown(object sender, MouseEventArgs e)
        {
            e = null;
            this.ActiveControl = lbVerseNumber;
        }
    }
}
