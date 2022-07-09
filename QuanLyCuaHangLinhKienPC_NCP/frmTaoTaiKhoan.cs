using BUS;
using DevExpress.XtraExport.Helpers;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmTaoTaiKhoan : Form
    {
        NhanVienBUS nvBus = new NhanVienBUS();
        PhanQuyenBUS quyenBus = new PhanQuyenBUS();
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        ChucVuBUS cvBUS = new ChucVuBUS();
        //...
        NotificationText mess = new NotificationText();

        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        //              ███████]▄▄▄▄▄▄▄▄▃
        //         ▂▄▅█████████▅▄▃▂
        //        [███████████████████]
        //        ◥⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙◤…

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadMaNVInCombobox()
        {
            foreach (NhanVienDTO nv in nvBus.LoadDataBboBUS())
            {
                cboMaNV.Items.Add(nv.MaNV);
            }
        }
        public void loadMaQuyenInCombobox()
        {
            cboPhanQuyen.DataSource = quyenBus.LoadDataBUS();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            loadMaNVInCombobox();
            loadMaQuyenInCombobox();
            if (cboMaNV == null)
            {
                cboMaNV.Enabled = false;
            }
            else
            {
                cboMaNV.Enabled = true;
            }
        }

        private void cboMaNV_TextChanged(object sender, EventArgs e)
        {
            int dem = 0;
            List<NhanVienDTO> list = nvBus.LoadDataBboBUS();
            foreach (NhanVienDTO nv in list)
            {
                if (cboMaNV.Text == nv.MaNV)
                {
                    txtHoTen.Text = nv.HoTenNV;
                    txtSoDienThoai.Text = nv.SdtNV;
                    txtDiaChi.Text = nv.DiaChi;
                    dtpNgaySinh.EditValue = nv.NgaySinh.ToString("dd/MM/yyyy");
                    if (nv.GioiTinh == "Nam")
                    {
                        radgrpGioiTinh.SelectedIndex = 0;
                    }
                    else
                    {
                        radgrpGioiTinh.SelectedIndex = 1;
                    }

                }
                else
                {
                    dem++;
                }
            }
            if (dem == list.Count())
            {
                txtHoTen.ResetText();
                txtSoDienThoai.ResetText();
                txtDiaChi.ResetText();
                dtpNgaySinh.ResetText();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.TenTaiKhoan = txtTenDangNhap.Text;
                tk.MatKhau = MaHoaMatKhau.Encrypt(txtMatKhau.Text);
                //tk.MaNhanVien = cboMaNV.SelectedItem.ToString();
                tk.MaNhanVien = cboMaNV.Text;
                tk.MaQuyen = cboPhanQuyen.SelectedIndex + 1;
                if (string.IsNullOrEmpty(cboMaNV.Text) || string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(cboPhanQuyen.Text))
                {
                    MessageBox.Show(mess.emptyAccountInput, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtHoTen.Text))
                {
                    MessageBox.Show(mess.accountExists, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tkBUS.ThemTaiKhoan(tk))
                {
                    MessageBox.Show(mess.createSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    DataLogin.formQuanLy.btnQuanLyTaiKhoan_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(mess.createFail, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show(mess.accountExists, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
