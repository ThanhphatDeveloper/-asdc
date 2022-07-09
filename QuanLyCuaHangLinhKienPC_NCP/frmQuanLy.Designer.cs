namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmQuanLy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.header = new System.Windows.Forms.Panel();
            this.btnRestaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.menu = new System.Windows.Forms.Panel();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.menuChild = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnDangXuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTenNV = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnQuanLySanPham = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyKhachHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBaoCao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBaoHanh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyPhieuNhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyNhaCungCap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyHoaDon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyNhanVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyTaiKhoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.menuChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.header.Controls.Add(this.btnRestaurar);
            this.header.Controls.Add(this.btnMinximize);
            this.header.Controls.Add(this.btnMaximize);
            this.header.Controls.Add(this.btnExit);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.logoAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1386, 30);
            this.header.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.header, "");
            this.bunifuToolTip1.SetToolTipIcon(this.header, null);
            this.bunifuToolTip1.SetToolTipTitle(this.header, "");
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoAnimator.SetDecoration(this.btnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.ImageActive = null;
            this.btnRestaurar.Location = new System.Drawing.Point(1308, 1);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(28, 28);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 10;
            this.btnRestaurar.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnRestaurar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnRestaurar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnRestaurar, "");
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Zoom = 10;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinximize
            // 
            this.btnMinximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoAnimator.SetDecoration(this.btnMinximize, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnMinximize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinximize.Image")));
            this.btnMinximize.ImageActive = null;
            this.btnMinximize.Location = new System.Drawing.Point(1272, 1);
            this.btnMinximize.Name = "btnMinximize";
            this.btnMinximize.Size = new System.Drawing.Size(28, 28);
            this.btnMinximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinximize.TabIndex = 10;
            this.btnMinximize.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnMinximize, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnMinximize, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnMinximize, "");
            this.btnMinximize.Zoom = 10;
            this.btnMinximize.Click += new System.EventHandler(this.btnMinximize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoAnimator.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.ImageActive = null;
            this.btnMaximize.Location = new System.Drawing.Point(1308, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(28, 28);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 10;
            this.btnMaximize.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnMaximize, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnMaximize, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnMaximize, "");
            this.btnMaximize.Zoom = 10;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoAnimator.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1344, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnExit, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnExit, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnExit, "");
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.PanelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(40, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(75, 20);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Quản Lý";
            this.bunifuToolTip1.SetToolTip(this.bunifuCustomLabel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCustomLabel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCustomLabel1, "");
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menu.Controls.Add(this.btnMenu);
            this.menu.Controls.Add(this.menuChild);
            this.menu.Controls.Add(this.logo);
            this.logoAnimator.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 30);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(246, 758);
            this.menu.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.menu, "");
            this.bunifuToolTip1.SetToolTipIcon(this.menu, null);
            this.bunifuToolTip1.SetToolTipTitle(this.menu, "");
            // 
            // btnMenu
            // 
            this.logoAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(205, 31);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 25);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnMenu, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnMenu, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnMenu, "");
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // menuChild
            // 
            this.menuChild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuChild.BackgroundImage")));
            this.menuChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuChild.Controls.Add(this.btnDangXuat);
            this.menuChild.Controls.Add(this.txtTenNV);
            this.menuChild.Controls.Add(this.picUser);
            this.menuChild.Controls.Add(this.btnQuanLySanPham);
            this.menuChild.Controls.Add(this.btnQuanLyKhachHang);
            this.menuChild.Controls.Add(this.btnBaoCao);
            this.menuChild.Controls.Add(this.btnBaoHanh);
            this.menuChild.Controls.Add(this.btnQuanLyPhieuNhap);
            this.menuChild.Controls.Add(this.btnQuanLyNhaCungCap);
            this.menuChild.Controls.Add(this.btnQuanLyHoaDon);
            this.menuChild.Controls.Add(this.btnQuanLyNhanVien);
            this.menuChild.Controls.Add(this.btnQuanLyTaiKhoan);
            this.PanelAnimator.SetDecoration(this.menuChild, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.menuChild, BunifuAnimatorNS.DecorationType.None);
            this.menuChild.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menuChild.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menuChild.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menuChild.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menuChild.Location = new System.Drawing.Point(9, 82);
            this.menuChild.Name = "menuChild";
            this.menuChild.Quality = 10;
            this.menuChild.Size = new System.Drawing.Size(228, 664);
            this.menuChild.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.menuChild, "");
            this.bunifuToolTip1.SetToolTipIcon(this.menuChild, null);
            this.bunifuToolTip1.SetToolTipTitle(this.menuChild, "");
            this.menuChild.Paint += new System.Windows.Forms.PaintEventHandler(this.menuChild_Paint);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Active = false;
            this.btnDangXuat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangXuat.BorderRadius = 0;
            this.btnDangXuat.ButtonText = "Đăng Xuất";
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnDangXuat, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnDangXuat, BunifuAnimatorNS.DecorationType.None);
            this.btnDangXuat.DisabledColor = System.Drawing.Color.Gray;
            this.btnDangXuat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Iconimage")));
            this.btnDangXuat.Iconimage_right = null;
            this.btnDangXuat.Iconimage_right_Selected = null;
            this.btnDangXuat.Iconimage_Selected = null;
            this.btnDangXuat.IconMarginLeft = 0;
            this.btnDangXuat.IconMarginRight = 0;
            this.btnDangXuat.IconRightVisible = true;
            this.btnDangXuat.IconRightZoom = 0D;
            this.btnDangXuat.IconVisible = true;
            this.btnDangXuat.IconZoom = 50D;
            this.btnDangXuat.IsTab = true;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 609);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnDangXuat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnDangXuat.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDangXuat.selected = false;
            this.btnDangXuat.Size = new System.Drawing.Size(228, 48);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangXuat.Textcolor = System.Drawing.Color.Black;
            this.btnDangXuat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnDangXuat, "Đăng xuất");
            this.bunifuToolTip1.SetToolTipIcon(this.btnDangXuat, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnDangXuat, "");
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenNV.BackColor = System.Drawing.Color.Gold;
            this.txtTenNV.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelAnimator.SetDecoration(this.txtTenNV, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.txtTenNV, BunifuAnimatorNS.DecorationType.None);
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Font = new System.Drawing.Font("SVN-Beast", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtTenNV.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenNV.HintText = "";
            this.txtTenNV.isPassword = false;
            this.txtTenNV.LineFocusedColor = System.Drawing.Color.Gold;
            this.txtTenNV.LineIdleColor = System.Drawing.Color.Gold;
            this.txtTenNV.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.txtTenNV.LineThickness = 4;
            this.txtTenNV.Location = new System.Drawing.Point(0, 86);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTenNV.MaxLength = 32767;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(227, 37);
            this.txtTenNV.TabIndex = 7;
            this.txtTenNV.Text = "Huỳnh Thanh Cảnh";
            this.txtTenNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuToolTip1.SetToolTip(this.txtTenNV, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtTenNV, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtTenNV, "");
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Black;
            this.PanelAnimator.SetDecoration(this.picUser, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.picUser, BunifuAnimatorNS.DecorationType.None);
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(72, 2);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(81, 81);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 6;
            this.picUser.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.picUser, "");
            this.bunifuToolTip1.SetToolTipIcon(this.picUser, null);
            this.bunifuToolTip1.SetToolTipTitle(this.picUser, "");
            // 
            // btnQuanLySanPham
            // 
            this.btnQuanLySanPham.Active = false;
            this.btnQuanLySanPham.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLySanPham.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLySanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLySanPham.BorderRadius = 0;
            this.btnQuanLySanPham.ButtonText = "     Quản Lý Sản Phẩm";
            this.btnQuanLySanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnQuanLySanPham, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnQuanLySanPham, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLySanPham.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLySanPham.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLySanPham.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLySanPham.Iconimage")));
            this.btnQuanLySanPham.Iconimage_right = null;
            this.btnQuanLySanPham.Iconimage_right_Selected = null;
            this.btnQuanLySanPham.Iconimage_Selected = null;
            this.btnQuanLySanPham.IconMarginLeft = 0;
            this.btnQuanLySanPham.IconMarginRight = 0;
            this.btnQuanLySanPham.IconRightVisible = true;
            this.btnQuanLySanPham.IconRightZoom = 0D;
            this.btnQuanLySanPham.IconVisible = true;
            this.btnQuanLySanPham.IconZoom = 50D;
            this.btnQuanLySanPham.IsTab = true;
            this.btnQuanLySanPham.Location = new System.Drawing.Point(0, 291);
            this.btnQuanLySanPham.Name = "btnQuanLySanPham";
            this.btnQuanLySanPham.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLySanPham.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLySanPham.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLySanPham.selected = false;
            this.btnQuanLySanPham.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLySanPham.TabIndex = 5;
            this.btnQuanLySanPham.Text = "     Quản Lý Sản Phẩm";
            this.btnQuanLySanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySanPham.Textcolor = System.Drawing.Color.White;
            this.btnQuanLySanPham.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnQuanLySanPham, "Quản lý sản phẩm");
            this.bunifuToolTip1.SetToolTipIcon(this.btnQuanLySanPham, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnQuanLySanPham, "");
            this.btnQuanLySanPham.Click += new System.EventHandler(this.btnQuanLySanPham_Click);
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.Active = false;
            this.btnQuanLyKhachHang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyKhachHang.BorderRadius = 0;
            this.btnQuanLyKhachHang.ButtonText = "     Quản Lý Khách Hàng";
            this.btnQuanLyKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnQuanLyKhachHang, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnQuanLyKhachHang, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyKhachHang.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyKhachHang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyKhachHang.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyKhachHang.Iconimage")));
            this.btnQuanLyKhachHang.Iconimage_right = null;
            this.btnQuanLyKhachHang.Iconimage_right_Selected = null;
            this.btnQuanLyKhachHang.Iconimage_Selected = null;
            this.btnQuanLyKhachHang.IconMarginLeft = 0;
            this.btnQuanLyKhachHang.IconMarginRight = 0;
            this.btnQuanLyKhachHang.IconRightVisible = true;
            this.btnQuanLyKhachHang.IconRightZoom = 0D;
            this.btnQuanLyKhachHang.IconVisible = true;
            this.btnQuanLyKhachHang.IconZoom = 50D;
            this.btnQuanLyKhachHang.IsTab = true;
            this.btnQuanLyKhachHang.Location = new System.Drawing.Point(0, 237);
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            this.btnQuanLyKhachHang.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyKhachHang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyKhachHang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyKhachHang.selected = false;
            this.btnQuanLyKhachHang.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLyKhachHang.TabIndex = 5;
            this.btnQuanLyKhachHang.Text = "     Quản Lý Khách Hàng";
            this.btnQuanLyKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKhachHang.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyKhachHang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnQuanLyKhachHang, "Quản lý khách hàng");
            this.bunifuToolTip1.SetToolTipIcon(this.btnQuanLyKhachHang, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnQuanLyKhachHang, "");
            this.btnQuanLyKhachHang.Click += new System.EventHandler(this.btnQuanLyKhachHang_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Active = false;
            this.btnBaoCao.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaoCao.BorderRadius = 0;
            this.btnBaoCao.ButtonText = "     Báo Cáo";
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnBaoCao, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnBaoCao, BunifuAnimatorNS.DecorationType.None);
            this.btnBaoCao.DisabledColor = System.Drawing.Color.Gray;
            this.btnBaoCao.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBaoCao.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Iconimage")));
            this.btnBaoCao.Iconimage_right = null;
            this.btnBaoCao.Iconimage_right_Selected = null;
            this.btnBaoCao.Iconimage_Selected = null;
            this.btnBaoCao.IconMarginLeft = 0;
            this.btnBaoCao.IconMarginRight = 0;
            this.btnBaoCao.IconRightVisible = true;
            this.btnBaoCao.IconRightZoom = 0D;
            this.btnBaoCao.IconVisible = true;
            this.btnBaoCao.IconZoom = 50D;
            this.btnBaoCao.IsTab = true;
            this.btnBaoCao.Location = new System.Drawing.Point(-1, 555);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBaoCao.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnBaoCao.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBaoCao.selected = false;
            this.btnBaoCao.Size = new System.Drawing.Size(228, 48);
            this.btnBaoCao.TabIndex = 5;
            this.btnBaoCao.Text = "     Báo Cáo";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Textcolor = System.Drawing.Color.White;
            this.btnBaoCao.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnBaoCao, "Thống kê");
            this.bunifuToolTip1.SetToolTipIcon(this.btnBaoCao, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnBaoCao, "");
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnBaoHanh
            // 
            this.btnBaoHanh.Active = false;
            this.btnBaoHanh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnBaoHanh.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoHanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaoHanh.BorderRadius = 0;
            this.btnBaoHanh.ButtonText = "     Bảo Hành";
            this.btnBaoHanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnBaoHanh, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnBaoHanh, BunifuAnimatorNS.DecorationType.None);
            this.btnBaoHanh.DisabledColor = System.Drawing.Color.Gray;
            this.btnBaoHanh.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBaoHanh.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBaoHanh.Iconimage")));
            this.btnBaoHanh.Iconimage_right = null;
            this.btnBaoHanh.Iconimage_right_Selected = null;
            this.btnBaoHanh.Iconimage_Selected = null;
            this.btnBaoHanh.IconMarginLeft = 0;
            this.btnBaoHanh.IconMarginRight = 0;
            this.btnBaoHanh.IconRightVisible = true;
            this.btnBaoHanh.IconRightZoom = 0D;
            this.btnBaoHanh.IconVisible = true;
            this.btnBaoHanh.IconZoom = 50D;
            this.btnBaoHanh.IsTab = true;
            this.btnBaoHanh.Location = new System.Drawing.Point(0, 501);
            this.btnBaoHanh.Name = "btnBaoHanh";
            this.btnBaoHanh.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBaoHanh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnBaoHanh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBaoHanh.selected = false;
            this.btnBaoHanh.Size = new System.Drawing.Size(228, 48);
            this.btnBaoHanh.TabIndex = 5;
            this.btnBaoHanh.Text = "     Bảo Hành";
            this.btnBaoHanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoHanh.Textcolor = System.Drawing.Color.White;
            this.btnBaoHanh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnBaoHanh, "Bảo hành");
            this.bunifuToolTip1.SetToolTipIcon(this.btnBaoHanh, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnBaoHanh, "");
            this.btnBaoHanh.Click += new System.EventHandler(this.btnBaoHanh_Click);
            // 
            // btnQuanLyPhieuNhap
            // 
            this.btnQuanLyPhieuNhap.Active = false;
            this.btnQuanLyPhieuNhap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyPhieuNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyPhieuNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyPhieuNhap.BorderRadius = 0;
            this.btnQuanLyPhieuNhap.ButtonText = "     Quản Lý Phiếu Nhập";
            this.btnQuanLyPhieuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnQuanLyPhieuNhap, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnQuanLyPhieuNhap, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyPhieuNhap.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyPhieuNhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyPhieuNhap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyPhieuNhap.Iconimage")));
            this.btnQuanLyPhieuNhap.Iconimage_right = null;
            this.btnQuanLyPhieuNhap.Iconimage_right_Selected = null;
            this.btnQuanLyPhieuNhap.Iconimage_Selected = null;
            this.btnQuanLyPhieuNhap.IconMarginLeft = 0;
            this.btnQuanLyPhieuNhap.IconMarginRight = 0;
            this.btnQuanLyPhieuNhap.IconRightVisible = true;
            this.btnQuanLyPhieuNhap.IconRightZoom = 0D;
            this.btnQuanLyPhieuNhap.IconVisible = true;
            this.btnQuanLyPhieuNhap.IconZoom = 50D;
            this.btnQuanLyPhieuNhap.IsTab = true;
            this.btnQuanLyPhieuNhap.Location = new System.Drawing.Point(0, 447);
            this.btnQuanLyPhieuNhap.Name = "btnQuanLyPhieuNhap";
            this.btnQuanLyPhieuNhap.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyPhieuNhap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyPhieuNhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyPhieuNhap.selected = false;
            this.btnQuanLyPhieuNhap.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLyPhieuNhap.TabIndex = 5;
            this.btnQuanLyPhieuNhap.Text = "     Quản Lý Phiếu Nhập";
            this.btnQuanLyPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyPhieuNhap.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyPhieuNhap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnQuanLyPhieuNhap, "Quản lý phiếu nhập");
            this.bunifuToolTip1.SetToolTipIcon(this.btnQuanLyPhieuNhap, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnQuanLyPhieuNhap, "");
            this.btnQuanLyPhieuNhap.Click += new System.EventHandler(this.btnQuanLyPhieuNhap_Click);
            // 
            // btnQuanLyNhaCungCap
            // 
            this.btnQuanLyNhaCungCap.Active = false;
            this.btnQuanLyNhaCungCap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyNhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhaCungCap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyNhaCungCap.BorderRadius = 0;
            this.btnQuanLyNhaCungCap.ButtonText = "     Quản Lý Nhà Cung Cấp";
            this.btnQuanLyNhaCungCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnQuanLyNhaCungCap, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnQuanLyNhaCungCap, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyNhaCungCap.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyNhaCungCap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhaCungCap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyNhaCungCap.Iconimage")));
            this.btnQuanLyNhaCungCap.Iconimage_right = null;
            this.btnQuanLyNhaCungCap.Iconimage_right_Selected = null;
            this.btnQuanLyNhaCungCap.Iconimage_Selected = null;
            this.btnQuanLyNhaCungCap.IconMarginLeft = 0;
            this.btnQuanLyNhaCungCap.IconMarginRight = 0;
            this.btnQuanLyNhaCungCap.IconRightVisible = true;
            this.btnQuanLyNhaCungCap.IconRightZoom = 0D;
            this.btnQuanLyNhaCungCap.IconVisible = true;
            this.btnQuanLyNhaCungCap.IconZoom = 50D;
            this.btnQuanLyNhaCungCap.IsTab = true;
            this.btnQuanLyNhaCungCap.Location = new System.Drawing.Point(0, 399);
            this.btnQuanLyNhaCungCap.Name = "btnQuanLyNhaCungCap";
            this.btnQuanLyNhaCungCap.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhaCungCap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyNhaCungCap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyNhaCungCap.selected = false;
            this.btnQuanLyNhaCungCap.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLyNhaCungCap.TabIndex = 5;
            this.btnQuanLyNhaCungCap.Text = "     Quản Lý Nhà Cung Cấp";
            this.btnQuanLyNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNhaCungCap.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyNhaCungCap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnQuanLyNhaCungCap, "Quản lý nhà cung cấp");
            this.bunifuToolTip1.SetToolTipIcon(this.btnQuanLyNhaCungCap, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnQuanLyNhaCungCap, "");
            this.btnQuanLyNhaCungCap.Click += new System.EventHandler(this.btnQuanLyNhaCungCap_Click);
            // 
            // btnQuanLyHoaDon
            // 
            this.btnQuanLyHoaDon.Active = false;
            this.btnQuanLyHoaDon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyHoaDon.BorderRadius = 0;
            this.btnQuanLyHoaDon.ButtonText = "     Quản Lý Hóa Đơn";
            this.btnQuanLyHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnQuanLyHoaDon, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnQuanLyHoaDon, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyHoaDon.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyHoaDon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyHoaDon.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyHoaDon.Iconimage")));
            this.btnQuanLyHoaDon.Iconimage_right = null;
            this.btnQuanLyHoaDon.Iconimage_right_Selected = null;
            this.btnQuanLyHoaDon.Iconimage_Selected = null;
            this.btnQuanLyHoaDon.IconMarginLeft = 0;
            this.btnQuanLyHoaDon.IconMarginRight = 0;
            this.btnQuanLyHoaDon.IconRightVisible = true;
            this.btnQuanLyHoaDon.IconRightZoom = 0D;
            this.btnQuanLyHoaDon.IconVisible = true;
            this.btnQuanLyHoaDon.IconZoom = 50D;
            this.btnQuanLyHoaDon.IsTab = true;
            this.btnQuanLyHoaDon.Location = new System.Drawing.Point(0, 345);
            this.btnQuanLyHoaDon.Name = "btnQuanLyHoaDon";
            this.btnQuanLyHoaDon.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyHoaDon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyHoaDon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyHoaDon.selected = false;
            this.btnQuanLyHoaDon.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLyHoaDon.TabIndex = 5;
            this.btnQuanLyHoaDon.Text = "     Quản Lý Hóa Đơn";
            this.btnQuanLyHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyHoaDon.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyHoaDon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnQuanLyHoaDon, "Quản lý hóa đơn");
            this.bunifuToolTip1.SetToolTipIcon(this.btnQuanLyHoaDon, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnQuanLyHoaDon, "");
            this.btnQuanLyHoaDon.Click += new System.EventHandler(this.btnQuanLyHoaDon_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Active = false;
            this.btnQuanLyNhanVien.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyNhanVien.BorderRadius = 0;
            this.btnQuanLyNhanVien.ButtonText = "     Quản Lý Nhân Viên";
            this.btnQuanLyNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnQuanLyNhanVien, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnQuanLyNhanVien, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyNhanVien.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyNhanVien.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhanVien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyNhanVien.Iconimage")));
            this.btnQuanLyNhanVien.Iconimage_right = null;
            this.btnQuanLyNhanVien.Iconimage_right_Selected = null;
            this.btnQuanLyNhanVien.Iconimage_Selected = null;
            this.btnQuanLyNhanVien.IconMarginLeft = 0;
            this.btnQuanLyNhanVien.IconMarginRight = 0;
            this.btnQuanLyNhanVien.IconRightVisible = true;
            this.btnQuanLyNhanVien.IconRightZoom = 0D;
            this.btnQuanLyNhanVien.IconVisible = true;
            this.btnQuanLyNhanVien.IconZoom = 50D;
            this.btnQuanLyNhanVien.IsTab = true;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(0, 183);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhanVien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyNhanVien.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyNhanVien.selected = false;
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLyNhanVien.TabIndex = 5;
            this.btnQuanLyNhanVien.Text = "     Quản Lý Nhân Viên";
            this.btnQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNhanVien.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyNhanVien.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnQuanLyNhanVien, "Quản lý nhân viên");
            this.bunifuToolTip1.SetToolTipIcon(this.btnQuanLyNhanVien, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnQuanLyNhanVien, "");
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.Active = false;
            this.btnQuanLyTaiKhoan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyTaiKhoan.BorderRadius = 0;
            this.btnQuanLyTaiKhoan.ButtonText = "     Quản Lý Tài Khoản";
            this.btnQuanLyTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnQuanLyTaiKhoan, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnQuanLyTaiKhoan, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyTaiKhoan.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyTaiKhoan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyTaiKhoan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyTaiKhoan.Iconimage")));
            this.btnQuanLyTaiKhoan.Iconimage_right = null;
            this.btnQuanLyTaiKhoan.Iconimage_right_Selected = null;
            this.btnQuanLyTaiKhoan.Iconimage_Selected = null;
            this.btnQuanLyTaiKhoan.IconMarginLeft = 0;
            this.btnQuanLyTaiKhoan.IconMarginRight = 0;
            this.btnQuanLyTaiKhoan.IconRightVisible = true;
            this.btnQuanLyTaiKhoan.IconRightZoom = 0D;
            this.btnQuanLyTaiKhoan.IconVisible = true;
            this.btnQuanLyTaiKhoan.IconZoom = 50D;
            this.btnQuanLyTaiKhoan.IsTab = true;
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(0, 129);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyTaiKhoan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(136)))));
            this.btnQuanLyTaiKhoan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyTaiKhoan.selected = false;
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(228, 48);
            this.btnQuanLyTaiKhoan.TabIndex = 5;
            this.btnQuanLyTaiKhoan.Text = "     Quản Lý Tài Khoản";
            this.btnQuanLyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyTaiKhoan.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyTaiKhoan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnQuanLyTaiKhoan, "Quản lý tài khoản");
            this.bunifuToolTip1.SetToolTipIcon(this.btnQuanLyTaiKhoan, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnQuanLyTaiKhoan, "");
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // logo
            // 
            this.PanelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(132, 75);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.logo, "");
            this.bunifuToolTip1.SetToolTipIcon(this.logo, null);
            this.bunifuToolTip1.SetToolTipTitle(this.logo, "");
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.logoAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0.5F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation3;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.logoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(262, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoAnimator.SetDecoration(this.panelContent, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panelContent, BunifuAnimatorNS.DecorationType.None);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(246, 30);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1140, 758);
            this.panelContent.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.panelContent, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelContent, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelContent, "");
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation4;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 90;
            this.bunifuElipse2.TargetControl = this.picUser;
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 0;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.header);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.menuChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuGradientPanel menuChild;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyNhanVien;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyTaiKhoan;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLySanPham;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyKhachHang;
        private Bunifu.Framework.UI.BunifuFlatButton btnBaoCao;
        private Bunifu.Framework.UI.BunifuFlatButton btnBaoHanh;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyHoaDon;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyNhaCungCap;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinximize;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton btnRestaurar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox picUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenNV;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyPhieuNhap;
        private Bunifu.Framework.UI.BunifuFlatButton btnDangXuat;
    }
}