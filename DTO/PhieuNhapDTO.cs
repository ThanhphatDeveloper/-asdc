using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        private string maPhieu;
        private string nhanVienLap;
        private int soLuongNhap;
        private DateTime ngayNhap;
        private string tenNhanVien;
        public PhieuNhapDTO()
        {

        }

        public PhieuNhapDTO(string maPhieu, string nhanVienLap, DateTime ngayNhap)
        {
            this.MaPhieu = maPhieu;
            this.NhanVienLap = nhanVienLap;
            this.NgayNhap = ngayNhap;
        }

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string NhanVienLap { get => nhanVienLap; set => nhanVienLap = value; }
        public int SoLuongNhap { get => soLuongNhap; set => soLuongNhap = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
    } 
}
