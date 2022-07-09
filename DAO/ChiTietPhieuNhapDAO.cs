using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietPhieuNhapDAO
    {
        DataProvider con = new DataProvider();
        public bool CapNhatSoLuongSpDAO(ChiTietHoaDonDTO cthd, string maPhieu)
        {
            string query = "UPDATE ChiTietPhieuNhap SET SoLuongTon = SoLuongTon-{0} WHERE MaPhieu='{1}' AND MaSP ='{2}'";
            string sql = string.Format(query, cthd.SoLuongMua, maPhieu, cthd.MaSP);
            int count = con.Insert(sql);
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        //...
        public List<ChiTietPhieuNhapDTO> loadDSPN(string maPN)
        {
            List<ChiTietPhieuNhapDTO> lsCTPN = new List<ChiTietPhieuNhapDTO>();
            con.Ketnoi();
            string Query = "SELECT PN.MaPhieu,NCC.MaNCC,SP.MaSP,CT.GiaGoc,CT.SoLuongNhap,CT.SoLuongTon,CT.ThanhTien FROM PhieuNhap PN, ChiTietPhieuNhap CT, SanPham SP,NhaCungCap NCC WHERE PN.MaPhieu = '{0}' AND CT.MaPhieu = PN.MaPhieu AND CT.MaSP = SP.MaSP AND CT.MaNCC = NCC.MaNCC";
            string Sql = string.Format(Query, maPN);
            SqlDataReader reader = con.getdata(Sql);
            while (reader.Read())
            {
                ChiTietPhieuNhapDTO CT = new ChiTietPhieuNhapDTO();
                CT.MaPhieu = maPN;
                CT.MaNCC = reader.GetString(1);
                CT.MaSP = reader.GetString(2);
                CT.GiaGoc = Math.Round(reader.GetDecimal(3));
                CT.SoLuongNhap = reader.GetInt32(4);
                CT.SoLuongTon = reader.GetInt32(5);
                CT.ThanhTien = Math.Round(reader.GetDecimal(6));
                lsCTPN.Add(CT);
            }
            con.Ngatketnoi();
            return lsCTPN;
        }

        public bool themCTPN(List<ChiTietPhieuNhapDTO> listPN)
        {
            if (listPN.Count == 0)
            {
                return false;
            }
            int dem = 0;
            string Query = "INSERT INTO [NCP].[dbo].[ChiTietPhieuNhap] VALUES ('{0}','{1}','{2}',{3},{4},{5},{6})";
            foreach (ChiTietPhieuNhapDTO ct in listPN)
            {
                string sql = string.Format(Query, ct.MaPhieu, ct.MaNCC, ct.MaSP, ct.GiaGoc, ct.SoLuongNhap, ct.SoLuongTon, ct.ThanhTien);
                int count = con.Insert(sql);
                dem += count;
            }
            if (dem == listPN.Count)
            {
                return true;
            }
            return false;
        }
        public long TinhTongTienPN(string maPN)
        {
            string query = "SELECT SUM(ThanhTien) FROM ChiTietPhieuNhap Where MaPhieu = '{0}'";
            string sql = string.Format(query, maPN);
            return con.GetTong(sql);
        }
    }
}
