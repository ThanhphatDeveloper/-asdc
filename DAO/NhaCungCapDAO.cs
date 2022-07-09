using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhaCungCapDAO
    {
        DataProvider conn = new DataProvider();
        NhaCungCapDTO ncc = new NhaCungCapDTO();
        NCPEntities DB = new NCPEntities();
        // ...
        public List<NhaCungCapDTO> LayDSNCCDao()
        {
            List<NhaCungCapDTO> dsNCC = new List<NhaCungCapDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT * FROM NhaCungCap WHERE TrangThai='True'";
            SqlDataReader reader = conn.getdata(query);
            while (reader.Read())
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO();
                ncc.MaNCC = reader.GetString(0);
                ncc.TenNCC = reader.GetString(1);
                ncc.TrangThai = reader.GetBoolean(2);
                dsNCC.Add(ncc);
            }
            conn.Ngatketnoi();
            return dsNCC;
        }

        //..
        public List<NhaCungCapDTO> LayDSNCCEntities()
        {
            List<NhaCungCapDTO> dsNCC = new List<NhaCungCapDTO>();
            // ...
            dsNCC = DB.NhaCungCaps.Where(u => u.TrangThai == true).Select(v => new NhaCungCapDTO
            {
                MaNCC = v.MaNCC,
                TenNCC = v.TenNCC


            }).ToList();


            return dsNCC;
        }

        public bool ThemNCCDao(NhaCungCapDTO ncc)
        {
            try
            {
                conn.Ketnoi();
                string query = "INSERT INTO NhaCungCap (MaNCC,TenNCC,TrangThai) VALUES ('{0}',N'{1}','{2}')";
                string sql = string.Format(query, ncc.MaNCC, ncc.TenNCC, ncc.TrangThai);
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
        public bool ThemNhaNCCENtities(NhaCungCapDTO NCC)
        {
            try
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNCC = NCC.MaNCC;
                ncc.TenNCC = NCC.TenNCC;
                ncc.TrangThai = true;
                DB.NhaCungCaps.Add(ncc);
                DB.SaveChanges();
                return true;
            }

            catch (Exception ex)
            {
                throw ex;
            }


        }

        public bool CapNhatNCCDao(NhaCungCapDTO ncc)
        {
            try
            {
                conn.Ketnoi();
                string query = "UPDATE NhaCungCap SET TenNCC=N'{0}' WHERE MaNCC='{1}'";
                string sql = string.Format(query, ncc.TenNCC, ncc.MaNCC);
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
        public bool CapNhapNCCEntities(NhaCungCapDTO NCC)
        {
            try
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc = DB.NhaCungCaps.SingleOrDefault(u => u.MaNCC == NCC.MaNCC);
                ncc.TenNCC = NCC.TenNCC;
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaNCCDao(NhaCungCapDTO ncc)
        {
            try
            {
                conn.Ketnoi();
                string query = "UPDATE NhaCungCap SET TrangThai='False' WHERE MaNCC='{0}'";
                string sql = string.Format(query, ncc.MaNCC);
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
        public bool XoaNCCEntities(NhaCungCapDTO NCC)
        {
            try
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc = DB.NhaCungCaps.SingleOrDefault(u => u.MaNCC == NCC.MaNCC);
                ncc.TrangThai = false;
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<NhaCungCapDTO> TimKiemNhanhDao(string value)
        {
            List<NhaCungCapDTO> dsNCC = new List<NhaCungCapDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT * FROM NhaCungCap WHERE (MaNCC like '%{0}%' OR TenNCC like '%{1}%') AND TrangThai='True'";
            string sql = string.Format(query, value, value, value, value);
            SqlDataReader reader = conn.getdata(sql);
            while (reader.Read())
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO();
                ncc.MaNCC = reader.GetString(0);
                ncc.TenNCC = reader.GetString(1);
                ncc.TrangThai = reader.GetBoolean(2);
                dsNCC.Add(ncc);
            }
            conn.Ngatketnoi();
            return dsNCC;
        }

        public long DemSoLuongNCC()
        {
            string query = "SELECT COUNT(*) FROM NhaCungCap";
            long count = conn.GetTong(query);
            return count;
        }
    }
}
