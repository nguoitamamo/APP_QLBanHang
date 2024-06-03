using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form_ThemMon : Form
    {
        Data data;
        internal Form_ThemMon(Data data)
        {
            InitializeComponent();
            this.data = data;
        }
        // them món
        private void btn_them_66_truong_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_tenSp_66_truong.Text) || string.IsNullOrEmpty(txt_gia_truong.Text) || string.IsNullOrEmpty(txt_image_66_truong.Text) || string.IsNullOrEmpty(txt_nhomMon_66_truong.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                data.GetgrSanPham().Add(new SanPham(txt_nhomMon_66_truong.Text, txt_tenSp_66_truong.Text,
                    int.Parse(txt_gia_truong.Text), txt_image_66_truong.Text));
                MessageBox.Show("Thêm Món Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data.WriterListSanPhamCurrent();
            }


        }


        // them nhóm Món





        private void btn_themMon_66_truong_Click(object sender, EventArgs e)
        {
            lbl_them_66_truong.Text = btn_themMon_66_truong.Text;
            gB_themMon_66_truong.Visible = true;
            gB_nhomMon_66_truong.Visible = false;
            gB_themBan_66_truong.Visible = false;
            gB_themDayBan_66_truong.Visible = false;
        }

        private void btn_themNhomMon_66_truong_Click(object sender, EventArgs e)
        {
            lbl_them_66_truong.Text = btn_themNhomMon_66_truong.Text;
            gB_nhomMon_66_truong.Visible = true;
            gB_themMon_66_truong.Visible = false;
            gB_themBan_66_truong.Visible = false;
            gB_themDayBan_66_truong.Visible = false;
        }

        private void button_themNhomMon_66_truong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_nhomMon_66_truong.Text))
            {

                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                data.GetgrNhomMon().Add(textBox_nhomMon_66_truong.Text);
                data.WriterThemNhonMon(textBox_nhomMon_66_truong.Text);

                MessageBox.Show("Thêm nhóm món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btn_themBan_66_truong_Click(object sender, EventArgs e)
        {
            lbl_them_66_truong.Text = btn_themBan_66_truong.Text;
            gB_themBan_66_truong.Visible = true;
            gB_nhomMon_66_truong.Visible = false;
            gB_themMon_66_truong.Visible = false;
            gB_themDayBan_66_truong.Visible = false;

        }

        private void button_themBan_66_truong_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tenBan_66_truong.Text) || !string.IsNullOrEmpty(comboBox_tenDayBan_66_truong.Text))
            {
                data.GetGrBan().Add(new Ban(txt_tenBan_66_truong.Text, "Trống"), "flowLayoutPanel_day" + comboBox_tenDayBan_66_truong.Text[comboBox_tenDayBan_66_truong.Text.Length - 1].ToString().ToUpper() + "_66_truong");


                data.WriterThemBan(txt_tenBan_66_truong.Text, comboBox_tenDayBan_66_truong.Text);
                MessageBox.Show("Thêm bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (gB_luaChonThem_66_truong.Visible == true) gB_luaChonThem_66_truong.Visible = false;
            else gB_luaChonThem_66_truong.Visible = true;
        }

        private void btn_themDayBan_66_truong_Click(object sender, EventArgs e)
        {
            lbl_them_66_truong.Text = btn_themDayBan_66_truong.Text;
            gB_themDayBan_66_truong.Visible = true;
            gB_nhomMon_66_truong.Visible = false;
            gB_themMon_66_truong.Visible = false;
            gB_themBan_66_truong.Visible = false;
        }

        private void button_themDayBan_66_truong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenDayban_66_truong.Text)) MessageBox.Show("Vui lòng nhập tên dãy cần thêm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                data.GetgrDayBan().Add(txt_tenDayban_66_truong.Text);
                data.WriterThemDayBan(txt_tenDayban_66_truong.Text);
                MessageBox.Show("Thêm dãy bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
            form_DanhSachBan.ShowDialog();
        }

        private void Form_ThemMon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
            {
                this.Hide();
                Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
                form_DanhSachBan.ShowDialog();
            }
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

        private void xóaMónToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void lbl_image_66_truong_Click(object sender, EventArgs e)
        {

        }
    }
}
