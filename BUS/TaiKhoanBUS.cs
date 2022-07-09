using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO tkDAO = new TaiKhoanDAO();
        public List<TaiKhoanDTO> LayDSTK()
        {
            return tkDAO.LayDSTK();
        }
        public List<TaiKhoanDTO> LayDSTKTheoTuKhoa(string value)
        {
            return tkDAO.LayDSTKTheoTuKhoa(value);
        }
        public TaiKhoanDTO checkQuyen(TaiKhoanDTO TK)
        {
            return tkDAO.KiemTraQuyen(TK);
        }
        public bool ThemTaiKhoan(TaiKhoanDTO TK)
        {
            return tkDAO.ThemTaiKhoan(TK);
        }
        public TaiKhoanDTO TimKiemTK(NhanVienDTO nv)
        {
            return tkDAO.TimKiemTK(nv);
        }
        public bool CapNhatTK(string tenTK, string mkMoi)
        {
            return tkDAO.CapNhatTK(tenTK,mkMoi);
        }
        public bool XoaTKBUS(NhanVienDTO nv)
        {
            return tkDAO.XoaTKDao(nv);
        }
        public TaiKhoanDTO SetTrangThaiTK(TaiKhoanDTO TK)
        {
            return tkDAO.SetTrangThaiTaiKhoan(TK);
        }
    }
}
