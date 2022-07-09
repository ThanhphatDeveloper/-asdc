using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        DataProvider conn = new DataProvider();
        KhachHangDTO kh = new KhachHangDTO();
        // ...
        public List<KhachHangDTO> LayDSKHDao()
        {
            List<KhachHangDTO> dsKH = new List<KhachHangDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT * FROM KhachHang WHERE TrangThai='True'";
            SqlDataReader reader = conn.getdata(query);
            while (reader.Read())
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKH = reader.GetString(0);
                kh.SDT = reader.GetString(1);
                kh.HoTenKH = reader.GetString(2);
                kh.DiaChi = reader.GetString(3);
                kh.TrangThai = reader.GetBoolean(4);
                dsKH.Add(kh);
            }
            conn.Ngatketnoi();
            return dsKH;
        }
        public bool ThemKHDao(KhachHangDTO kh)
        {
            try
            {
                conn.Ketnoi();
                string query = "INSERT INTO KhachHang (MaKH,SDT, HoTenKH, DiaChi,TrangThai) VALUES ('{0}','{1}',N'{2}',N'{3}','{4}')";
                string sql = string.Format(query, kh.MaKH, kh.SDT, kh.HoTenKH, kh.DiaChi, kh.TrangThai);
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

        public bool CapNhatKHDao(KhachHangDTO kh)
        {
            try
            {
                conn.Ketnoi();
                string query = "UPDATE KhachHang SET HotenKH=N'{0}',DiaChi=N'{1}', SDT='{2}' WHERE MaKH='{3}'";
                string sql = string.Format(query, kh.HoTenKH, kh.DiaChi, kh.SDT, kh.MaKH);
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

        public bool XoaKHDao(KhachHangDTO kh)
        {
            try
            {
                conn.Ketnoi();
                string query = "UPDATE KhachHang SET TrangThai='False' WHERE  MaKH='{0}' OR SDT='{1}' ";
                string sql = string.Format(query, kh.MaKH, kh.SDT);
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
        public List<KhachHangDTO> TimKiemNhanhDao(string value)
        {
            List<KhachHangDTO> dsKH = new List<KhachHangDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT * FROM KhachHang WHERE (MaKH like '%{0}%' OR SDT like '%{1}%' OR HoTenKH like N'%{2}%' OR DiaChi like N'%{3}%') AND TrangThai='True'";
            string sql = string.Format(query, value, value, value, value);
            SqlDataReader reader = conn.getdata(sql);
            while (reader.Read())
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKH = reader.GetString(0);
                kh.SDT = reader.GetString(1);
                kh.HoTenKH = reader.GetString(2);
                kh.DiaChi = reader.GetString(3);
                kh.TrangThai = reader.GetBoolean(4);
                dsKH.Add(kh);
            }
            conn.Ngatketnoi();
            return dsKH;
        }
        public KhachHangDTO TimKiemTheoSDT(string value)
        {
            KhachHangDTO kh = new KhachHangDTO();
            // ...
            conn.Ketnoi();
            string query = "SELECT * FROM KhachHang WHERE SDT = '{0}'";
            string sql = string.Format(query, value);
            SqlDataReader reader = conn.getdata(sql);
            while (reader.Read())
            {
                kh.MaKH = reader.GetString(0);
                kh.SDT = reader.GetString(1);
                kh.HoTenKH = reader.GetString(2);
                kh.DiaChi = reader.GetString(3);
                kh.TrangThai = true;
            }
            //...
            conn.Ngatketnoi();
            return kh;
        }
        public Int64 DemSoLuongKH()
        {
            string query = "SELECT COUNT(*) FROM KhachHang";
            Int64 count = conn.GetDataScalar(query);
            //...
            return count;
        }
    }
}
