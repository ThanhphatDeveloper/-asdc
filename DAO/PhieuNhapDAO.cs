using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    
    public  class PhieuNhapDAO
    {
        DataProvider con = new DataProvider();
        public List<PhieuNhapDTO> LayDSPN()
        {
            List<PhieuNhapDTO> phieuNhaps = new List<PhieuNhapDTO>();
            string Query = "SELECT PN.MaPhieu,PN.NhanVienLap,NV.HoTenNV,PN.NgayNhap FROM PhieuNhap PN, NhanVien NV WHERE NV.MaNV = pn.NhanVienLap";
            SqlDataReader reader = con.getdata(Query);
            while (reader.Read())
            {
                PhieuNhapDTO pn = new PhieuNhapDTO();
                pn.MaPhieu = reader.GetString(0);
                pn.NhanVienLap = reader.GetString(1);
                pn.TenNhanVien = reader.GetString(2);
                pn.NgayNhap = reader.GetDateTime(3);
                phieuNhaps.Add(pn);

            }
            con.Ngatketnoi();
            return phieuNhaps;
        }
        public string DemTongPhieu()
        {
            //...
            //string query = "SELECT COUNT(*) FROM PhieuNhap";
            //int count = con.GetDataScalar(query);
            ////...
            //return count;

            string Query = "SELECT MaPhieu FROM PhieuNhap GROUP BY MaPhieu HAVING MAX(CONVERT(int,SUBSTRING(MaPhieu, 3,LEN(MaPhieu)))) >=ALL(SELECT MAX(CONVERT(int,SUBSTRING(MaPhieu, 3,LEN(MaPhieu))))FROM PhieuNhap)";
            string ID = Convert.ToString(con.GetMaxPNId(Query));
            return ID;
        }

        public bool ThemPhieuNhap(PhieuNhapDTO pn)
        {
            //..
            try
            {
                con.Ketnoi();
                string query = "INSERT INTO [NCP].[dbo].[PhieuNhap] VALUES ('{0}', '{1}', '{2}')";
                string sql = string.Format(query, pn.MaPhieu, pn.NhanVienLap, pn.NgayNhap);
                SqlCommand cmd = new SqlCommand(sql, con.cn);
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
                con.Ngatketnoi();
            }
            return false;
        }

        public List<PhieuNhapDTO> TimKiemNhanh(string value)
        {
            List<PhieuNhapDTO> dsPN = new List<PhieuNhapDTO>();
            // ..
            string query = "SELECT PN.MaPhieu,  PN.NhanVienLap,Nv.HoTenNV,PN.NgayNhap from PhieuNhap PN, NhanVien NV where PN.NhanVienLap = NV.MaNV AND(PN.MaPhieu like '{0}%' OR PN.NhanVienLap like '{1}%' OR NV.HoTenNV like '{2}%' OR PN.NgayNhap like '{3}%')";
            string sql = string.Format(query, value, value, value, value);
            SqlDataReader reader = con.getdata(sql);
            while (reader.Read())
            {
                PhieuNhapDTO pn = new PhieuNhapDTO();
                pn.MaPhieu = reader.GetString(0);
                pn.NhanVienLap = reader.GetString(1);
                pn.TenNhanVien = reader.GetString(2);
                pn.NgayNhap = reader.GetDateTime(3);
                dsPN.Add(pn);
            }
            con.Ngatketnoi();
            return dsPN;
        }

    }
}
