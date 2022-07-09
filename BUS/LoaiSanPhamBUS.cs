using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public  class LoaiSanPhamBUS
    {
        LoaiSanPhamDAO lSP = new LoaiSanPhamDAO();
        public List<LoaiSanPhamDTO>LoadLoaiSP()
        {
            return lSP.LoadLoaiSP();
        }
        public string MaxMaLoai()
        {
            return lSP.MaxMaLoai();
        }
        public bool ThemLoaiSanPhamEntities(LoaiSanPhamDTO l)
        {
            return lSP.ThemLoaiSanPhamEntities(l);
        }
        public bool CapNhatSanPhamEntities(LoaiSanPhamDTO l)
        {
            return lSP.CapNhapLoaiEntities(l);
        }
        public bool XoaSanPhamEntities(LoaiSanPhamDTO l)
        {
            return lSP.XoaLoaiEntities(l);
        }
        public List<LoaiSanPhamDTO> LoadLoaiSPTheoKeyWork(string value)
        {
            return lSP.LoadLoaiSPTheoKeyWork(value);
        }
    }
}
