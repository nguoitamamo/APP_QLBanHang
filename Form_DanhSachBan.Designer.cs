namespace WinFormsApp1
{
    partial class Form_DanhSachBan
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
            lbl_danhsachban_66_truong = new Label();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thốngKêDoanhThuHômNayToolStripMenuItem = new ToolStripMenuItem();
            xemThốngKêTheoNgàyToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            thêmMónMớiToolStripMenuItem = new ToolStripMenuItem();
            sửaThôngTinMónToolStripMenuItem = new ToolStripMenuItem();
            xóaMónToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            groupBox_dayBan_66_truong = new GroupBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_danhsachban_66_truong
            // 
            lbl_danhsachban_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            lbl_danhsachban_66_truong.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl_danhsachban_66_truong.ImageAlign = ContentAlignment.BottomCenter;
            lbl_danhsachban_66_truong.Location = new Point(0, 28);
            lbl_danhsachban_66_truong.Name = "lbl_danhsachban_66_truong";
            lbl_danhsachban_66_truong.Size = new Size(818, 36);
            lbl_danhsachban_66_truong.TabIndex = 0;
            lbl_danhsachban_66_truong.Text = "Danh Sách Tất Cả Bàn";
            lbl_danhsachban_66_truong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 255, 192);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, trợGiúpToolStripMenuItem, trợGiúpToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(818, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thốngKêDoanhThuHômNayToolStripMenuItem, xemThốngKêTheoNgàyToolStripMenuItem });
            hệThốngToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.H;
            hệThốngToolStripMenuItem.Size = new Size(91, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thốngKêDoanhThuHômNayToolStripMenuItem
            // 
            thốngKêDoanhThuHômNayToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            thốngKêDoanhThuHômNayToolStripMenuItem.Name = "thốngKêDoanhThuHômNayToolStripMenuItem";
            thốngKêDoanhThuHômNayToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            thốngKêDoanhThuHômNayToolStripMenuItem.Size = new Size(364, 26);
            thốngKêDoanhThuHômNayToolStripMenuItem.Text = "Thống Kê Doanh Thu Hôm nay";
            thốngKêDoanhThuHômNayToolStripMenuItem.Click += thốngKêDoanhThuHômNayToolStripMenuItem_Click;
            // 
            // xemThốngKêTheoNgàyToolStripMenuItem
            // 
            xemThốngKêTheoNgàyToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            xemThốngKêTheoNgàyToolStripMenuItem.Name = "xemThốngKêTheoNgàyToolStripMenuItem";
            xemThốngKêTheoNgàyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            xemThốngKêTheoNgàyToolStripMenuItem.Size = new Size(364, 26);
            xemThốngKêTheoNgàyToolStripMenuItem.Text = "Xem Danh Sách Thống Kê";
            xemThốngKêTheoNgàyToolStripMenuItem.Click += xemThốngKêTheoNgàyToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmMónMớiToolStripMenuItem, sửaThôngTinMónToolStripMenuItem, xóaMónToolStripMenuItem });
            trợGiúpToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(77, 24);
            trợGiúpToolStripMenuItem.Text = "Tiện ích";
            // 
            // thêmMónMớiToolStripMenuItem
            // 
            thêmMónMớiToolStripMenuItem.Name = "thêmMónMớiToolStripMenuItem";
            thêmMónMớiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            thêmMónMớiToolStripMenuItem.Size = new Size(285, 26);
            thêmMónMớiToolStripMenuItem.Text = "Thêm";
            thêmMónMớiToolStripMenuItem.Click += thêmMónMớiToolStripMenuItem_Click;
            // 
            // sửaThôngTinMónToolStripMenuItem
            // 
            sửaThôngTinMónToolStripMenuItem.Name = "sửaThôngTinMónToolStripMenuItem";
            sửaThôngTinMónToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            sửaThôngTinMónToolStripMenuItem.Size = new Size(285, 26);
            sửaThôngTinMónToolStripMenuItem.Text = "Sửa Thông Tin Món";
            sửaThôngTinMónToolStripMenuItem.Click += sửaThôngTinMónToolStripMenuItem_Click;
            // 
            // xóaMónToolStripMenuItem
            // 
            xóaMónToolStripMenuItem.Name = "xóaMónToolStripMenuItem";
            xóaMónToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            xóaMónToolStripMenuItem.Size = new Size(285, 26);
            xóaMónToolStripMenuItem.Text = "Xóa";
            xóaMónToolStripMenuItem.Click += xóaMónToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem1
            // 
            trợGiúpToolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            trợGiúpToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.T;
            trợGiúpToolStripMenuItem1.Size = new Size(83, 24);
            trợGiúpToolStripMenuItem1.Text = "Trợ Giúp";
            trợGiúpToolStripMenuItem1.Click += trợGiúpToolStripMenuItem1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Location = new Point(0, 651);
            label1.Name = "label1";
            label1.Size = new Size(818, 33);
            label1.TabIndex = 9;
            // 
            // groupBox_dayBan_66_truong
            // 
            groupBox_dayBan_66_truong.Location = new Point(12, 67);
            groupBox_dayBan_66_truong.Name = "groupBox_dayBan_66_truong";
            groupBox_dayBan_66_truong.Size = new Size(797, 19);
            groupBox_dayBan_66_truong.TabIndex = 11;
            groupBox_dayBan_66_truong.TabStop = false;
            groupBox_dayBan_66_truong.Text = " ";
            // 
            // Form_DanhSachBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(822, 676);
            Controls.Add(groupBox_dayBan_66_truong);
            Controls.Add(label1);
            Controls.Add(lbl_danhsachban_66_truong);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_DanhSachBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_DanhSachBan";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_danhsachban_66_truong;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem thốngKêDoanhThuHômNayToolStripMenuItem;
        private ToolStripMenuItem xemThốngKêTheoNgàyToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem1;
        private ToolStripMenuItem thêmMónMớiToolStripMenuItem;
        private ToolStripMenuItem sửaThôngTinMónToolStripMenuItem;
        private ToolStripMenuItem xóaMónToolStripMenuItem;
        private Label label1;
        private GroupBox groupBox_dayBan_66_truong;
    }
}