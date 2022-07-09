using BUS;
using DevExpress.Utils.DirectXPaint;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraRichEdit.Import.Doc;
using DTO;
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
    public partial class frmQuanLy : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        private static Point coorMenuTmp = new Point(205, 31);
        private static Point coorMenuChildTmp = new Point(12, 87);
        private static Point coorLogoTmp = new Point(12, 6);
        //...
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            panelContent.Width = 1112;
            panelContent.Height = 710;
            NhanVienDTO nv = nvBUS.TimKiemNVBUS(DataLogin.tenTK);
            if (nv.MaNV == null)
            {
                txtTenNV.Text = "Admin";
                picUser.Image = Image.FromFile("../../Images/NV1.jpg");
            }
            else
            {
                txtTenNV.Text = nv.HoTenNV;
                DataLogin.tenNV = txtTenNV.Text;
            }
            if (string.IsNullOrEmpty(nv.Anh))
            {
                picUser.Image = null;
            }
            else
            {
                picUser.Image = Image.FromFile("../../Images/" + nv.Anh);
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menu.Width == 70)
            {
                menu.Visible = false;
                txtTenNV.Visible = true; ;
                menu.Width = 246;
                menuChild.Width = 228;
                picUser.Width = 81;
                picUser.Height = 81;
                Point coorIconUser = new Point(72, 7);
                picUser.Location = coorIconUser;
                panelContent.Width = 1107;
                panelContent.Height = 722;
                panelContent.Location = new Point(254, 36);
                btnMenu.Location = coorMenuTmp;
                PanelAnimator.ShowSync(menu);
                logoAnimator.ShowSync(logo);
            }
            else
            {
                logoAnimator.Hide(logo);
                menu.Visible = false;
                txtTenNV.Visible = false;
                menu.Width = 70;
                menuChild.Width = 52;
                panelContent.Width = 1286;
                panelContent.Height = 722;
                panelContent.Location = new Point(75, 36);
                picUser.Width = 50;
                picUser.Height = 50;
                Point coorIconUser = new Point(1, 50);
                picUser.Location = coorIconUser;
                Point coorIconMenu = new Point(22, 28);
                btnMenu.Location = coorIconMenu;
                PanelAnimator.ShowSync(menu);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximize.Visible = true;
        }

        public void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmQuanLyNhanVien frmNV = new frmQuanLyNhanVien()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmNV);
            frmNV.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmNV.Show();
        }

        public void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmQuanLyTaiKhoan frmTK = new frmQuanLyTaiKhoan()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmTK);
            frmTK.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmTK.Show();
        }

        public void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmQuanLyKhachHang frmKH = new frmQuanLyKhachHang()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmKH);
            frmKH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmKH.Show();
        }

        public void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmQuanLySanPham frmSP = new frmQuanLySanPham()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmSP);
            frmSP.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmSP.Show();
        }

        public void btnQuanLyNhaCungCap_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmQuanLyNhaCungCap frmNCC = new frmQuanLyNhaCungCap()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmNCC);
            frmNCC.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmNCC.Show();
        }

        public void btnBaoHanh_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmQuanLyBaoHanh frmBH = new frmQuanLyBaoHanh()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmBH);
            frmBH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmBH.Show();
        }

        public void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            NhanVienDTO nv = nvBUS.TimKiemNVBUS(DataLogin.tenTK);
            frmQuanLyHoaDon frmHD = new frmQuanLyHoaDon(nv.MaNV, nv.HoTenNV)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            panelContent.Controls.Add(frmHD);
            frmHD.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmHD.Show();
            //...
            btnQuanLyHoaDon.Active = true;
        }

        private void menuChild_Paint(object sender, PaintEventArgs e)
        {
            if (DataLogin.quyen == "Bán hàng")
            {
                btnQuanLyNhanVien.Enabled = false;
                btnBaoCao.Enabled = false;
                btnQuanLyTaiKhoan.Enabled = false;
                //btnQuanLyNhanVien.Visible = false;
                //btnThongKe.Visible = false;
                //btnQuanLyTaiKhoan.Visible = false;


            }
            else if (DataLogin.quyen == "Thủ kho")
            {
                btnQuanLyKhachHang.Enabled = false;
                btnQuanLyNhanVien.Enabled = false;
                btnBaoCao.Enabled = false;
                btnQuanLyTaiKhoan.Enabled = false;
                btnBaoHanh.Enabled = false;
                btnQuanLyHoaDon.Enabled = false;

            }
            else if (DataLogin.quyen == "Thu ngân")
            {
                btnQuanLyKhachHang.Enabled = false;
                btnQuanLyNhanVien.Enabled = false;
                btnQuanLyTaiKhoan.Enabled = false;
                btnBaoHanh.Enabled = false; 
                btnBaoCao.Enabled = true;
                btnQuanLySanPham.Enabled = false;
                btnQuanLyPhieuNhap.Enabled = false;
                btnQuanLyNhaCungCap.Enabled = false;
            }

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muôn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
                this.Hide();
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmBaoCao frmBC = new frmBaoCao()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmBC);
            frmBC.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmBC.Show();
        }

        public void btnQuanLyPhieuNhap_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            NhanVienDTO nv = nvBUS.TimKiemNVBUS(DataLogin.tenTK);
            frmQuanLyPhieuNhap frmPN = new frmQuanLyPhieuNhap(nv.MaNV, nv.HoTenNV)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            panelContent.Controls.Add(frmPN);
            frmPN.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmPN.Show();
        }
    }
}
