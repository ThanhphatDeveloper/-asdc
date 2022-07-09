namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmTimKiemSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemSanPham));
            this.lblBannerQuanLyKH = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTimKiemNhanh = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTiemKiemNhanh = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDanhSachSP = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBannerQuanLyKH
            // 
            this.lblBannerQuanLyKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBannerQuanLyKH.AutoSize = true;
            this.lblBannerQuanLyKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerQuanLyKH.ForeColor = System.Drawing.Color.White;
            this.lblBannerQuanLyKH.Location = new System.Drawing.Point(274, 12);
            this.lblBannerQuanLyKH.Name = "lblBannerQuanLyKH";
            this.lblBannerQuanLyKH.Size = new System.Drawing.Size(461, 42);
            this.lblBannerQuanLyKH.TabIndex = 41;
            this.lblBannerQuanLyKH.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // txtTimKiemNhanh
            // 
            this.txtTimKiemNhanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiemNhanh.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight;
            this.txtTimKiemNhanh.BorderColorIdle = System.Drawing.Color.Black;
            this.txtTimKiemNhanh.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight;
            this.txtTimKiemNhanh.BorderThickness = 2;
            this.txtTimKiemNhanh.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiemNhanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNhanh.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemNhanh.isPassword = false;
            this.txtTimKiemNhanh.Location = new System.Drawing.Point(283, 80);
            this.txtTimKiemNhanh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimKiemNhanh.MaxLength = 32767;
            this.txtTimKiemNhanh.Name = "txtTimKiemNhanh";
            this.txtTimKiemNhanh.Size = new System.Drawing.Size(394, 28);
            this.txtTimKiemNhanh.TabIndex = 47;
            this.txtTimKiemNhanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblTiemKiemNhanh
            // 
            this.lblTiemKiemNhanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTiemKiemNhanh.AutoSize = true;
            this.lblTiemKiemNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiemKiemNhanh.ForeColor = System.Drawing.Color.Black;
            this.lblTiemKiemNhanh.Location = new System.Drawing.Point(156, 83);
            this.lblTiemKiemNhanh.Name = "lblTiemKiemNhanh";
            this.lblTiemKiemNhanh.Size = new System.Drawing.Size(124, 20);
            this.lblTiemKiemNhanh.TabIndex = 48;
            this.lblTiemKiemNhanh.Text = "Tìm kiếm nhanh:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.lblBannerQuanLyKH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 67);
            this.panel1.TabIndex = 51;
            // 
            // dgvDanhSachSP
            // 
            this.dgvDanhSachSP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachSP.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDanhSachSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDanhSachSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachSP.ColumnHeadersHeight = 35;
            this.dgvDanhSachSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colLoai,
            this.colGiaBan,
            this.colSLT,
            this.colMaNCC,
            this.colXuatXu});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachSP.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachSP.DoubleBuffered = true;
            this.dgvDanhSachSP.EnableHeadersVisualStyles = false;
            this.dgvDanhSachSP.HeaderBgColor = System.Drawing.Color.Gainsboro;
            this.dgvDanhSachSP.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachSP.Location = new System.Drawing.Point(12, 127);
            this.dgvDanhSachSP.Name = "dgvDanhSachSP";
            this.dgvDanhSachSP.ReadOnly = true;
            this.dgvDanhSachSP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachSP.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDanhSachSP.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDanhSachSP.RowTemplate.Height = 30;
            this.dgvDanhSachSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDanhSachSP.Size = new System.Drawing.Size(1030, 513);
            this.dgvDanhSachSP.TabIndex = 54;
            // 
            // colMaSP
            // 
            this.colMaSP.DataPropertyName = "MaSP";
            this.colMaSP.HeaderText = "Mã SP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            this.colTenSP.DataPropertyName = "TenSP";
            this.colTenSP.HeaderText = "Tên SP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            this.colTenSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colLoai
            // 
            this.colLoai.DataPropertyName = "TenLoai";
            this.colLoai.HeaderText = "Loại";
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            this.colLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colGiaBan
            // 
            this.colGiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle3.Format = "###,##0";
            this.colGiaBan.DefaultCellStyle = dataGridViewCellStyle3;
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            this.colGiaBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSLT
            // 
            this.colSLT.DataPropertyName = "SoLuongTon";
            this.colSLT.HeaderText = "Số Lượng Tồn";
            this.colSLT.Name = "colSLT";
            this.colSLT.ReadOnly = true;
            this.colSLT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMaNCC
            // 
            this.colMaNCC.DataPropertyName = "TenNCC";
            this.colMaNCC.HeaderText = "Nhà Cung Cấp";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.ReadOnly = true;
            this.colMaNCC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colXuatXu
            // 
            this.colXuatXu.DataPropertyName = "XuaXu";
            this.colXuatXu.HeaderText = "Xuất xứ";
            this.colXuatXu.Name = "colXuatXu";
            this.colXuatXu.ReadOnly = true;
            this.colXuatXu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnDong
            // 
            this.btnDong.ActiveBorderThickness = 1;
            this.btnDong.ActiveCornerRadius = 1;
            this.btnDong.ActiveFillColor = System.Drawing.Color.DarkGray;
            this.btnDong.ActiveForecolor = System.Drawing.Color.White;
            this.btnDong.ActiveLineColor = System.Drawing.Color.DarkGray;
            this.btnDong.BackColor = System.Drawing.SystemColors.Control;
            this.btnDong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDong.BackgroundImage")));
            this.btnDong.ButtonText = "Đóng";
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.IdleBorderThickness = 1;
            this.btnDong.IdleCornerRadius = 1;
            this.btnDong.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.btnDong.IdleForecolor = System.Drawing.Color.White;
            this.btnDong.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.btnDong.Location = new System.Drawing.Point(857, 648);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(185, 53);
            this.btnDong.TabIndex = 55;
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmTimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 706);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvDanhSachSP);
            this.Controls.Add(this.txtTimKiemNhanh);
            this.Controls.Add(this.lblTiemKiemNhanh);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimKiemSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiemSanPham";
            this.Load += new System.EventHandler(this.frmTimKiemSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lblBannerQuanLyKH;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTimKiemNhanh;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTiemKiemNhanh;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDanhSachSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXuatXu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDong;
    }
}