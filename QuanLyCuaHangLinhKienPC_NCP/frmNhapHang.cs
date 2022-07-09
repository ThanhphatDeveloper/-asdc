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
using DevExpress.XtraScheduler.Drawing;
using System.Data.SqlClient;
using System.Globalization;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmNhapHang : Form
    {
        private string maNV = null;
        private string tenNV = null;
        private decimal thanhTien;
        private decimal giaGoc;
        PhieuNhapBUS pnBUS = new PhieuNhapBUS();
        NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        SanPhamBUS spBUS = new SanPhamBUS();
        LoaiSanPhamBUS lSP = new LoaiSanPhamBUS();
        ChiTietPhieuNhapBUS ctpnBUS = new ChiTietPhieuNhapBUS();
        SanPhamDTO sp;
        //..
        List<LoaiSanPhamDTO> lstlSP;
        List<NhaCungCapDTO> lstNCC;
        //...
        NotificationText mess = new NotificationText();
        //..
        List<ChiTietPhieuNhapDTO> list = new List<ChiTietPhieuNhapDTO>();
        public frmNhapHang(string maNV, string tenNV) : this()
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
        }
        public decimal TinhThanhTien(decimal giaGoc, decimal soLuongNhap)
        {
            decimal thanhTien = giaGoc * soLuongNhap;
            return Math.Round(thanhTien);
        }
        public decimal TinhTongThanhTien()
        {
            decimal tong = 0;
            foreach (ChiTietPhieuNhapDTO ct in list)
            {
                tong += ct.ThanhTien;
            }
            return Math.Round(tong);
        }
        public string DinhDangTienVND(decimal tien)
        {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tien);
        }
        public void LoadNCC()
        {
            cboNhaCungCapOfTTPN.DataSource = nccBUS.layDSNCCBus();
            lstNCC= nccBUS.layDSNCCBus();
        }
        public void LoadLoaiSP()
        {
            cboLoai.DataSource = lSP.LoadLoaiSP();
            lstlSP= lSP.LoadLoaiSP();
        }
        public frmNhapHang()
        {
            InitializeComponent();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataLogin.formOpacity.Hide();
            DataLogin.formQuanLy.Hide();
            DataLogin.formQuanLy.Show();
            DataLogin.formQuanLy.btnQuanLyPhieuNhap_Click(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericSoLuongNhapOfTTPN.Value == 0)
                {
                    MessageBox.Show(mess.emptyNumberOfProduct, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if(string.IsNullOrEmpty(txtMaSP.Text)|| string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(cboLoai.Text) || string.IsNullOrEmpty(txtGiaGoc.Text) || string.IsNullOrEmpty(txtXuatXu.Text) || string.IsNullOrEmpty(cboNhaCungCapOfTTPN.Text) || string.IsNullOrEmpty(txtThanhTien.Text))
                    {
                        MessageBox.Show(mess.emptyInputOfFormNhapHang, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //...
                    foreach (LoaiSanPhamDTO loai in lstlSP)
                    {
                        if (loai.MaLoai == cboLoai.Text)
                        {
                            foreach(NhaCungCapDTO ncc in lstNCC)
                            {
                                if (ncc.MaNCC == cboNhaCungCapOfTTPN.Text)
                                {
                                    SanPhamDTO spDTO = new SanPhamDTO();
                                    spDTO.MaSP = txtMaSP.Text;
                                    spDTO.TenSP = txtTenSP.Text;
                                    spDTO.MaLoai = cboLoai.SelectedValue.ToString();
                                    spDTO.XuaXu = txtXuatXu.Text;
                                    if (spBUS.ThemSanPham(spDTO))
                                    {
                                        MessageBox.Show(mess.addProductSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        btnCapNhat.Visible = true;
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show(mess.addProductFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }
                            }
                        }
                        MessageBox.Show(mess.typeNotExsit, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboLoai.ResetText();
                        return;
                    }
                }

                foreach (ChiTietPhieuNhapDTO ct in list)
                {
                    if (txtMaSP.Text == ct.MaSP)
                    {
                        ct.SoLuongNhap += (int)numericSoLuongNhapOfTTPN.Value;
                        ct.ThanhTien += this.thanhTien;
                        dgvDanhSachPhieuNhap.DataSource = "";
                        dgvDanhSachPhieuNhap.AutoGenerateColumns = false;
                        dgvDanhSachPhieuNhap.DataSource = list;
                        txtTongTienThanhToan.Text = DinhDangTienVND(TinhTongThanhTien());
                        //..
                        btnThem.Visible = false;
                        btnThemSanPham.Visible = true;
                        //..
                        txtTenSP.ResetText();
                        cboLoai.ResetText();
                        txtGiaGoc.ResetText();
                        txtXuatXu.ResetText();
                        cboLoai.ResetText();
                        txtMaSP.ResetText();
                        txtThanhTien.ResetText();
                        numericSoLuongNhapOfTTPN.Value = 0;

                        //..
                        txtTenSP.Enabled = false;
                        cboLoai.Enabled = false;
                        txtGiaGoc.Enabled = false;
                        txtXuatXu.Enabled = false;
                        cboNhaCungCapOfTTPN.Enabled = false;
                        numericSoLuongNhapOfTTPN.Enabled = false;
                        return;
                    }
                }
                //...
                ChiTietPhieuNhapDTO ctPN = new ChiTietPhieuNhapDTO();
                ctPN.MaPhieu = txtMaPhieu.Text;
                ctPN.MaSP = txtMaSP.Text;
                ctPN.TenSanPham = txtTenSP.Text;
                ctPN.GiaGoc = Convert.ToDecimal(txtGiaGoc.Text);
                this.giaGoc = Convert.ToDecimal(txtGiaGoc.Text);
                ctPN.SoLuongNhap = Convert.ToInt32(numericSoLuongNhapOfTTPN.Text);
                ctPN.SoLuongTon = Convert.ToInt32(numericSoLuongNhapOfTTPN.Text);
                ctPN.MaNCC = cboNhaCungCapOfTTPN.SelectedValue.ToString();
                ctPN.ThanhTien = this.thanhTien;
                list.Add(ctPN);

                //...
                dgvDanhSachPhieuNhap.DataSource = "";
                dgvDanhSachPhieuNhap.AutoGenerateColumns = false;
                dgvDanhSachPhieuNhap.DataSource = list;
                txtTongTienThanhToan.Text = DinhDangTienVND(TinhTongThanhTien());

                //..
                btnThem.Visible = false;
                btnThemSanPham.Visible = true;
                //..
                txtTenSP.ResetText();
                cboLoai.ResetText();
                txtGiaGoc.ResetText();
                txtXuatXu.ResetText();
                cboLoai.ResetText();
                txtMaSP.ResetText();
                txtThanhTien.ResetText();
                numericSoLuongNhapOfTTPN.Value = 0;

                //..
                txtTenSP.Enabled = false;
                cboLoai.Enabled = false;
                txtGiaGoc.Enabled = false;
                txtXuatXu.Enabled = false;
                cboNhaCungCapOfTTPN.Enabled = false;
                numericSoLuongNhapOfTTPN.Enabled = false;
            }
            catch
            {
                MessageBox.Show(mess.emptyBill, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(mess.createImportCouponQuestion, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                //panel thông tin sản phẩm
                txtMaSP.Enabled = false;
                txtTenSP.Enabled = false;
                cboLoai.Enabled = false;
                txtGiaGoc.Enabled = true;

                txtXuatXu.Enabled = false;

                txtMaSP.Focus();

                //panel thông tin phiếu nhập
                txtMaPhieu.Enabled = false;
                dtpNgayNhapOfTTPN.Enabled = false;
                cboNhaCungCapOfTTPN.Enabled = false;
                numericSoLuongNhapOfTTPN.Enabled = false;
                txtTenNhanVien.Enabled = false;
                //...
                btnTaoPhieu.Visible = false;
                btnHuyPhieu.Visible = true;
                txtMaSP.Focus();
                //...
                btnThemSanPham.Visible = true;
                btnLuuCapNhat.Visible = false;
                btnCapNhat.Visible = true;
                //...


            }
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(mess.cancelImportCouponQuestion, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //panel thông tin sản phẩm
                txtMaSP.Enabled = false;
                txtTenSP.Enabled = false;
                cboLoai.Enabled = false;
                txtGiaGoc.Enabled = false;
                txtXuatXu.Enabled = false;
                //panel thông tin phiếu nhập
                txtMaPhieu.Enabled = true;
                dtpNgayNhapOfTTPN.Enabled = true;
                cboNhaCungCapOfTTPN.Enabled = true;
                numericSoLuongNhapOfTTPN.Enabled = true;
                txtTenNhanVien.Enabled = true;
                //...
                btnTaoPhieu.Visible = true;
                btnHuyPhieu.Visible = false;
                txtMaPhieu.Focus();
                //...
                btnThem.Visible = false;
                btnLuuCapNhat.Visible = false;
                btnCapNhat.Visible = false;
                btnThemSanPham.Visible = false;
                //hủy phiếu các trường ở sản phẩm được reset
                txtMaSP.ResetText();
                txtTenSP.ResetText();
                cboLoai.ResetText();
                txtGiaGoc.ResetText();
                txtXuatXu.ResetText();
                cboNhaCungCapOfTTPN.ResetText();
                numericSoLuongNhapOfTTPN.ResetText();
                txtThanhTien.ResetText();
                //. reset lại Datagridview ChitietNhapHang
                dgvDanhSachPhieuNhap.DataSource = "";
                //..
                btnTimKiemSanPham.Visible = false;

            }
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(mess.addProductQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (result == DialogResult.Yes)
                {

                    if (numericSoLuongNhapOfTTPN.Value == 0)
                    {
                        MessageBox.Show(mess.emptyNumberOfProduct, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    foreach (ChiTietPhieuNhapDTO ct in list)
                    {
                        if (txtMaSP.Text == ct.MaSP)
                        {
                            ct.SoLuongNhap += (int)numericSoLuongNhapOfTTPN.Value;
                            ct.ThanhTien += this.thanhTien;
                            dgvDanhSachPhieuNhap.DataSource = "";
                            dgvDanhSachPhieuNhap.AutoGenerateColumns = false;
                            dgvDanhSachPhieuNhap.DataSource = list;
                            txtTongTienThanhToan.Text = DinhDangTienVND(TinhTongThanhTien());
                            //..
                            btnLuuCapNhat.Visible = false;
                            btnCapNhat.Visible = true;
                            //..
                            txtTenSP.ResetText();
                            cboLoai.ResetText();
                            txtGiaGoc.ResetText();
                            txtXuatXu.ResetText();
                            cboLoai.ResetText();
                            txtMaSP.ResetText();
                            txtThanhTien.ResetText();
                            numericSoLuongNhapOfTTPN.Value = 0;

                            //..
                            txtMaSP.Enabled = false;
                            txtTenSP.Enabled = false;
                            cboLoai.Enabled = false;
                            txtGiaGoc.Enabled = false;
                            txtXuatXu.Enabled = false;
                            cboNhaCungCapOfTTPN.Enabled = false;
                            numericSoLuongNhapOfTTPN.Enabled = false;
                            return;
                        }
                        btnThemSanPham.Visible = true;
                    }
                    //...
                    if (string.IsNullOrEmpty(txtTenSP.Text))
                    {
                        MessageBox.Show(mess.nccCodeNotExsit, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaSP.ResetText();
                        txtGiaGoc.ResetText();
                        numericSoLuongNhapOfTTPN.ResetText();
                        txtMaSP.Focus();
                        return;
                    }
                    else
                    {
                        ChiTietPhieuNhapDTO ctPN = new ChiTietPhieuNhapDTO();
                        ctPN.MaPhieu = txtMaPhieu.Text;
                        ctPN.MaSP = txtMaSP.Text;
                        ctPN.TenSanPham = txtTenSP.Text;
                        ctPN.GiaGoc = this.giaGoc;
                        ctPN.SoLuongNhap = Convert.ToInt32(numericSoLuongNhapOfTTPN.Value);
                        ctPN.SoLuongTon = Convert.ToInt32(numericSoLuongNhapOfTTPN.Value);
                        ctPN.MaNCC = cboNhaCungCapOfTTPN.SelectedValue.ToString();
                        ctPN.ThanhTien = this.thanhTien;
                        list.Add(ctPN);
                    }

                    //...
                    dgvDanhSachPhieuNhap.DataSource = "";
                    dgvDanhSachPhieuNhap.AutoGenerateColumns = false;
                    dgvDanhSachPhieuNhap.DataSource = list;
                    txtTongTienThanhToan.Text = DinhDangTienVND(TinhTongThanhTien());

                    //..
                    btnLuuCapNhat.Visible = false;
                    btnCapNhat.Visible = true;
                    //..
                    txtTenSP.ResetText();
                    cboLoai.ResetText();
                    txtGiaGoc.ResetText();
                    txtXuatXu.ResetText();
                    cboLoai.ResetText();
                    txtMaSP.ResetText();
                    txtThanhTien.ResetText();
                    numericSoLuongNhapOfTTPN.Value = 0;

                    //..
                    txtMaSP.Enabled = false;
                    txtTenSP.Enabled = false;
                    cboLoai.Enabled = false;
                    txtGiaGoc.Enabled = false;
                    txtXuatXu.Enabled = false;
                    cboNhaCungCapOfTTPN.Enabled = false;
                    numericSoLuongNhapOfTTPN.Enabled = false;
                    //...
                    btnThemSanPham.Visible = true;
                    btnTimKiemSanPham.Visible = false;
                    
                }
                else
                {
                    return;
                }
            }

        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtMaSP.Enabled = true;
            txtTenSP.Enabled = false;
            cboLoai.Enabled = false;
            txtXuatXu.Enabled = false;
            txtGiaGoc.Enabled = true;
            numericSoLuongNhapOfTTPN.Enabled = true;
            //..
            btnCapNhat.Visible = false;
            btnLuuCapNhat.Visible = true;
            txtMaSP.Focus();
            btnThemSanPham.Visible = false;
            //..
            btnTimKiemSanPham.Visible = true;
           
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show(mess.addImportCouponQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //..
            //try
            //{
            if (result == DialogResult.Yes)
            {
                if (list.Count > 0)
                {
                    PhieuNhapDTO pn = new PhieuNhapDTO(txtMaPhieu.Text, txtMaNV.Text, Convert.ToDateTime(dtpNgayNhapOfTTPN.EditValue));

                    if (pnBUS.ThemPhieuNhap(pn) && ctpnBUS.ThemCTPN(list))
                    {
                        MessageBox.Show(mess.addImportCouponSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        DataLogin.formOpacity.Hide();
                        DataLogin.formQuanLy.Hide();
                        DataLogin.formQuanLy.Show();
                        DataLogin.formQuanLy.btnQuanLyPhieuNhap_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(mess.emptyInputOfFormNhapHang, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show(mess.emptyImportCoupon, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                return;
            }
            this.Hide();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {

            //...
            txtMaPhieu.Text = this.generatePNId();

            txtMaNV.Text = maNV;
            txtTenNhanVien.Text = tenNV;
            dtpNgayNhapOfTTPN.EditValue = DateTime.Now;
            LoadNCC();
            LoadLoaiSP();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            btnThem.Visible = true;
            btnThemSanPham.Visible = false;
            Int64 maSP = spBUS.PhatSinhMaSP() + 1;
            string phatSinhMa = "SP" + maSP;
            txtMaSP.Text = phatSinhMa;
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = true;
            cboLoai.Enabled = true;
            txtXuatXu.Enabled = true;
            txtGiaGoc.Enabled = true;
            cboNhaCungCapOfTTPN.Enabled = true;
            numericSoLuongNhapOfTTPN.Enabled = true;
            txtTenSP.Focus();
            btnCapNhat.Visible = false;

        }

        private void numericSoLuongNhapOfTTPN_EditValueChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtGiaGoc.Text))
            {
                this.giaGoc = 0;
            }
            else
            {
                if (sp.GiaGoc == 0 && !string.IsNullOrEmpty(txtGiaGoc.Text))
                {
                    this.giaGoc = Convert.ToDecimal(txtGiaGoc.Text);
                }
                else
                {
                    this.giaGoc = sp.GiaGoc;
                }
                decimal soLuong = numericSoLuongNhapOfTTPN.Value;
                this.thanhTien = TinhThanhTien(this.giaGoc, soLuong);
                txtThanhTien.Text = DinhDangTienVND(Math.Round(this.thanhTien));
            }

        }


        private void txtGiaGoc_OnValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                this.giaGoc = 0;
                decimal soLuong = numericSoLuongNhapOfTTPN.Value;
                this.thanhTien = TinhThanhTien(this.giaGoc, soLuong);
                txtThanhTien.Text = DinhDangTienVND(Math.Round(this.thanhTien));
            }
            else
            {

                decimal soLuong = numericSoLuongNhapOfTTPN.Value;
                if (sp.GiaGoc == 0 && !string.IsNullOrEmpty(txtGiaGoc.Text))
                {
                    this.giaGoc = Convert.ToDecimal(txtGiaGoc.Text);
                }
                else
                {
                    this.giaGoc = sp.GiaGoc;
                }
                this.thanhTien = TinhThanhTien(this.giaGoc, soLuong);
                txtThanhTien.Text = DinhDangTienVND(Math.Round(this.thanhTien));
            }
        }

        public string generatePNId()
        {
            //get max id in DB

            string ID = pnBUS.PhatSinhMa();//VD=PN2
            //Create new id
            if (ID == "")
            {
                ID = "PN0";
            }
            int Ma = Convert.ToInt32(ID.Substring(2));
            string MaPhatSinh = "PN" + (Ma + 1);
            txtMaPhieu.Text = MaPhatSinh;
            //Return new id
            return MaPhatSinh;
        }

        private void txtGiaGoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtMaSP_OnValueChanged(object sender, EventArgs e)
        {
            decimal soLuongnhap = numericSoLuongNhapOfTTPN.Value;
            sp = spBUS.TimKiemSanPhamPN(txtMaSP.Text);
            txtTenSP.Text = sp.TenSP;
            this.giaGoc = sp.GiaGoc;
            cboLoai.Text = sp.TenLoai;
            txtXuatXu.Text = sp.XuaXu;
            cboNhaCungCapOfTTPN.Text = sp.TenNCC;
            //..
            txtGiaGoc.Text = DinhDangTienVND(sp.GiaGoc);
            this.thanhTien = TinhThanhTien(this.giaGoc, soLuongnhap);
            txtThanhTien.Text = DinhDangTienVND(Math.Round(this.thanhTien));
        }

        private void dgvDanhSachPhieuNhap_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var result = MessageBox.Show(mess.deleteProductFromImportCouponQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //...
            try
            {
                if (result == DialogResult.Yes)
                {
                    string maPN = null;
                    if (dgvDanhSachPhieuNhap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dgvDanhSachPhieuNhap.CurrentRow.Selected = true;
                        maPN = dgvDanhSachPhieuNhap.Rows[e.RowIndex].Cells[0].Value.ToString();
                    }
                    //tìm kiếm vị trí của phiếu nhập trong list
                    var index = list.FindIndex(ct => ct.MaPhieu == maPN);
                    //xóa nó đi 
                    list.RemoveAt(index);
                    //load lại datagridview
                    dgvDanhSachPhieuNhap.DataSource = "";
                    dgvDanhSachPhieuNhap.AutoGenerateColumns = false;
                    dgvDanhSachPhieuNhap.DataSource = list;
                    dgvDanhSachPhieuNhap.Text = DinhDangTienVND(TinhTongThanhTien());
                    txtTongTienThanhToan.Text = "0";
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

        private void btnTimKiemSanPham_Click(object sender, EventArgs e)
        {
            
            DataLogin.formOpacity.Show();
            frmTimKiemSanPham frm = new frmTimKiemSanPham();
            frm.ShowDialog();
            
        }

        private void txtXuatXu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void cboNhaCungCapOfTTPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void cboLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }
    }
}
