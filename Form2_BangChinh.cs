using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static WinFormsApp1.Data;
using Button = System.Windows.Forms.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using GroupBox = System.Windows.Forms.GroupBox;
using ToolTip = System.Windows.Forms.ToolTip;
using System.Resources;
using static System.Windows.Forms.DataFormats;
using System.Reflection;
using System.Collections;
using ListView = System.Windows.Forms.ListView;
using WinFormsApp1.Properties;
namespace WinFormsApp1
{
    public partial class Form2_BangChinh : Form
    {
        Data data;
        Ban banPhu;
        internal Form2_BangChinh(Ban ban, Data data)
        {
            InitializeComponent();
            this.data = data;
            this.banPhu = ban;

            LoadNhomSanPhamToListView(); // load nhóm sản phẩm tức là tạo ListView
            LoadSanPhamToListView();  // load sản phẩm đến các ListView
            RemoveNhomSanPham();  // remove nhóm sản phẩm tức là xóa ListView
            if (ban.getListSPThanhToan().Count != 0)
            {
                btn_thanhToan_66_truong.Enabled = true;
                loadSanPham(ban);  // load sản phẩm đã chọn trước đó của bàn nhưng chưa thanh toán
            }
            else btn_thanhToan_66_truong.Enabled = false;
        }

        /*  load nhóm sản phẩm tức là tạo ListView */
        internal void themNhomSanPham(string tenNhomMon)
        {
            if (tenNhomMon != null)
            {
                int height = groupBox_listView_SanPham_66_truong.Height;
                groupBox_listView_SanPham_66_truong.Height += 187;
                ListView listView = new ListView();
                listView.Columns.Add(tenNhomMon);
                listView.Columns[0].Width = 442;
                listView.Location = new Point(1, height + 6);
                listView.Size = new Size(208, 181);
                listView.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
                listView.View = View.Details;
                listView.GridLines = true;
                listView.SelectedIndexChanged += ListView_SelectedIndexChanged;
                groupBox_listView_SanPham_66_truong.Controls.Add(listView);
            }
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            if (listView != null)
            {
                ListViewItem ItemSelected = listView.SelectedItems.Cast<ListViewItem>().FirstOrDefault();
                chossenSanPham(listView, ItemSelected);
            }
        }

        public void LoadNhomSanPhamToListView()
        {
            foreach (string nhomMon in data.GetgrNhomMon())
            {
                themNhomSanPham(nhomMon);
            }

        }

        /*  load sản phẩm đến các ListView */
        public ListView TimSpThuocList(string nhomSP)
        {
            foreach (ListView listView in groupBox_listView_SanPham_66_truong.Controls)
            {
                if (listView.Columns[0].Text.Equals(nhomSP)) { return listView; }
            }
            return null;
        }

        public void LoadSanPhamToListView()
        {
            foreach (SanPham sp in data.GetgrSanPham())
                TimSpThuocList(sp.NhomSP).Items.Add(sp.Ten);

        }


        /*   remove nhóm sản phẩm tức là xóa ListView */
        public void RemoveNhomSanPham()
        {
            if (groupBox_listView_SanPham_66_truong.Controls.Count > data.GetgrNhomMon().Count)
            {
                foreach (ListView listView in groupBox_listView_SanPham_66_truong.Controls)
                {
                    if (data.checkExIngrNhomMon(listView.Columns[0].Text) == false)
                    {
                        groupBox_listView_SanPham_66_truong.Controls.Remove(listView);
                        groupBox_listView_SanPham_66_truong.Refresh();
                    }
                }
            }

        }



        internal void loadSanPham(Ban ban)
        {
            foreach (SanPham item in ban.getListSPThanhToan())
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Name = "groupBox";
                groupBox.Width = 100;
                groupBox.Height = 110;
                // Tạo một PictureBox mới
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "pictureBox";
                pictureBox.Size = new Size(100, 110);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                try
                {
                    pictureBox.Image = Resources.ResourceManager.GetObject(item.TenFileImage) as Image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                }
                groupBox.Controls.Add(pictureBox);
                Button btn_TenSanPham = new Button();
                btn_TenSanPham.Size = new Size(100, 29);
                btn_TenSanPham.Text = item.Ten;
                btn_TenSanPham.ForeColor = Color.Red;
                btn_TenSanPham.Location = new Point(0, 81);
                SanPham sanPhamSelected = new SanPham(item.Ten, getGia(item.Ten), getPathImage(item.TenFileImage));
                pictureBox.Tag = sanPhamSelected;
                pictureBox.Controls.Add(btn_TenSanPham);
                pictureBox.MouseClick += PictureBox_MouseClick;
                flowLayoutPanel_danhSachSP_66_truong.Controls.Add(groupBox);

            }

        }


        public string getPathImage(string tenSanPham)
        {
            foreach (SanPham sanPham in data.GetgrSanPham())
                if (sanPham.Ten.Equals(tenSanPham)) return sanPham.TenFileImage;
            return null;
        }
        public int getGia(string tenSanPham)
        {
            foreach (SanPham sanPham in data.GetgrSanPham())
                if (sanPham.Ten.Equals(tenSanPham)) return sanPham.Gia;
            return 0; ;
        }

        internal SanPham GetSanPhamToTen(string tenSanPham)
        {
            
            foreach (SanPham sp in banPhu.getListSPThanhToan())
                if (sp.Ten.Equals(tenSanPham)) return sp;
            return null;
        }

 

     
        public void chossenSanPham(System.Windows.Forms.ListView listViewS, ListViewItem ItemSelected)
        {
            if (listViewS.SelectedItems.Count > 0 || ItemSelected != null)
            {
                string tenFileImgage = getPathImage(ItemSelected.Text);
                banPhu.getListSPThanhToan().Add(new SanPham(ItemSelected.Text, getGia(ItemSelected.Text), tenFileImgage));
                GroupBox groupBox = new GroupBox();
                groupBox.Name = "groupBox";
                groupBox.Width = 100;
                groupBox.Height = 110;

                // Tạo một PictureBox mới
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "pictureBox";
                pictureBox.Size = new Size(100, 110);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                try
                {
                    pictureBox.Image = Resources.ResourceManager.GetObject(tenFileImgage) as Image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                }
                groupBox.Controls.Add(pictureBox);
                Button btn_TenSanPham = new Button();
                btn_TenSanPham.Size = new Size(100, 29);
                btn_TenSanPham.Text = ItemSelected.Text;
                btn_TenSanPham.ForeColor = Color.Red;
                btn_TenSanPham.Location = new Point(0, 81);
                SanPham sanPhamSelected = new SanPham(ItemSelected.Text, getGia(ItemSelected.Text), tenFileImgage);
                pictureBox.Tag = sanPhamSelected;
                pictureBox.Controls.Add(btn_TenSanPham);
                pictureBox.MouseClick += PictureBox_MouseClick;
                flowLayoutPanel_danhSachSP_66_truong.Controls.Add(groupBox);
            }
        }


        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pictureBox = (PictureBox)sender;
                SanPham sanPhamSelected = pictureBox.Tag as SanPham;
                if (sanPhamSelected != null)
                {
                    Form3_BangThongTinSanPham Form3_info_sanPham = new 
                        Form3_BangThongTinSanPham(sanPhamSelected.TenFileImage, sanPhamSelected.Ten, sanPhamSelected.Gia);
                    Form3_info_sanPham.ShowDialog();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                PictureBox pictureBox = (PictureBox)sender;
                if (pictureBox != null)
                {
                    Button btn_Xoa = new Button();
                    btn_Xoa.Text = "Xóa";
                    btn_Xoa.Location = new Point(13, 25);
                    btn_Xoa.Click += (sender, args) =>
                    {
                        banPhu.getListSPThanhToan().Remove(GetSanPhamToTen(pictureBox.Controls[0].Text));
                        flowLayoutPanel_danhSachSP_66_truong.Controls.Remove(pictureBox.Parent);
                        pictureBox.Dispose();
                        flowLayoutPanel_danhSachSP_66_truong.Refresh();
                    };

                    Button btn_GhiChu = new Button();
                    btn_GhiChu.Text = "Ghi chú";
                    btn_GhiChu.Location = new Point(13, 50);
                    pictureBox.Controls.Add(btn_Xoa);
                    pictureBox.Controls.Add(btn_GhiChu);
                    pictureBox.MouseHover += (sender, e) =>
                    {
                        if (!IsMouseOutsidePictureBox(pictureBox))
                        {
                            btn_GhiChu.Hide();
                            btn_Xoa.Hide();
                        }
                    };
                }
            }
        }
        private bool IsMouseOutsidePictureBox(PictureBox pictureBox)
        {
            Point mousePosition = pictureBox.PointToClient(Control.MousePosition);
            return !pictureBox.ClientRectangle.Contains(mousePosition);
        }

        private void btn_xacNhanOrder_66_truong_Click_1(object sender, EventArgs e)
        {

            ToolTip toolTip_XacNhan = new ToolTip();
            toolTip_XacNhan.SetToolTip(btn_xacNhanOrder_66_truong, "Nhấn xác nhận sẽ thêm hàng đợi các món cần làm");
            if (banPhu.getListSPThanhToan().Count != 0)
                btn_thanhToan_66_truong.Enabled = true;
            else
            {
                btn_thanhToan_66_truong.Enabled = false;
                MessageBox.Show("Hiện tại không có sản phẩm nào cần thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_thanhToan_66_truong_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form_ThanhToan_nhieumon form_ThanhToan_Nhieumon = new Form_ThanhToan_nhieumon(banPhu, data);
            form_ThanhToan_Nhieumon.ShowDialog();
        }



        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
            form_DanhSachBan.ShowDialog();


        }

        private void nhậpMónMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ThongKe form_ThongKe = new Form_ThongKe(data);
            form_ThongKe.LoadDataThongKe();
            form_ThongKe.ShowDialog();
        }

        private void xemThốngKêTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form_ChonDayThongKe form_ChonDayThongKe = new Form_ChonDayThongKe(data);
            form_ChonDayThongKe.ShowDialog();
        }

        private void thêmMónMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ThemMon form_ThemMon = new Form_ThemMon(data);
            form_ThemMon.ShowDialog();
        }

        private void sửaThôngTinMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SuaThongTinMon form_SuaThongTinMon = new Form_SuaThongTinMon(data);
            form_SuaThongTinMon.ShowDialog();
        }

        private void xóaMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_XoaMon form_XoaMon = new Form_XoaMon(data);
            form_XoaMon.ShowDialog();
        }

        private void Form2_BangChinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
            {
                this.Hide();
                Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
                form_DanhSachBan.ShowDialog();
            }
        }

        private void trợGiúpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_TroGiup form_TroGiup = new Form_TroGiup(data);
            form_TroGiup.ShowDialog();
        }

    
    }
}
