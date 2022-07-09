using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class SanPhamDAO
    {

        DataProvider con = new DataProvider();
        NCPEntities DB = new NCPEntities();
        public List<SanPhamDTO> LayDSanPhamFromSanPhamTableEntities()
        {
            List<SanPhamDTO> dsNCC = new List<SanPhamDTO>();
            // ...
            dsNCC = DB.SanPhams.Where(u => u.TrangThai == true) .Select(v => new SanPhamDTO
            {
                MaSP = v.MaSP,
                TenSP = v.TenSP,
                MaLoai = v.MaLoai,
                XuaXu = v.XuatXu,
                TrangThai = v.TrangThai
            }).ToList();


            return dsNCC;
        }
        public List<SanPhamDTO> LayDSSP()
        {
            List<SanPhamDTO> SanPhams = new List<SanPhamDTO>();// Tao List
            string select = "SELECT pn.MaPhieu, sp.MaSP, sp.TenSP, l.TenLoai, ctpn.GiaGoc+(ctpn.GiaGoc*0.5) N'Giá bán', SUM(ctpn.SoLuongTon) N'Số lượng tồn', ncc.TenNCC, sp.XuatXu";
            string from = " FROM SanPham sp, PhieuNhap pn, ChiTietPhieuNhap ctpn, LoaiSanPham l, NhaCungCap ncc";
            string where = " WHERE sp.MaSP=ctpn.MaSP AND pn.MaPhieu = ctpn.MaPhieu AND sp.MaLoai = l.MaLoai AND ncc.MaNCC=ctpn.MaNCC AND sp.TrangThai='True'";
            string groupBy = " GROUP BY pn.MaPhieu, sp.MaSP, sp.TenSP, l.TenLoai, ctpn.GiaGoc,  ncc.TenNCC, sp.XuatXu";
            string having = " HAVING SUM(ctpn.SoLuongTon) > 0";
            string orderBy = " ORDER BY sp.MaSP asc";
            string Query = select + from + where + groupBy + having + orderBy;
            SqlDataReader reader = con.getdata(Query);
            while (reader.Read())
            {
                SanPhamDTO SP = new SanPhamDTO();
                SP.MaPhieuNhap = reader.GetString(0);
                SP.MaSP = reader.GetString(1);
                SP.TenSP = reader.GetString(2);
                SP.TenLoai = reader.GetString(3);
                SP.GiaBan = Math.Round(reader.GetDecimal(4));
                SP.SoLuongTon = reader.GetInt32(5);
                SP.TenNCC = reader.GetString(6);
                SP.XuaXu = reader.GetString(7);
                SanPhams.Add(SP);

            }
            con.Ngatketnoi();
            return SanPhams;
        }

        // Thêm san Pham
        public bool ThemSanPham(SanPhamDTO sp)
        {
            try
            {
                con.Ketnoi();
                string sql = "INSERT INTO [NCP].[dbo].[SanPham] VALUES ('{0}',N'{1}','{2}',N'{3}',1)";
                string Query = string.Format(sql, sp.MaSP, sp.TenSP, sp.MaLoai, sp.XuaXu);
                SqlCommand cmd = new SqlCommand(Query, con.cn);
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
        public bool SuaSanPham(SanPhamDTO sp)
        {
            try
            {
                string Query = string.Format("UPDATE SanPham SET TenSanPham=N'{0}',LoaiSanPham=N'{1}', GiaBan={2},KhuyenMai={3},MaNCC='{4}',XuatXu=N'{5}' WHERE MaSanPham='{6}'", sp.TenSP, sp.MaLoai, sp.GiaBan, sp.KhuyenMai, sp.MaNCC, sp.XuaXu, sp.MaSP);
                SqlCommand cmd = new SqlCommand(Query, con.cn);
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
            }
            return false;
        }
        public bool XoaSanPham(SanPhamDTO SP)
        {
            try
            {
                string query = "UPDATE SanPham SET TrangThai = 'False' WHERE MaSP = '{0}'";
                string sql = string.Format(query, SP.MaSP);
                int count = con.Delete(sql);
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
            }
            return false;
        }

        public SanPhamDTO TimKiemSP(string maSP)
        {
            //...
            SanPhamDTO sp = new SanPhamDTO();
            //select
            string select1 = "SELECT TOP(1) pn.MaPhieu, sp.MaSP, sp.TenSP, l.TenLoai, ctpn.GiaGoc+(ctpn.GiaGoc*0.5) N'Giá bán', SUM(ctpn.SoLuongTon) N'Số lượng tồn', ncc.TenNCC, sp.XuatXu";
            string from1 = " FROM SanPham sp, PhieuNhap pn, ChiTietPhieuNhap ctpn, LoaiSanPham l, NhaCungCap ncc";
            string where1 = " WHERE sp.MaSP=ctpn.MaSP AND pn.MaPhieu = ctpn.MaPhieu AND sp.MaLoai = l.MaLoai AND ncc.MaNCC=ctpn.MaNCC AND sp.MaSP='{0}' AND sp.TrangThai='True'";
            string groupBy1 = " GROUP BY pn.MaPhieu, sp.MaSP, sp.TenSP, l.TenLoai, ctpn.GiaGoc,  ncc.TenNCC, sp.XuatXu";
            string having1 = " HAVING SUM(ctpn.SoLuongTon)";
            //select lồng
            string select2 = " = (SELECT TOP (1) SUM(ctpn.SoLuongTon)";
            string from2 = " FROM SanPham sp, PhieuNhap pn, ChiTietPhieuNhap ctpn, LoaiSanPham l, NhaCungCap ncc";
            string where2 = " WHERE sp.MaSP=ctpn.MaSP AND pn.MaPhieu = ctpn.MaPhieu AND sp.MaLoai = l.MaLoai AND ncc.MaNCC=ctpn.MaNCC AND sp.MaSP='{1}' AND sp.TrangThai='True'";
            string groupBy2 = " GROUP BY pn.MaPhieu, sp.MaSP, sp.TenSP, l.TenLoai, ctpn.GiaGoc,  ncc.TenNCC, sp.XuatXu";
            string having2 = " HAVING SUM(ctpn.SoLuongTon) > 0)";
            //...
            string query = select1 + from1 + where1 + groupBy1 + having1 + select2 + from2 + where2 + groupBy2 + having2;
            string sql = string.Format(query, maSP, maSP);
            SqlDataReader reader = con.getdata(sql);
            while (reader.Read())
            {
                sp.MaPhieuNhap = reader.GetString(0);
                sp.MaSP = reader.GetString(1);
                sp.TenSP = reader.GetString(2);
                sp.TenLoai = reader.GetString(3);
                sp.GiaBan = Math.Round(reader.GetDecimal(4));
                sp.SoLuongTon = reader.GetInt32(5);
                sp.TenNCC = reader.GetString(6);
                sp.XuaXu = reader.GetString(7);
            }
            //...
            con.Ngatketnoi();
            return sp;
        }
        public List<SanPhamDTO> TimKiemNhanh(string value)
        {
            //...
            List<SanPhamDTO> listSP = new List<SanPhamDTO>();
            string select = "SELECT sp.MaSP, sp.TenSP, l.TenLoai, ctpn.GiaGoc+(ctpn.GiaGoc*0.5) 'GiaBan', SUM(ctpn.SoLuongTon) 'SoLuongTon', ncc.TenNCC, sp.XuatXu";
            string from = " FROM SanPham sp, PhieuNhap pn, ChiTietPhieuNhap ctpn, LoaiSanPham l, NhaCungCap ncc";
            string where = " WHERE sp.MaSP=ctpn.MaSP AND pn.MaPhieu = ctpn.MaPhieu AND sp.MaLoai = l.MaLoai AND ncc.MaNCC=ctpn.MaNCC AND sp.TrangThai='True' AND (sp.MaSP LIKE '{0}%' OR sp.TenSP LIKE '{1}%' OR l.TenLoai LIKE '{2}%' OR ncc.TenNCC LIKE '{3}%' OR sp.XuatXu LIKE '{4}%')";
            string groupBy = " GROUP BY  sp.MaSP, sp.TenSP, l.TenLoai, ctpn.GiaGoc,  ncc.TenNCC, sp.XuatXu";
            string having = " HAVING SUM(ctpn.SoLuongTon) > 0";
            string query = select + from + where + groupBy + having;
            string sql = string.Format(query, value, value, value, value, value);
            SqlDataReader reader = con.getdata(sql);
            while (reader.Read())
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.MaSP = reader.GetString(0);
                sp.TenSP = reader.GetString(1);
                sp.TenLoai = reader.GetString(2);
                sp.GiaBan = Math.Round(reader.GetDecimal(3));
                sp.SoLuongTon = reader.GetInt32(4);
                sp.TenNCC = reader.GetString(5);
                sp.XuaXu = reader.GetString(6);
                listSP.Add(sp);
            }
            //...
            con.Ngatketnoi();
            return listSP;
        }
        public Int64 DemTongSanPham()
        {
            //...
            string query = "SELECT COUNT(*) FROM SanPham";
            Int64 count = con.GetDataScalar(query);
            //...
            return count;
        }
        // TÌM KIẾM SẢN PHẨM TRONG PHIẾU NHẬP
        public SanPhamDTO TimKiemSanPhamPN(string maSP)
        {
            SanPhamDTO sp = new SanPhamDTO();
            string Query = "SELECT sp.MaSP, sp.TenSP,l.TenLoai ,CT.GiaGoc ,sp.XuatXu  ,NCC.TenNCC from SanPham sp,ChiTietPhieuNhap ct, LoaiSanPham l ,NhaCungCap NCC WHERE sp.MaSP = '{0}' AND l.MaLoai = sp.MaLoai  AND sp.MaSP = ct.MaSP AND NCC.MaNCC = ct.MaNCC ";
            string sql = string.Format(Query, maSP);
            SqlDataReader reader = con.getdata(sql);
            while (reader.Read())
            {
                sp.MaSP = reader.GetString(0);
                sp.TenSP = reader.GetString(1);
                sp.TenLoai = reader.GetString(2);
                sp.GiaGoc = reader.GetDecimal(3);
                sp.XuaXu = reader.GetString(4);
                sp.TenNCC = reader.GetString(5);
            }
            con.Ngatketnoi();
            return sp;
        }
    }
}
