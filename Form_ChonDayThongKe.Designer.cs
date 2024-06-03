namespace WinFormsApp1
{
    partial class Form_ChonDayThongKe
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thoosToolStripMenuItem = new ToolStripMenuItem();
            xemDanhSáchThốngKêToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            thêmmToolStripMenuItem = new ToolStripMenuItem();
            sửaThôngTinMónToolStripMenuItem = new ToolStripMenuItem();
            xóaToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            pictureBox1_66_truong = new PictureBox();
            label3 = new Label();
            flowLayoutPanel_ButtonDSThongKe_66_truong = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_66_truong).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 255, 192);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, hệThốngToolStripMenuItem, trợGiúpToolStripMenuItem, trợGiúpToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(822, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.FromArgb(192, 255, 192);
            toolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(76, 24);
            toolStripMenuItem1.Text = "<-------";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoosToolStripMenuItem, xemDanhSáchThốngKêToolStripMenuItem });
            hệThốngToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(91, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thoosToolStripMenuItem
            // 
            thoosToolStripMenuItem.Name = "thoosToolStripMenuItem";
            thoosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            thoosToolStripMenuItem.Size = new Size(367, 26);
            thoosToolStripMenuItem.Text = "Thống Kê Doanh Thu Hôm Nay";
            thoosToolStripMenuItem.Click += thoosToolStripMenuItem_Click;
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
            trợGiúpToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmmToolStripMenuItem, sửaThôngTinMónToolStripMenuItem, xóaToolStripMenuItem });
            trợGiúpToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(76, 24);
            trợGiúpToolStripMenuItem.Text = "TIệc ích";
            // 
            // thêmmToolStripMenuItem
            // 
            thêmmToolStripMenuItem.Name = "thêmmToolStripMenuItem";
            thêmmToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            thêmmToolStripMenuItem.Size = new Size(285, 26);
            thêmmToolStripMenuItem.Text = "Thêm";
            thêmmToolStripMenuItem.Click += thêmmToolStripMenuItem_Click;
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
            xóaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            xóaToolStripMenuItem.Size = new Size(285, 26);
            xóaToolStripMenuItem.Text = "Xóa";
            xóaToolStripMenuItem.Click += xóaToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem1
            // 
            trợGiúpToolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            trợGiúpToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.T;
            trợGiúpToolStripMenuItem1.Size = new Size(83, 24);
            trợGiúpToolStripMenuItem1.Text = "Trợ Giúp";
            trợGiúpToolStripMenuItem1.Click += trợGiúpToolStripMenuItem1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(819, 43);
            label1.TabIndex = 1;
            label1.Text = "XEM LẠI THỐNG KÊ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Location = new Point(0, 640);
            label2.Name = "label2";
            label2.Size = new Size(822, 37);
            label2.TabIndex = 2;
            // 
            // pictureBox1_66_truong
            // 
            pictureBox1_66_truong.Image = Properties.Resources.OIP;
            pictureBox1_66_truong.Location = new Point(87, 87);
            pictureBox1_66_truong.Name = "pictureBox1_66_truong";
            pictureBox1_66_truong.Size = new Size(48, 36);
            pictureBox1_66_truong.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1_66_truong.TabIndex = 3;
            pictureBox1_66_truong.TabStop = false;
            pictureBox1_66_truong.Click += pictureBox1_66_truong_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(192, 255, 192);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(4, 87);
            label3.Name = "label3";
            label3.Size = new Size(77, 36);
            label3.TabIndex = 4;
            label3.Text = "Chọn:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_ButtonDSThongKe_66_truong
            // 
            flowLayoutPanel_ButtonDSThongKe_66_truong.AutoScroll = true;
            flowLayoutPanel_ButtonDSThongKe_66_truong.Location = new Point(4, 129);
            flowLayoutPanel_ButtonDSThongKe_66_truong.Name = "flowLayoutPanel_ButtonDSThongKe_66_truong";
            flowLayoutPanel_ButtonDSThongKe_66_truong.Size = new Size(327, 471);
            flowLayoutPanel_ButtonDSThongKe_66_truong.TabIndex = 6;
            // 
            // Form_ChonDayThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 676);
            Controls.Add(flowLayoutPanel_ButtonDSThongKe_66_truong);
            Controls.Add(label3);
            Controls.Add(pictureBox1_66_truong);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form_ChonDayThongKe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_ChonDayThongKe";
            Load += Form_ChonDayThongKe_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_66_truong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1_66_truong;
        private Label label3;
        private ToolStripMenuItem thoosToolStripMenuItem;
        private ToolStripMenuItem xemDanhSáchThốngKêToolStripMenuItem;
        private ToolStripMenuItem thêmmToolStripMenuItem;
        private ToolStripMenuItem sửaThôngTinMónToolStripMenuItem;
        private ToolStripMenuItem xóaToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem1;
        private FlowLayoutPanel flowLayoutPanel_ButtonDSThongKe_66_truong;
    }
}