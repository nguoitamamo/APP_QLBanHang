using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;
using System.IO;
using System.Resources;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form_TrangChu : Form
    {
        public Form_TrangChu()
        {
            InitializeComponent();
            data_66_truong = new Data();
            data_66_truong.ReadToGrSanPham(); // đọc tất cả các sản phẩm từ file
            data_66_truong.ReadToGrBan(); // đọc danh sách bàn từ file
            data_66_truong.ReadToNhomMon(); // đọc danh sách nhóm món từ file
            data_66_truong.ReadToDayBan(); // đọc danh sách dãy bàn 
            data_66_truong.ReadThongKeBefore(); // đọc các thống kê trước đó
        }
        Data data_66_truong;
        List<string> listTenImage_66_truong = new List<string>();
        Timer timer_66_truong;
        int currentImageIndex_66_truong = 0;
        private void Form_TrangChu_Load(object sender, EventArgs e)
        {
            listTenImage_66_truong.Add("logo_1");
            listTenImage_66_truong.Add("logo_2");
            listTenImage_66_truong.Add("logo_3");
            listTenImage_66_truong.Add("logo_4");
            listTenImage_66_truong.Add("logo_5");
            listTenImage_66_truong.Add("logo_6");
            listTenImage_66_truong.Add("logo_n");
            timer_66_truong = new Timer(TimerCallback, timer_66_truong, 0, 500);
        }
        private void TimerCallback(object state)
        {
            pictureBox_imag_66_truong.Image = Resources.ResourceManager.GetObject(listTenImage_66_truong[currentImageIndex_66_truong]) as Image;
            currentImageIndex_66_truong++;
            if (currentImageIndex_66_truong == listTenImage_66_truong.Count)
            {
                timer_66_truong.Change(Timeout.Infinite, Timeout.Infinite); // dừng timer
                this.Invoke((MethodInvoker)delegate
                {
                    this.Hide();
                    Form_DanhSachBan form_DanhSachBan = new Form_DanhSachBan(data_66_truong);
                    form_DanhSachBan.ShowDialog();


                });
            }
            
        }



    }
}
