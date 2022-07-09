using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nvDAO = new NhanVienDAO();

        public List<NhanVienDTO> LayDSNVBUS()
        {
            return nvDAO.LayDSNVDAO();
        }
        public List<NhanVienDTO> LayDSNVTheoKeyworkDAO(string value)
        {
            return nvDAO.LayDSNVTheoKeyworkDAO(value);
        }
        public List<NhanVienDTO> LoadDataBboBUS()
        {
            return nvDAO.LayDSNVCboDAO();
        }
        public NhanVienDTO TimKiemNVBUS(string tenTK)
        {
            return nvDAO.TimKiemNVDAO(tenTK);
        }
        public bool CapNhatNVBus(NhanVienDTO nv)
        {
            return nvDAO.CapNhatNVDao(nv);
        }

        public bool ThemNVBus(NhanVienDTO nv)
        {
            return nvDAO.ThemNVDao(nv);
        }

        public bool XoaNVBus(NhanVienDTO nv)
        {
            return nvDAO.XoaNVDao(nv);
        }
        public Int64 DemSoLuongNV()
        {
            return nvDAO.DemSoLuongNV();
        }
    }
}
