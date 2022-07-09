using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAO nccDAO = new NhaCungCapDAO();

        public List<NhaCungCapDTO> layDSNCCBus()
        {
            return nccDAO.LayDSNCCDao();
        }

        public bool capNhatNCCBus(NhaCungCapDTO ncc)
        {
            return nccDAO.CapNhatNCCDao(ncc);
        }

        public bool themNCCBus(NhaCungCapDTO ncc)
        {
            return nccDAO.ThemNCCDao(ncc);
        }

        public bool xoaNCCBus(NhaCungCapDTO ncc)
        {
            return nccDAO.XoaNCCDao(ncc);

        }

        public List<NhaCungCapDTO> timKiemNhanhBus(string value)
        {
            return nccDAO.TimKiemNhanhDao(value);
        }

        public long demSoLuongNCC()
        {
            return nccDAO.DemSoLuongNCC();
        }
        public List<NhaCungCapDTO> LoadNCCEntities()
        {
            return nccDAO.LayDSNCCEntities();
        }

        public bool ThemNhaNCCENtities(NhaCungCapDTO ncc)
        {
            return nccDAO.ThemNhaNCCENtities(ncc);
        }

        public bool CapNhapNCCEntities(NhaCungCapDTO ncc)
        {
            return nccDAO.CapNhapNCCEntities(ncc);
        }
        public bool XoaNCCEntities(NhaCungCapDTO ncc)
        {
            return nccDAO.XoaNCCEntities(ncc);
        }
    }
}
