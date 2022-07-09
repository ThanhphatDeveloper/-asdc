using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class PhieuNhapBUS
    {
        PhieuNhapDAO pnDAO = new PhieuNhapDAO();
        public List<PhieuNhapDTO> LayDSPN()
        {
            return pnDAO.LayDSPN();
        }
        public string PhatSinhMa()
        {
            return pnDAO.DemTongPhieu();
        }
        public bool ThemPhieuNhap(PhieuNhapDTO pn)
        {
            return pnDAO.ThemPhieuNhap(pn);
        }
        public List<PhieuNhapDTO> TimKiemNhanh(string values)
        {
            return pnDAO.TimKiemNhanh(values);
        }
    }
}
