namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmLapBaoHanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapBaoHanh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBannerQuanLyNhanVien = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.lblBannerQuanLyNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 67);
            this.panel1.TabIndex = 47;
            // 
            // lblBannerQuanLyNhanVien
            // 
            this.lblBannerQuanLyNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBannerQuanLyNhanVien.AutoSize = true;
            this.lblBannerQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerQuanLyNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblBannerQuanLyNhanVien.Location = new System.Drawing.Point(266, 12);
            this.lblBannerQuanLyNhanVien.Name = "lblBannerQuanLyNhanVien";
            this.lblBannerQuanLyNhanVien.Size = new System.Drawing.Size(306, 42);
            this.lblBannerQuanLyNhanVien.TabIndex = 41;
            this.lblBannerQuanLyNhanVien.Text = "LẬP BẢO HÀNH";
            // 
            // frmLapBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 734);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLapBaoHanh";
            this.Text = "frmLapBaoHanh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBannerQuanLyNhanVien;
    }
}