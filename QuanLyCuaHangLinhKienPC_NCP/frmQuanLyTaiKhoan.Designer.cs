namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmQuanLyTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiKhoan));
            this.txtTimKiemNhanh = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTimKiemNhanh = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvDanhSachTK = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colTenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiSoHuu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBannerQuanLyNhanVien = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnTaoTaiKhoan = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTK)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiemNhanh
            // 
            this.txtTimKiemNhanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTimKiemNhanh.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight;
            this.txtTimKiemNhanh.BorderColorIdle = System.Drawing.Color.Black;
            this.txtTimKiemNhanh.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight;
            this.txtTimKiemNhanh.BorderThickness = 2;
            this.txtTimKiemNhanh.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiemNhanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNhanh.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemNhanh.isPassword = false;
            this.txtTimKiemNhanh.Location = new System.Drawing.Point(421, 86);
            this.txtTimKiemNhanh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimKiemNhanh.MaxLength = 32767;
            this.txtTimKiemNhanh.Name = "txtTimKiemNhanh";
            this.txtTimKiemNhanh.Size = new System.Drawing.Size(394, 28);
            this.txtTimKiemNhanh.TabIndex = 0;
            this.txtTimKiemNhanh.Tag = "";
            this.txtTimKiemNhanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiemNhanh.OnValueChanged += new System.EventHandler(this.txtTimKiemNhanh_OnValueChanged);
            // 
            // lblTimKiemNhanh
            // 
            this.lblTimKiemNhanh.AutoSize = true;
            this.lblTimKiemNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemNhanh.ForeColor = System.Drawing.Color.Black;
            this.lblTimKiemNhanh.Location = new System.Drawing.Point(282, 90);
            this.lblTimKiemNhanh.Name = "lblTimKiemNhanh";
            this.lblTimKiemNhanh.Size = new System.Drawing.Size(132, 20);
            this.lblTimKiemNhanh.TabIndex = 42;
            this.lblTimKiemNhanh.Text = "Tìm kiếm nhanh:";
            // 
            // dgvDanhSachTK
            // 
            this.dgvDanhSachTK.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachTK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachTK.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDanhSachTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachTK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDanhSachTK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachTK.ColumnHeadersHeight = 35;
            this.dgvDanhSachTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenTK,
            this.colQuyenHan,
            this.colNguoiSoHuu,
            this.colChucVu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachTK.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachTK.DoubleBuffered = true;
            this.dgvDanhSachTK.EnableHeadersVisualStyles = false;
            this.dgvDanhSachTK.HeaderBgColor = System.Drawing.Color.Gainsboro;
            this.dgvDanhSachTK.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachTK.Location = new System.Drawing.Point(12, 132);
            this.dgvDanhSachTK.Name = "dgvDanhSachTK";
            this.dgvDanhSachTK.ReadOnly = true;
            this.dgvDanhSachTK.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachTK.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachTK.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDanhSachTK.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachTK.RowTemplate.Height = 30;
            this.dgvDanhSachTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDanhSachTK.Size = new System.Drawing.Size(1088, 568);
            this.dgvDanhSachTK.TabIndex = 41;
            // 
            // colTenTK
            // 
            this.colTenTK.DataPropertyName = "tenTaiKhoan";
            this.colTenTK.HeaderText = "Tên tài khoản";
            this.colTenTK.Name = "colTenTK";
            this.colTenTK.ReadOnly = true;
            // 
            // colQuyenHan
            // 
            this.colQuyenHan.DataPropertyName = "tenQuyen";
            this.colQuyenHan.HeaderText = "Quyền hạn";
            this.colQuyenHan.Name = "colQuyenHan";
            this.colQuyenHan.ReadOnly = true;
            // 
            // colNguoiSoHuu
            // 
            this.colNguoiSoHuu.DataPropertyName = "nhanVienSoHuu";
            this.colNguoiSoHuu.HeaderText = "Người sở hữu";
            this.colNguoiSoHuu.Name = "colNguoiSoHuu";
            this.colNguoiSoHuu.ReadOnly = true;
            // 
            // colChucVu
            // 
            this.colChucVu.DataPropertyName = "chucVu";
            this.colChucVu.HeaderText = "Chức vụ";
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.lblBannerQuanLyNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 67);
            this.panel1.TabIndex = 44;
            // 
            // lblBannerQuanLyNhanVien
            // 
            this.lblBannerQuanLyNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBannerQuanLyNhanVien.AutoSize = true;
            this.lblBannerQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerQuanLyNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblBannerQuanLyNhanVien.Location = new System.Drawing.Point(323, 12);
            this.lblBannerQuanLyNhanVien.Name = "lblBannerQuanLyNhanVien";
            this.lblBannerQuanLyNhanVien.Size = new System.Drawing.Size(467, 42);
            this.lblBannerQuanLyNhanVien.TabIndex = 41;
            this.lblBannerQuanLyNhanVien.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.ActiveBorderThickness = 1;
            this.btnTaoTaiKhoan.ActiveCornerRadius = 1;
            this.btnTaoTaiKhoan.ActiveFillColor = System.Drawing.Color.Gold;
            this.btnTaoTaiKhoan.ActiveForecolor = System.Drawing.Color.Black;
            this.btnTaoTaiKhoan.ActiveLineColor = System.Drawing.Color.Gold;
            this.btnTaoTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnTaoTaiKhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.BackgroundImage")));
            this.btnTaoTaiKhoan.ButtonText = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnTaoTaiKhoan.IdleBorderThickness = 1;
            this.btnTaoTaiKhoan.IdleCornerRadius = 1;
            this.btnTaoTaiKhoan.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnTaoTaiKhoan.IdleForecolor = System.Drawing.Color.Black;
            this.btnTaoTaiKhoan.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(982, 75);
            this.btnTaoTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(117, 49);
            this.btnTaoTaiKhoan.TabIndex = 1;
            this.btnTaoTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 710);
            this.Controls.Add(this.btnTaoTaiKhoan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTimKiemNhanh);
            this.Controls.Add(this.lblTimKiemNhanh);
            this.Controls.Add(this.dgvDanhSachTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "frmQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTimKiemNhanh;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTimKiemNhanh;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDanhSachTK;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBannerQuanLyNhanVien;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTaoTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuyenHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiSoHuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
    }
}