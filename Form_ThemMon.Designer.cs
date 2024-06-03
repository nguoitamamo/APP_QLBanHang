namespace WinFormsApp1
{
    partial class Form_ThemMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThemMon));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thốngKêDoanhThuHômNayToolStripMenuItem = new ToolStripMenuItem();
            xemDanhSáchThốngKêToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            thêmToolStripMenuItem = new ToolStripMenuItem();
            sửaThôngTinMónToolStripMenuItem = new ToolStripMenuItem();
            xóaMónToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem1 = new ToolStripMenuItem();
            lbl_them_66_truong = new Label();
            label2 = new Label();
            lbl_tenmonthem_66_truong = new Label();
            txt_tenSp_66_truong = new TextBox();
            txt_gia_truong = new TextBox();
            lbl_gia_66_truong = new Label();
            lbl_image_66_truong = new Label();
            txt_image_66_truong = new TextBox();
            btn_them_66_truong = new Button();
            toolTip1 = new ToolTip(components);
            comboBox_tenDayBan_66_truong = new ComboBox();
            txt_nhomMon_66_truong = new TextBox();
            lbl_nhommon_66_truong = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            gB_luaChonThem_66_truong = new GroupBox();
            btn_themDayBan_66_truong = new Button();
            btn_themBan_66_truong = new Button();
            btn_themNhomMon_66_truong = new Button();
            btn_themMon_66_truong = new Button();
            gB_themDayBan_66_truong = new GroupBox();
            button_themDayBan_66_truong = new Button();
            txt_tenDayban_66_truong = new TextBox();
            label6 = new Label();
            gB_themMon_66_truong = new GroupBox();
            gB_nhomMon_66_truong = new GroupBox();
            button_themNhomMon_66_truong = new Button();
            textBox_nhomMon_66_truong = new TextBox();
            label4 = new Label();
            gB_themBan_66_truong = new GroupBox();
            button_themBan_66_truong = new Button();
            txt_tenBan_66_truong = new TextBox();
            label5 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gB_luaChonThem_66_truong.SuspendLayout();
            gB_themDayBan_66_truong.SuspendLayout();
            gB_themMon_66_truong.SuspendLayout();
            gB_nhomMon_66_truong.SuspendLayout();
            gB_themBan_66_truong.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 255, 192);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, hệThốngToolStripMenuItem, trợGiúpToolStripMenuItem, trợGiúpToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(819, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(76, 24);
            toolStripMenuItem1.Text = "<-------";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thốngKêDoanhThuHômNayToolStripMenuItem, xemDanhSáchThốngKêToolStripMenuItem });
            hệThốngToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmToolStripMenuItem, sửaThôngTinMónToolStripMenuItem, xóaMónToolStripMenuItem });
            trợGiúpToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(81, 24);
            trợGiúpToolStripMenuItem.Text = " Tiện ích";
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
            // xóaMónToolStripMenuItem
            // 
            xóaMónToolStripMenuItem.Name = "xóaMónToolStripMenuItem";
            xóaMónToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            xóaMónToolStripMenuItem.Size = new Size(285, 26);
            xóaMónToolStripMenuItem.Text = "Xóa Món";
            xóaMónToolStripMenuItem.Click += xóaMónToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem1
            // 
            trợGiúpToolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            trợGiúpToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.S;
            trợGiúpToolStripMenuItem1.Size = new Size(83, 24);
            trợGiúpToolStripMenuItem1.Text = "Trợ Giúp";
            trợGiúpToolStripMenuItem1.Click += trợGiúpToolStripMenuItem1_Click;
            // 
            // lbl_them_66_truong
            // 
            lbl_them_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            lbl_them_66_truong.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl_them_66_truong.Location = new Point(0, 28);
            lbl_them_66_truong.Name = "lbl_them_66_truong";
            lbl_them_66_truong.Size = new Size(819, 52);
            lbl_them_66_truong.TabIndex = 1;
            lbl_them_66_truong.Text = "Thêm ";
            lbl_them_66_truong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Location = new Point(0, 648);
            label2.Name = "label2";
            label2.Size = new Size(819, 30);
            label2.TabIndex = 2;
            // 
            // lbl_tenmonthem_66_truong
            // 
            lbl_tenmonthem_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            lbl_tenmonthem_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl_tenmonthem_66_truong.Location = new Point(38, 135);
            lbl_tenmonthem_66_truong.Name = "lbl_tenmonthem_66_truong";
            lbl_tenmonthem_66_truong.Size = new Size(172, 27);
            lbl_tenmonthem_66_truong.TabIndex = 3;
            lbl_tenmonthem_66_truong.Text = "Tên Món Cần Thêm:";
            lbl_tenmonthem_66_truong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_tenSp_66_truong
            // 
            txt_tenSp_66_truong.Location = new Point(239, 135);
            txt_tenSp_66_truong.Name = "txt_tenSp_66_truong";
            txt_tenSp_66_truong.Size = new Size(210, 27);
            txt_tenSp_66_truong.TabIndex = 4;
            // 
            // txt_gia_truong
            // 
            txt_gia_truong.Location = new Point(239, 213);
            txt_gia_truong.Name = "txt_gia_truong";
            txt_gia_truong.Size = new Size(210, 27);
            txt_gia_truong.TabIndex = 6;
            // 
            // lbl_gia_66_truong
            // 
            lbl_gia_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            lbl_gia_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_gia_66_truong.Location = new Point(38, 220);
            lbl_gia_66_truong.Name = "lbl_gia_66_truong";
            lbl_gia_66_truong.Size = new Size(172, 27);
            lbl_gia_66_truong.TabIndex = 7;
            lbl_gia_66_truong.Text = "Giá:";
            lbl_gia_66_truong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_image_66_truong
            // 
            lbl_image_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            lbl_image_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_image_66_truong.Location = new Point(38, 297);
            lbl_image_66_truong.Name = "lbl_image_66_truong";
            lbl_image_66_truong.Size = new Size(172, 27);
            lbl_image_66_truong.TabIndex = 10;
            lbl_image_66_truong.Text = "Image:";
            lbl_image_66_truong.TextAlign = ContentAlignment.MiddleLeft;
            lbl_image_66_truong.Click += lbl_image_66_truong_Click;
            // 
            // txt_image_66_truong
            // 
            txt_image_66_truong.Location = new Point(239, 294);
            txt_image_66_truong.Name = "txt_image_66_truong";
            txt_image_66_truong.Size = new Size(210, 27);
            txt_image_66_truong.TabIndex = 9;
            toolTip1.SetToolTip(txt_image_66_truong, "Nhập tên File VD: tragung");
            // 
            // btn_them_66_truong
            // 
            btn_them_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            btn_them_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_them_66_truong.Location = new Point(325, 406);
            btn_them_66_truong.Name = "btn_them_66_truong";
            btn_them_66_truong.Size = new Size(124, 29);
            btn_them_66_truong.TabIndex = 11;
            btn_them_66_truong.Text = "Thêm";
            btn_them_66_truong.UseVisualStyleBackColor = false;
            btn_them_66_truong.Click += btn_them_66_truong_Click;
            // 
            // comboBox_tenDayBan_66_truong
            // 
            comboBox_tenDayBan_66_truong.FormattingEnabled = true;
            comboBox_tenDayBan_66_truong.Items.AddRange(new object[] { "Dãy A", "Dãy B", "Dãy C" });
            comboBox_tenDayBan_66_truong.Location = new Point(210, 44);
            comboBox_tenDayBan_66_truong.Name = "comboBox_tenDayBan_66_truong";
            comboBox_tenDayBan_66_truong.Size = new Size(229, 28);
            comboBox_tenDayBan_66_truong.TabIndex = 1;
            toolTip1.SetToolTip(comboBox_tenDayBan_66_truong, "Nhập tên dãy VD: dayD");
            // 
            // txt_nhomMon_66_truong
            // 
            txt_nhomMon_66_truong.Location = new Point(239, 50);
            txt_nhomMon_66_truong.Name = "txt_nhomMon_66_truong";
            txt_nhomMon_66_truong.Size = new Size(210, 27);
            txt_nhomMon_66_truong.TabIndex = 13;
            // 
            // lbl_nhommon_66_truong
            // 
            lbl_nhommon_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            lbl_nhommon_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl_nhommon_66_truong.Location = new Point(38, 50);
            lbl_nhommon_66_truong.Name = "lbl_nhommon_66_truong";
            lbl_nhommon_66_truong.Size = new Size(172, 27);
            lbl_nhommon_66_truong.TabIndex = 12;
            lbl_nhommon_66_truong.Text = "Nhóm Món:";
            lbl_nhommon_66_truong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(6, 101);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 14;
            label3.Text = "Chọn:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // gB_luaChonThem_66_truong
            // 
            gB_luaChonThem_66_truong.Controls.Add(btn_themDayBan_66_truong);
            gB_luaChonThem_66_truong.Controls.Add(btn_themBan_66_truong);
            gB_luaChonThem_66_truong.Controls.Add(btn_themNhomMon_66_truong);
            gB_luaChonThem_66_truong.Controls.Add(btn_themMon_66_truong);
            gB_luaChonThem_66_truong.Location = new Point(11, 132);
            gB_luaChonThem_66_truong.Name = "gB_luaChonThem_66_truong";
            gB_luaChonThem_66_truong.Size = new Size(250, 474);
            gB_luaChonThem_66_truong.TabIndex = 16;
            gB_luaChonThem_66_truong.TabStop = false;
            // 
            // btn_themDayBan_66_truong
            // 
            btn_themDayBan_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            btn_themDayBan_66_truong.FlatStyle = FlatStyle.Flat;
            btn_themDayBan_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_themDayBan_66_truong.Location = new Point(20, 284);
            btn_themDayBan_66_truong.Name = "btn_themDayBan_66_truong";
            btn_themDayBan_66_truong.Size = new Size(206, 29);
            btn_themDayBan_66_truong.TabIndex = 3;
            btn_themDayBan_66_truong.Text = "Thêm Dãy Bàn";
            btn_themDayBan_66_truong.TextAlign = ContentAlignment.MiddleLeft;
            btn_themDayBan_66_truong.UseVisualStyleBackColor = false;
            btn_themDayBan_66_truong.Click += btn_themDayBan_66_truong_Click;
            // 
            // btn_themBan_66_truong
            // 
            btn_themBan_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            btn_themBan_66_truong.FlatStyle = FlatStyle.Flat;
            btn_themBan_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_themBan_66_truong.Location = new Point(20, 204);
            btn_themBan_66_truong.Name = "btn_themBan_66_truong";
            btn_themBan_66_truong.Size = new Size(206, 29);
            btn_themBan_66_truong.TabIndex = 2;
            btn_themBan_66_truong.Text = "Thêm Bàn";
            btn_themBan_66_truong.TextAlign = ContentAlignment.MiddleLeft;
            btn_themBan_66_truong.UseVisualStyleBackColor = false;
            btn_themBan_66_truong.Click += btn_themBan_66_truong_Click;
            // 
            // btn_themNhomMon_66_truong
            // 
            btn_themNhomMon_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            btn_themNhomMon_66_truong.FlatStyle = FlatStyle.Flat;
            btn_themNhomMon_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_themNhomMon_66_truong.Location = new Point(20, 123);
            btn_themNhomMon_66_truong.Name = "btn_themNhomMon_66_truong";
            btn_themNhomMon_66_truong.Size = new Size(206, 29);
            btn_themNhomMon_66_truong.TabIndex = 1;
            btn_themNhomMon_66_truong.Text = "Thêm Nhóm Món Mới";
            btn_themNhomMon_66_truong.TextAlign = ContentAlignment.MiddleLeft;
            btn_themNhomMon_66_truong.UseVisualStyleBackColor = false;
            btn_themNhomMon_66_truong.Click += btn_themNhomMon_66_truong_Click;
            // 
            // btn_themMon_66_truong
            // 
            btn_themMon_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            btn_themMon_66_truong.FlatStyle = FlatStyle.Flat;
            btn_themMon_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_themMon_66_truong.Location = new Point(20, 48);
            btn_themMon_66_truong.Name = "btn_themMon_66_truong";
            btn_themMon_66_truong.Size = new Size(206, 29);
            btn_themMon_66_truong.TabIndex = 0;
            btn_themMon_66_truong.Text = "Thêm Món Mới";
            btn_themMon_66_truong.TextAlign = ContentAlignment.MiddleLeft;
            btn_themMon_66_truong.UseVisualStyleBackColor = false;
            btn_themMon_66_truong.Click += btn_themMon_66_truong_Click;
            // 
            // gB_themDayBan_66_truong
            // 
            gB_themDayBan_66_truong.Controls.Add(button_themDayBan_66_truong);
            gB_themDayBan_66_truong.Controls.Add(txt_tenDayban_66_truong);
            gB_themDayBan_66_truong.Controls.Add(label6);
            gB_themDayBan_66_truong.Location = new Point(271, 132);
            gB_themDayBan_66_truong.Name = "gB_themDayBan_66_truong";
            gB_themDayBan_66_truong.Size = new Size(527, 474);
            gB_themDayBan_66_truong.TabIndex = 5;
            gB_themDayBan_66_truong.TabStop = false;
            gB_themDayBan_66_truong.Visible = false;
            // 
            // button_themDayBan_66_truong
            // 
            button_themDayBan_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            button_themDayBan_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button_themDayBan_66_truong.Location = new Point(306, 178);
            button_themDayBan_66_truong.Name = "button_themDayBan_66_truong";
            button_themDayBan_66_truong.Size = new Size(126, 29);
            button_themDayBan_66_truong.TabIndex = 2;
            button_themDayBan_66_truong.Text = "Thêm";
            button_themDayBan_66_truong.UseVisualStyleBackColor = false;
            button_themDayBan_66_truong.Click += button_themDayBan_66_truong_Click;
            // 
            // txt_tenDayban_66_truong
            // 
            txt_tenDayban_66_truong.Location = new Point(222, 48);
            txt_tenDayban_66_truong.Name = "txt_tenDayban_66_truong";
            txt_tenDayban_66_truong.Size = new Size(210, 27);
            txt_tenDayban_66_truong.TabIndex = 1;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(192, 255, 192);
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(45, 47);
            label6.Name = "label6";
            label6.Size = new Size(156, 29);
            label6.TabIndex = 0;
            label6.Text = "Nhập tên dãy bàn:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gB_themMon_66_truong
            // 
            gB_themMon_66_truong.Controls.Add(lbl_nhommon_66_truong);
            gB_themMon_66_truong.Controls.Add(lbl_tenmonthem_66_truong);
            gB_themMon_66_truong.Controls.Add(txt_tenSp_66_truong);
            gB_themMon_66_truong.Controls.Add(txt_gia_truong);
            gB_themMon_66_truong.Controls.Add(txt_nhomMon_66_truong);
            gB_themMon_66_truong.Controls.Add(lbl_gia_66_truong);
            gB_themMon_66_truong.Controls.Add(txt_image_66_truong);
            gB_themMon_66_truong.Controls.Add(btn_them_66_truong);
            gB_themMon_66_truong.Controls.Add(lbl_image_66_truong);
            gB_themMon_66_truong.Location = new Point(271, 132);
            gB_themMon_66_truong.Name = "gB_themMon_66_truong";
            gB_themMon_66_truong.Size = new Size(527, 474);
            gB_themMon_66_truong.TabIndex = 17;
            gB_themMon_66_truong.TabStop = false;
            gB_themMon_66_truong.Visible = false;
            // 
            // gB_nhomMon_66_truong
            // 
            gB_nhomMon_66_truong.Controls.Add(button_themNhomMon_66_truong);
            gB_nhomMon_66_truong.Controls.Add(textBox_nhomMon_66_truong);
            gB_nhomMon_66_truong.Controls.Add(label4);
            gB_nhomMon_66_truong.Location = new Point(271, 132);
            gB_nhomMon_66_truong.Name = "gB_nhomMon_66_truong";
            gB_nhomMon_66_truong.Size = new Size(527, 474);
            gB_nhomMon_66_truong.TabIndex = 14;
            gB_nhomMon_66_truong.TabStop = false;
            gB_nhomMon_66_truong.Visible = false;
            // 
            // button_themNhomMon_66_truong
            // 
            button_themNhomMon_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            button_themNhomMon_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button_themNhomMon_66_truong.Location = new Point(306, 204);
            button_themNhomMon_66_truong.Name = "button_themNhomMon_66_truong";
            button_themNhomMon_66_truong.Size = new Size(133, 29);
            button_themNhomMon_66_truong.TabIndex = 2;
            button_themNhomMon_66_truong.Text = "Thêm";
            button_themNhomMon_66_truong.UseVisualStyleBackColor = false;
            button_themNhomMon_66_truong.Click += button_themNhomMon_66_truong_Click;
            // 
            // textBox_nhomMon_66_truong
            // 
            textBox_nhomMon_66_truong.Location = new Point(207, 50);
            textBox_nhomMon_66_truong.Name = "textBox_nhomMon_66_truong";
            textBox_nhomMon_66_truong.Size = new Size(232, 27);
            textBox_nhomMon_66_truong.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 255, 192);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(44, 52);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 0;
            label4.Text = "Nhập Nhóm Món:";
            // 
            // gB_themBan_66_truong
            // 
            gB_themBan_66_truong.Controls.Add(button_themBan_66_truong);
            gB_themBan_66_truong.Controls.Add(txt_tenBan_66_truong);
            gB_themBan_66_truong.Controls.Add(label5);
            gB_themBan_66_truong.Controls.Add(comboBox_tenDayBan_66_truong);
            gB_themBan_66_truong.Controls.Add(label1);
            gB_themBan_66_truong.Location = new Point(271, 132);
            gB_themBan_66_truong.Name = "gB_themBan_66_truong";
            gB_themBan_66_truong.Size = new Size(527, 474);
            gB_themBan_66_truong.TabIndex = 3;
            gB_themBan_66_truong.TabStop = false;
            gB_themBan_66_truong.Visible = false;
            // 
            // button_themBan_66_truong
            // 
            button_themBan_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            button_themBan_66_truong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button_themBan_66_truong.Location = new Point(325, 260);
            button_themBan_66_truong.Name = "button_themBan_66_truong";
            button_themBan_66_truong.Size = new Size(111, 29);
            button_themBan_66_truong.TabIndex = 4;
            button_themBan_66_truong.Text = "Thêm";
            button_themBan_66_truong.UseVisualStyleBackColor = false;
            button_themBan_66_truong.Click += button_themBan_66_truong_Click;
            // 
            // txt_tenBan_66_truong
            // 
            txt_tenBan_66_truong.Location = new Point(207, 133);
            txt_tenBan_66_truong.Name = "txt_tenBan_66_truong";
            txt_tenBan_66_truong.Size = new Size(229, 27);
            txt_tenBan_66_truong.TabIndex = 3;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(192, 255, 192);
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(25, 134);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 2;
            label5.Text = "Nhập tên bàn:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(25, 46);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "Chọn dãy cần thêm:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form_ThemMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 676);
            Controls.Add(gB_themDayBan_66_truong);
            Controls.Add(gB_nhomMon_66_truong);
            Controls.Add(gB_themMon_66_truong);
            Controls.Add(gB_themBan_66_truong);
            Controls.Add(gB_luaChonThem_66_truong);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_them_66_truong);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form_ThemMon";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_ThemMon";
            KeyDown += Form_ThemMon_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gB_luaChonThem_66_truong.ResumeLayout(false);
            gB_themDayBan_66_truong.ResumeLayout(false);
            gB_themDayBan_66_truong.PerformLayout();
            gB_themMon_66_truong.ResumeLayout(false);
            gB_themMon_66_truong.PerformLayout();
            gB_nhomMon_66_truong.ResumeLayout(false);
            gB_nhomMon_66_truong.PerformLayout();
            gB_themBan_66_truong.ResumeLayout(false);
            gB_themBan_66_truong.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private Label lbl_them_66_truong;
        private Label label2;
        private Label lbl_tenmonthem_66_truong;
        private TextBox txt_tenSp_66_truong;
        private TextBox txt_gia_truong;
        private Label lbl_gia_66_truong;
        private Label lbl_image_66_truong;
        private TextBox txt_image_66_truong;
        private Button btn_them_66_truong;
        private ToolTip toolTip1;
        private TextBox txt_nhomMon_66_truong;
        private Label lbl_nhommon_66_truong;
        private ToolStripMenuItem thốngKêDoanhThuHômNayToolStripMenuItem;
        private ToolStripMenuItem xemDanhSáchThốngKêToolStripMenuItem;
        private ToolStripMenuItem thêmToolStripMenuItem;
        private ToolStripMenuItem sửaThôngTinMónToolStripMenuItem;
        private ToolStripMenuItem xóaMónToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem1;
        private Label label3;
        private PictureBox pictureBox1;
        private GroupBox gB_luaChonThem_66_truong;
        private Button btn_themDayBan_66_truong;
        private Button btn_themBan_66_truong;
        private Button btn_themNhomMon_66_truong;
        private Button btn_themMon_66_truong;
        private GroupBox gB_themMon_66_truong;
        private GroupBox gB_nhomMon_66_truong;
        private TextBox textBox_nhomMon_66_truong;
        private Label label4;
        private Button button_themNhomMon_66_truong;
        private GroupBox gB_themBan_66_truong;
        private Label label1;
        private ComboBox comboBox_tenDayBan_66_truong;
        private TextBox txt_tenBan_66_truong;
        private Label label5;
        private Button button_themBan_66_truong;
        private GroupBox gB_themDayBan_66_truong;
        private TextBox txt_tenDayban_66_truong;
        private Label label6;
        private Button button_themDayBan_66_truong;
    }
}