using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Properties;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Image = System.Drawing.Image;

namespace WinFormsApp1
{
    public partial class Form3_BangThongTinSanPham : Form
    {
        string tenSanPham;


        internal Form3_BangThongTinSanPham(string tenFileImage, string ten, int giaTien)
        {

            InitializeComponent();

            pictureBox_Image_66_truong.Image = (Image)Resources.ResourceManager.GetObject(tenFileImage);
            lbl_tenSanPham_66_truong.Text = ten;
            lbl_giaTien_66_truong.Text = giaTien + ".000VND";
            tenSanPham = tenFileImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
