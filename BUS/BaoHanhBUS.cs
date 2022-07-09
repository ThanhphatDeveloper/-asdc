using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BaoHanhBUS
    {
        BaoHanhDAO bhDAO = new BaoHanhDAO();
        //...
        public List<BaoHanhDTO> LayDSBH()
        {
            return bhDAO.LayDSBH();
        }
    }
}
