using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form_ChonDayThongKe : Form
    {
        Data data;


        internal Form_ChonDayThongKe(Data data)
        {
            InitializeComponent();
            this.data = data;
            foreach (ThongKe thongKe in data.GetListThongKe())
            {

                Button button = new Button();
                button.Text = "Thống Kê: " + thongKe.GetDateTime();
                button.BackColor = Color.FromArgb(192, 255, 192);
                button.Size = new Size(284, 39);
                button.Margin = new Padding(21, 5, 3, 5);
                button.Click += Button_Click;
                flowLayoutPanel_ButtonDSThongKe_66_truong.Controls.Add(button);
            }
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string ngayThongKe = clickedButton.Text.Replace("Thống Kê: ", "");
                // Sử dụng biến ngayThongKe ở đây
                if (GetThongKeToDateTime(ngayThongKe) == null) MessageBox.Show("không Tìm thấy Thống kê tương ứng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.Hide();
                    Form_ThongKe form_ThongKe = new Form_ThongKe(data);
                    form_ThongKe.LoadThongKe(GetThongKeToDateTime(ngayThongKe));
                    form_ThongKe.ShowDialog();
                }
            }
        }

        private void pictureBox1_66_truong_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel_ButtonDSThongKe_66_truong.Visible == true)
                flowLayoutPanel_ButtonDSThongKe_66_truong.Visible = false;
            else flowLayoutPanel_ButtonDSThongKe_66_truong.Visible = true;
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
            form_DanhSachBan.ShowDialog();
        }


        internal ThongKe GetThongKeToDateTime(string dateTime)
        {
            foreach (ThongKe thongKe in data.GetListThongKe())
                if (thongKe.GetDateTime().ToString().Equals(dateTime))
                    return thongKe;

            return null;
        }

        private void thoosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void thêmmToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Form_ChonDayThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
