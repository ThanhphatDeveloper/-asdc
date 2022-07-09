using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraEditors.Filtering.Templates;
using DTO;
using Microsoft.Reporting.WinForms;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmXemBaoCao : Form
    {
        ChiTietHoaDonBUS cthdBUS = new ChiTietHoaDonBUS();
        public frmXemBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoanhThuHD_Load(object sender, EventArgs e)
        {

            // this.rpvXemBaoCao.RefreshReport();
            this.rpvXemBaoCao.RefreshReport();
            this.rpvXemBaoCao.RefreshReport();
            this.rpvXemBaoCao.RefreshReport();
        }
        public ReportDataSource ThietLapBCDoanhThu(string ngayBatDau, string ngayKetThuc)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.NCPConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BaoCaoDoanhThuTheoHD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NgayBatDau", ngayBatDau));
            cmd.Parameters.Add(new SqlParameter("@NgayKetThuc", ngayKetThuc));
            //Khai báo datatset để chứa dữ liệu
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            //Thiết lập báo cáo
            rpvXemBaoCao.ProcessingMode = ProcessingMode.Local;
            rpvXemBaoCao.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangLinhKienPC_NCP.rptBaoCaoDoanhThuHD.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DSHoaDon";
            rds.Value = ds.Tables[0];
            return rds;
        }
        public void TatCaHoaDon(string tenNV)
        {
            string tenNVLap = null;
            if (tenNV == null)
            {
                tenNVLap = "Admin";
            }
            else
            {
                tenNVLap = tenNV;
            }
            //...
            string tatCa = "Tất cả hóa đơn";
            string ngayBatDau = "";
            string ngayKetThuc = "";
            ReportDataSource rds = ThietLapBCDoanhThu(ngayBatDau, ngayKetThuc);
            this.rpvXemBaoCao.LocalReport.DataSources.Clear();
            this.rpvXemBaoCao.LocalReport.DataSources.Add(rds);
            //...
            ReportParameter paNV = new ReportParameter("paNVLap", tenNVLap);
            this.rpvXemBaoCao.LocalReport.SetParameters(paNV);
            ReportParameter paTatCaHD = new ReportParameter("paTatCa", tatCa);
            this.rpvXemBaoCao.LocalReport.SetParameters(paTatCaHD);
            //...
            this.rpvXemBaoCao.RefreshReport();
        }
        public void TatCaHoaDonTheoNgay(string tenNV, string ngayBatDau, string ngayKetThuc,string loai)
        {
            string tenNVLap = null;
            if (tenNV == null)
            {
                tenNVLap = "Admin";
            }
            else
            {
                tenNVLap = tenNV;
            }
            //...
            ReportDataSource rds = ThietLapBCDoanhThu(ngayBatDau, ngayKetThuc);
            this.rpvXemBaoCao.LocalReport.DataSources.Clear();
            this.rpvXemBaoCao.LocalReport.DataSources.Add(rds);
            //...
            DateTime dateStart = Convert.ToDateTime(ngayBatDau);
            DateTime dateEnd = Convert.ToDateTime(ngayKetThuc);
            //...
            ngayBatDau = "Từ " + dateStart.ToString("dd/MM/yyyy");
            ngayKetThuc = "đến " + dateEnd.ToString("dd/MM/yyyy");
            //...
            ReportParameter paNV = new ReportParameter("paNVLap", tenNVLap);
            this.rpvXemBaoCao.LocalReport.SetParameters(paNV);
            ReportParameter paNgayBatDau = new ReportParameter("paNgayBatDau", ngayBatDau);
            this.rpvXemBaoCao.LocalReport.SetParameters(paNgayBatDau);
            ReportParameter paNgayKetThuc = new ReportParameter("paNgayKetThuc", ngayKetThuc);
            this.rpvXemBaoCao.LocalReport.SetParameters(paNgayKetThuc);
            //...
            ReportParameter paTatCaHD = new ReportParameter("paTatCa", loai);
            this.rpvXemBaoCao.LocalReport.SetParameters(paTatCaHD);
            this.rpvXemBaoCao.RefreshReport();
        }
    }
}
