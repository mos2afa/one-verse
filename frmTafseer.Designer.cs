namespace quran
{
    partial class frmTafseer
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
            this.rtbTafseer = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbTafserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbTafseer
            // 
            this.rtbTafseer.BackColor = System.Drawing.Color.Black;
            this.rtbTafseer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTafseer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbTafseer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTafseer.ForeColor = System.Drawing.Color.White;
            this.rtbTafseer.Location = new System.Drawing.Point(0, 42);
            this.rtbTafseer.Margin = new System.Windows.Forms.Padding(8);
            this.rtbTafseer.Name = "rtbTafseer";
            this.rtbTafseer.ReadOnly = true;
            this.rtbTafseer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbTafseer.Size = new System.Drawing.Size(799, 360);
            this.rtbTafseer.TabIndex = 0;
            this.rtbTafseer.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(750, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbTafserLabel
            // 
            this.lbTafserLabel.AutoSize = true;
            this.lbTafserLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(70)))));
            this.lbTafserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTafserLabel.Location = new System.Drawing.Point(267, 2);
            this.lbTafserLabel.Name = "lbTafserLabel";
            this.lbTafserLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTafserLabel.Size = new System.Drawing.Size(240, 32);
            this.lbTafserLabel.TabIndex = 2;
            this.lbTafserLabel.Text = "تفسير سورة \"  \" ايه \"  \"";
            // 
            // frmTafseer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(799, 402);
            this.Controls.Add(this.lbTafserLabel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtbTafseer);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTafseer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTafseer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTafseer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbTafserLabel;
    }
}