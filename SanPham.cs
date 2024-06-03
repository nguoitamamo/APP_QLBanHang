using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class SanPham
    {
        private string nhomSp;
        private string ten;
        private int gia;
        private string tenFileImage;
        private int SL;

        public SanPham(string ten, int gia , int SL)
        {
            this.ten = ten;
            this.gia = gia;
            this.SL = SL;
        }
        public SanPham(string nhom,string ten, int gia, string path)
        {
            this.nhomSp = nhom;
            this.ten = ten;
            this.gia = gia;
            this.tenFileImage = path;
            SL = 1;
        }
        public SanPham( string ten, int gia, string path)
        {
            this.ten = ten;
            this.gia = gia;
            this.tenFileImage = path;
            SL = 1;
        }

        public string Ten { get => ten; set => ten = value; }
        public int Gia { get => gia; set => gia = value; }
        public string TenFileImage { get => tenFileImage; set => tenFileImage = value; }
        public string NhomSP { get => nhomSp; set => nhomSp = value; }
        public int SoLuong {  get => SL; set => SL = value; }
        public string ConvertObjToString()
        {
            return ten + "," + Gia + "," + SL + "#";
        }
    }
}
