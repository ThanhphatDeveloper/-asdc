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
namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmDangNhap : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        NotificationText mess = new NotificationText();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        #region Xử lý thao tác chuyển qua lại giữa 2 slide
        //private void btnDangNhapHeader_Click(object sender, EventArgs e)
        //{
        //    slideDangNhap.Visible = true;
        //    slideDangKy.Visible = false;
        //    slideDangNhap.Left = 40;

        //    separator.Left = btnDangNhapHeader.Left;
        //    separator.Width = btnDangNhapHeader.Width;
        //}

        //private void btnDangKyHeader_Click(object sender, EventArgs e)
        //{
        //    slideDangKy.Visible = true;
        //    slideDangNhap.Visible = false;
        //    slideDangKy.Left = 40;

        //    separator.Left = btnDangKyHeader.Left;
        //    separator.Width = btnDangKyHeader.Width;
        //}
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show(mess.loginInputError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TaiKhoanDTO tkDTO = new TaiKhoanDTO();
            tkDTO.TenTaiKhoan = txtTenDangNhap.Text;
            if (tkDTO.TenTaiKhoan == "admin")
            {
                tkDTO.MatKhau = txtMatKhau.Text;
            }
            else
            {
                tkDTO.MatKhau = MaHoaMatKhau.Encrypt(txtMatKhau.Text);
            }
            TaiKhoanDTO result = tkBUS.checkQuyen(tkDTO);
            TaiKhoanDTO KQ = tkBUS.SetTrangThaiTK(tkDTO);

            string TenQuyen = null;

            if (KQ.TrangThai == false)
            {

                MessageBox.Show(mess.loginDataError, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!string.IsNullOrEmpty(result.TenTaiKhoan))
            {
                TenQuyen = result.TenQuyen;
                DataLogin.quyen = TenQuyen;
                DataLogin.tenTK = txtTenDangNhap.Text;
                frmLoading d = new frmLoading();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(mess.loginDataError, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Text = null;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            e.Handled = char.IsSymbol(e.KeyChar) || (e.KeyChar == (char)Keys.Space);
        }
    }
}
