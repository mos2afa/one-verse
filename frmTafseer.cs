using System;
using System.Windows.Forms;

namespace quran
{
    public partial class frmTafseer : Form
    {
        public frmTafseer(string surahName,int verseNumber,string Tafseer)
        {
            InitializeComponent();
            rtbTafseer.Text= Tafseer;

            lbTafserLabel.Text = "";
            lbTafserLabel.Text += "تفسير سورة ";
            lbTafserLabel.Text += $"( {surahName} )";
            lbTafserLabel.Text += $" آيه ";
            lbTafserLabel.Text += $"( {verseNumber} )";

            CenterToParent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.W))
                Close();

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
