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
    public partial class frmQuanLyPhieuNhap : Form
    {
        private string maNV = null;
        private string tenNV = null;
        PhieuNhapBUS pnBUS = new PhieuNhapBUS();
       
        public frmQuanLyPhieuNhap()
        {
            InitializeComponent();
        }
        public frmQuanLyPhieuNhap(string maNV, string tenNV) : this()
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
        }
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            DataLogin.formOpacity.Show();
            frmNhapHang frmNH = new frmNhapHang(maNV, tenNV);
            frmNH.ShowDialog();
        }

        private void frmQuanLyPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadPhieuNhap();
        }

        public void LoadPhieuNhap()
        {
            dgvDanhSachPN.AutoGenerateColumns = false;
            dgvDanhSachPN.DataSource = pnBUS.LayDSPN();
        }

        private void dgvDanhSachPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0)
            {
                return;
            }    
           if(dgvDanhSachPN.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                dgvDanhSachPN.CurrentCell.Selected = true;
                string maPhieu = dgvDanhSachPN.Rows[e.RowIndex].Cells[0].Value.ToString();
                string maNhanVien= dgvDanhSachPN.Rows[e.RowIndex].Cells[1].Value.ToString();
                string tenNhanVien = dgvDanhSachPN.Rows[e.RowIndex].Cells[2].Value.ToString();
                DateTime NgayNhap = Convert.ToDateTime(dgvDanhSachPN.Rows[e.RowIndex].Cells[3].Value.ToString());
                //...
                DataLogin.formOpacity.Show();
                frmChiTietPhieuNhap frm = new frmChiTietPhieuNhap(maPhieu, maNhanVien,tenNhanVien,NgayNhap);             
                frm.ShowDialog();
            }    
        }

        private void txtTimKiemNhanh_OnValueChanged(object sender, EventArgs e)
        {
            string Values = txtTimKiemNhanh.Text;
            dgvDanhSachPN.DataSource = pnBUS.TimKiemNhanh(Values);
        }
    }
}
