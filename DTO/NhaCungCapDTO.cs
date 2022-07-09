using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        private string maNCC;
        private string tenNCC;
        private bool trangThai;

        public NhaCungCapDTO()
        {

        }

        public NhaCungCapDTO(string maNCC, string tenNCC, bool trangThai)
        {
            this.MaNCC = maNCC;
            this.TenNCC = tenNCC;
            this.TrangThai = trangThai;
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
