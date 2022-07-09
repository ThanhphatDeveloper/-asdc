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
using DevExpress.XtraRichEdit.Layout;
using DTO;


namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmQuanLyNhaCungCap : Form
    {
        NhaCungCapBUS nccBus = new NhaCungCapBUS();
        NotificationText mess = new NotificationText();
        List<NhaCungCapDTO> lst;
        public frmQuanLyNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtTenNCC.Enabled = true;
            btnLuuCapNhat.Visible = true;
            btnCapNhat.Visible = false;
            txtMaNCC.Focus();
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            //...
            var result = MessageBox.Show(mess.updateCustomerQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                NhaCungCapDTO nccDTO = new NhaCungCapDTO(txtMaNCC.Text, txtTenNCC.Text, true);
                if (result == DialogResult.Yes)
                {
                    if(string.IsNullOrEmpty(txtMaNCC.Text)||string.IsNullOrEmpty(txtTenNCC.Text))
                    {
                        MessageBox.Show(mess.updateNCCFail, "Question?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                    else
                    {
                        if (nccBus.CapNhapNCCEntities(nccDTO))
                        {
                            MessageBox.Show(mess.updateNCCSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmQuanLyNhaCungCap_Load(sender, e);
                            // ...
                            txtMaNCC.Enabled = false;
                            txtTenNCC.Enabled = false;
                            btnLuuCapNhat.Visible = false;
                            btnCapNhat.Visible = true;
                            //...
                            txtMaNCC.ResetText();
                            txtTenNCC.ResetText();
                        }
                        else
                        {
                            MessageBox.Show(mess.updateNCCFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(mess.UnknownExceptionError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void frmQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvDanhSachNCC.AutoGenerateColumns = false;
            dgvDanhSachNCC.DataSource = nccBus.layDSNCCBus();
            lst= nccBus.layDSNCCBus();
        }

        private void dgvDanhSachNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvDanhSachNCC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDanhSachNCC.CurrentRow.Selected = true;
                txtMaNCC.Text = dgvDanhSachNCC.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNCC.Text = dgvDanhSachNCC.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(mess.deleteNCCQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // ...
            try
            {
                NhaCungCapDTO nccDTO = new NhaCungCapDTO();
                nccDTO.MaNCC = txtMaNCC.Text;
                nccDTO.TenNCC = txtTenNCC.Text;
                if (result == DialogResult.Yes)
                {
                    foreach (NhaCungCapDTO item in lst)
                    {
                        if(item.MaNCC==txtMaNCC.Text)
                        {
                            if (string.IsNullOrEmpty(txtMaNCC.Text))
                            {
                                MessageBox.Show(mess.emptyMaNCCInput, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else if (nccBus.XoaNCCEntities(nccDTO))
                            {
                                MessageBox.Show(mess.deleteNCCSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmQuanLyNhaCungCap_Load(sender, e);
                                txtMaNCC.ResetText();
                                txtTenNCC.ResetText();
                            }
                            else
                            {
                                MessageBox.Show(mess.deleteNCCFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }    
                    }
                    MessageBox.Show(mess.nccCodeNotExsit, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(mess.UnknownExceptionError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void btnThemNCCMoi_Click(object sender, EventArgs e)
        {
            //...
            btnThemNCCMoi.Visible = false;
            btnThem.Visible = true;
            //phat sinh ma
            long stt = nccBus.demSoLuongNCC() + 1;
            string maNCC = "NCC" + stt;
            txtMaNCC.Text = maNCC;
            //...
            txtTenNCC.Enabled = true;
            txtTenNCC.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panelThongTinKhac.Enabled = true;
            txtTenNCC.Enabled = false;
            // ...
            btnThemNCCMoi.Visible = false;
            btnThem.Visible = true;
            //...
            var result = MessageBox.Show(mess.addNCCQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // ...
            try
            {
                NhaCungCapDTO nccDTO = new NhaCungCapDTO(txtMaNCC.Text, txtTenNCC.Text, true);

                if (result == DialogResult.Yes)
                {
                    foreach (NhaCungCapDTO item in lst)
                    {
                        if(item.MaNCC==txtMaNCC.Text)
                        {
                            MessageBox.Show(mess.nccCodeExsit, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaNCC.ResetText();
                            txtTenNCC.ResetText();
                            btnThem.Visible = false;
                            btnThemNCCMoi.Visible = true;
                            return;
                        }
                    }
                    if (string.IsNullOrEmpty(txtTenNCC.Text))
                    {
                        MessageBox.Show(mess.addNCCFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaNCC.ResetText();
                        txtTenNCC.ResetText();
                        txtTenNCC.Enabled = false;
                        btnThemNCCMoi.Visible = true;
                        btnThem.Visible = false;
                        return;
                    }
                    else if (nccBus.ThemNhaNCCENtities(nccDTO))
                    {
                        MessageBox.Show(mess.addNCCSuccess, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyNhaCungCap_Load(sender, e);
                        // ...
                        txtMaNCC.ResetText();
                        txtTenNCC.ResetText();
                        txtTenNCC.Enabled = false;
                        btnThemNCCMoi.Visible = true;
                        btnThem.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(mess.addNCCFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtMaNCC.ResetText();
                    txtTenNCC.ResetText();
                    txtTenNCC.Enabled = false;
                    btnThemNCCMoi.Visible = true;
                    btnThem.Visible = false;
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
            string value = txtTimKiemNhanh.Text;
            dgvDanhSachNCC.DataSource = nccBus.timKiemNhanhBus(value);
        }

        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }
    }
}
