namespace quran
{
    partial class OneVerse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbVerse = new System.Windows.Forms.RichTextBox();
            this.btnPrevVerse = new System.Windows.Forms.Button();
            this.btnNextVerse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbVerseNumber = new System.Windows.Forms.Label();
            this.cbSurahsNames = new System.Windows.Forms.ComboBox();
            this.btnLang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbVerse
            // 
            this.rtbVerse.BackColor = System.Drawing.Color.Black;
            this.rtbVerse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbVerse.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbVerse.ForeColor = System.Drawing.Color.White;
            this.rtbVerse.Location = new System.Drawing.Point(12, 24);
            this.rtbVerse.Name = "rtbVerse";
            this.rtbVerse.ReadOnly = true;
            this.rtbVerse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbVerse.Size = new System.Drawing.Size(800, 396);
            this.rtbVerse.TabIndex = 0;
            this.rtbVerse.TabStop = false;
            this.rtbVerse.Text = "";
            // 
            // btnPrevVerse
            // 
            this.btnPrevVerse.FlatAppearance.BorderSize = 0;
            this.btnPrevVerse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevVerse.ForeColor = System.Drawing.Color.Black;
            this.btnPrevVerse.Location = new System.Drawing.Point(297, 426);
            this.btnPrevVerse.Name = "btnPrevVerse";
            this.btnPrevVerse.Size = new System.Drawing.Size(82, 41);
            this.btnPrevVerse.TabIndex = 1;
            this.btnPrevVerse.TabStop = false;
            this.btnPrevVerse.Text = "<";
            this.btnPrevVerse.UseVisualStyleBackColor = true;
            this.btnPrevVerse.Click += new System.EventHandler(this.btnPrevVerse_Click);
            // 
            // btnNextVerse
            // 
            this.btnNextVerse.FlatAppearance.BorderSize = 0;
            this.btnNextVerse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextVerse.ForeColor = System.Drawing.Color.Black;
            this.btnNextVerse.Location = new System.Drawing.Point(384, 426);
            this.btnNextVerse.Name = "btnNextVerse";
            this.btnNextVerse.Size = new System.Drawing.Size(82, 41);
            this.btnNextVerse.TabIndex = 2;
            this.btnNextVerse.TabStop = false;
            this.btnNextVerse.Text = ">";
            this.btnNextVerse.UseVisualStyleBackColor = true;
            this.btnNextVerse.Click += new System.EventHandler(this.btnNextVerse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "verse number";
            // 
            // lbVerseNumber
            // 
            this.lbVerseNumber.AutoSize = true;
            this.lbVerseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVerseNumber.Location = new System.Drawing.Point(235, 426);
            this.lbVerseNumber.Name = "lbVerseNumber";
            this.lbVerseNumber.Size = new System.Drawing.Size(32, 36);
            this.lbVerseNumber.TabIndex = 4;
            this.lbVerseNumber.Text = "0";
            // 
            // cbSurahsNames
            // 
            this.cbSurahsNames.DropDownHeight = 200;
            this.cbSurahsNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSurahsNames.DropDownWidth = 220;
            this.cbSurahsNames.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSurahsNames.FormattingEnabled = true;
            this.cbSurahsNames.IntegralHeight = false;
            this.cbSurahsNames.Location = new System.Drawing.Point(519, 426);
            this.cbSurahsNames.Name = "cbSurahsNames";
            this.cbSurahsNames.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSurahsNames.Size = new System.Drawing.Size(220, 41);
            this.cbSurahsNames.TabIndex = 5;
            this.cbSurahsNames.TabStop = false;
            // 
            // btnLang
            // 
            this.btnLang.BackColor = System.Drawing.Color.White;
            this.btnLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang.ForeColor = System.Drawing.Color.Black;
            this.btnLang.Location = new System.Drawing.Point(745, 427);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(67, 41);
            this.btnLang.TabIndex = 6;
            this.btnLang.TabStop = false;
            this.btnLang.Text = "AR";
            this.btnLang.UseVisualStyleBackColor = false;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // OneVerse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(824, 474);
            this.Controls.Add(this.btnLang);
            this.Controls.Add(this.cbSurahsNames);
            this.Controls.Add(this.lbVerseNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNextVerse);
            this.Controls.Add(this.btnPrevVerse);
            this.Controls.Add(this.rtbVerse);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "OneVerse";
            this.Text = "One verse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbVerse;
        private System.Windows.Forms.Button btnPrevVerse;
        private System.Windows.Forms.Button btnNextVerse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVerseNumber;
        private System.Windows.Forms.ComboBox cbSurahsNames;
        private System.Windows.Forms.Button btnLang;
    }
}

