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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            frmXemBaoCao frmBCDT = new frmXemBaoCao();
            if (radTatCaDT.Checked)
            {
                frmBCDT.TatCaHoaDon(DataLogin.tenNV);
                frmBCDT.ShowDialog();
            }
            else if (radTheoNgayDT.Checked) //Theo ngày
            {
                string ngayBatDau = Convert.ToString(dtpNgayBatDau.EditValue);
                string ngayKetThuc = Convert.ToString(dtpNgayKetThuc.EditValue);
                if (Convert.ToDateTime(dtpNgayBatDau.EditValue) > Convert.ToDateTime(dtpNgayKetThuc.EditValue))
                {
                    MessageBox.Show("Khoảng thời gian không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmBCDT.TatCaHoaDonTheoNgay(DataLogin.tenNV, ngayBatDau, ngayKetThuc, null);
                frmBCDT.ShowDialog();
            }
            else if (radTheoQuyDT.Checked) //Theo Quý
            {
                if (cboQuy.SelectedItem.ToString() == "Quý 1")
                {
                    string ngayBatDau = dtpNamTheoQuy.Text + "/1/1";
                    string ngayKetThuc = dtpNamTheoQuy.Text + "/3/31";
                    frmBCDT.TatCaHoaDonTheoNgay(DataLogin.tenNV, ngayBatDau, ngayKetThuc, "Quý 1");
                    frmBCDT.ShowDialog();
                }
                else if (cboQuy.SelectedItem.ToString() == "Quý 2")
                {
                    string ngayBatDau = dtpNamTheoQuy.Text + "/4/1";
                    string ngayKetThuc = dtpNamTheoQuy.Text + "/6/30";
                    frmBCDT.TatCaHoaDonTheoNgay(DataLogin.tenNV, ngayBatDau, ngayKetThuc, "Quý 2");
                    frmBCDT.ShowDialog();
                }
                else if (cboQuy.SelectedItem.ToString() == "Quý 3")
                {
                    string ngayBatDau = dtpNamTheoQuy.Text + "/7/1";
                    string ngayKetThuc = dtpNamTheoQuy.Text + "/9/30";
                    frmBCDT.TatCaHoaDonTheoNgay(DataLogin.tenNV, ngayBatDau, ngayKetThuc, "Quý 3");
                    frmBCDT.ShowDialog();
                }
                else if (cboQuy.SelectedItem.ToString() == "Quý 4")
                {
                    string ngayBatDau = dtpNamTheoQuy.Text + "/10/1";
                    string ngayKetThuc = dtpNamTheoQuy.Text + "/12/31";
                    frmBCDT.TatCaHoaDonTheoNgay(DataLogin.tenNV, ngayBatDau, ngayKetThuc, "Quý 4");
                    frmBCDT.ShowDialog();
                }
            }
            else if (radTheoNamDT.Checked)
            {
                string ngayBatDau = dtpNam.Text + "/1/1";
                string ngayKetThuc = dtpNam.Text + "/12/31";
                frmBCDT.TatCaHoaDonTheoNgay(DataLogin.tenNV, ngayBatDau, ngayKetThuc, "Doanh thu trong năm: " + dtpNam.Text);
                frmBCDT.ShowDialog();
            }
        }

        private void btbBaoCaoDSSanPham_Click(object sender, EventArgs e)
        {
            frmBaoCaoDSSanPham frm = new frmBaoCaoDSSanPham();
            frm.ShowDialog();
        }
    }
}
