namespace WinFormsApp1
{
    partial class Form_TrangChu
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
            pictureBox_imag_66_truong = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_imag_66_truong).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_imag_66_truong
            // 
            pictureBox_imag_66_truong.Dock = DockStyle.Fill;
            pictureBox_imag_66_truong.Location = new Point(0, 0);
            pictureBox_imag_66_truong.Name = "pictureBox_imag_66_truong";
            pictureBox_imag_66_truong.Size = new Size(822, 676);
            pictureBox_imag_66_truong.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_imag_66_truong.TabIndex = 0;
            pictureBox_imag_66_truong.TabStop = false;
            // 
            // Form_TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 676);
            Controls.Add(pictureBox_imag_66_truong);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_TrangChu";
            Load += Form_TrangChu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_imag_66_truong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_imag_66_truong;
    }
}