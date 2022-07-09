using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        DataProvider conn = new DataProvider();
        //...
        public List<HoaDonDTO> LoadDataDAO()
        {
            List<HoaDonDTO> lsHD = new List<HoaDonDTO>();
            //...
            string query = "SELECT hd.MaHD, hd.NgayLap, hd.NhanVienLap, nv.HoTenNV ,kh.SDT FROM HoaDon hd, NhanVien nv, KhachHang kh WHERE hd.NhanVienLap = nv.MaNV AND kh.MaKH = hd.MaKH";
            SqlDataReader reader = conn.getdata(query);
            while (reader.Read())
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.MaHD = reader.GetString(0);
                hd.NgayLap = reader.GetDateTime(1);
                hd.MaNhanVienLap = reader.GetString(2);
                hd.NhanVienLap = reader.GetString(3);
                hd.SdtKhachHang = reader.GetString(4);
                hd.TrangThai = true;
                lsHD.Add(hd);
            }
            //...
            conn.Ngatketnoi();
            return lsHD;
        }

        public bool ThemHoaDonDAO(HoaDonDTO hd)
        {
            //...
            string query = "INSERT INTO HoaDon VALUES ('{0}', '{1}', '{2}','{3}')";
            string sql = string.Format(query, hd.MaHD, hd.MaKH, hd.MaNhanVienLap, hd.NgayLap);
            int count = conn.Insert(sql);
            if (count > 0)
            {
                return true;
            }
            //...
            return false;
        }

        public Int64 DemTongHoaDonDAO()
        {
            //...
            string query = "SELECT COUNT(*) FROM HoaDon";
            Int64 count = conn.GetDataScalar(query);
            //...
            return count;
        }
        public List<HoaDonDTO> TimKiemNhanhDAO(string value)
        {
            List<HoaDonDTO> lsHD = new List<HoaDonDTO>();
            //...
            string query = "SELECT hd.MaHD, hd.NgayLap, hd.NhanVienLap, nv.HoTenNV ,kh.SDT FROM HoaDon hd, NhanVien nv, KhachHang kh WHERE (hd.NhanVienLap = nv.MaNV AND kh.MaKH = hd.MaKH) AND (hd.MaHD like '{0}%' OR hd.NgayLap like '{1}%' OR hd.NhanVienLap like '{2}%' OR nv.HoTenNV like '{3}%' OR kh.SDT like '{4}%')";
            string sql = string.Format(query, value, value, value, value, value);
            SqlDataReader reader = conn.getdata(sql);
            while (reader.Read())
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.MaHD = reader.GetString(0);
                hd.NgayLap = reader.GetDateTime(1);
                hd.MaNhanVienLap = reader.GetString(2);
                hd.NhanVienLap = reader.GetString(3);
                hd.SdtKhachHang = reader.GetString(4);
                hd.TrangThai = true;
                lsHD.Add(hd);
            }
            //...
            conn.Ngatketnoi();
            return lsHD;
        }
    }
}
