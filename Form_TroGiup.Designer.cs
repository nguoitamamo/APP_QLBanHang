namespace WinFormsApp1
{
    partial class Form_TroGiup
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            hệThốnhToolStripMenuItem = new ToolStripMenuItem();
            thốngKêDoanhThuHômNayToolStripMenuItem = new ToolStripMenuItem();
            xemDanhSáchThốngKêToolStripMenuItem = new ToolStripMenuItem();
            tiệnÍchToolStripMenuItem = new ToolStripMenuItem();
            thêmToolStripMenuItem = new ToolStripMenuItem();
            sửaThôngTinMónToolStripMenuItem = new ToolStripMenuItem();
            xóaToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_tieuDe_66_truong = new TextBox();
            txt_EmailSender_66_truong = new TextBox();
            txt_pass_66_truong = new TextBox();
            btn_gui_66_truong = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txt_noidung_66_truong = new TextBox();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 255, 192);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, hệThốnhToolStripMenuItem, tiệnÍchToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(819, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.FromArgb(192, 255, 192);
            toolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(70, 24);
            toolStripMenuItem1.Text = "<------";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // hệThốnhToolStripMenuItem
            // 
            hệThốnhToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            hệThốnhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thốngKêDoanhThuHômNayToolStripMenuItem, xemDanhSáchThốngKêToolStripMenuItem });
            hệThốnhToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            hệThốnhToolStripMenuItem.Name = "hệThốnhToolStripMenuItem";
            hệThốnhToolStripMenuItem.Size = new Size(91, 24);
            hệThốnhToolStripMenuItem.Text = "Hệ Thống";
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
            // tiệnÍchToolStripMenuItem
            // 
            tiệnÍchToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            tiệnÍchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmToolStripMenuItem, sửaThôngTinMónToolStripMenuItem, xóaToolStripMenuItem });
            tiệnÍchToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tiệnÍchToolStripMenuItem.Name = "tiệnÍchToolStripMenuItem";
            tiệnÍchToolStripMenuItem.Size = new Size(77, 24);
            tiệnÍchToolStripMenuItem.Text = "Tiện ích";
            // 
            // thêmToolStripMenuItem
            // 
            thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            thêmToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            thêmToolStripMenuItem.Size = new Size(285, 26);
            thêmToolStripMenuItem.Text = "Thêm";
            thêmToolStripMenuItem.Click += thêmToolStripMenuItem_Click;
            // 
            // sửaThôngTinMónToolStripMenuItem
            // 
            sửaThôngTinMónToolStripMenuItem.Name = "sửaThôngTinMónToolStripMenuItem";
            sửaThôngTinMónToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            sửaThôngTinMónToolStripMenuItem.Size = new Size(285, 26);
            sửaThôngTinMónToolStripMenuItem.Text = "Sửa Thông Tin Món";
            sửaThôngTinMónToolStripMenuItem.Click += sửaThôngTinMónToolStripMenuItem_Click;
            // 
            // xóaToolStripMenuItem
            // 
            xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            xóaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            xóaToolStripMenuItem.Size = new Size(285, 26);
            xóaToolStripMenuItem.Text = "Xóa";
            xóaToolStripMenuItem.Click += xóaToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            trợGiúpToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(83, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(819, 42);
            label1.TabIndex = 1;
            label1.Text = "GỬI PHẢN HỒI VỀ CHÚNG TÔI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(192, 255, 192);
            label3.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(0, 638);
            label3.Name = "label3";
            label3.Size = new Size(819, 42);
            label3.TabIndex = 3;
            label3.Text = "XIN CẢM ƠN!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(245, 108);
            label2.Name = "label2";
            label2.Size = new Size(94, 27);
            label2.TabIndex = 4;
            label2.Text = "Tiêu đề:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(192, 255, 192);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(71, 29);
            label4.Name = "label4";
            label4.Size = new Size(195, 25);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(192, 255, 192);
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(71, 117);
            label5.Name = "label5";
            label5.Size = new Size(195, 25);
            label5.TabIndex = 6;
            label5.Text = "Password:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_tieuDe_66_truong
            // 
            txt_tieuDe_66_truong.Location = new Point(354, 108);
            txt_tieuDe_66_truong.Name = "txt_tieuDe_66_truong";
            txt_tieuDe_66_truong.Size = new Size(219, 27);
            txt_tieuDe_66_truong.TabIndex = 7;
            // 
            // txt_EmailSender_66_truong
            // 
            txt_EmailSender_66_truong.Location = new Point(281, 26);
            txt_EmailSender_66_truong.Name = "txt_EmailSender_66_truong";
            txt_EmailSender_66_truong.Size = new Size(227, 27);
            txt_EmailSender_66_truong.TabIndex = 8;
            // 
            // txt_pass_66_truong
            // 
            txt_pass_66_truong.Location = new Point(281, 115);
            txt_pass_66_truong.Name = "txt_pass_66_truong";
            txt_pass_66_truong.PasswordChar = '*';
            txt_pass_66_truong.Size = new Size(227, 27);
            txt_pass_66_truong.TabIndex = 9;
            // 
            // btn_gui_66_truong
            // 
            btn_gui_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            btn_gui_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_gui_66_truong.Location = new Point(385, 375);
            btn_gui_66_truong.Name = "btn_gui_66_truong";
            btn_gui_66_truong.Size = new Size(123, 29);
            btn_gui_66_truong.TabIndex = 12;
            btn_gui_66_truong.Text = "Gửi";
            btn_gui_66_truong.UseVisualStyleBackColor = false;
            btn_gui_66_truong.Click += btn_gui_66_truong_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_noidung_66_truong);
            groupBox1.Controls.Add(txt_EmailSender_66_truong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btn_gui_66_truong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_pass_66_truong);
            groupBox1.Location = new Point(73, 178);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(673, 434);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(192, 255, 192);
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(71, 199);
            label6.Name = "label6";
            label6.Size = new Size(195, 25);
            label6.TabIndex = 14;
            label6.Text = "Mô tả vấn đề của bạn:";
            // 
            // txt_noidung_66_truong
            // 
            txt_noidung_66_truong.Location = new Point(281, 199);
            txt_noidung_66_truong.Multiline = true;
            txt_noidung_66_truong.Name = "txt_noidung_66_truong";
            txt_noidung_66_truong.Size = new Size(227, 117);
            txt_noidung_66_truong.TabIndex = 13;
            // 
            // Form_TroGiup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 676);
            Controls.Add(groupBox1);
            Controls.Add(txt_tieuDe_66_truong);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form_TroGiup";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            KeyDown += Form_TroGiup_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem hệThốnhToolStripMenuItem;
        private ToolStripMenuItem tiệnÍchToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txt_tieuDe_66_truong;
        private TextBox txt_EmailSender_66_truong;
        private TextBox txt_pass_66_truong;
        private Button btn_gui_66_truong;
        private GroupBox groupBox1;
        private TextBox txt_noidung_66_truong;
        private Label label6;
        private ToolStripMenuItem thốngKêDoanhThuHômNayToolStripMenuItem;
        private ToolStripMenuItem xemDanhSáchThốngKêToolStripMenuItem;
        private ToolStripMenuItem thêmToolStripMenuItem;
        private ToolStripMenuItem sửaThôngTinMónToolStripMenuItem;
        private ToolStripMenuItem xóaToolStripMenuItem;
        private ToolTip toolTip1;
    }
}