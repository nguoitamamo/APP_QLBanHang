using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form_XoaMon : Form
    {
        Data data;
        internal Form_XoaMon(Data data)
        {
            InitializeComponent();
            this.data = data;
        }
        internal SanPham GetSPXoa(string ten)
        {
            foreach (SanPham sp in data.GetgrSanPham()) if (sp.Ten == ten) return sp;
            return null;
        }

        private void btn_Xoa_66_truong_Click(object sender, EventArgs e)
        {
          
                if (GetSPXoa(txt_tenSP_66_truong.Text) != null && !data.checkExSanPhamInALlBan())
                {
                   
                    data.GetgrSanPham().Remove(GetSPXoa(txt_tenSP_66_truong.Text));

                    data.WriterListSanPhamCurrent();
                    MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else MessageBox.Show("Không tìm thấy Sản Phẩm cần xóa hoặc đảm bảo rằng tất cả các bàn đã được thanh toán trước khi xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         

        }





        private void btn_xoaMon_66_truong_Click(object sender, EventArgs e)
        {
            lbl_xoaTieuDe_66_truong.Text = btn_xoaMon_66_truong.Text;
            gB_xoaMon_66_truong.Visible = true;
            gB_xoaNhomSanPham_66_truong.Visible = false;
            gB_xoaBan_66_truong.Visible = false;
            gB_xoaDayBan_66_truong.Visible = false;

        }

        private void btn_xoaNhomMon_66_truong_Click(object sender, EventArgs e)
        {
            lbl_xoaTieuDe_66_truong.Text = btn_xoaNhomMon_66_truong.Text;
            gB_xoaNhomSanPham_66_truong.Visible = true;
            gB_xoaMon_66_truong.Visible = false;
            gB_xoaBan_66_truong.Visible = false;
            gB_xoaDayBan_66_truong.Visible = false;

        }

        private void button_xoaNhomSanPham_66_truong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_nhomXoaSanPham_66_truong.Text)) MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                data.GetgrNhomMon().Remove(comboBox_nhomXoaSanPham_66_truong.Text);

                data.RemoveSanPham(comboBox_nhomXoaSanPham_66_truong.Text);
                data.WriterListNhomMonCurrent();
                data.WriterListSanPhamCurrent();
                MessageBox.Show("Đã xóa thành công nhóm món " + comboBox_nhomXoaSanPham_66_truong.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_xoaBan_66_truong_Click(object sender, EventArgs e)
        {
            lbl_xoaTieuDe_66_truong.Text = btn_xoaBan_66_truong.Text;
            gB_xoaBan_66_truong.Visible = true;
            gB_xoaNhomSanPham_66_truong.Visible = false;
            gB_xoaMon_66_truong.Visible = false;
            gB_xoaDayBan_66_truong.Visible = false;

        }

        private void button_xoaBan_66_truong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenBan_66_truong.Text) || string.IsNullOrEmpty(txt_tenDay_66_truong.Text)) MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                data.RemoveBan(txt_tenBan_66_truong.Text); // xóa bàn trong grBan
                data.WrtiterGrBanCurrent(); // ghi lại file: DanhSachBan.txt
                MessageBox.Show("Đã xóa bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }





        private void pictureBox_luachon_66_truong_Click(object sender, EventArgs e)
        {
            if (groupBox_luaChonXoa_66_truong.Visible == true) groupBox_luaChonXoa_66_truong.Visible = false;
            else groupBox_luaChonXoa_66_truong.Visible = true;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
            form_DanhSachBan.ShowDialog();
        }

        private void Form_XoaMon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
            {
                this.Hide();
                Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
                form_DanhSachBan.ShowDialog();
            }
        }

        private void thốngKêDoanhThToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button_xoaDay_66_truong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_tenDayXoa_66_truong.Text)) MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                data.GetgrDayBan().Remove(comboBox_tenDayXoa_66_truong.Text);
                data.WriterGrDayBanCurrent();
                string tenFlow = "flowLayoutPanel_day" + comboBox_tenDayXoa_66_truong.Text[comboBox_tenDayXoa_66_truong.Text.Length - 1].ToString().ToUpper() + "_66_truong";
                data.RemoveALLBanInGrDayBan(tenFlow);
                data.WrtiterGrBanCurrent();
                MessageBox.Show("Đã xóa dãy " + comboBox_nhomXoaSanPham_66_truong.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_xoaDay_66_truong_Click(object sender, EventArgs e)
        {
            lbl_xoaTieuDe_66_truong.Text = btn_xoaDay_66_truong.Text;
            gB_xoaBan_66_truong.Visible = false;
            gB_xoaMon_66_truong.Visible = false;
            gB_xoaNhomSanPham_66_truong.Visible = false;
            gB_xoaDayBan_66_truong.Visible = true;
        }

       
    }
}
