namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmXemBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemBaoCao));
            this.rpvXemBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvXemBaoCao
            // 
            this.rpvXemBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvXemBaoCao.Location = new System.Drawing.Point(0, 0);
            this.rpvXemBaoCao.Name = "rpvXemBaoCao";
            this.rpvXemBaoCao.ServerReport.BearerToken = null;
            this.rpvXemBaoCao.Size = new System.Drawing.Size(1161, 749);
            this.rpvXemBaoCao.TabIndex = 0;
            this.rpvXemBaoCao.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmXemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 749);
            this.Controls.Add(this.rpvXemBaoCao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXemBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThuHD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvXemBaoCao;
    }
}