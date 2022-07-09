using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPhamDTO
    {
        private string maLoai;
        private string tenLoai;
        private bool trangThai;

        public LoaiSanPhamDTO()
        {
        }

        public LoaiSanPhamDTO(string maLoai, string tenLoai, bool trangThai)
        {
            this.MaLoai = maLoai;
            this.TenLoai = tenLoai;
            this.TrangThai = trangThai;
        }

        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
