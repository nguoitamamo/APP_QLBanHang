using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form_ThongKe : Form
    {

        Data data;
        int STT_Sp = 0;   // STT trong ListView các sản phẩm bán
        int STT_khoangchi = 0; // STT trong ListView các khoảng chi
        internal Form_ThongKe(Data data)
        {
            InitializeComponent();
            this.data = data;
        }
        internal void LoadDataThongKe()
        {

            foreach (SanPham sanPham in data.getALlSanPhamTrongNgay())
            {
                if (sanPham != null && !CheckSanPhamHasInListView(sanPham.Ten))
                {
                    ListViewItem newSanPham = new ListViewItem();
                    STT_Sp++;
                    newSanPham.Text = STT_Sp.ToString();
                    newSanPham.SubItems.Add(sanPham.Ten);
                    newSanPham.SubItems.Add("1");
                    newSanPham.SubItems.Add(sanPham.Gia + ".000VND");
                    listview_sanphanBan_66_truong.Items.Add(newSanPham);

                }
                else
                {

                    updateSL(sanPham.Ten);
                }
            }
            txt_tongthu_66_truong.Text = sumGiaTien(listview_sanphanBan_66_truong) + ".000VND";
        }
        internal void LoadThongKe(ThongKe thongKe)
        {
            lbl_ngayGio_66_truong.Text = thongKe.GetDateTime() + "";
            lbl_ngayGio1_66_truong.Text = thongKe.GetDateTime() + "";
            lbl_chon_66_truong.Visible = false;
            comboBox_tenKhoangChi_66_truong.Visible = false;
            nrud_soluong_66_truong.Visible = false;
            txt_giaChi_66_truong.Visible = false;
            btn_XacNhan_66_truong.Visible = false;
            btn_inThonKe_66_truong.Visible = false;
            LoadDataSPBanThongKe(thongKe);
            LoadDataChiThongKe(thongKe.GetChiInDay());
        }
        internal void LoadDataSPBanThongKe(ThongKe thongKe)
        {

            foreach (SanPham sanPham in thongKe.GetSpBan())
            {
                if (sanPham != null && !CheckSanPhamHasInListView(sanPham.Ten))
                {
                    ListViewItem newSanPham = new ListViewItem();
                    STT_Sp++;
                    newSanPham.Text = STT_Sp.ToString();
                    newSanPham.SubItems.Add(sanPham.Ten);
                    newSanPham.SubItems.Add("1");
                    newSanPham.SubItems.Add(sanPham.Gia + ".000VND");
                    listview_sanphanBan_66_truong.Items.Add(newSanPham);

                }
                else
                {

                    updateSL(sanPham.Ten, sanPham);
                }
            }
            txt_tongthu_66_truong.Text = sumGiaTien(listview_sanphanBan_66_truong) + ".000VND";

        }
        internal void LoadDataChiThongKe(List<Chi> list)
        {

            foreach (Chi chi in list)
            {
                ListViewItem listViewItem = new ListViewItem();
                STT_khoangchi++;
                listViewItem.Text = STT_khoangchi + "";
                listViewItem.SubItems.Add(chi.Ten);
                listViewItem.SubItems.Add(chi.SoLuong + "");
                listViewItem.SubItems.Add(chi.Gia + ".000VND");

                listView_bangChi_66_truong.Items.Add(listViewItem);
            }
            txt_tongchi_66_truong.Text = sumGiaTien(listView_bangChi_66_truong) + ".000VND";
            txt_tongDoanhThu_66_truong.Text = int.Parse(txt_tongthu_66_truong.Text.Replace(".000VND", "")) - int.Parse(txt_tongchi_66_truong.Text.Replace(".000VND", "")) + ".000VND";
        }


       

        public bool CheckSanPhamHasInListView(string textValue)
        {
            ListViewItem foundItem = listview_sanphanBan_66_truong.FindItemWithText(textValue);
            return foundItem != null;
        }
        internal void updateSL(string ten, SanPham sanPham)
        {
            foreach (ListViewItem item in listview_sanphanBan_66_truong.Items)
            {
                if (item.SubItems[1].Text.Equals(ten))
                {

                    item.SubItems[2].Text = int.Parse(item.SubItems[2].Text) + 1 + "";
                    item.SubItems[3].Text = int.Parse(item.SubItems[3].Text.Replace(".000VND", "")) + int.Parse(item.SubItems[3].Text.Replace(".000VND", "")) + ".000VND";
                    listview_sanphanBan_66_truong.Refresh();
                    break;
                }
            }
        }
        public int sumGiaTien(ListView l)
        {
            int tongGiaTien = 0;
            foreach (ListViewItem item in l.Items)
            {
                tongGiaTien += int.Parse(item.SubItems[3].Text.Replace(".000VND", ""));

            }
            return tongGiaTien;
        }
    

        internal void updateSL(string ten)
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



        private void btn_XacNhan_66_truong_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            STT_khoangchi++;
            listViewItem.Text = STT_khoangchi + "";

            listViewItem.SubItems.Add(comboBox_tenKhoangChi_66_truong.Text);
            listViewItem.SubItems.Add(nrud_soluong_66truong.Value + "");
            listViewItem.SubItems.Add(txt_giaChi_66_truong.Text + ".000VND");

            listView_bangChi_66_truong.Items.Add(listViewItem);
            txt_tongchi_66_truong.Text = sumGiaTien(listView_bangChi_66_truong) + ".000VND";

            txt_tongDoanhThu_66_truong.Text = int.Parse(txt_tongthu_66_truong.Text.Replace(".000VND", "")) - int.Parse(txt_tongchi_66_truong.Text.Replace(".000VND", "")) + ".000VND";

            data.GetgrChi().Add(new Chi(comboBox_tenKhoangChi_66_truong.Text, int.Parse(txt_giaChi_66_truong.Text), (int)nrud_soluong_66truong.Value));

            txt_giaChi_66_truong.Text = "";
            txt_giaChi_66_truong.Refresh();
        }

      
        internal void CopyAllSanPhamTrongNgay(ref ThongKe thongKe)
        {
            foreach (SanPham sp in data.getALlSanPhamTrongNgay())
            {
                thongKe.GetSpBan().Add(sp);
            }
            if (data.GetgrChi().Count() == 0) data.GetgrChi().Add(new Chi("Trống", 0, 0));
            foreach (Chi chi in data.GetgrChi())
            {
                thongKe.GetChiInDay().Add(chi);
            }
        }
        private void btn_inThonKe_66_truong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn in thống kê chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DateTime dateTime = DateTime.Now;
                ThongKe thongKe = new ThongKe(dateTime);
                CopyAllSanPhamTrongNgay(ref thongKe);
                data.GetListThongKe().Add(thongKe);

                data.WriterFileThongKe(dateTime + "");
                data.GetgrChi().Clear();
                data.getALlSanPhamTrongNgay().Clear();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data);
            form_DanhSachBan.ShowDialog();
        }



     

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void Form_ThongKe_KeyDown(object sender, KeyEventArgs e)
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
            Form_TroGiup form_TroGiup = new Form_TroGiup(data);
            form_TroGiup.ShowDialog();
        }

      
    }
}
