using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form_SuaThongTinMon : Form
    {
        Data data;
        internal Form_SuaThongTinMon(Data data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void btn_xacNhan_66_truong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_giaMon_66_truong.Text) || string.IsNullOrEmpty(txt_tenMon_66_truong.Text)|| string.IsNullOrEmpty(txt_pathFileImage_66_truong.Text)) MessageBox.Show("Vui lòng điền đầy đủ thông tin sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                SanPham spham = GetSanPham(tenmon_66_truong.Text);
                data.GetgrSanPham().Remove(spham);
                data.GetgrSanPham().Add(new SanPham(spham.NhomSP, txt_tenMon_66_truong.Text, int.Parse(txt_giaMon_66_truong.Text),  txt_pathFileImage_66_truong.Text));
                data.WriterListSanPhamCurrent();
                MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        internal SanPham GetSanPham(string ten)
        {
            foreach (SanPham sp in data.GetgrSanPham())
            {
                if (sp.Ten.Equals(ten)) return sp;

            }
            return null;
        }
     

        private void Form_SuaThongTinMon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tenmon_66_truong.Text == null) MessageBox.Show("Vui lòng nhập tên món cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string tenMon = tenmon_66_truong.Text;
                    SanPham sanPham = GetSanPham(tenMon);
                    if (sanPham != null)
                    {
                        pictureBox_image_66_truong.Image = (Image)Resources.ResourceManager.GetObject(sanPham.TenFileImage);
                        lbl_gia_66_truong.Text = sanPham.Gia + ".000VND";
                        lbl_ten_66_truong.Text = sanPham.Ten;
                       
                    }else MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
            {
                this.Hide();
                Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
                form_DanhSachBan.ShowDialog();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
            form_DanhSachBan.ShowDialog();
        }

        private void thốngKêDoanhThuHômNayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ThongKe form_ThongKe = new Form_ThongKe(data);
            form_ThongKe.LoadDataThongKe();
            form_ThongKe.ShowDialog();
        }

        private void xemDanhSáchThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ChonDayThongKe form_ChonDayThongKe = new Form_ChonDayThongKe(data);
            form_ChonDayThongKe.ShowDialog();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_XoaMon form_XoaMon = new Form_XoaMon(data);
            form_XoaMon.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_TroGiup form_TroGiup = new Form_TroGiup(data);
            form_TroGiup.ShowDialog();
        }
    }
}
