using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ChucVuDTO
    {
        public string maChucVu { get; set;}
        public string tenChucVu { get; set; }
        public ChucVuDTO()
        {

        }

        public ChucVuDTO(string maChucVu, string tenChucVu)
        {
            this.MaChucVu = maChucVu;
            this.TenChucVu = tenChucVu;
        }

        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
    }
}
