using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmQuanLyHoaDon : Form
    {
        HoaDonBUS hdBUS = new HoaDonBUS();
        private string maNV = null;
        private string tenNV = null;
        //...
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }
        public frmQuanLyHoaDon(string maNV, string tenNV) : this()
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            DataLogin.formOpacity.Show();
            frmLapHoaDon frmLHD = new frmLapHoaDon(maNV, tenNV);
            frmLHD.ShowDialog();
        }
        //...
        public void loadData()
        {
            dgvDanhSachHD.AutoGenerateColumns = false;
            dgvDanhSachHD.DataSource = hdBUS.LoadDataBUS();
        }

        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvDanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvDanhSachHD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDanhSachHD.CurrentRow.Selected = true;
                string maHD = dgvDanhSachHD.Rows[e.RowIndex].Cells[0].Value.ToString();
                DateTime ngayLap = Convert.ToDateTime(dgvDanhSachHD.Rows[e.RowIndex].Cells[1].Value);
                string maNV = dgvDanhSachHD.Rows[e.RowIndex].Cells[2].Value.ToString();
                string tenNV = dgvDanhSachHD.Rows[e.RowIndex].Cells[3].Value.ToString();
                string sdtKhachHang = dgvDanhSachHD.Rows[e.RowIndex].Cells[4].Value.ToString();
                //...
                DataLogin.formOpacity.Show();
                frmChiTietHoaDon frm = new frmChiTietHoaDon(maHD, ngayLap, maNV, tenNV, sdtKhachHang);
                frm.ShowDialog();
            }
        }

        private void txtTimKiemNhanh_OnValueChanged(object sender, EventArgs e)
        {
            dgvDanhSachHD.AutoGenerateColumns = false;
            dgvDanhSachHD.DataSource = hdBUS.TimKiemNhanhBUS(txtTimKiemNhanh.Text);
        }
    }
}
