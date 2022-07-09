using CrystalDecisions.CrystalReports.Engine;
namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmBaoCaoDSSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoDSSanPham));
            this.crysRpvBaoCaoDSSanPham = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crysRpvBaoCaoDSSanPham
            // 
            this.crysRpvBaoCaoDSSanPham.ActiveViewIndex = -1;
            this.crysRpvBaoCaoDSSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crysRpvBaoCaoDSSanPham.Cursor = System.Windows.Forms.Cursors.Default;
            this.crysRpvBaoCaoDSSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crysRpvBaoCaoDSSanPham.Location = new System.Drawing.Point(0, 0);
            this.crysRpvBaoCaoDSSanPham.Name = "crysRpvBaoCaoDSSanPham";
            this.crysRpvBaoCaoDSSanPham.Size = new System.Drawing.Size(800, 450);
            this.crysRpvBaoCaoDSSanPham.TabIndex = 0;
            // 
            // frmBaoCaoDSSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crysRpvBaoCaoDSSanPham);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaoCaoDSSanPham";
            this.Text = "frmBaoCaoDSSanPham";
            this.Load += new System.EventHandler(this.frmBaoCaoDSSanPham_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crysRpvBaoCaoDSSanPham;
    }
}