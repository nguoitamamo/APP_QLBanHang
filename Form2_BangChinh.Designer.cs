namespace WinFormsApp1
{
    partial class Form2_BangChinh
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
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            nhậpMónMớiToolStripMenuItem = new ToolStripMenuItem();
            xemThốngKêTheoNgàyToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem1 = new ToolStripMenuItem();
            thêmMónMớiToolStripMenuItem = new ToolStripMenuItem();
            sửaThôngTinMónToolStripMenuItem = new ToolStripMenuItem();
            xóaMónToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem2 = new ToolStripMenuItem();
            flowLayoutPanel_danhSachSP_66_truong = new FlowLayoutPanel();
            lbl_dsSelected_66_truong = new Label();
            btn_xacNhanOrder_66_truong = new Button();
            label1 = new Label();
            btn_thanhToan_66_truong = new Button();
            groupBox_listView_SanPham_66_truong = new GroupBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(192, 255, 192);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, trợGiúpToolStripMenuItem, trợGiúpToolStripMenuItem1, trợGiúpToolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(819, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(64, 29);
            hệThốngToolStripMenuItem.Text = "<-----";
            hệThốngToolStripMenuItem.Click += hệThốngToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhậpMónMớiToolStripMenuItem, xemThốngKêTheoNgàyToolStripMenuItem });
            trợGiúpToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(91, 29);
            trợGiúpToolStripMenuItem.Text = "Hệ Thống";
            // 
            // nhậpMónMớiToolStripMenuItem
            // 
            nhậpMónMớiToolStripMenuItem.Name = "nhậpMónMớiToolStripMenuItem";
            nhậpMónMớiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nhậpMónMớiToolStripMenuItem.Size = new Size(367, 26);
            nhậpMónMớiToolStripMenuItem.Text = "Thống Kê Doanh Thu Hôm Nay";
            nhậpMónMớiToolStripMenuItem.Click += nhậpMónMớiToolStripMenuItem_Click;
            // 
            // xemThốngKêTheoNgàyToolStripMenuItem
            // 
            xemThốngKêTheoNgàyToolStripMenuItem.Name = "xemThốngKêTheoNgàyToolStripMenuItem";
            xemThốngKêTheoNgàyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            xemThốngKêTheoNgàyToolStripMenuItem.Size = new Size(367, 26);
            xemThốngKêTheoNgàyToolStripMenuItem.Text = "Xem Danh Sách Thống Kê";
            xemThốngKêTheoNgàyToolStripMenuItem.Click += xemThốngKêTheoNgàyToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem1
            // 
            trợGiúpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { thêmMónMớiToolStripMenuItem, sửaThôngTinMónToolStripMenuItem, xóaMónToolStripMenuItem });
            trợGiúpToolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            trợGiúpToolStripMenuItem1.Size = new Size(77, 29);
            trợGiúpToolStripMenuItem1.Text = "Tiện ích";
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
            // trợGiúpToolStripMenuItem2
            // 
            trợGiúpToolStripMenuItem2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            trợGiúpToolStripMenuItem2.Name = "trợGiúpToolStripMenuItem2";
            trợGiúpToolStripMenuItem2.Size = new Size(83, 29);
            trợGiúpToolStripMenuItem2.Text = "Trợ Giúp";
            trợGiúpToolStripMenuItem2.Click += trợGiúpToolStripMenuItem2_Click;
            // 
            // flowLayoutPanel_danhSachSP_66_truong
            // 
            flowLayoutPanel_danhSachSP_66_truong.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel_danhSachSP_66_truong.Location = new Point(246, 64);
            flowLayoutPanel_danhSachSP_66_truong.Name = "flowLayoutPanel_danhSachSP_66_truong";
            flowLayoutPanel_danhSachSP_66_truong.Size = new Size(538, 527);
            flowLayoutPanel_danhSachSP_66_truong.TabIndex = 6;
            // 
            // lbl_dsSelected_66_truong
            // 
            lbl_dsSelected_66_truong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl_dsSelected_66_truong.Location = new Point(246, 36);
            lbl_dsSelected_66_truong.Name = "lbl_dsSelected_66_truong";
            lbl_dsSelected_66_truong.Size = new Size(186, 25);
            lbl_dsSelected_66_truong.TabIndex = 8;
            lbl_dsSelected_66_truong.Text = "Danh sách Món đã chọn";
            // 
            // btn_xacNhanOrder_66_truong
            // 
            btn_xacNhanOrder_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            btn_xacNhanOrder_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_xacNhanOrder_66_truong.Location = new Point(634, 603);
            btn_xacNhanOrder_66_truong.Name = "btn_xacNhanOrder_66_truong";
            btn_xacNhanOrder_66_truong.Size = new Size(150, 38);
            btn_xacNhanOrder_66_truong.TabIndex = 0;
            btn_xacNhanOrder_66_truong.Text = "Xác Nhận";
            btn_xacNhanOrder_66_truong.UseVisualStyleBackColor = false;
            btn_xacNhanOrder_66_truong.Click += btn_xacNhanOrder_66_truong_Click_1;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(0, 644);
            label1.Name = "label1";
            label1.Size = new Size(822, 32);
            label1.TabIndex = 11;
            // 
            // btn_thanhToan_66_truong
            // 
            btn_thanhToan_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            btn_thanhToan_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_thanhToan_66_truong.ForeColor = SystemColors.ActiveCaptionText;
            btn_thanhToan_66_truong.Location = new Point(441, 603);
            btn_thanhToan_66_truong.Name = "btn_thanhToan_66_truong";
            btn_thanhToan_66_truong.Size = new Size(150, 38);
            btn_thanhToan_66_truong.TabIndex = 12;
            btn_thanhToan_66_truong.Text = "Thanh Toán";
            btn_thanhToan_66_truong.UseVisualStyleBackColor = false;
            btn_thanhToan_66_truong.Click += btn_thanhToan_66_truong_Click_2;
            // 
            // groupBox_listView_SanPham_66_truong
            // 
            groupBox_listView_SanPham_66_truong.Location = new Point(12, 36);
            groupBox_listView_SanPham_66_truong.Name = "groupBox_listView_SanPham_66_truong";
            groupBox_listView_SanPham_66_truong.Size = new Size(209, 16);
            groupBox_listView_SanPham_66_truong.TabIndex = 13;
            groupBox_listView_SanPham_66_truong.TabStop = false;
            // 
            // Form2_BangChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(822, 676);
            Controls.Add(groupBox_listView_SanPham_66_truong);
            Controls.Add(btn_thanhToan_66_truong);
            Controls.Add(label1);
            Controls.Add(btn_xacNhanOrder_66_truong);
            Controls.Add(lbl_dsSelected_66_truong);
            Controls.Add(flowLayoutPanel_danhSachSP_66_truong);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form2_BangChinh";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            KeyDown += Form2_BangChinh_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel_danhSachSP_66_truong;
        private Label lbl_dsSelected_66_truong;
        private Button btn_xacNhanOrder_66_truong;
        private ToolStripMenuItem trợGiúpToolStripMenuItem1;
        private Label label1;
        private Button btn_thanhToan_66_truong;
        private ToolStripMenuItem nhậpMónMớiToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem2;
        private ToolStripMenuItem xemThốngKêTheoNgàyToolStripMenuItem;
        private ToolStripMenuItem thêmMónMớiToolStripMenuItem;
        private ToolStripMenuItem sửaThôngTinMónToolStripMenuItem;
        private ToolStripMenuItem xóaMónToolStripMenuItem;
        private GroupBox groupBox_listView_SanPham_66_truong;
    }
}