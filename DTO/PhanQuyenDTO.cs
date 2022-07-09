using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyenDTO
    {
        private string maQuyen;
        private string tenQuyen;
        private string chiTietQuyen;

        public PhanQuyenDTO()
        {

        }

        public PhanQuyenDTO(string maQuyen, string tenQuyen, string chiTietQuyen)
        {
            this.MaQuyen = maQuyen;
            this.TenQuyen = tenQuyen;
            this.ChiTietQuyen = chiTietQuyen;
        }

        public string MaQuyen { get => maQuyen; set => maQuyen = value; }
        public string TenQuyen { get => tenQuyen; set => tenQuyen = value; }
        public string ChiTietQuyen { get => chiTietQuyen; set => chiTietQuyen = value; }
    }
}
