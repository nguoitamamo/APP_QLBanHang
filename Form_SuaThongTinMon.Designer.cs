namespace WinFormsApp1
{
    partial class Form_SuaThongTinMon
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thốngKêDoanhThuHômNayToolStripMenuItem = new ToolStripMenuItem();
            xemDanhSáchThốngKêToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            thêmToolStripMenuItem = new ToolStripMenuItem();
            sửaThôngTinMónToolStripMenuItem = new ToolStripMenuItem();
            xóaToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem1 = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tenmon_66_truong = new TextBox();
            txt_tenMon_66_truong = new TextBox();
            txt_giaMon_66_truong = new TextBox();
            txt_pathFileImage_66_truong = new TextBox();
            btn_xacNhan_66_truong = new Button();
            pictureBox_image_66_truong = new PictureBox();
            lbl_ten_66_truong = new Label();
            lbl_gia_66_truong = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_image_66_truong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(819, 50);
            label1.TabIndex = 0;
            label1.Text = "SỬA THÔNG TIN MÓN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 255, 192);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, hệThốngToolStripMenuItem, trợGiúpToolStripMenuItem, trợGiúpToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(822, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(70, 24);
            toolStripMenuItem1.Text = "<------";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thốngKêDoanhThuHômNayToolStripMenuItem, xemDanhSáchThốngKêToolStripMenuItem });
            hệThốngToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(91, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thốngKêDoanhThuHômNayToolStripMenuItem
            // 
            thốngKêDoanhThuHômNayToolStripMenuItem.Name = "thốngKêDoanhThuHômNayToolStripMenuItem";
            thốngKêDoanhThuHômNayToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            thốngKêDoanhThuHômNayToolStripMenuItem.Size = new Size(367, 26);
            thốngKêDoanhThuHômNayToolStripMenuItem.Text = "Thống Kê Doanh Thu Hôm Nay";
            thốngKêDoanhThuHômNayToolStripMenuItem.Click += thốngKêDoanhThuHômNayToolStripMenuItem_Click;
            // 
            // xemDanhSáchThốngKêToolStripMenuItem
            // 
            xemDanhSáchThốngKêToolStripMenuItem.Name = "xemDanhSáchThốngKêToolStripMenuItem";
            xemDanhSáchThốngKêToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            xemDanhSáchThốngKêToolStripMenuItem.Size = new Size(367, 26);
            xemDanhSáchThốngKêToolStripMenuItem.Text = "Xem Danh Sách Thống Kê";
            xemDanhSáchThốngKêToolStripMenuItem.Click += xemDanhSáchThốngKêToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmToolStripMenuItem, sửaThôngTinMónToolStripMenuItem, xóaToolStripMenuItem });
            trợGiúpToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(77, 24);
            trợGiúpToolStripMenuItem.Text = "Tiện ích";
            // 
            // thêmToolStripMenuItem
            // 
            thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            thêmToolStripMenuItem.Size = new Size(229, 26);
            thêmToolStripMenuItem.Text = "Thêm";
            thêmToolStripMenuItem.Click += thêmToolStripMenuItem_Click;
            // 
            // sửaThôngTinMónToolStripMenuItem
            // 
            sửaThôngTinMónToolStripMenuItem.Name = "sửaThôngTinMónToolStripMenuItem";
            sửaThôngTinMónToolStripMenuItem.Size = new Size(229, 26);
            sửaThôngTinMónToolStripMenuItem.Text = "Sửa Thông Tin Món";
            sửaThôngTinMónToolStripMenuItem.Click += sửaThôngTinMónToolStripMenuItem_Click;
            // 
            // xóaToolStripMenuItem
            // 
            xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            xóaToolStripMenuItem.Size = new Size(229, 26);
            xóaToolStripMenuItem.Text = "Xóa";
            xóaToolStripMenuItem.Click += xóaToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem1
            // 
            trợGiúpToolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            trợGiúpToolStripMenuItem1.Size = new Size(83, 24);
            trợGiúpToolStripMenuItem1.Text = "Trợ Giúp";
            trợGiúpToolStripMenuItem1.Click += trợGiúpToolStripMenuItem1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Location = new Point(0, 649);
            label2.Name = "label2";
            label2.Size = new Size(819, 29);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(225, 106);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 3;
            label3.Text = "Tên Món:";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(192, 255, 192);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(455, 158);
            label4.Name = "label4";
            label4.Size = new Size(235, 25);
            label4.TabIndex = 4;
            label4.Text = "Sửa";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(132, 392);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 5;
            label5.Text = "Tên:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(132, 458);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 6;
            label6.Text = "Giá:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tenmon_66_truong
            // 
            tenmon_66_truong.Location = new Point(344, 103);
            tenmon_66_truong.Name = "tenmon_66_truong";
            tenmon_66_truong.Size = new Size(235, 27);
            tenmon_66_truong.TabIndex = 7;
            // 
            // txt_tenMon_66_truong
            // 
            txt_tenMon_66_truong.Location = new Point(455, 222);
            txt_tenMon_66_truong.Name = "txt_tenMon_66_truong";
            txt_tenMon_66_truong.Size = new Size(235, 27);
            txt_tenMon_66_truong.TabIndex = 8;
            // 
            // txt_giaMon_66_truong
            // 
            txt_giaMon_66_truong.Location = new Point(455, 326);
            txt_giaMon_66_truong.Name = "txt_giaMon_66_truong";
            txt_giaMon_66_truong.Size = new Size(235, 27);
            txt_giaMon_66_truong.TabIndex = 9;
            // 
            // txt_pathFileImage_66_truong
            // 
            txt_pathFileImage_66_truong.Location = new Point(455, 450);
            txt_pathFileImage_66_truong.Name = "txt_pathFileImage_66_truong";
            txt_pathFileImage_66_truong.Size = new Size(235, 27);
            txt_pathFileImage_66_truong.TabIndex = 10;
            toolTip1.SetToolTip(txt_pathFileImage_66_truong, "Nhập tên file VD: tragung");
            // 
            // btn_xacNhan_66_truong
            // 
            btn_xacNhan_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            btn_xacNhan_66_truong.Location = new Point(325, 528);
            btn_xacNhan_66_truong.Name = "btn_xacNhan_66_truong";
            btn_xacNhan_66_truong.Size = new Size(152, 29);
            btn_xacNhan_66_truong.TabIndex = 11;
            btn_xacNhan_66_truong.Text = "Xác Nhận";
            btn_xacNhan_66_truong.UseVisualStyleBackColor = false;
            btn_xacNhan_66_truong.Click += btn_xacNhan_66_truong_Click;
            // 
            // pictureBox_image_66_truong
            // 
            pictureBox_image_66_truong.Image = Properties.Resources.xoa;
            pictureBox_image_66_truong.Location = new Point(132, 158);
            pictureBox_image_66_truong.Name = "pictureBox_image_66_truong";
            pictureBox_image_66_truong.Size = new Size(205, 201);
            pictureBox_image_66_truong.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_image_66_truong.TabIndex = 14;
            pictureBox_image_66_truong.TabStop = false;
            // 
            // lbl_ten_66_truong
            // 
            lbl_ten_66_truong.Location = new Point(167, 392);
            lbl_ten_66_truong.Name = "lbl_ten_66_truong";
            lbl_ten_66_truong.Size = new Size(170, 25);
            lbl_ten_66_truong.TabIndex = 15;
            lbl_ten_66_truong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_gia_66_truong
            // 
            lbl_gia_66_truong.Location = new Point(167, 458);
            lbl_gia_66_truong.Name = "lbl_gia_66_truong";
            lbl_gia_66_truong.Size = new Size(170, 25);
            lbl_gia_66_truong.TabIndex = 16;
            lbl_gia_66_truong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Location = new Point(456, 196);
            label7.Name = "label7";
            label7.Size = new Size(107, 25);
            label7.TabIndex = 17;
            label7.Text = "Tên Món:";
            // 
            // label8
            // 
            label8.Location = new Point(456, 294);
            label8.Name = "label8";
            label8.Size = new Size(62, 25);
            label8.TabIndex = 18;
            label8.Text = "Giá:";
            // 
            // label9
            // 
            label9.Location = new Point(456, 424);
            label9.Name = "label9";
            label9.Size = new Size(62, 25);
            label9.TabIndex = 19;
            label9.Text = "Image:";
            // 
            // Form_SuaThongTinMon
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 676);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lbl_gia_66_truong);
            Controls.Add(lbl_ten_66_truong);
            Controls.Add(pictureBox_image_66_truong);
            Controls.Add(btn_xacNhan_66_truong);
            Controls.Add(txt_pathFileImage_66_truong);
            Controls.Add(txt_giaMon_66_truong);
            Controls.Add(txt_tenMon_66_truong);
            Controls.Add(tenmon_66_truong);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form_SuaThongTinMon";
            StartPosition = FormStartPosition.CenterParent;
            Text = "  ";
            KeyDown += Form_SuaThongTinMon_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_image_66_truong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tenmon_66_truong;
        private TextBox txt_tenMon_66_truong;
        private TextBox txt_giaMon_66_truong;
        private TextBox txt_pathFileImage_66_truong;
        private Button btn_xacNhan_66_truong;
        private PictureBox pictureBox_image_66_truong;
        private Label lbl_ten_66_truong;
        private Label lbl_gia_66_truong;
        private Label label7;
        private Label label8;
        private Label label9;
        private ToolTip toolTip1;
        private ToolStripMenuItem thốngKêDoanhThuHômNayToolStripMenuItem;
        private ToolStripMenuItem xemDanhSáchThốngKêToolStripMenuItem;
        private ToolStripMenuItem thêmToolStripMenuItem;
        private ToolStripMenuItem sửaThôngTinMónToolStripMenuItem;
        private ToolStripMenuItem xóaToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem1;
    }
}