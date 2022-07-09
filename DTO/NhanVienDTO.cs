using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string maNV;
        private string tenChucVu;
        private string maChucVu;
        private string hoTenNV;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string sdtNV;
        private string diaChi;
        private string anh;
        private bool trangThai;

        public NhanVienDTO()
        {

        }

        public NhanVienDTO(string maNV, string maChucVu, string hoTenNV, string gioiTinh, DateTime ngaySinh, string sdtNV, string diaChi, string anh/*, bool trangThai*/)
        {
            this.MaNV = maNV;
            this.MaChucVu = maChucVu;
            this.HoTenNV = hoTenNV;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.SdtNV = sdtNV;
            this.DiaChi = diaChi;
            this.Anh = anh;
            //this.TrangThai = trangThai;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SdtNV { get => sdtNV; set => sdtNV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public string Anh { get => anh; set => anh = value; }
    }
}