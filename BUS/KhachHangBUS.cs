using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO khDAO = new KhachHangDAO();

        public List<KhachHangDTO> layDSKHBus()
        {
            return khDAO.LayDSKHDao();
        }

        public bool capNhatKHBus(KhachHangDTO kh)
        {
            return khDAO.CapNhatKHDao(kh);
        }
        public bool themKHBus(KhachHangDTO kh)
        {
            return khDAO.ThemKHDao(kh);
        }
        public bool xoaKHBus(KhachHangDTO kh)
        {
            return khDAO.XoaKHDao(kh);
        }

        public List<KhachHangDTO> timKiemNhanhBus(string value)
        {
            return khDAO.TimKiemNhanhDao(value);
        }
        public KhachHangDTO TimKiemTheoSDT(string value)
        {
            return khDAO.TimKiemTheoSDT(value);
        }
        public Int64 DemSoluongKH()
        {
            return khDAO.DemSoLuongKH();
        }
    }
}
