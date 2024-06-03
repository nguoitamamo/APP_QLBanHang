namespace WinFormsApp1
{
    partial class Form3_BangThongTinSanPham
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
            pictureBox_Image_66_truong = new PictureBox();
            lbl_tenSanPham_66_truong = new Label();
            lbl_giaTien_66_truong = new Label();
            label1 = new Label();
            lbl_ten_66_truong = new Label();
            lbl_gia_66_truong = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Image_66_truong).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_Image_66_truong
            // 
            pictureBox_Image_66_truong.Location = new Point(96, 68);
            pictureBox_Image_66_truong.Name = "pictureBox_Image_66_truong";
            pictureBox_Image_66_truong.Size = new Size(247, 238);
            pictureBox_Image_66_truong.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Image_66_truong.TabIndex = 0;
            pictureBox_Image_66_truong.TabStop = false;
            // 
            // lbl_tenSanPham_66_truong
            // 
            lbl_tenSanPham_66_truong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl_tenSanPham_66_truong.Location = new Point(165, 336);
            lbl_tenSanPham_66_truong.Name = "lbl_tenSanPham_66_truong";
            lbl_tenSanPham_66_truong.Size = new Size(244, 25);
            lbl_tenSanPham_66_truong.TabIndex = 1;
            // 
            // lbl_giaTien_66_truong
            // 
            lbl_giaTien_66_truong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl_giaTien_66_truong.Location = new Point(165, 390);
            lbl_giaTien_66_truong.Name = "lbl_giaTien_66_truong";
            lbl_giaTien_66_truong.Size = new Size(244, 25);
            lbl_giaTien_66_truong.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(436, 53);
            label1.TabIndex = 3;
            label1.Text = "THÔNG TIN SẢN PHẨM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // lbl_ten_66_truong
            // 
            lbl_ten_66_truong.AutoSize = true;
            lbl_ten_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_ten_66_truong.Location = new Point(96, 338);
            lbl_ten_66_truong.Name = "lbl_ten_66_truong";
            lbl_ten_66_truong.Size = new Size(38, 20);
            lbl_ten_66_truong.TabIndex = 4;
            lbl_ten_66_truong.Text = "Tên:";
            // 
            // lbl_gia_66_truong
            // 
            lbl_gia_66_truong.AutoSize = true;
            lbl_gia_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_gia_66_truong.Location = new Point(96, 392);
            lbl_gia_66_truong.Name = "lbl_gia_66_truong";
            lbl_gia_66_truong.Size = new Size(36, 20);
            lbl_gia_66_truong.TabIndex = 5;
            lbl_gia_66_truong.Text = "Giá:";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Location = new Point(0, 459);
            label2.Name = "label2";
            label2.Size = new Size(436, 24);
            label2.TabIndex = 9;
            // 
            // Form3_BangThongTinSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 482);
            Controls.Add(label2);
            Controls.Add(lbl_gia_66_truong);
            Controls.Add(lbl_ten_66_truong);
            Controls.Add(label1);
            Controls.Add(lbl_giaTien_66_truong);
            Controls.Add(lbl_tenSanPham_66_truong);
            Controls.Add(pictureBox_Image_66_truong);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3_BangThongTinSanPham";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Image_66_truong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_Image_66_truong;
        private Label lbl_tenSanPham_66_truong;
        private Label lbl_giaTien_66_truong;
        private Label label1;
        private Label lbl_ten_66_truong;
        private Label lbl_gia_66_truong;
        private Label label2;
    }
}