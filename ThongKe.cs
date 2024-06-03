using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ThongKe
    {
        private DateTime dateTime;  // ngày giờ thống kê
        private List<SanPham> spBan= new List<SanPham>(); // tất cả sản phẩm bán trong 1 thống kê
        private List<Chi> chiInDay= new List<Chi>(); // tất cả sản phàm chi trong 1 thống kê
        public ThongKe(DateTime dateTime)
        {
            this.dateTime = dateTime;
       
        }
        public ThongKe(DateTime dateTime,  List<SanPham> spBan, List<Chi> chis)
        {
            this.dateTime = dateTime;
            this.spBan = spBan;
            this.chiInDay = chis;
        }
        public List<SanPham> GetSpBan()
        {
            return spBan;
        }
        public DateTime GetDateTime() { return dateTime; }
        public List<Chi> GetChiInDay() {  return chiInDay; }
    }
}
