using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.SqlServer.Server;

namespace DAO
{
    public class TaiKhoanDAO
    {
        DataProvider con = new DataProvider();
        public TaiKhoanDTO KiemTraQuyen(TaiKhoanDTO TK)
        {
            string Query = "select a.TenTaiKhoan,a.MatKhau,b.TenQuyen from TaiKhoan a, PhanQuyen b where a.MaQuyen = b.MaQuyen and a.TenTaiKhoan='" + TK.TenTaiKhoan + "' and a.MatKhau='" + TK.MatKhau + "'";
            SqlDataReader reader = con.getdata(Query);
            TaiKhoanDTO newTK = new TaiKhoanDTO();
            while (reader.Read())
            {
                newTK.TenTaiKhoan = reader.GetString(0);
                newTK.MatKhau = reader.GetString(1);
                newTK.TenQuyen = reader.GetString(2);
            }
            con.Ngatketnoi();
            return newTK;
        }
        public List<TaiKhoanDTO> LayDSTK()
        {
            List<TaiKhoanDTO> lst = new List<TaiKhoanDTO>();
            string sql = "SELECT tk.TenTaiKhoan, pq.TenQuyen, nv.HoTenNV,cv.TenChucVu FROM TaiKhoan tk, NhanVien nv, PhanQuyen pq, ChucVu cv WHERE tk.NVSoHuu = nv.MaNV AND tk.MaQuyen = pq.MaQuyen AND cv.MaChucVu = nv.MaChucVu AND tk.TrangThai='True'";
            SqlDataReader reader = con.getdata(sql);
            while (reader.Read())
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.TenTaiKhoan = reader.GetString(0);
                tk.TenQuyen = reader.GetString(1);
                tk.NhanVienSoHuu = reader.GetString(2);
                tk.ChucVu = reader.GetString(3);
                lst.Add(tk);
            }
            con.Ngatketnoi();
            return lst;
        }
        public List<TaiKhoanDTO> LayDSTKTheoTuKhoa(string value)
        {
            List<TaiKhoanDTO> lst = new List<TaiKhoanDTO>();
            string query = "SELECT tk.TenTaiKhoan, pq.TenQuyen, nv.HoTenNV,cv.TenChucVu FROM TaiKhoan tk, NhanVien nv, PhanQuyen pq, ChucVu cv WHERE tk.NVSoHuu = nv.MaNV AND tk.MaQuyen = pq.MaQuyen AND cv.MaChucVu = nv.MaChucVu AND tk.TrangThai='True' AND (tk.TenTaiKhoan LIKE '{0}%'OR pq.TenQuyen LIKE '{1}%' OR nv.HoTenNV LIKE '{2}%' OR cv.TenChucVu LIKE '{3}%')";
            string sql = string.Format(query, value, value, value, value);
            SqlDataReader reader = con.getdata(sql);
            while (reader.Read())
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.TenTaiKhoan = reader.GetString(0);
                tk.TenQuyen = reader.GetString(1);
                tk.NhanVienSoHuu = reader.GetString(2);
                tk.ChucVu = reader.GetString(3);
                lst.Add(tk);
            }
            con.Ngatketnoi();
            return lst;
        }
        public bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            try
            {
                string query = "INSERT INTO TaiKhoan VALUES('{0}','{1}','{2}','{3}',1)";
                string sql = string.Format(query, tk.TenTaiKhoan, tk.MatKhau, tk.MaNhanVien, tk.MaQuyen);
                int count = con.Insert(sql);
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
        public TaiKhoanDTO TimKiemTK(NhanVienDTO nv)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            string query = "SELECT tk.TenTaiKhoan, tk.MatKhau FROM NhanVien nv, TaiKhoan tk WHERE tk.NVSoHuu = '{0}'";
            string sql = string.Format(query, nv.MaNV);
            SqlDataReader reader = con.getdata(sql);
            while (reader.Read())
            {
                tk.TenTaiKhoan = reader.GetString(0);
                tk.MatKhau = reader.GetString(1);
            }
            con.Ngatketnoi();
            return tk;
        }
        public bool CapNhatTK(string tenTK, string mkMoi)
        {
            string query = "UPDATE TaiKhoan SET MatKhau = '{0}' WHERE TenTaiKhoan = '{1}'";
            string sql = string.Format(query, mkMoi, tenTK);
            int count = con.Update(sql);
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public bool XoaTKDao(NhanVienDTO nv)
        {
            try
            {
                con.Ketnoi();
                string queryTK = "UPDATE TaiKhoan SET TrangThai='False' WHERE NVSoHuu='{0}'";
                //...
                string sqlTK = string.Format(queryTK, nv.MaNV);
                //...
                SqlCommand cmdTK = new SqlCommand(sqlTK, con.cn);
                //...
                int countTK = cmdTK.ExecuteNonQuery();
                //...
                if (countTK > 0)
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

        public TaiKhoanDTO SetTrangThaiTaiKhoan(TaiKhoanDTO TK)
        {
            string Query = "select TenTaiKhoan,TrangThai from TaiKhoan where TenTaiKhoan = '{0}'";
            string sql = string.Format(Query, TK.TenTaiKhoan);
            SqlDataReader reader = con.getdata(sql);
            TaiKhoanDTO newTK = new TaiKhoanDTO();
            while (reader.Read())
            {
                newTK.TenTaiKhoan = reader.GetString(0);
                newTK.TrangThai = reader.GetBoolean(1);
            }
            con.Ngatketnoi();
            return newTK;


        }
    }
}
