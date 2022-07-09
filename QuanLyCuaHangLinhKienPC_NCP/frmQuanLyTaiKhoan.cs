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
    public partial class frmQuanLyTaiKhoan : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaoTaiKhoan frm = new frmTaoTaiKhoan();
            frm.ShowDialog();
        }
        public void LoadTK()
        {
            dgvDanhSachTK.AutoGenerateColumns = false;
            dgvDanhSachTK.DataSource = tkBUS.LayDSTK();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTK();
        }

        private void txtTimKiemNhanh_OnValueChanged(object sender, EventArgs e)
        {
            dgvDanhSachTK.AutoGenerateColumns = false;
            dgvDanhSachTK.DataSource = tkBUS.LayDSTKTheoTuKhoa(txtTimKiemNhanh.Text);
        }
    }
}
