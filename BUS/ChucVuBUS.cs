using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ChucVuBUS
    {
        ChucVuDAO cvDAO = new ChucVuDAO();

        public List<ChucVuDTO> layDSCVBus()
        {
            return cvDAO.layDSCVDao();
        }

        public bool capNhatCVBus(ChucVuDTO cv)
        {
            return cvDAO.capNhatCVDao(cv);
        }

        public bool themCVBus(ChucVuDTO cv)
        {
            return cvDAO.themCVDao(cv);
        }
        public ChucVuDTO TimKiemTheoMa(string maCV)
        {
            return cvDAO.TimKiemTheoMa(maCV);
        }
        public Int64 demSoLuongCV()
        {
            return cvDAO.demSoLuongCV();
        }
    }
}
