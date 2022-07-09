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
    public class ChiTietHoaDonDAO
    {
        DataProvider conn = new DataProvider();

        public List<ChiTietHoaDonDTO> loadDataDAO(string maHD)
        {
            List<ChiTietHoaDonDTO> lsCTHD = new List<ChiTietHoaDonDTO>();
            conn.Ketnoi();
            //...
            string query = "SELECT ct.MaSP, sp.TenSP, ct.GiaBan, ct.SoLuongMua, ct.KhuyenMai, ct.ThanhTien FROM HoaDon hd, ChiTietHoaDon ct, SanPham sp WHERE hd.MaHD = '{0}' AND ct.MaHD = hd.MaHD AND ct.MaSP = sp.MaSP";
            string sql = string.Format(query, maHD);
            SqlDataReader reader = conn.getdata(sql);
            while (reader.Read())
            {
                ChiTietHoaDonDTO ct = new ChiTietHoaDonDTO();
                ct.MaHD = maHD;
                ct.MaSP = reader.GetString(0);
                ct.TenSP = reader.GetString(1);
                ct.GiaBan = Math.Round(reader.GetDecimal(2));
                ct.SoLuongMua = reader.GetInt32(3);
                ct.KhuyenMai = reader.GetInt32(4);
                ct.ThanhTien = Math.Round(reader.GetDecimal(5));
                ct.TrangThai = true;
                lsCTHD.Add(ct);
            }
            //...
            conn.Ngatketnoi();
            return lsCTHD;
        }
        public bool ThemCTHD(List<ChiTietHoaDonDTO> listCTHD)
        {
            if (listCTHD.Count == 0)
            {
                return false;
            }
            int dem = 0;
            string query = "INSERT INTO ChiTietHoaDon VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}')";
            foreach(ChiTietHoaDonDTO ct in listCTHD)
            {
                string sql = string.Format(query, ct.MaHD,ct.MaSP,ct.MaBH,ct.GiaBan,ct.SoLuongMua,ct.KhuyenMai,ct.ThanhTien);
                int count = conn.Insert(sql);
                dem += count;
            }
            if (dem == listCTHD.Count)
            {
                return true;
            } 
            return false;
        }

        public Int64 TinhTongTien(string maHD)
        {
            string query = "SELECT SUM(ThanhTien) FROM ChiTietHoaDon Where MaHD = '{0}'";
            string sql = string.Format(query,maHD);
            return conn.GetDataScalar(sql);
        }
    }
}
