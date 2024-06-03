using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace WinFormsApp1
{
    public partial class Form_ThanhToan_nhieumon : Form
    {
        Ban banPhu;
        int STT = 0;
        Data data;
        internal Form_ThanhToan_nhieumon(Ban ban, Data data)
        {

            InitializeComponent();
            banPhu = ban;
            this.data = data;
            themListViewItem(ban);
        }
        internal void themListViewItem(Ban ban)
        {
            foreach (SanPham p in banPhu.getListSPThanhToan())
            {
                if (p != null && !CheckSanPhamHasInListView(p.Ten))
                {
                    ListViewItem newSanPham = new ListViewItem();
                    STT++;
                    newSanPham.Text = STT.ToString();
                    newSanPham.SubItems.Add(p.Ten);
                    newSanPham.SubItems.Add("1");
                    newSanPham.SubItems.Add(p.Gia + ".000VND");
                    listview_sanphanBan_66_truong.Items.Add(newSanPham);
                }
                else
                    updateSL(p.Ten);           
            }
            lbl_tongTien_66_truong.Text = sumGiaTien() + ".000VND";

        }
        public int sumGiaTien()
        {
            int tongGiaTien = 0;
            foreach (ListViewItem item in listview_sanphanBan_66_truong.Items)
            {
                tongGiaTien += int.Parse(item.SubItems[3].Text.Replace(".000VND", ""));

            }
            return tongGiaTien;
        }
        public void updateSL(string ten)
        {
            foreach (ListViewItem item in listview_sanphanBan_66_truong.Items)
            {
                if (item.SubItems[1].Text.Equals(ten))
                {

                    item.SubItems[2].Text = int.Parse(item.SubItems[2].Text) + 1 + "";
                    item.SubItems[3].Text = int.Parse(item.SubItems[3].Text.Replace(".000VND", "")) + int.Parse(item.SubItems[3].Text.Replace(".000VND", "")) + ".000VND";
                    listview_sanphanBan_66_truong.Refresh(); // Làm mới ListView để hiển thị dữ liệu đã cập nhật
                    break; // Thoát khỏi vòng lặp sau khi đã cập nhật xong
                }
            }
        }

        public bool CheckSanPhamHasInListView(string textValue)
        {
            ListViewItem foundItem = listview_sanphanBan_66_truong.FindItemWithText(textValue);
            return foundItem != null;
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
            form_DanhSachBan.ShowDialog();
        }

        private void btn_xacNhanThanhToan_66_truong_Click(object sender, EventArgs e)
        {

            DialogResult xacNhanThanhToan = MessageBox.Show("Xác Nhận Thanh Toán", "Thanh Toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhanThanhToan == DialogResult.Yes)
            {


                foreach (SanPham i in banPhu.getListSPThanhToan())
                {
                    data.getALlSanPhamTrongNgay().Add(i);
                }
                banPhu.getListSPThanhToan().Clear();

            }
        }





        private void thoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ThongKe form_ThongKe = new Form_ThongKe(data);
            form_ThongKe.LoadDataThongKe();
            form_ThongKe.ShowDialog();
        }

        private void xemLạiDanhSáchThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void Form_ThanhToan_nhieumon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
            {
                this.Hide();
                Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
                form_DanhSachBan.ShowDialog();
            }
        }



        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
            form_DanhSachBan.ShowDialog();
        }

        internal SanPham GetSanPhamToTen(string tenSanPham)
        {

            foreach (SanPham sp in banPhu.getListSPThanhToan())
                if (sp.Ten.Equals(tenSanPham)) return sp;
            return null;
        }

        public void UpdateSTTListViewAfterRemove()
        {
            int stt = 1;
            foreach( ListViewItem listViewItem in listview_sanphanBan_66_truong.Items )
            {
                listViewItem.Text = stt + ""; stt++;
            }
        }
        public void XoaBefore()
        {
            foreach( Control control in listview_sanphanBan_66_truong.Controls)
            {
                listview_sanphanBan_66_truong.Controls.Remove(control);
            } 
        }
        private void listview_sanphanBan_66_truong_SelectedIndexChanged(object sender, EventArgs e)
        {
            XoaBefore();
            ListViewItem ItemSelected = listview_sanphanBan_66_truong.SelectedItems.Cast<ListViewItem>().FirstOrDefault();
            if (ItemSelected != null)
            {
                Point clickLocation = listview_sanphanBan_66_truong.PointToClient(Cursor.Position);

                GroupBox groupBox = new GroupBox();
                groupBox.Text = "Thao tác";
                groupBox.Location = clickLocation;
                groupBox.Size = new Size(112, 81);
                groupBox.Click += (sender, args) =>
                {
                        listview_sanphanBan_66_truong.Controls.Remove(groupBox);                    
                };

                Button btn_Xoa = new Button();
                btn_Xoa.Text = "Xóa";
                btn_Xoa.Size = new Size(73, 29);
                btn_Xoa.Location = new Point(25, 35);
                groupBox.Controls.Add(btn_Xoa);
                listview_sanphanBan_66_truong.Controls.Add(groupBox);
                btn_Xoa.Click += (sender, args) =>
                {
                    listview_sanphanBan_66_truong.Controls.Remove(groupBox);
                    GroupBox groupBox1 = new GroupBox();
                    groupBox1.Text = "Chức năng cần có mật khẩu";
                    groupBox1.Size = new Size(351, 105);
                    groupBox1.Location = new Point(107, 120);

                    PictureBox pictureBox1 = new PictureBox();
                    pictureBox1.Image = Properties.Resources.xoa as Image;
                    pictureBox1.Size = new Size(27, 29);
                    pictureBox1.Location = new Point(325,0);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    groupBox1.Controls.Add(pictureBox1);

                    pictureBox1.Click += (sender, args) =>{
                        listview_sanphanBan_66_truong.Controls.Remove(groupBox1 );
                    };
                    TextBox textBox = new TextBox();
                    textBox.PasswordChar = '*';
                    textBox.Size = new Size(250, 27);
                    textBox.Location = new Point(59, 42);
                    groupBox1.Controls.Add(textBox);
                    listview_sanphanBan_66_truong.Controls.Add(groupBox1);
                    textBox.KeyDown += (sender, args) =>
                    {
                        if (args.KeyCode == Keys.Enter)
                            if (textBox.Text == "12345")
                            {
                                banPhu.RemoveSanPhamThanhToan(ItemSelected.SubItems[1].Text);
                                listview_sanphanBan_66_truong.Items.Remove(ItemSelected);
                                listview_sanphanBan_66_truong.Controls.Remove(groupBox1);
                                UpdateSTTListViewAfterRemove();
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Mật khẩu sai! Nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    };

                };
            }
        }




    }
}
