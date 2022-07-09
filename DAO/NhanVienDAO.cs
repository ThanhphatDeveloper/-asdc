using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        DataProvider conn = new DataProvider();
        NhanVienDTO nv = new NhanVienDTO();

        public List<NhanVienDTO> LayDSNVDAO()
        {
            List<NhanVienDTO> dsNV = new List<NhanVienDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT nv.MaNV, nv.HoTenNV,nv.MaChucVu, cv.TenChucVu, nv.NgaySinh, nv.GioiTinh, nv.SDT_NhanVien,nv.DiaChi,nv.Anh, nv.TrangThai FROM NhanVien nv, ChucVu cv WHERE nv.MaChucVu=cv.MaChucVu AND nv.TrangThai='True'";
            SqlDataReader reader = conn.getdata(query);
            while (reader.Read())
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNV = reader.GetString(0);
                nv.HoTenNV = reader.GetString(1);
                nv.MaChucVu = reader.GetString(2);
                nv.TenChucVu = reader.GetString(3);
                nv.NgaySinh = reader.GetDateTime(4);
                if (reader.GetBoolean(5) == true)
                {
                    nv.GioiTinh = "Nam";
                }
                else
                {
                    nv.GioiTinh = "Nữ";
                }
                nv.SdtNV = reader.GetString(6);
                nv.DiaChi = reader.GetString(7);
                nv.Anh = reader.GetString(8);
                nv.TrangThai = reader.GetBoolean(9);
                dsNV.Add(nv);
            }
            // ...
            conn.Ngatketnoi();
            return dsNV;
        }
        public List<NhanVienDTO> LayDSNVTheoKeyworkDAO(string value)
        {
            List<NhanVienDTO> dsNV = new List<NhanVienDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT nv.MaNV, nv.HoTenNV,nv.MaChucVu, cv.TenChucVu, nv.NgaySinh, nv.GioiTinh, nv.SDT_NhanVien,nv.DiaChi,nv.Anh, nv.TrangThai FROM NhanVien nv, ChucVu cv WHERE nv.MaChucVu=cv.MaChucVu AND nv.TrangThai='True' AND (nv.MaNV LIKE '{0}%' OR nv.HoTenNV LIKE '{1}%' OR nv.MaChucVu LIKE '{2}%' OR cv.TenChucVu LIKE '{3}%' OR nv.NgaySinh LIKE '{4}%' OR nv.GioiTinh LIKE '{5}%' OR nv.SDT_NhanVien LIKE '{6}%' OR nv.DiaChi LIKE '{7}%')";
            string sql = string.Format(query,value, value, value, value, value, value, value, value);
            SqlDataReader reader = conn.getdata(sql);
            while (reader.Read())
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNV = reader.GetString(0);
                nv.HoTenNV = reader.GetString(1);
                nv.MaChucVu = reader.GetString(2);
                nv.TenChucVu = reader.GetString(3);
                nv.NgaySinh = reader.GetDateTime(4);
                if (reader.GetBoolean(5) == true)
                {
                    nv.GioiTinh = "Nam";
                }
                else
                {
                    nv.GioiTinh = "Nữ";
                }
                nv.SdtNV = reader.GetString(6);
                nv.DiaChi = reader.GetString(7);
                nv.Anh = reader.GetString(8);
                nv.TrangThai = reader.GetBoolean(9);
                dsNV.Add(nv);
            }
            // ...
            conn.Ngatketnoi();
            return dsNV;
        }
        public List<NhanVienDTO> LayDSNVCboDAO()
        {
            List<NhanVienDTO> dsNV = new List<NhanVienDTO>();
            // ...
            conn.Ketnoi();
            string query = "SELECT nv.MaNV, nv.HoTenNV, nv.MaChucVu, cv.TenChucVu,nv.GioiTinh,nv.NgaySinh,nv.SDT_NhanVien,nv.DiaChi,nv.TrangThai FROM NhanVien nv, ChucVu cv WHERE nv.MaChucVu = cv.MaChucVu AND nv.TrangThai='True' AND nv.MaNV NOT IN (SELECT nv.MaNV FROM NhanVien nv, TaiKhoan tk WHERE nv.MaNV = tk.NVSoHuu)";
            SqlDataReader reader = conn.getdata(query);
            while (reader.Read())
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNV = reader.GetString(0);
                nv.HoTenNV = reader.GetString(1);
                nv.MaChucVu = reader.GetString(2);
                nv.TenChucVu = reader.GetString(3);
                if (reader.GetBoolean(4) == true)
                {
                    nv.GioiTinh = "Nam";
                }
                else
                {
                    nv.GioiTinh = "Nữ";
                }
                nv.NgaySinh = reader.GetDateTime(5);
                nv.SdtNV = reader.GetString(6);
                nv.DiaChi = reader.GetString(7);
                nv.TrangThai = reader.GetBoolean(8);
                dsNV.Add(nv);
            }
            // ...
            conn.Ngatketnoi();
            return dsNV;
        }

        public NhanVienDTO TimKiemNVDAO(string tenTK)
        {
            string query = "SELECT nv.MaNV, nv.HoTenNV, nv.Anh FROM NhanVien nv, TaiKhoan tk WHERE tk.TenTaiKhoan = '{0}' AND  nv.MaNV = tk.NVSoHuu";
            string sql = string.Format(query, tenTK);
            SqlDataReader reader = conn.getdata(sql);
            NhanVienDTO nv = new NhanVienDTO();
            while (reader.Read())
            {
                nv.MaNV = reader.GetString(0);
                nv.HoTenNV = reader.GetString(1);
                nv.Anh = reader.GetString(2);
            }
            conn.Ngatketnoi();
            return nv;
        }
        public bool ThemNVDao(NhanVienDTO nv)
        {
            try
            {
                conn.Ketnoi();
                string query = "INSERT INTO NhanVien VALUES ('{0}','{1}',N'{2}',N'{3}','{4}','{5}',N'{6}','{7}',1)";
                string sql = string.Format(query, nv.MaNV, nv.MaChucVu, nv.HoTenNV, nv.GioiTinh == "Nam" ? 1 : 0, nv.NgaySinh.ToString("yyyy/MM/dd"), nv.SdtNV, nv.DiaChi, nv.Anh);
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
        public bool CapNhatNVDao(NhanVienDTO nv)
        {
            try
            {
                string query = "UPDATE NhanVien SET MaChucVu='{0}', HoTenNV=N'{1}',GioiTinh='{2}',NgaySinh='{3}',SDT_NhanVien='{4}',DiaChi=N'{5}',Anh='{6}' WHERE MaNV='{7}'";
                string sql = string.Format(query, nv.MaChucVu, nv.HoTenNV, nv.GioiTinh == "Nam" ? true : false, nv.NgaySinh, nv.SdtNV, nv.DiaChi, nv.Anh, nv.MaNV);
                int count = conn.Update(sql);
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
        public bool XoaNVDao(NhanVienDTO nv)
        {
            try
            {
                conn.Ketnoi();
                string queryNV = "UPDATE NhanVien SET TrangThai='False' WHERE MaNV='{0}'";
                //...
                string sqlNV = string.Format(queryNV, nv.MaNV);
                //...
                SqlCommand cmdNV = new SqlCommand(sqlNV, conn.cn);
                //...
                int countNV = cmdNV.ExecuteNonQuery();
                //...
                if (countNV > 0)
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
        public Int64 DemSoLuongNV()
        {
            string query = "SELECT COUNT(*) FROM NhanVien";
            Int64 count = conn.GetDataScalar(query);
            return count;
        }
    }
}
