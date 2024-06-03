using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WinFormsApp1
{
    public partial class Form_TroGiup : Form
    {
        Data data;
        internal Form_TroGiup(Data data)
        {
            InitializeComponent();
            this.data = data;
        }
        private void btn_gui_66_truong_Click(object sender, EventArgs e)
        {
            if (txt_EmailSender_66_truong.Text == null || txt_noidung_66_truong.Text == null || txt_pass_66_truong.Text == null || txt_tieuDe_66_truong.Text == null) MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string tieuDe = txt_tieuDe_66_truong.Text;
                string MailForm = txt_EmailSender_66_truong.Text.Trim();
                string pass = txt_pass_66_truong.Text.Trim();
                string noiDung = txt_noidung_66_truong.Text;

                MailMessage mailMessage = new MailMessage();
                mailMessage.Subject = tieuDe;
                mailMessage.Body = noiDung;
                mailMessage.From = new MailAddress(MailForm);
                mailMessage.To.Add("huynhngoctruongg@gmail.com");


                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(MailForm, pass);
                try
                {
                    smtpClient.Send(mailMessage);
                    MessageBox.Show("Gửi mail thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
            form_DanhSachBan.ShowDialog();
        }

        private void Form_TroGiup_KeyDown(object sender, KeyEventArgs e)
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

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_XoaMon form_XoaMon = new Form_XoaMon(data);
            form_XoaMon.ShowDialog();
        }

   
    }
}
