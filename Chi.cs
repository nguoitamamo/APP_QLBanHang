using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Chi: SanPham
    {
        public Chi(string ten, int gia , int SL ) : base(ten, gia, SL)
        {
        }
  
        public string ConvertObjToString()
        {
            return Ten + "," + Gia+ "," + SoLuong + "#";
        }
    }
}
