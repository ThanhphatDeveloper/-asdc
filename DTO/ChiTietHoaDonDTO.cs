using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        public string MaPN { get; set; }
        public string MaHD { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaBH { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongMua { get; set; }
        public int KhuyenMai { get; set; }
        public decimal ThanhTien { get; set; }
        public bool TrangThai { get; set; }
    }
}
