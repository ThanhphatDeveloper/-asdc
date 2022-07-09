using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmQuanLyKhachHang : Form
    {
        KhachHangBUS khBus = new KhachHangBUS();
        NotificationText mess = new NotificationText();
        List<KhachHangDTO> lstKH;
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            panelTTKHContent.Enabled = true;
            btnCapNhat.Visible = false;
            btnLuuCapNhat.Visible = true;
            //...
            txtSDT.Focus();
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(mess.updateCustomerQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // ...
            try
            {
                KhachHangDTO khDTO = new KhachHangDTO(txtMaKH.Text, txtSDT.Text, txtHoTen.Text, txtDiaChi.Text, true);
                if (result == DialogResult.Yes)
                {
                    if (khBus.capNhatKHBus(khDTO))
                    {
                        MessageBox.Show(mess.updateCustomerSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyKhachHang_Load(sender, e);
                        // ...
                        panelTTKHContent.Enabled = false;
                        btnLuuCapNhat.Visible = false;
                        btnCapNhat.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show(mess.updateCustomerFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(mess.UnknownExceptionError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dgvDanhSachKH.AutoGenerateColumns = false;
            dgvDanhSachKH.DataSource = khBus.layDSKHBus();
            panelTTKHContent.Enabled = false;
            lstKH = khBus.layDSKHBus(); ;
        }

        private void dgvDanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvDanhSachKH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDanhSachKH.CurrentRow.Selected = true;
                txtMaKH.Text = dgvDanhSachKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSDT.Text = dgvDanhSachKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHoTen.Text = dgvDanhSachKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvDanhSachKH.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(mess.deleteCustomerQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // ...
            try
            {
                KhachHangDTO khDTO = new KhachHangDTO(txtSDT.Text);
                if (result == DialogResult.Yes)
                {
                    if (khBus.xoaKHBus(khDTO))
                    {
                        MessageBox.Show(mess.deleteCustomerSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyKhachHang_Load(sender, e);
                        //...
                        txtMaKH.ResetText();
                        txtSDT.ResetText();
                        txtHoTen.ResetText();
                        txtDiaChi.ResetText();
                        // ...
                        panelTTKHContent.Enabled = false;
                        btnLuuCapNhat.Visible = false;
                        btnCapNhat.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show(mess.deleteCustomerFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(mess.UnknownExceptionError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(mess.addCustomerQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // ...
            if (txtSDT.Text != " " || txtHoTen.Text != " ")
            {
                try
                {
                    KhachHangDTO khDTO = new KhachHangDTO(txtMaKH.Text, txtSDT.Text, txtHoTen.Text, txtDiaChi.Text, true);
                    if (result == DialogResult.Yes)
                    {
                        foreach (KhachHangDTO item in lstKH)
                        {
                            if(item.MaKH == txtMaKH.Text)
                            {
                                MessageBox.Show(mess.customerIsExit, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMaKH.ResetText();
                                txtSDT.ResetText();
                                txtHoTen.ResetText();
                                txtDiaChi.ResetText();
                                //...
                                panelTTKHContent.Enabled = false;
                                btnThemKHMoi.Visible = true;
                                btnThem.Visible = false;
                                return;
                            }
                        }
                        if (string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtHoTen.Text))
                        {
                            MessageBox.Show(mess.addCustomerFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaKH.ResetText();
                            txtSDT.ResetText();
                            txtHoTen.ResetText();
                            txtDiaChi.ResetText();
                            //..
                            panelTTKHContent.Enabled = false;
                            btnThemKHMoi.Visible = true;
                            btnThem.Visible = false;
                            return;
                        }
                        else if (khBus.themKHBus(khDTO))
                        {
                            MessageBox.Show(mess.addCustomerSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmQuanLyKhachHang_Load(sender, e);
                            // ...
                            txtMaKH.ResetText();
                            txtSDT.ResetText();
                            txtHoTen.ResetText();
                            txtDiaChi.ResetText();
                            //...
                            panelTTKHContent.Enabled = false;
                            btnThemKHMoi.Visible = true;
                            btnThem.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show(mess.addCustomerFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaKH.ResetText();
                            txtSDT.ResetText();
                            txtHoTen.ResetText();
                            txtDiaChi.ResetText();
                            //...
                            panelTTKHContent.Enabled = false;
                            btnThemKHMoi.Visible = true;
                            btnThem.Visible = false;
                        }
                    }
                    else
                    {
                        txtMaKH.ResetText();
                        txtSDT.ResetText();
                        txtHoTen.ResetText();
                        txtDiaChi.ResetText();
                        //...
                        panelTTKHContent.Enabled = false;
                        btnThemKHMoi.Visible = true;
                        btnThem.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(mess.UnknownExceptionError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }

        }

        private void btnThemKHMoi_Click(object sender, EventArgs e)
        {
            btnThemKHMoi.Visible = false;
            btnThem.Visible = true;
            //phat sinh ma
            Int64 stt = khBus.DemSoluongKH() + 1;
            string maKH = "KH" + stt;
            txtMaKH.Text = maKH;
            //...
            panelTTKHContent.Enabled = true;
            txtSDT.ResetText();
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtSDT.Focus();
        }

        private void txtTimKiemNhanh_OnValueChanged(object sender, EventArgs e)
        {
            string value = txtTimKiemNhanh.Text;
            dgvDanhSachKH.DataSource = khBus.timKiemNhanhBus(value);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }
    }
    
}
