using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ChucVuDAO
    {
        DataProvider conn = new DataProvider();
        ChucVuDTO cv = new ChucVuDTO();

        public List<ChucVuDTO> layDSCVDao()
        {
            List<ChucVuDTO> dsCV = new List<ChucVuDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT * FROM ChucVu ";
            SqlDataReader reader = conn.getdata(query);
            while (reader.Read())
            {
                ChucVuDTO cv = new ChucVuDTO();
                cv.MaChucVu = reader.GetString(0);
                cv.TenChucVu = reader.GetString(1);
                dsCV.Add(cv);
            }
            conn.Ngatketnoi();
            return dsCV;
        }

        public bool themCVDao(ChucVuDTO cv)
        {
            try
            {
                conn.Ketnoi();
                string query = "INSERT INTO ChucVu (MaChucVu,TenChucVu) VALUES ('{0}','{1}')";
                string sql = string.Format(query, cv.MaChucVu, cv.TenChucVu);
                SqlCommand cmd = new SqlCommand(sql, conn.cn);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Ngatketnoi();
            }
            return false;
        }

        public bool capNhatCVDao(ChucVuDTO cv)
        {
            try
            {
                conn.Ketnoi();
                string query = "UPDATE ChucVu SET TenChucVu=N'{0}' WHERE MaChucVu='{1}'";
                string sql = string.Format(query, cv.TenChucVu, cv.MaChucVu);
                SqlCommand cmd = new SqlCommand(sql, conn.cn);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Ngatketnoi();
            }
            return false;
        }
        public ChucVuDTO TimKiemTheoMa(string maCV)
        {
            ChucVuDTO cv = new ChucVuDTO();
            //...
            string query = "SELECT * FROM ChucVu cv WHERE cv.MaChucVu = '{0}'";
            string sql = string.Format(query,maCV);
            SqlDataReader reader = conn.getdata(sql);
            while (reader.Read())
            {
                cv.MaChucVu = reader.GetString(0);
                cv.TenChucVu = reader.GetString(1);
            }
            //...
            conn.Ngatketnoi();
            return cv;
        }
        public Int64 demSoLuongCV()
        {
            string query = "SELECT COUNT(*) FROM ChucVu";
            Int64 count = conn.GetDataScalar(query);
            return count;
        }
    }
}
