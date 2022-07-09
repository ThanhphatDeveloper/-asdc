using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{

    public class SanPhamBUS
    {
        SanPhamDAO spDAO = new SanPhamDAO();
        public List<SanPhamDTO> LayDanhSachSanPham()
        {
            return spDAO.LayDSSP();
        }
        public List<SanPhamDTO> LayDSanPhamFromSanPhamTableEntities()
        {
            return spDAO.LayDSanPhamFromSanPhamTableEntities();
        }
        public bool ThemSanPham(SanPhamDTO SP)
        {
            return spDAO.ThemSanPham(SP);
        }
        public bool SuaSanPham(SanPhamDTO SP)
        {
            return spDAO.SuaSanPham(SP);
        }
        public bool XoaSanPham(SanPhamDTO SP)
        {
            return spDAO.XoaSanPham(SP);
        }
        public SanPhamDTO TimKiemSP(string maSP)
        {
            return spDAO.TimKiemSP(maSP);
        }
        public List<SanPhamDTO> TimKiemNhanh(string value)
        {
            return spDAO.TimKiemNhanh(value);
        }
        public Int64 PhatSinhMaSP()
        {
            return spDAO.DemTongSanPham();
        }
        public SanPhamDTO TimKiemSanPhamPN(string maSP)
        {
            return spDAO.TimKiemSanPhamPN(maSP);
        }
    }
}
