namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBannerQuanLyNhanVien = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel = new System.Windows.Forms.Panel();
            this.cboQuy = new System.Windows.Forms.ComboBox();
            this.radTheoNamDT = new System.Windows.Forms.RadioButton();
            this.radTheoNgayDT = new System.Windows.Forms.RadioButton();
            this.radTheoQuyDT = new System.Windows.Forms.RadioButton();
            this.radTatCaDT = new System.Windows.Forms.RadioButton();
            this.dtpNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNam = new DevExpress.XtraEditors.DateEdit();
            this.dtpNamTheoQuy = new DevExpress.XtraEditors.DateEdit();
            this.dtpNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThongTinSPBanner = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnXemBC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btbBaoCaoDSSanPham = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNam.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNamTheoQuy.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNamTheoQuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBatDau.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblBannerQuanLyNhanVien);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1184, 63);
            this.panel4.TabIndex = 49;
            // 
            // lblBannerQuanLyNhanVien
            // 
            this.lblBannerQuanLyNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBannerQuanLyNhanVien.AutoSize = true;
            this.lblBannerQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerQuanLyNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblBannerQuanLyNhanVien.Location = new System.Drawing.Point(478, 8);
            this.lblBannerQuanLyNhanVien.Name = "lblBannerQuanLyNhanVien";
            this.lblBannerQuanLyNhanVien.Size = new System.Drawing.Size(195, 42);
            this.lblBannerQuanLyNhanVien.TabIndex = 41;
            this.lblBannerQuanLyNhanVien.Text = "BÁO CÁO";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel.Controls.Add(this.cboQuy);
            this.panel.Controls.Add(this.radTheoNamDT);
            this.panel.Controls.Add(this.radTheoNgayDT);
            this.panel.Controls.Add(this.radTheoQuyDT);
            this.panel.Controls.Add(this.radTatCaDT);
            this.panel.Controls.Add(this.dtpNgayKetThuc);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.dtpNam);
            this.panel.Controls.Add(this.dtpNamTheoQuy);
            this.panel.Controls.Add(this.dtpNgayBatDau);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.btnXemBC);
            this.panel.Location = new System.Drawing.Point(12, 69);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(537, 242);
            this.panel.TabIndex = 50;
            // 
            // cboQuy
            // 
            this.cboQuy.AutoCompleteCustomSource.AddRange(new string[] {
            "Quý 1",
            "Quý 2",
            "Quý 2",
            "Quý 4"});
            this.cboQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuy.FormattingEnabled = true;
            this.cboQuy.Items.AddRange(new object[] {
            "Quý 1",
            "Quý 2",
            "Quý 3",
            "Quý 4"});
            this.cboQuy.Location = new System.Drawing.Point(136, 147);
            this.cboQuy.Name = "cboQuy";
            this.cboQuy.Size = new System.Drawing.Size(121, 26);
            this.cboQuy.TabIndex = 5;
            // 
            // radTheoNamDT
            // 
            this.radTheoNamDT.AutoSize = true;
            this.radTheoNamDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTheoNamDT.Location = new System.Drawing.Point(34, 202);
            this.radTheoNamDT.Name = "radTheoNamDT";
            this.radTheoNamDT.Size = new System.Drawing.Size(97, 22);
            this.radTheoNamDT.TabIndex = 7;
            this.radTheoNamDT.Text = "Theo năm:";
            this.radTheoNamDT.UseVisualStyleBackColor = true;
            // 
            // radTheoNgayDT
            // 
            this.radTheoNgayDT.AutoSize = true;
            this.radTheoNgayDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTheoNgayDT.Location = new System.Drawing.Point(34, 94);
            this.radTheoNgayDT.Name = "radTheoNgayDT";
            this.radTheoNgayDT.Size = new System.Drawing.Size(99, 22);
            this.radTheoNgayDT.TabIndex = 1;
            this.radTheoNgayDT.Text = "Theo ngày:";
            this.radTheoNgayDT.UseVisualStyleBackColor = true;
            // 
            // radTheoQuyDT
            // 
            this.radTheoQuyDT.AutoSize = true;
            this.radTheoQuyDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTheoQuyDT.Location = new System.Drawing.Point(34, 148);
            this.radTheoQuyDT.Name = "radTheoQuyDT";
            this.radTheoQuyDT.Size = new System.Drawing.Size(91, 22);
            this.radTheoQuyDT.TabIndex = 4;
            this.radTheoQuyDT.Text = "Theo quý:";
            this.radTheoQuyDT.UseVisualStyleBackColor = true;
            // 
            // radTatCaDT
            // 
            this.radTatCaDT.AutoSize = true;
            this.radTatCaDT.Checked = true;
            this.radTatCaDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCaDT.Location = new System.Drawing.Point(34, 41);
            this.radTatCaDT.Name = "radTatCaDT";
            this.radTatCaDT.Size = new System.Drawing.Size(67, 22);
            this.radTatCaDT.TabIndex = 0;
            this.radTatCaDT.TabStop = true;
            this.radTatCaDT.Text = "Tất cả";
            this.radTatCaDT.UseVisualStyleBackColor = true;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.EditValue = null;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(401, 92);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.Properties.Appearance.Options.UseFont = true;
            this.dtpNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayKetThuc.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNgayKetThuc.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNgayKetThuc.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(105, 26);
            this.dtpNgayKetThuc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "trong năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày:";
            // 
            // dtpNam
            // 
            this.dtpNam.EditValue = new System.DateTime(2020, 7, 6, 7, 58, 14, 512);
            this.dtpNam.Location = new System.Drawing.Point(136, 200);
            this.dtpNam.Name = "dtpNam";
            this.dtpNam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNam.Properties.Appearance.Options.UseFont = true;
            this.dtpNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNam.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNam.Properties.DisplayFormat.FormatString = "yyyy";
            this.dtpNam.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNam.Properties.EditFormat.FormatString = "yyyy";
            this.dtpNam.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNam.Properties.Mask.EditMask = "yyyy";
            this.dtpNam.Size = new System.Drawing.Size(121, 26);
            this.dtpNam.TabIndex = 8;
            // 
            // dtpNamTheoQuy
            // 
            this.dtpNamTheoQuy.EditValue = new System.DateTime(2020, 7, 6, 7, 58, 14, 512);
            this.dtpNamTheoQuy.Location = new System.Drawing.Point(367, 147);
            this.dtpNamTheoQuy.Name = "dtpNamTheoQuy";
            this.dtpNamTheoQuy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNamTheoQuy.Properties.Appearance.Options.UseFont = true;
            this.dtpNamTheoQuy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNamTheoQuy.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNamTheoQuy.Properties.DisplayFormat.FormatString = "yyyy";
            this.dtpNamTheoQuy.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNamTheoQuy.Properties.EditFormat.FormatString = "yyyy";
            this.dtpNamTheoQuy.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNamTheoQuy.Properties.Mask.EditMask = "yyyy";
            this.dtpNamTheoQuy.Size = new System.Drawing.Size(139, 26);
            this.dtpNamTheoQuy.TabIndex = 6;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.EditValue = null;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(209, 92);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Properties.Appearance.Options.UseFont = true;
            this.dtpNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayBatDau.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpNgayBatDau.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNgayBatDau.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpNgayBatDau.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNgayBatDau.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(106, 26);
            this.dtpNgayBatDau.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ ngày:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.lblThongTinSPBanner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 35);
            this.panel1.TabIndex = 0;
            // 
            // lblThongTinSPBanner
            // 
            this.lblThongTinSPBanner.AutoSize = true;
            this.lblThongTinSPBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinSPBanner.ForeColor = System.Drawing.Color.Black;
            this.lblThongTinSPBanner.Location = new System.Drawing.Point(171, 6);
            this.lblThongTinSPBanner.Name = "lblThongTinSPBanner";
            this.lblThongTinSPBanner.Size = new System.Drawing.Size(166, 20);
            this.lblThongTinSPBanner.TabIndex = 0;
            this.lblThongTinSPBanner.Text = "Doanh thu/Hóa đơn";
            // 
            // btnXemBC
            // 
            this.btnXemBC.ActiveBorderThickness = 1;
            this.btnXemBC.ActiveCornerRadius = 1;
            this.btnXemBC.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(223)))));
            this.btnXemBC.ActiveForecolor = System.Drawing.Color.White;
            this.btnXemBC.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(223)))));
            this.btnXemBC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXemBC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemBC.BackgroundImage")));
            this.btnXemBC.ButtonText = "Lập báo cáo";
            this.btnXemBC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBC.ForeColor = System.Drawing.Color.White;
            this.btnXemBC.IdleBorderThickness = 1;
            this.btnXemBC.IdleCornerRadius = 1;
            this.btnXemBC.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnXemBC.IdleForecolor = System.Drawing.Color.White;
            this.btnXemBC.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnXemBC.Location = new System.Drawing.Point(396, 181);
            this.btnXemBC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemBC.Name = "btnXemBC";
            this.btnXemBC.Size = new System.Drawing.Size(110, 49);
            this.btnXemBC.TabIndex = 9;
            this.btnXemBC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemBC.Click += new System.EventHandler(this.btnXemBC_Click);
            // 
            // btbBaoCaoDSSanPham
            // 
            this.btbBaoCaoDSSanPham.ActiveBorderThickness = 1;
            this.btbBaoCaoDSSanPham.ActiveCornerRadius = 1;
            this.btbBaoCaoDSSanPham.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(223)))));
            this.btbBaoCaoDSSanPham.ActiveForecolor = System.Drawing.Color.White;
            this.btbBaoCaoDSSanPham.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(223)))));
            this.btbBaoCaoDSSanPham.BackColor = System.Drawing.Color.White;
            this.btbBaoCaoDSSanPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btbBaoCaoDSSanPham.BackgroundImage")));
            this.btbBaoCaoDSSanPham.ButtonText = "Lập báo cáo danh sách sản phẩm";
            this.btbBaoCaoDSSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbBaoCaoDSSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbBaoCaoDSSanPham.ForeColor = System.Drawing.Color.White;
            this.btbBaoCaoDSSanPham.IdleBorderThickness = 1;
            this.btbBaoCaoDSSanPham.IdleCornerRadius = 1;
            this.btbBaoCaoDSSanPham.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btbBaoCaoDSSanPham.IdleForecolor = System.Drawing.Color.White;
            this.btbBaoCaoDSSanPham.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btbBaoCaoDSSanPham.Location = new System.Drawing.Point(717, 134);
            this.btbBaoCaoDSSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btbBaoCaoDSSanPham.Name = "btbBaoCaoDSSanPham";
            this.btbBaoCaoDSSanPham.Size = new System.Drawing.Size(322, 108);
            this.btbBaoCaoDSSanPham.TabIndex = 9;
            this.btbBaoCaoDSSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btbBaoCaoDSSanPham.Click += new System.EventHandler(this.btbBaoCaoDSSanPham_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 710);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btbBaoCaoDSSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNam.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNamTheoQuy.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNamTheoQuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBatDau.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBannerQuanLyNhanVien;
        private System.Windows.Forms.Panel panel;
        private DevExpress.XtraEditors.DateEdit dtpNgayKetThuc;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtpNgayBatDau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblThongTinSPBanner;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXemBC;
        private System.Windows.Forms.ComboBox cboQuy;
        private System.Windows.Forms.RadioButton radTheoNamDT;
        private System.Windows.Forms.RadioButton radTheoNgayDT;
        private System.Windows.Forms.RadioButton radTheoQuyDT;
        private System.Windows.Forms.RadioButton radTatCaDT;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dtpNam;
        private DevExpress.XtraEditors.DateEdit dtpNamTheoQuy;
        private Bunifu.Framework.UI.BunifuThinButton2 btbBaoCaoDSSanPham;
    }
}