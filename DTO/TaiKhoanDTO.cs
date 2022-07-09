using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string tenTaiKhoan;
        private string matKhau;
        private string maNhanVien;
        private string nhanVienSoHuu;
        private string chucVu;
        private int maQuyen;
        private string tenQuyen;
        private bool trangThai;

        public TaiKhoanDTO()
        {

        }

        public TaiKhoanDTO(string tenTaiKhoan, string matKhau, string maNhanVien, int maQuyen, string tenQuyen, bool trangThai)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
            this.MaNhanVien = maNhanVien;
            this.MaQuyen = maQuyen;
            this.TenQuyen = tenQuyen;
            this.TrangThai = trangThai;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public int MaQuyen { get => maQuyen; set => maQuyen = value; }
        public string TenQuyen { get => tenQuyen; set => tenQuyen = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public string NhanVienSoHuu { get => nhanVienSoHuu; set => nhanVienSoHuu = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}
