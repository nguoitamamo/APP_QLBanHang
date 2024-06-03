using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;
using System.Net.Http.Headers;
using System.Security.Permissions;
namespace WinFormsApp1
{
    public partial class Form_DanhSachBan : Form
    {
        Data data_66_truong;
        internal Form_DanhSachBan(Data data_66_truong)
        {
            InitializeComponent();
            this.data_66_truong = data_66_truong;
            themDayBan();
            CreatBan();
            RemoveBan();
            this.FormClosing += YourForm_FormClosing;
        }
        public void creatDayBan(string tenDay)
        {
            int height_66_truong = groupBox_dayBan_66_truong.Height;
            groupBox_dayBan_66_truong.Height += 173;
            Label lbl_tenDayBan_66_truong = new Label();
            lbl_tenDayBan_66_truong.Name = "lbl_day" + tenDay[tenDay.Length - 1].ToString().ToUpper() + "_66_truong";
            lbl_tenDayBan_66_truong.Location = new Point(6, height_66_truong);
            lbl_tenDayBan_66_truong.Size = new Size(64, 25);
            lbl_tenDayBan_66_truong.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lbl_tenDayBan_66_truong.BackColor = Color.FromArgb(192, 255, 192);
            lbl_tenDayBan_66_truong.Text = tenDay + ":";

            FlowLayoutPanel flowLayoutPanel_66_truong = new FlowLayoutPanel();
            flowLayoutPanel_66_truong.AutoScroll = true;
            flowLayoutPanel_66_truong.Size = new Size(712, 148);
            flowLayoutPanel_66_truong.Location = new Point(46, height_66_truong + 28);
            flowLayoutPanel_66_truong.Name = "flowLayoutPanel_day" + tenDay[tenDay.Length - 1].ToString().ToUpper() + "_66_truong";

            groupBox_dayBan_66_truong.Controls.Add(lbl_tenDayBan_66_truong);
            groupBox_dayBan_66_truong.Controls.Add(flowLayoutPanel_66_truong);
            groupBox_dayBan_66_truong.Refresh();
        }
        public void themDayBan()
        {
            foreach (string dayBan in data_66_truong.GetgrDayBan() )        
                    creatDayBan(dayBan);
        }

        public void CreatBan()
        {
            foreach (KeyValuePair<Ban, string> pair in data_66_truong.GetGrBan())
            {
                    GroupBox groupBox_66_truong = new GroupBox();
                    groupBox_66_truong.Size = new Size(130, 130);

                    Label lbl_tenBan_66_truong = new Label();
                    lbl_tenBan_66_truong.Text = pair.Key.TenBan;
                    lbl_tenBan_66_truong.ForeColor = Color.Red;
                    lbl_tenBan_66_truong.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    lbl_tenBan_66_truong.Location = new Point(41, 42);
                    lbl_tenBan_66_truong.Size = new Size(70, 20);
                    groupBox_66_truong.Controls.Add(lbl_tenBan_66_truong);

                    Label lbl_stateBan = new Label();
                    if (TimBan(pair.Key.TenBan) != null && TimBan(pair.Key.TenBan).getListSPThanhToan().Count != 0)
                    {
                        lbl_stateBan.Text = "Không trống";
                    }
                    else
                    {
                        lbl_stateBan.Text = "Trống";
                    }
                    lbl_stateBan.Location = new Point(6, 75);
                    lbl_stateBan.Size = new Size(118, 29);
                    lbl_stateBan.TextAlign = ContentAlignment.MiddleCenter;
                    groupBox_66_truong.Controls.Add(lbl_stateBan);

                    groupBox_66_truong.Margin = new Padding(4, 4, 4, 4);
                    groupBox_66_truong.Click += GroupBox_Click1_66_truong;
                    FlowLayoutPanel flowLayoutPanel_66_truong = GetFlowLayoutPanelToTen(pair.Value);
                    if(flowLayoutPanel_66_truong == null) { MessageBox.Show("Không tìm thấy Dãy cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    flowLayoutPanel_66_truong.Controls.Add(groupBox_66_truong);
              
                
            }

        }
        private void GroupBox_Click1_66_truong(object sender, EventArgs e)
        {
            this.Hide();
            GroupBox group_66_truong = sender as GroupBox;
            Form2_BangChinh form2_BangChinh = new Form2_BangChinh(TimBan(group_66_truong.Controls[0].Text), data_66_truong);
            form2_BangChinh.ShowDialog();
        }
        internal Ban TimBan(string tenBan)
        {

            foreach (KeyValuePair<Ban, string> pair in data_66_truong.GetGrBan())
            {
                if (pair.Key.TenBan.Equals(tenBan)) return pair.Key;
            }
            return null;
        }
        public void RemoveBan()
        {
            if (demAllBanInFlowLayoutPanel() > data_66_truong.GetGrBan().Count())
            {
                duyetBan();
            }
        }


        public void duyetBan()
        {
            foreach (Control control in groupBox_dayBan_66_truong.Controls)
            {
                if (control is FlowLayoutPanel)
                    foreach (Control controlBan in control.Controls) {
                        if (data_66_truong.checkBanExIngrBan(controlBan.Controls[0].Text) == false)
                            ((FlowLayoutPanel)control).Controls.Remove(controlBan); 
                    }
            }
        }
  
        public int demAllBanInFlowLayoutPanel()
        {
            int soBan_66_truong = 0;
            foreach (Control control in groupBox_dayBan_66_truong.Controls)
            {
                if (control is FlowLayoutPanel)
                {
                    FlowLayoutPanel flowLayoutPanel_66_truong = (FlowLayoutPanel)control;
                    soBan_66_truong += flowLayoutPanel_66_truong.Controls.Count;
                }
            }
            return soBan_66_truong;
        }
        public int demALLFlowLayoutPanel()
        {
            int soFlow_66_truong = 0;
            foreach (Control control in groupBox_dayBan_66_truong.Controls)
            {
                if (control is FlowLayoutPanel) soFlow_66_truong++;
            }
            return soFlow_66_truong;
        }
        public FlowLayoutPanel GetFlowLayoutPanelToTen(string tenFlow)
        {
            foreach (Control control in groupBox_dayBan_66_truong.Controls)
            {
                if (control is FlowLayoutPanel)
                {

                    if (((FlowLayoutPanel)control).Name.Equals(tenFlow))
                        return (FlowLayoutPanel)control;
                }
            }
            return null;
        }
        public Label GetLabelTenDay(string tenDay_66_truong)
        {

            foreach (Control control in groupBox_dayBan_66_truong.Controls)
            {
                if (control is Label)
                {
                    if (((Label)control).Name.Equals(tenDay_66_truong)) return (Label)control;
                }
            }
            return null;
        }




 




        private void thốngKêDoanhThuHômNayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ThongKe form_ThongKe = new Form_ThongKe(data_66_truong);
            form_ThongKe.LoadDataThongKe();
            form_ThongKe.ShowDialog();
        }


        private void YourForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            data_66_truong.GetgrSanPham().Clear();
            data_66_truong.GetgrChi().Clear();
            data_66_truong.GetGrBan().Clear();
            data_66_truong.GetListThongKe().Clear();
            data_66_truong.getALlSanPhamTrongNgay().Clear();
            data_66_truong.GetgrNhomMon().Clear();
            data_66_truong.GetgrDayBan().Clear();
            data_66_truong = null;
        }

        private void xemThốngKêTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ChonDayThongKe form_ChonDayThongKe = new Form_ChonDayThongKe(data_66_truong);
            form_ChonDayThongKe.ShowDialog();
        }

        private void thêmMónMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ThemMon form_ThemMon = new Form_ThemMon(data_66_truong);
            form_ThemMon.ShowDialog();
        }

        private void sửaThôngTinMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SuaThongTinMon form_SuaThongTinMon = new Form_SuaThongTinMon(data_66_truong);
            form_SuaThongTinMon.ShowDialog();
        }

        private void xóaMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_XoaMon form_XoaMon = new Form_XoaMon(data_66_truong);
            form_XoaMon.ShowDialog();
        }

 
        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_TroGiup form_TroGiup = new Form_TroGiup(data_66_truong);
            form_TroGiup.ShowDialog();
        }

     
    }
}
