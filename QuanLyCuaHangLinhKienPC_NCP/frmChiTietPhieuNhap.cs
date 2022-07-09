using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmChiTietPhieuNhap : Form
    {
        private string maPN;
        private DateTime ngayNhap;
        private string maNhanVien;
        private string tenNhanVien;
        ChiTietPhieuNhapBUS ctpnBUS = new ChiTietPhieuNhapBUS();
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
        }
        public  frmChiTietPhieuNhap(string maPN ,string maNhanVien,string tenNhanVien, DateTime ngayNhap) : this()
        {
            this.maPN = maPN;
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.ngayNhap = ngayNhap;
        }

        public void loadData()
        {
            dgvDanhSachCTPN.AutoGenerateColumns = false;
            dgvDanhSachCTPN.DataSource = ctpnBUS.loadData(txtMaPN.Text);
        }

        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            txtMaPN.Text = maPN;
            txtMaNV.Text = maNhanVien;
            txtTenNV.Text = tenNhanVien;
            dtpNgayNhap.EditValue = ngayNhap;
            loadData();
            Int64 tongTienPhieuNhap = ctpnBUS.TinhTongTienPN(maPN);
            txtTongThanhTien.Text = DinhDangTienVND(tongTienPhieuNhap);
        }

        public string DinhDangTienVND(long tien)
        {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tien);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataLogin.formOpacity.Hide();
            DataLogin.formQuanLy.Hide();
            DataLogin.formQuanLy.Show();
            DataLogin.formQuanLy.btnQuanLyPhieuNhap_Click(sender, e);
        }
    }
}
