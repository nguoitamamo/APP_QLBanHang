namespace WinFormsApp1
{
    partial class Form_ThanhToan_nhieumon
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
            thoToolStripMenuItem = new ToolStripMenuItem();
            xemLạiDanhSáchThốngKêToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            thêmMónMớiToolStripMenuItem = new ToolStripMenuItem();
            sửaThôngTinMónToolStripMenuItem = new ToolStripMenuItem();
            xóaMónToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem1 = new ToolStripMenuItem();
            lbl_infodonhang_66_truong = new Label();
            label1 = new Label();
            listview_sanphanBan_66_truong = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label2 = new Label();
            lbl_tongTien_66_truong = new Label();
            btn_xacNhanThanhToan_66_truong = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 255, 192);
            menuStrip1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, hệThốngToolStripMenuItem, trợGiúpToolStripMenuItem, trợGiúpToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(822, 28);
            menuStrip1.TabIndex = 0;
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
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoToolStripMenuItem, xemLạiDanhSáchThốngKêToolStripMenuItem });
            hệThốngToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(91, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thoToolStripMenuItem
            // 
            thoToolStripMenuItem.Name = "thoToolStripMenuItem";
            thoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            thoToolStripMenuItem.Size = new Size(367, 26);
            thoToolStripMenuItem.Text = "Thống Kê Doanh Thu Hôm Nay";
            thoToolStripMenuItem.Click += thoToolStripMenuItem_Click;
            // 
            // xemLạiDanhSáchThốngKêToolStripMenuItem
            // 
            xemLạiDanhSáchThốngKêToolStripMenuItem.Name = "xemLạiDanhSáchThốngKêToolStripMenuItem";
            xemLạiDanhSáchThốngKêToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            xemLạiDanhSáchThốngKêToolStripMenuItem.Size = new Size(367, 26);
            xemLạiDanhSáchThốngKêToolStripMenuItem.Text = "Xem Danh Sách Thống Kê";
            xemLạiDanhSáchThốngKêToolStripMenuItem.Click += xemLạiDanhSáchThốngKêToolStripMenuItem_Click;
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
            thêmMónMớiToolStripMenuItem.Text = "Thêm Món Mới";
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
            xóaMónToolStripMenuItem.Text = "Xóa Món";
            xóaMónToolStripMenuItem.Click += xóaMónToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem1
            // 
            trợGiúpToolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            trợGiúpToolStripMenuItem1.Size = new Size(83, 24);
            trợGiúpToolStripMenuItem1.Text = "Trợ Giúp";
            trợGiúpToolStripMenuItem1.Click += trợGiúpToolStripMenuItem1_Click;
            // 
            // lbl_infodonhang_66_truong
            // 
            lbl_infodonhang_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            lbl_infodonhang_66_truong.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_infodonhang_66_truong.Location = new Point(0, 28);
            lbl_infodonhang_66_truong.Name = "lbl_infodonhang_66_truong";
            lbl_infodonhang_66_truong.Size = new Size(819, 54);
            lbl_infodonhang_66_truong.TabIndex = 1;
            lbl_infodonhang_66_truong.Text = "THÔNG TIN ĐƠN HÀNG";
            lbl_infodonhang_66_truong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(0, 632);
            label1.Name = "label1";
            label1.Size = new Size(829, 44);
            label1.TabIndex = 2;
            label1.Text = "Cảm Ơn Quý Khách";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listview_sanphanBan_66_truong
            // 
            listview_sanphanBan_66_truong.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listview_sanphanBan_66_truong.ForeColor = Color.Red;
            listview_sanphanBan_66_truong.FullRowSelect = true;
            listview_sanphanBan_66_truong.GridLines = true;
            listview_sanphanBan_66_truong.Location = new Point(119, 117);
            listview_sanphanBan_66_truong.Name = "listview_sanphanBan_66_truong";
            listview_sanphanBan_66_truong.Size = new Size(581, 311);
            listview_sanphanBan_66_truong.TabIndex = 3;
            listview_sanphanBan_66_truong.UseCompatibleStateImageBehavior = false;
            listview_sanphanBan_66_truong.View = View.Details;
            listview_sanphanBan_66_truong.SelectedIndexChanged += listview_sanphanBan_66_truong_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên Sản Phẩm";
            columnHeader2.Width = 320;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số Lượng";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giá Tiền";
            columnHeader4.Width = 126;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(465, 431);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 4;
            label2.Text = "Tổng giá tiền:";
            // 
            // lbl_tongTien_66_truong
            // 
            lbl_tongTien_66_truong.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl_tongTien_66_truong.ForeColor = Color.Red;
            lbl_tongTien_66_truong.Location = new Point(579, 431);
            lbl_tongTien_66_truong.Name = "lbl_tongTien_66_truong";
            lbl_tongTien_66_truong.Size = new Size(121, 25);
            lbl_tongTien_66_truong.TabIndex = 5;
            // 
            // btn_xacNhanThanhToan_66_truong
            // 
            btn_xacNhanThanhToan_66_truong.AutoSize = true;
            btn_xacNhanThanhToan_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            btn_xacNhanThanhToan_66_truong.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_xacNhanThanhToan_66_truong.ForeColor = Color.Black;
            btn_xacNhanThanhToan_66_truong.Location = new Point(523, 496);
            btn_xacNhanThanhToan_66_truong.Name = "btn_xacNhanThanhToan_66_truong";
            btn_xacNhanThanhToan_66_truong.Size = new Size(177, 30);
            btn_xacNhanThanhToan_66_truong.TabIndex = 6;
            btn_xacNhanThanhToan_66_truong.Text = "Xác Nhận Thanh Toán";
            btn_xacNhanThanhToan_66_truong.UseVisualStyleBackColor = false;
            btn_xacNhanThanhToan_66_truong.Click += btn_xacNhanThanhToan_66_truong_Click;
            // 
            // Form_ThanhToan_nhieumon
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 676);
            Controls.Add(btn_xacNhanThanhToan_66_truong);
            Controls.Add(lbl_tongTien_66_truong);
            Controls.Add(label2);
            Controls.Add(listview_sanphanBan_66_truong);
            Controls.Add(label1);
            Controls.Add(lbl_infodonhang_66_truong);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form_ThanhToan_nhieumon";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_ThanhToan_nhieumon";
            KeyDown += Form_ThanhToan_nhieumon_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private Label lbl_infodonhang_66_truong;
        private Label label1;
        private ListView listview_sanphanBan_66_truong;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label2;
        private Label lbl_tongTien_66_truong;
        private Button btn_xacNhanThanhToan_66_truong;
        private ToolStripMenuItem thoToolStripMenuItem;
        private ToolStripMenuItem xemLạiDanhSáchThốngKêToolStripMenuItem;
        private ToolStripMenuItem thêmMónMớiToolStripMenuItem;
        private ToolStripMenuItem sửaThôngTinMónToolStripMenuItem;
        private ToolStripMenuItem xóaMónToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem1;
    }
}