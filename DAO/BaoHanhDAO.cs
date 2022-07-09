using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BaoHanhDAO
    {
        DataProvider con = new DataProvider();
        public List<BaoHanhDTO> LayDSBH()
        {
            List<BaoHanhDTO> lst = new List<BaoHanhDTO>();
            //...
            string sql = "SELECT * FROM BaoHanh";
            SqlDataReader reader = con.getdata(sql);
            while (reader.Read())
            {
                BaoHanhDTO bh = new BaoHanhDTO();
                bh.MaBH = reader.GetString(0);
                bh.ThoiGianBaoHanh = reader.GetInt32(1);
                lst.Add(bh);
            }
            con.Ngatketnoi();
            return lst;
        }
    }
}
