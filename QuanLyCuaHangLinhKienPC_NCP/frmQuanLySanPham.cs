using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using Bunifu;
using DevExpress.XtraPrinting.Native.Lines;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmQuanLySanPham : Form
    {
        private string maNV = null;
        private string tenNV = null;
        SanPhamBUS spBUS = new SanPhamBUS();
        LoaiSanPhamBUS loaiSPBus = new LoaiSanPhamBUS();
        //...
        NotificationText mess = new NotificationText();
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }
        public frmQuanLySanPham(string maNV, string tenNV) : this()
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            dgvDanhSachSP.AutoGenerateColumns = false;
            dgvDanhSachSP.DataSource = spBUS.LayDanhSachSanPham();
            //...
            LoadLoaiSPListView();
        }
        public void LoadLoaiSPListView()
        {
            foreach(LoaiSanPhamDTO loai in loaiSPBus.LoadLoaiSP())
            {
                lvwDanhMucSanPham.Items.Add(loai.TenLoai);
            }
        }
        private void dgvDanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvDanhSachSP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDanhSachSP.CurrentRow.Selected = true;
                txtMaSP.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSP.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLoai.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                decimal giaBan = (decimal)dgvDanhSachSP.Rows[e.RowIndex].Cells[3].Value;
                txtGiaBan.Text = DinhDangTienVN.DinhDangTienVND(giaBan);
                txtGiaGoc.Text = DinhDangTienVN.DinhDangTienVND(giaBan / (decimal)1.5);
                txtSoLuongTon.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtMaNCC.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtXuatXu.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[6].Value.ToString();
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show(mess.deleteProductQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                SanPhamDTO spDTO = new SanPhamDTO();
                spDTO.MaSP = txtMaSP.Text;
                if (result == DialogResult.Yes)
                {
                    if (spBUS.XoaSanPham(spDTO))
                    {
                        MessageBox.Show(mess.deleteProductSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDanhSachSP.DataSource = spBUS.LayDanhSachSanPham();
                    }
                    else
                    {
                        MessageBox.Show(mess.deleteProductFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(mess.UnknownExceptionError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }
        private void txtTimKiemNhanh_OnValueChanged(object sender, EventArgs e)
        {
            int valueNumber = 0;
            bool checkValue = int.TryParse(txtTimKiemNhanh.Text, out valueNumber);
            if (checkValue)
            {
                dgvDanhSachSP.DataSource = "";
                dgvDanhSachSP.AutoGenerateColumns = false;
                dgvDanhSachSP.DataSource = spBUS.TimKiemNhanh(valueNumber.ToString());
            }
            else
            {
                dgvDanhSachSP.DataSource = "";
                dgvDanhSachSP.AutoGenerateColumns = false;
                dgvDanhSachSP.DataSource = spBUS.TimKiemNhanh(txtTimKiemNhanh.Text);
            }

        }
        private void btnQuanLyLoai_Click(object sender, EventArgs e)
        {
            DataLogin.formOpacity.Show();
            frmQuanLyLoaiSanPham frm = new frmQuanLyLoaiSanPham();
            frm.ShowDialog();
        }
    }
}
