using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public KhachHangDTO()
        {
        }

        public KhachHangDTO(string sdt)
        {
            this.SDT = sdt;
        }

        public KhachHangDTO(string maKH, string sDT, string hoTenKH, string diaChi, bool trangThai)
        {
            this.MaKH = maKH;
            this.SDT = sDT;
            this.HoTenKH = hoTenKH;
            this.DiaChi = diaChi;
            this.TrangThai = trangThai;
        }

        public string MaKH { get; set; }
        public string SDT { get; set; }
        public string HoTenKH { get; set; }
        public string DiaChi { get; set; }
        public bool TrangThai { get; set; }
    }
}
