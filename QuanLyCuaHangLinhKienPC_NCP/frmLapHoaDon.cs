using BUS;
using DevExpress.Utils.DirectXPaint.Svg;
using DevExpress.XtraRichEdit.Model;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmLapHoaDon : Form
    {
        private string maNV = null;
        private string tenNV = null;
        private decimal giaBan;
        private decimal thanhTien;
        //...
        HoaDonBUS hdBUS = new HoaDonBUS();
        ChiTietHoaDonBUS cthdBUS = new ChiTietHoaDonBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        SanPhamBUS spBUS = new SanPhamBUS();
        BaoHanhBUS bhBUS = new BaoHanhBUS();
        ChiTietPhieuNhapBUS ctpnBUS = new ChiTietPhieuNhapBUS();
        SanPhamDTO sp;
        //...
        NotificationText mess = new NotificationText();
        //...
        private static List<ChiTietHoaDonDTO> lstCTHD = new List<ChiTietHoaDonDTO>();
        public frmLapHoaDon()
        {
            InitializeComponent();
        }
        public frmLapHoaDon(string maNV, string tenNV) : this()
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
        }
        public decimal TinhThanhTien(decimal giaBan, decimal soLuongMua, decimal khuyenMai)
        {
            decimal thanhTien = (giaBan - (giaBan * (khuyenMai / 100))) * soLuongMua;

            return Math.Round(thanhTien);
        }
        public decimal TinhTongThanhTien()
        {
            decimal tong = 0;
            foreach (ChiTietHoaDonDTO ct in lstCTHD)
            {
                tong += ct.ThanhTien;
            }
            return Math.Round(tong);
        }
        public string DinhDangTienVND(decimal tien)
        {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tien);
        }

        //              ███████]▄▄▄▄▄▄▄▄▃
        //         ▂▄▅█████████▅▄▃▂
        //        [███████████████████]
        //        ◥⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙◤…

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            //Phát sinh mã
            Int64 maHD = hdBUS.DemTongHDBUS() + 1;
            string phatSinhMa = "HD" + maHD;
            txtMaHD.Text = phatSinhMa;
            //...
            txtMaNV.Text = maNV;
            txtTenNhanVien.Text = tenNV;
            dtpNgayLap.EditValue = DateTime.Now;
            //Load combobox BaoHanh
            cboBaoHanh.DataSource = bhBUS.LayDSBH();
            //Load combobox SanPham
            cboDSSanPham.DataSource = spBUS.LayDSanPhamFromSanPhamTableEntities();
        }
        private void btnTaoMoiKhachHang_Click(object sender, EventArgs e)
        {
            btnTaoMoiKhachHang.Visible = false;
            btnLuuKH.Visible = true;
            txtTenKH.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDTKH.Enabled = true;
            txtSDTKH.Focus();
            //...
            txtTenKH.ResetText();
            txtDiaChi.ResetText();
            txtSDTKH.ResetText();
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            btnTaoMoiKhachHang.Visible = true;
            btnLuuKH.Visible = false;
            txtTenKH.Enabled = false;
            txtDiaChi.Enabled = false;
            //thêm KH mới vào dtb
            var result = MessageBox.Show(mess.addCustomerQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                //Phát sinh mã KH
                Int64 stt = khBUS.DemSoluongKH() + 1;
                string maKH = "KH" + stt;
                KhachHangDTO khDTO = new KhachHangDTO(maKH, txtSDTKH.Text, txtTenKH.Text, txtDiaChi.Text, true);

                if (result == DialogResult.Yes)
                {
                    if(string.IsNullOrEmpty(txtSDTKH.Text)||string.IsNullOrEmpty(txtDiaChi.Text))
                    {
                        MessageBox.Show(mess.loginInputError, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (khBUS.themKHBus(khDTO))
                        {
                            MessageBox.Show(mess.addCustomerSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // ...
                            txtTenKH.Enabled = false;
                            txtDiaChi.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show(mess.addCustomerFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataLogin.formOpacity.Hide();
            DataLogin.formQuanLy.Hide();
            DataLogin.formQuanLy.Show();
            DataLogin.formQuanLy.btnQuanLyHoaDon_Click(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSDTKH.ResetText();
            cboDSSanPham.ResetText();
            numericSoLuong.ResetText();
            numericKhuyenMai.ResetText();
            lstCTHD.Clear();
            dgvDanhSachSP.DataSource = "";
            dgvDanhSachSP.AutoGenerateColumns = false;
            dgvDanhSachSP.DataSource = lstCTHD;
            txtTongThanhTien.ResetText();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(mess.addBillQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //...
            try
            {
                if (result == DialogResult.Yes)
                {
                    if (lstCTHD.Count > 0)
                    {
                        KhachHangDTO kh = khBUS.TimKiemTheoSDT(txtSDTKH.Text);
                        HoaDonDTO hd = new HoaDonDTO(txtMaHD.Text, kh.MaKH, txtMaNV.Text, Convert.ToDateTime(dtpNgayLap.EditValue));
                        if (!string.IsNullOrEmpty(txtSDTKH.Text) && hdBUS.ThemHoaDonBUS(hd) && cthdBUS.ThemCTDH(lstCTHD))
                        {
                            //Cập nhật sại số lượng sản phẩm còn tồn trong kho sau khi bán 1 vài sp
                            foreach (ChiTietHoaDonDTO cthd in lstCTHD)
                            {
                                SanPhamDTO sp = spBUS.TimKiemSP(cthd.MaSP);
                                if (!ctpnBUS.CapNhatSoLuongSpBUS(cthd, sp.MaPhieuNhap))
                                {
                                    MessageBox.Show(mess.addBillFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            MessageBox.Show(mess.addBillSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //...
                            this.Hide();
                            DataLogin.formOpacity.Hide();
                            DataLogin.formQuanLy.Hide();
                            DataLogin.formQuanLy.Show();
                            DataLogin.formQuanLy.btnQuanLyHoaDon_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show(mess.inputBillError, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(mess.emptyBill, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(mess.UnknownExceptionError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            //...
            this.Hide();

        }

        private void btnThemVaoHoaDon_Click(object sender, EventArgs e)
        {
            if (cboDSSanPham.Text == "")
            {
                MessageBox.Show(mess.inputBillError, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (numericSoLuong.Value == 0)
                {
                    MessageBox.Show(mess.productNumberIsEmpty, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            foreach (ChiTietHoaDonDTO ct in lstCTHD)
            {
                if (cboDSSanPham.Text == ct.MaSP)
                {
                    ct.SoLuongMua += (int)numericSoLuong.Value;
                    ct.ThanhTien += this.thanhTien;
                    //...
                    dgvDanhSachSP.DataSource = "";
                    dgvDanhSachSP.AutoGenerateColumns = false;
                    dgvDanhSachSP.DataSource = lstCTHD;
                    txtTongThanhTien.Text = DinhDangTienVND(TinhTongThanhTien());
                    return;
                }
            }
            ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO();
            cthd.MaHD = txtMaHD.Text;
            cthd.MaSP = cboDSSanPham.Text;
            cthd.TenSP = txtTenSP.Text;
            cthd.GiaBan = this.giaBan;
            cthd.SoLuongMua = Convert.ToInt32(numericSoLuong.Value);
            cthd.KhuyenMai = Convert.ToInt32(numericKhuyenMai.Value);
            cthd.MaBH = cboBaoHanh.SelectedValue.ToString();
            cthd.ThanhTien = this.thanhTien;
            lstCTHD.Add(cthd);

            //...
            cboDSSanPham.ResetText();
            txtThanhTien.ResetText();
            //...
            dgvDanhSachSP.DataSource = "";
            dgvDanhSachSP.AutoGenerateColumns = false;
            dgvDanhSachSP.DataSource = lstCTHD;
            txtTongThanhTien.Text = DinhDangTienVND(TinhTongThanhTien());
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void txtSDTKH_OnValueChanged(object sender, EventArgs e)
        {
            KhachHangDTO kh = khBUS.TimKiemTheoSDT(txtSDTKH.Text);
            txtTenKH.Text = kh.HoTenKH;
            txtDiaChi.Text = kh.DiaChi;
        }

        private void numericSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            decimal soLuong = numericSoLuong.Value;
            decimal khuyenMai = Convert.ToDecimal(numericKhuyenMai.Value);
            this.thanhTien = TinhThanhTien(this.giaBan, soLuong, khuyenMai);
            //...
            if (numericSoLuong.Value > sp.SoLuongTon)
            {
                MessageBox.Show(mess.numberOfProductExceededTheLimit, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericSoLuong.Value = sp.SoLuongTon;
                return;
            }
            //...
            if (numericSoLuong.Value < 0)
            {
                MessageBox.Show(mess.inputValueInvalid, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericSoLuong.Value = 0;
                return;
            }
            //...
            txtThanhTien.Text = DinhDangTienVND(Math.Round(this.thanhTien));
        }

        private void numericKhuyenMai_EditValueChanged(object sender, EventArgs e)
        {
            decimal soLuong = numericSoLuong.Value;
            decimal khuyenMai = Convert.ToDecimal(numericKhuyenMai.Value);
            this.thanhTien = TinhThanhTien(this.giaBan, soLuong, khuyenMai);
            //...
            if (numericKhuyenMai.Value > 100)
            {
                MessageBox.Show(mess.numberOfSaleExceededTheLimit, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericKhuyenMai.Value = 100;
                return;
            }
            //...
            if (numericKhuyenMai.Value < 0)
            {
                MessageBox.Show(mess.inputValueInvalid, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericKhuyenMai.Value = 0;
                return;
            }
            txtThanhTien.Text = DinhDangTienVND(Math.Round(this.thanhTien));
        }

        private void txtGiaBan_OnValueChanged(object sender, EventArgs e)
        {
            decimal soLuong = numericSoLuong.Value;
            decimal khuyenMai = Convert.ToDecimal(numericKhuyenMai.Value);
            this.thanhTien = TinhThanhTien(this.giaBan, soLuong, khuyenMai);

            txtThanhTien.Text = DinhDangTienVND(Math.Round(this.thanhTien));
        }
        //Xóa SP khỏi ds cthd
        private void dgvDanhSachSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var result = MessageBox.Show(mess.deleteBillQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //...
            try
            {
                if (result == DialogResult.Yes)
                {
                    string maSP = null;
                    if (dgvDanhSachSP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dgvDanhSachSP.CurrentRow.Selected = true;
                        maSP = dgvDanhSachSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                    }
                    //tìm kiếm vị trí của sp trong list
                    var index = lstCTHD.FindIndex(ct => ct.MaSP == maSP);
                    //xóa nó đi 
                    lstCTHD.RemoveAt(index);
                    //load lại datagridview
                    dgvDanhSachSP.DataSource = "";
                    dgvDanhSachSP.AutoGenerateColumns = false;
                    dgvDanhSachSP.DataSource = lstCTHD;
                    txtTongThanhTien.Text = DinhDangTienVND(TinhTongThanhTien());
                    return;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(mess.UnknownExceptionError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cboDSSanPham_TextChanged(object sender, EventArgs e)
        {
            decimal soLuong = numericSoLuong.Value;
            decimal khuyenMai = Convert.ToDecimal(numericKhuyenMai.Value);
            //...
            sp = spBUS.TimKiemSP(cboDSSanPham.Text);
            txtTenSP.Text = sp.TenSP;
            this.giaBan = sp.GiaBan;
            txtGiaBan.Text = DinhDangTienVND(sp.GiaBan);
            this.thanhTien = TinhThanhTien(this.giaBan, soLuong, khuyenMai);

            txtThanhTien.Text = DinhDangTienVND(Math.Round(this.thanhTien));
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }
    }
    
}
