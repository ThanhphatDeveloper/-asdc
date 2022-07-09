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
    public partial class frmTimKiemSanPham : Form
    {
        SanPhamBUS spBUS = new SanPhamBUS();
        public frmTimKiemSanPham()
        {
            InitializeComponent();
        }

        private void frmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }
       public void LoadData()
        {
            dgvDanhSachSP.AutoGenerateColumns = false;
            dgvDanhSachSP.DataSource = spBUS.LayDanhSachSanPham();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
