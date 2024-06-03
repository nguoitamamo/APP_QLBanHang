using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Ban
    {
        private string tenBan;
        private string stateBan;
        private List<SanPham> listSpThanhToan = new List<SanPham>(); 

        public Ban(string tenBan)
        {
            this.tenBan= tenBan;
        }
        public Ban(string tenBan, string stateBan)
        {
            this.tenBan = tenBan;
            this.stateBan = stateBan;

        }
        public Ban() { }

        public string TenBan { get => tenBan; set => tenBan = value; }
        public string StateBan { get => stateBan;  set => stateBan = value; }

        public void RemoveSanPhamThanhToan(string tenSP)
        {
            for(int i = 0; i <  listSpThanhToan.Count; i++)
            {
                if(listSpThanhToan[i].Ten.Equals(tenSP))
                {
                    listSpThanhToan.RemoveAt(i);
                    i--;
                }
            }
        }
        public List<SanPham> getListSPThanhToan()
        {
            return listSpThanhToan;
        }
        public void addSanPhamThanhToan(SanPham p) {
           listSpThanhToan.Add(p);
        }
        public void removeALLSanPham()
        {
            listSpThanhToan.Clear();
        }


    }
}
