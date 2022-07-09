namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmQuanLyPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyPhieuNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBannerQuanLyPhieuNhap = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTimKiemNhanh = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTimKiemNhanh = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvDanhSachPN = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanVienLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNhapHang = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.lblBannerQuanLyPhieuNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 56);
            this.panel1.TabIndex = 85;
            // 
            // lblBannerQuanLyPhieuNhap
            // 
            this.lblBannerQuanLyPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBannerQuanLyPhieuNhap.AutoSize = true;
            this.lblBannerQuanLyPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerQuanLyPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.lblBannerQuanLyPhieuNhap.Location = new System.Drawing.Point(429, 7);
            this.lblBannerQuanLyPhieuNhap.Name = "lblBannerQuanLyPhieuNhap";
            this.lblBannerQuanLyPhieuNhap.Size = new System.Drawing.Size(437, 42);
            this.lblBannerQuanLyPhieuNhap.TabIndex = 41;
            this.lblBannerQuanLyPhieuNhap.Text = "QUẢN LÝ PHIẾU NHẬP";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(8, 73);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(388, 20);
            this.bunifuCustomLabel4.TabIndex = 89;
            this.bunifuCustomLabel4.Text = "*Nhấp đúp một dòng để xem chi tiết phiếu nhập";
            // 
            // txtTimKiemNhanh
            // 
            this.txtTimKiemNhanh.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight;
            this.txtTimKiemNhanh.BorderColorIdle = System.Drawing.Color.Black;
            this.txtTimKiemNhanh.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight;
            this.txtTimKiemNhanh.BorderThickness = 2;
            this.txtTimKiemNhanh.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiemNhanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNhanh.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemNhanh.isPassword = false;
            this.txtTimKiemNhanh.Location = new System.Drawing.Point(573, 70);
            this.txtTimKiemNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemNhanh.MaxLength = 32767;
            this.txtTimKiemNhanh.Name = "txtTimKiemNhanh";
            this.txtTimKiemNhanh.Size = new System.Drawing.Size(350, 28);
            this.txtTimKiemNhanh.TabIndex = 0;
            this.txtTimKiemNhanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiemNhanh.OnValueChanged += new System.EventHandler(this.txtTimKiemNhanh_OnValueChanged);
            // 
            // lblTimKiemNhanh
            // 
            this.lblTimKiemNhanh.AutoSize = true;
            this.lblTimKiemNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemNhanh.ForeColor = System.Drawing.Color.Black;
            this.lblTimKiemNhanh.Location = new System.Drawing.Point(438, 73);
            this.lblTimKiemNhanh.Name = "lblTimKiemNhanh";
            this.lblTimKiemNhanh.Size = new System.Drawing.Size(128, 20);
            this.lblTimKiemNhanh.TabIndex = 87;
            this.lblTimKiemNhanh.Text = "Tìm kiếm nhanh :";
            // 
            // dgvDanhSachPN
            // 
            this.dgvDanhSachPN.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachPN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPN.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDanhSachPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachPN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDanhSachPN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachPN.ColumnHeadersHeight = 35;
            this.dgvDanhSachPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieu,
            this.colManv,
            this.colNhanVienLap,
            this.colNgayNhap});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachPN.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachPN.DoubleBuffered = true;
            this.dgvDanhSachPN.EnableHeadersVisualStyles = false;
            this.dgvDanhSachPN.HeaderBgColor = System.Drawing.Color.Gainsboro;
            this.dgvDanhSachPN.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachPN.Location = new System.Drawing.Point(12, 114);
            this.dgvDanhSachPN.Name = "dgvDanhSachPN";
            this.dgvDanhSachPN.ReadOnly = true;
            this.dgvDanhSachPN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachPN.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachPN.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDanhSachPN.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDanhSachPN.RowTemplate.Height = 30;
            this.dgvDanhSachPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDanhSachPN.Size = new System.Drawing.Size(1280, 558);
            this.dgvDanhSachPN.TabIndex = 86;
            this.dgvDanhSachPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPN_CellClick);
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.DataPropertyName = "MaPhieu";
            this.colMaPhieu.HeaderText = "Mã phiếu";
            this.colMaPhieu.Name = "colMaPhieu";
            this.colMaPhieu.ReadOnly = true;
            // 
            // colManv
            // 
            this.colManv.DataPropertyName = "NhanVienLap";
            this.colManv.HeaderText = "Mã nhân viên";
            this.colManv.Name = "colManv";
            this.colManv.ReadOnly = true;
            // 
            // colNhanVienLap
            // 
            this.colNhanVienLap.DataPropertyName = "TenNhanVien";
            this.colNhanVienLap.HeaderText = "Nhân viên lập";
            this.colNhanVienLap.Name = "colNhanVienLap";
            this.colNhanVienLap.ReadOnly = true;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.colNgayNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNgayNhap.HeaderText = "Ngày nhập";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.ReadOnly = true;
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.ActiveBorderThickness = 1;
            this.btnNhapHang.ActiveCornerRadius = 1;
            this.btnNhapHang.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(223)))));
            this.btnNhapHang.ActiveForecolor = System.Drawing.Color.White;
            this.btnNhapHang.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(223)))));
            this.btnNhapHang.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNhapHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnNhapHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNhapHang.BackgroundImage")));
            this.btnNhapHang.ButtonText = "Nhập hàng";
            this.btnNhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.IdleBorderThickness = 1;
            this.btnNhapHang.IdleCornerRadius = 1;
            this.btnNhapHang.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnNhapHang.IdleForecolor = System.Drawing.Color.White;
            this.btnNhapHang.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnNhapHang.Location = new System.Drawing.Point(1181, 57);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(110, 49);
            this.btnNhapHang.TabIndex = 1;
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // frmQuanLyPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 722);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txtTimKiemNhanh);
            this.Controls.Add(this.lblTimKiemNhanh);
            this.Controls.Add(this.dgvDanhSachPN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyPhieuNhap";
            this.Text = "frmQuanLyPhieuNhap";
            this.Load += new System.EventHandler(this.frmQuanLyPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBannerQuanLyPhieuNhap;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTimKiemNhanh;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTimKiemNhanh;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDanhSachPN;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanVienLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
    }
}