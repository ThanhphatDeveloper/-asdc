using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using DevExpress.DataProcessing;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmQuanLyNhanVien : Form
    {
        NhanVienBUS nvBus = new NhanVienBUS();
        ChucVuBUS cvBus = new ChucVuBUS();
        TaiKhoanBUS tkBus = new TaiKhoanBUS();
        private string dir = "../../Images/";
        NotificationText mess = new NotificationText();
        List<NhanVienDTO> lst;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvDanhSachNV.AutoGenerateColumns = false;
            dgvDanhSachNV.DataSource = nvBus.LayDSNVBUS();
            cboChucVu.DataSource = cvBus.layDSCVBus();
            //...
            btnDoiMK.Visible = false;
            btnLuu.Visible = false;
            //..
            lst= nvBus.LayDSNVBUS();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //...
            panelTTNVContent.Enabled = true;
            btnCapNhat.Visible = false;
            btnLuuCapNhat.Visible = true;
            foreach (NhanVienDTO nv in nvBus.LayDSNVBUS())
            {
                if (nv.MaNV == txtMaNV.Text)
                {
                    if (string.IsNullOrEmpty(nv.Anh))
                    {
                        picNV.Image = null;
                        btnChinhSuaAnh.Visible = true;
                    }
                }
            }
            cboChucVu.Enabled = true;
            txtHoTen.Focus();
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            //panelTTNVContent.Enabled = false;
            //btnLuuCapNhat.Visible = false;
            //btnCapNhat.Visible = true;
            //cboChucVu.Enabled = false;
            var result = MessageBox.Show(mess.updateStaffQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                string anh;
                if (picNV.Image != null)
                {
                    anh = txtMaNV.Text + ".jpg";
                }
                else
                {
                    anh = "";
                }
                NhanVienDTO nvDTO = new NhanVienDTO(txtMaNV.Text, cboChucVu.SelectedValue.ToString(), txtHoTen.Text, radNam.Checked ? "Nam" : "Nữ", Convert.ToDateTime(dtpNgaySinh.EditValue), txtSDT.Text, txtDiaChi.Text, anh);
                if (result == DialogResult.Yes)
                {
                    if (nvBus.CapNhatNVBus(nvDTO))
                    {
                        if (picNV.Image != null)
                        {
                            TaiAnhVeFolderImages();
                        }
                        MessageBox.Show(mess.updateStaffSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyNhanVien_Load(sender, e);
                        // ...
                        panelTTNVContent.Enabled = false;
                        btnCapNhat.Visible = true;
                        btnLuuCapNhat.Visible = false;
                        btnChinhSuaAnh.Visible = false;
                        cboChucVu.Enabled = false;
                        ChucVuDTO cv = cvBus.TimKiemTheoMa(nvDTO.MaChucVu);
                        cboChucVu.Text = cv.tenChucVu;
                    }
                    else
                    {
                        MessageBox.Show(mess.updateStaffFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(mess.UnknownExceptionError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void btnCapNhatTTK_Click(object sender, EventArgs e)
        {
            panelDoiMK.Enabled = true;
            //
            btnDoiMK.Visible = false;
            btnLuu.Visible = true;
            //
            txtMatKhauMoi.Focus();
        }

        private void btnLuuCapNhatTTK_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNV = txtMaNV.Text;
            //...
            panelDoiMK.Enabled = false;
            //...
            btnDoiMK.Visible = true;
            btnLuu.Visible = false;
            cboChucVu.Enabled = false;
            txtTenTaiKhoan.Enabled = false;
            txtMatKhau.Enabled = false;
            //Xử lý cập nhật MK cho TK
            string maHoaMK = MaHoaMatKhau.Encrypt(txtMatKhauMoi.Text);
            if (tkBus.CapNhatTK(txtTenTaiKhoan.Text, maHoaMK))
            {
                MessageBox.Show(mess.changePasswordSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhauMoi.ResetText();
            }
            else
            {
                MessageBox.Show(mess.changePasswordFail, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauMoi.ResetText();
            }
        }

        private void btnThemNVMoi_Click(object sender, EventArgs e)
        {
            //Mã NV tự phát sinh
            btnThemNVMoi.Visible = false;
            btnThem.Visible = true;
            btnChinhSuaAnh.Visible = true;
            //phat sinh ma
            Int64 stt = nvBus.DemSoLuongNV() + 1;
            string maNV = "NV" + stt;
            txtMaNV.Text = maNV;
            //Reset text
            txtHoTen.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            //...
            panelTTNVContent.Enabled = true;
            btnThemNVMoi.Visible = false;
            btnThem.Visible = true;
            cboChucVu.Enabled = true;
            picNV.Image = null;
            txtHoTen.Focus();
        }

        public void TaiAnhVeFolderImages()
        {
            try
            {
                string fileName = txtMaNV.Text + ".jpg";
                string sourcePath = picNV.ImageLocation;
                string targetPath = @"..\..\Images";
                //Combine file và đường dẫn
                string sourceFile = System.IO.Path.Combine(sourcePath);
                string destFile = System.IO.Path.Combine(targetPath, fileName);
                //Copy file từ file nguồn đến file đích
                System.IO.Directory.CreateDirectory(targetPath);
                System.IO.File.Copy(sourceFile, destFile, true);
                picNV.Image = Image.FromFile(dir + txtMaNV.Text + ".jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show(mess.UnknownExceptionError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(mess.addStaffQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // ...
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show(mess.emptyInput, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //...
            try
            {
                string anh;
                if (picNV.Image != null)
                {
                    anh = txtMaNV.Text + ".jpg";
                }
                else
                {
                    anh = "";
                }
                NhanVienDTO nvDTO = new NhanVienDTO(txtMaNV.Text, cboChucVu.SelectedValue.ToString(), txtHoTen.Text, radNam.Checked ? "Nam" : "Nữ", Convert.ToDateTime(dtpNgaySinh.EditValue.ToString()), txtSDT.Text, txtDiaChi.Text, anh);
                if (result == DialogResult.Yes)
                {
                    foreach (NhanVienDTO item in lst)
                    {
                        if (item.MaNV == txtMaNV.Text)
                        {
                            MessageBox.Show(mess.staffCodeIsExsit, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //...
                            txtMaNV.ResetText();
                            cboChucVu.Enabled = true;
                            txtHoTen.ResetText();
                            radNam.Enabled = true;
                            radNu.Enabled = true;
                            dtpNgaySinh.Enabled = true;
                            txtSDT.ResetText();
                            txtDiaChi.ResetText();
                            btnThemNVMoi.Visible = true;
                            btnThem.Visible = false;
                            picNV.Image = null;
                            //...
                            panelTTNVContent.Enabled = false;
                            btnChinhSuaAnh.Visible = false;
                            return;
                        }
                    }
                    if (nvBus.ThemNVBus(nvDTO))
                    {
                        if (picNV.Image != null)
                        {
                            TaiAnhVeFolderImages();
                        }
                        MessageBox.Show(mess.addStaffSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyNhanVien_Load(sender, e);
                        //...
                        txtMaNV.ResetText();
                        cboChucVu.Enabled = true;
                        txtHoTen.ResetText();
                        radNam.Enabled = true;
                        radNu.Enabled = true;
                        dtpNgaySinh.Enabled = true;
                        txtSDT.ResetText();
                        txtDiaChi.ResetText();
                        btnThemNVMoi.Visible = true;
                        btnThem.Visible = false;
                        picNV.Image = null;
                        //...
                        panelTTNVContent.Enabled = false;
                        btnChinhSuaAnh.Visible = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show(mess.addStafFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    txtMaNV.ResetText();
                    cboChucVu.Enabled = true;
                    txtHoTen.ResetText();
                    radNam.Enabled = true;
                    radNu.Enabled = true;
                    dtpNgaySinh.Enabled = true;
                    txtSDT.ResetText();
                    txtDiaChi.ResetText();
                    btnThemNVMoi.Visible = true;
                    btnThem.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(mess.UnknownExceptionError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void dgvDanhSachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvDanhSachNV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDanhSachNV.CurrentRow.Selected = true;
                txtMaNV.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboChucVu.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinh.EditValue = dgvDanhSachNV.Rows[e.RowIndex].Cells[3].Value;
                if (dgvDanhSachNV.Rows[e.RowIndex].Cells[4].Value.ToString() == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                txtSDT.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChi.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[6].Value.ToString();
                //Tìm kiếm tài khoản của nv
                txtTenTaiKhoan.ResetText();
                txtMatKhau.ResetText();
                NhanVienDTO nvTmp = new NhanVienDTO();
                nvTmp.MaNV = txtMaNV.Text;
                TaiKhoanDTO tk = tkBus.TimKiemTK(nvTmp);
                txtTenTaiKhoan.Text = tk.TenTaiKhoan;
                txtMatKhau.Text = tk.MatKhau;
                //Bật tắt button
                if (string.IsNullOrEmpty(txtTenTaiKhoan.Text))
                {
                    btnDoiMK.Visible = false;
                    btnLuu.Visible = false;
                }
                else
                {
                    btnDoiMK.Visible = true;
                    btnLuu.Visible = false;
                }
                //...
                foreach (NhanVienDTO nv in nvBus.LayDSNVBUS())
                {
                    if (nv.MaNV == txtMaNV.Text)
                    {
                        if (string.IsNullOrEmpty(nv.Anh))
                        {
                            picNV.Image = null;
                            return;
                        }
                    }
                }
                picNV.Image = Image.FromFile(dir + txtMaNV.Text + ".jpg");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(mess.deleteStaffQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                string anh;
                if (picNV.Image != null)
                {
                    anh = txtMaNV.Text + ".jpg";
                }
                else
                {
                    anh = "";
                }
                NhanVienDTO nvDTO = new NhanVienDTO(txtMaNV.Text, cboChucVu.SelectedValue.ToString(), txtHoTen.Text, radNam.Checked ? "Nam" : "Nữ", Convert.ToDateTime(dtpNgaySinh.EditValue.ToString()), txtSDT.Text, txtDiaChi.Text, anh);
                if (result == DialogResult.Yes)
                {
                    if (nvBus.XoaNVBus(nvDTO))
                    {
                        tkBus.XoaTKBUS(nvDTO);
                        MessageBox.Show(mess.deleteStaffSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyNhanVien_Load(sender, e);
                        //...
                        txtMaNV.ResetText();
                        cboChucVu.Enabled = true;
                        txtHoTen.ResetText();
                        radNam.Enabled = true;
                        radNu.Enabled = true;
                        dtpNgaySinh.Enabled = true;
                        txtSDT.ResetText();
                        txtDiaChi.ResetText();
                        txtTenTaiKhoan.ResetText();
                        txtMatKhau.ResetText();
                        btnThemNVMoi.Visible = true;
                        btnThem.Visible = false;
                        picNV.Image = null;
                    }
                    else
                    {
                        MessageBox.Show(mess.deleteStaffFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtMaNV.ResetText();
                    cboChucVu.Enabled = true;
                    txtHoTen.ResetText();
                    radNam.Enabled = true;
                    radNu.Enabled = true;
                    dtpNgaySinh.Enabled = true;
                    txtSDT.ResetText();
                    txtDiaChi.ResetText();
                    btnThemNVMoi.Visible = true;
                    btnThem.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(mess.UnknownExceptionError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }

        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {

        }

        private void btnChinhSuaAnh_Click(object sender, EventArgs e)
        {
            string imageLocation = null;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = @"..\..\Images\";
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    picNV.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(mess.fileIsNotVaild, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }

        private void txtTimKiemNhanh_OnValueChanged(object sender, EventArgs e)
        {
            dgvDanhSachNV.AutoGenerateColumns = false;
            dgvDanhSachNV.DataSource = nvBus.LayDSNVTheoKeyworkDAO(txtTimKiemNhanh.Text);
        }
    }
}
