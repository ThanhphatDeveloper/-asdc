using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhanQuyenDAO
    {
        DataProvider conn = new DataProvider();

        public List<PhanQuyenDTO> LoadDataDAO()
        {
            List<PhanQuyenDTO> lsQuyen = new List<PhanQuyenDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT * FROM PhanQuyen";
            SqlDataReader reader = conn.getdata(query);
            while (reader.Read())
            {
                PhanQuyenDTO quyen = new PhanQuyenDTO();
                quyen.MaQuyen = reader.GetString(0);
                quyen.TenQuyen = reader.GetString(1);
                quyen.ChiTietQuyen = reader.GetString(2);
                lsQuyen.Add(quyen);
            }
            // ...
            conn.Ngatketnoi();
            return lsQuyen;
        }
    }
}
