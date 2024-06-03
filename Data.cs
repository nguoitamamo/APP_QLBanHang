using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    internal class Data
    {
        private List<SanPham> grSanPham_66_truong = new List<SanPham>(); // 
        private List<string> grNhomMon_66_truong = new List<string>();

        private Dictionary<Ban, string> grBan_66_truong = new Dictionary<Ban, string>();
        private List<string> grDayBan_66_truong = new List<string>();


        private List<Chi> grChi_66_truong = new List<Chi>();
        private List<SanPham> AllSanPhamTrongNgay_66_truong = new List<SanPham>();
        private List<ThongKe> ALlThongKe_66_truong = new List<ThongKe>();
        private string HereDownloadProject_66_truong;
        public Data()
        {

            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string driveLetter = Path.GetPathRoot(currentDirectory);
            this.HereDownloadProject_66_truong = driveLetter;

        }
        
            
        
        public bool checkkExSanPham(string tenSp) {
            foreach (SanPham sp in grSanPham_66_truong)
                if (sp.Ten.Equals(tenSp)) return true;
            return false;
        }
       public bool checkExIngrNhomMon(string tenNhomMon)
        {
            foreach( string nhomMon in grNhomMon_66_truong)
            {
                if (nhomMon.Equals(tenNhomMon)) return true;
            }
            return false;
       }
        public bool checkBanExIngrBan(string tenBan)
        {
            foreach( KeyValuePair <Ban, string> pair in grBan_66_truong)
            {
                if(pair.Key.TenBan.Equals(tenBan))  return true;
            }
            return false;
        }
      
        public bool checkTenFlowExInBan(string tenFlow)
        {
            string s = "Dãy " + tenFlow[tenFlow.IndexOf("day") + 3];
          
            foreach (string dayban in grDayBan_66_truong)
            {
                if (dayban.Equals(s)) return true;
            }
            return false;
        }
        public void RemoveALLBanInGrDayBan(string tenFlow)  // xóa bàn 
        {
            foreach (var pair in grBan_66_truong.ToList())
            {
                if (pair.Value.Equals(tenFlow))
                {
                    grBan_66_truong.Remove(pair.Key);
                    pair.Key.getListSPThanhToan().Clear();
                    
                }
            }
        }
        public  bool checkExSanPhamInALlBan()
        {
            foreach( KeyValuePair<Ban, string > pair  in grBan_66_truong)
            {
                if( pair.Key.getListSPThanhToan().Count !=0) return true;
            }
            return false;
        }
        public void RemoveBan(string tenBan)
        {
            foreach( var pair in grBan_66_truong.ToList() )
            {
                if( pair.Key.TenBan.Equals(tenBan))
                {
                    grBan_66_truong.Remove(pair.Key); // xóa bàn trong grBan
                    pair.Key.getListSPThanhToan().Clear();   //  xóa listSPThanhToan của bàn đó
                    return;
                }
            }
        }
        public void RemoveSanPham(string tenNhom)
        {
            for (int i = 0; i < grSanPham_66_truong.Count; i++)
            {
                if (grSanPham_66_truong[i].NhomSP.Equals(tenNhom))
                {
                    grSanPham_66_truong.RemoveAt(i);
                    i--;
                }
            }

        }   
        public Dictionary<Ban, string> GetGrBan()
        {
            return grBan_66_truong;
        }
    
        // đọc  đến grSanPham
        public void ReadToGrSanPham()
        {


            using (FileStream fileStream_66_truong = new FileStream(HereDownloadProject_66_truong + "BanHang\\WinFormsApp1\\Data\\DanhSachMon.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader_66_truong = new StreamReader(fileStream_66_truong))
                {
                    string line;
                    while ((line = streamReader_66_truong.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        string[] properties = line.Split(',');
                        grSanPham_66_truong.Add(new SanPham(properties[0], properties[1], int.Parse(properties[2]), properties[3]));
                    }
                }
            }
        }
        // đọc đến grBan

        public void ReadToGrBan()
        {
            using (FileStream fileStream_66_truong = new FileStream(HereDownloadProject_66_truong + "BanHang\\WinFormsApp1\\Data\\DanhSachBan.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader_66_truong = new StreamReader(fileStream_66_truong))
                {

                    string line;
                    while ((line = streamReader_66_truong.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        string[] PropertisBan = line.Split(",");
                        grBan_66_truong.Add(new Ban(PropertisBan[0], PropertisBan[1]), PropertisBan[2]);
                    }
                }
            }
        }
         // đọc đến nhóm món
         public void ReadToNhomMon()
         {
            using (FileStream fileStream_66_truong = new FileStream(HereDownloadProject_66_truong + "BanHang\\WinFormsApp1\\Data\\NhomMon.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader_66_truong = new StreamReader(fileStream_66_truong))
                {
                    string line;
                    while ((line = streamReader_66_truong.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        grNhomMon_66_truong.Add(line);
                    }
                }
            }
         }

         // đọc đến dãy bàn
         public void ReadToDayBan()
        {
            using (FileStream fileStream_66_truong = new FileStream(HereDownloadProject_66_truong + "BanHang\\WinFormsApp1\\Data\\DayBan.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader fileReader_66_truong = new StreamReader(fileStream_66_truong))
                {
                    string line;
                    while ((line = fileReader_66_truong.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        grDayBan_66_truong.Add(line);
                    }
                }
            }
        }

        // đọc các thống kê trước đó

        public void ReadThongKeBefore()
        {
            using (FileStream fileStream_66_truong = new FileStream(HereDownloadProject_66_truong + "BanHang\\WinFormsApp1\\Data\\ThongKe.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader fileReader_66_truong = new StreamReader(fileStream_66_truong))
                {
                    string line_66_truong;
                    string[] PropetiesThongKe_66_truong;
                    string ngay_66_truong;
                    List<Chi> chis_66_truong = new List<Chi>();
                    List<SanPham> sanPhams_66_truong = new List<SanPham>();
                    string[] PropertiesChi;
                    string[] PropertiesBan;
                    while ((line_66_truong = fileReader_66_truong.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line_66_truong)) continue;
                        PropetiesThongKe_66_truong = line_66_truong.Split("%");
                        ngay_66_truong = PropetiesThongKe_66_truong[0];
                        PropertiesChi = PropetiesThongKe_66_truong[1].Substring(0, PropetiesThongKe_66_truong[1].Length - 1).Split('#');
                        foreach (string strings in PropertiesChi)
                        {
                            string[] chi = strings.Split(",");
                            chis_66_truong.Add(new Chi(chi[0], int.Parse(chi[1]), int.Parse(chi[2])));
                        }
                        PropertiesBan = PropetiesThongKe_66_truong[2].Substring(0, PropetiesThongKe_66_truong[2].Length - 1).Split('#');
                        foreach (string strings in PropertiesBan)
                        {
                            string[] ban = strings.Split(",");
                            sanPhams_66_truong.Add(new Chi(ban[0], int.Parse(ban[1]), int.Parse(ban[2])));
                        }
                        ALlThongKe_66_truong.Add( new ThongKe(DateTime.Parse(ngay_66_truong), sanPhams_66_truong, chis_66_truong));

                    }
                  
                }
            }

        }

        // xóa nhóm sản phẩm
        public void WriterListNhomMonCurrent()
        {
            using (FileStream fileStream_66_truong = new FileStream(HereDownloadProject_66_truong + "BanHang\\WinFormsApp1\\Data\\NhomMon.txt", FileMode.Truncate, FileAccess.Write))
            {
                using (StreamWriter streamWriter_66_truong = new StreamWriter(fileStream_66_truong))
                {
                    foreach (string nhomMon in grNhomMon_66_truong)
                    {
                        streamWriter_66_truong.WriteLine(nhomMon);
                    }
                }
            }
        }
        // xóa bàn
        public void WrtiterGrBanCurrent()
        {
            using (FileStream fileStream_66_truong = new FileStream(HereDownloadProject_66_truong + "BanHang\\WinFormsApp1\\Data\\DanhSachBan.txt", FileMode.Truncate, FileAccess.Write))
            {
                using (StreamWriter streamWriter_66_truong = new StreamWriter(fileStream_66_truong))
                {
                    foreach (KeyValuePair<Ban, string> pair in grBan_66_truong)
                    {
                        string line_66_truong = pair.Key.TenBan + "," + pair.Key.StateBan + "," + pair.Value;
                        streamWriter_66_truong.WriteLine(line_66_truong);

                    }
                }
            }

        }
        // xóa dãy
        public void WriterGrDayBanCurrent()
        {
            using (FileStream fileStream = new FileStream(HereDownloadProject_66_truong + "BanHang\\WinFormsApp1\\Data\\DayBan.txt", FileMode.Truncate, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                   
                    foreach (string dayban in grDayBan_66_truong)
                    {
                        
                        streamWriter.WriteLine(dayban);
                    }
                }
            }
        }




        // thêm sản phẩm và xóa sản phẩm, xóa nhóm sản phẩm
        public void WriterListSanPhamCurrent()
        {
            using (FileStream fileStream_66_truong = new FileStream(HereDownloadProject_66_truong + "BanHang\\WinFormsApp1\\Data\\DanhSachMon.txt", FileMode.Truncate, FileAccess.Write))
            {
                using (StreamWriter streamWrite_66_truong = new StreamWriter(fileStream_66_truong))
                {
                    foreach (SanPham sanPham in grSanPham_66_truong)
                    {
                        string line = string.Format("{0},{1},{2},{3}", sanPham.NhomSP, sanPham.Ten, sanPham.Gia, sanPham.TenFileImage);
                        streamWrite_66_truong.WriteLine(line);
                    }
                }
            }
        }
        // them nhóm món 
        public  void WriterThemNhonMon(string tenNhomMonstreamWrite_66_truong)
        {
            using (FileStream fileStreamstreamWrite_66_truong = new FileStream(HereDownloadProject_66_truong + "BanHang\\WinFormsApp1\\Data\\NhomMon.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter streamWriterstreamWrite_66_truong = new StreamWriter(fileStreamstreamWrite_66_truong))
                {
                    string linestreamWrite_66_truong = tenNhomMonstreamWrite_66_truong;
                    streamWriterstreamWrite_66_truong.Write( "\n" + linestreamWrite_66_truong);
                }
            }
        }
        // them bàn
        public void WriterThemBan(string tenBan_66_truong, string tenFLow_66_truong)
        {
            using (FileStream fileStream_66_truong = new FileStream(HereDownloadProject_66_truong + "BanHang\\WinFormsApp1\\Data\\DanhSachBan.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter streamWriter_66_truong = new StreamWriter(fileStream_66_truong))
                {
                    string line = tenBan_66_truong + ",Trống,flowLayoutPanel_day" + tenFLow_66_truong[tenFLow_66_truong.Length -1].ToString().ToUpper() + "_66_truong";
                    streamWriter_66_truong.Write( "\n" +line );
                }
            }
        }
        // them dãy bàn
        public void WriterThemDayBan(string tenDayBan)
        {
            using (FileStream fileStream_66_truong = new FileStream(HereDownloadProject_66_truong + "BanHang\\WinFormsApp1\\Data\\DayBan.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter streamWriter_66_truong = new StreamWriter(fileStream_66_truong))
                {
                    string line = tenDayBan;
                    streamWriter_66_truong.Write( "\n" +line );
                }
            }
        }


        // ghi file thong ke
        public void WriterFileThongKe(string ngay_66_truong)
        {
            using (FileStream fileStream_66_truong = new FileStream(HereDownloadProject_66_truong + "BanHang\\WinFormsApp1\\Data\\ThongKe.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter streamWriter_66_truong = new StreamWriter(fileStream_66_truong))
                {
                    string line_66_truong = ngay_66_truong;
                    string s1_66_truong = "";
                    string s2_66_truong = "";
                    foreach (Chi chi in grChi_66_truong) s1_66_truong += chi.ConvertObjToString();
                    line_66_truong += "%" + s1_66_truong;
                    foreach (SanPham sanPhams in AllSanPhamTrongNgay_66_truong) s2_66_truong += sanPhams.ConvertObjToString();
                    line_66_truong += "%" + s2_66_truong;
                    streamWriter_66_truong.Write("\n" + line_66_truong);


                }
            }
        }


        // doc file thong ke


        public void AddSpDaThanhToan(SanPham sanPham)
        {
            AllSanPhamTrongNgay_66_truong.Add(sanPham);
        }
        public List<SanPham> getALlSanPhamTrongNgay()
        {
            return AllSanPhamTrongNgay_66_truong;
        }
        public List<SanPham> GetgrSanPham()
        {
            return grSanPham_66_truong;
        }

        public List<ThongKe> GetListThongKe()
        {
            return ALlThongKe_66_truong;
        }
        public List<Chi> GetgrChi()
        {
            return grChi_66_truong;
        }
        public List<string> GetgrNhomMon()
        {
            return grNhomMon_66_truong;
        }
        public List<string> GetgrDayBan()
        {
            return grDayBan_66_truong;
        }

  
    }



}

