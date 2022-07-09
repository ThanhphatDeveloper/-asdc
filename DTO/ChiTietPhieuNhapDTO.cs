using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapDTO
    {
        private string maPhieu;
        private string maNCC;
        private string maSP;
        private int soLuongNhap;
        private decimal giaGoc;
        private decimal thanhTien;
        private string tenSanPham;
        private string tenNCC;
        private int soLuongTon;

        public ChiTietPhieuNhapDTO(string maPhieu, string maNCC, string maSP, int soLuongNhap, decimal giaGoc, decimal thanhTien, string tenSanPham, string tenNCC, int soLuongTon)
        {
            this.maPhieu = maPhieu;
            this.maNCC = maNCC;
            this.maSP = maSP;
            this.soLuongNhap = soLuongNhap;
            this.giaGoc = giaGoc;
            this.thanhTien = thanhTien;
            this.tenSanPham = tenSanPham;
            this.tenNCC = tenNCC;
            this.soLuongTon = soLuongTon;
        }

        public ChiTietPhieuNhapDTO()
        {

        }

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuongNhap { get => soLuongNhap; set => soLuongNhap = value; }
        public decimal GiaGoc { get => giaGoc; set => giaGoc = value; }
        public decimal ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
    }
}
