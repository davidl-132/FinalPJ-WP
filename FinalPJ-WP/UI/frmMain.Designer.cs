namespace FinalPJ_WP
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nghiepVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTopGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoSapHet = new System.Windows.Forms.ToolStripMenuItem();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.lblNgayHienTai = new System.Windows.Forms.Label();
            this.lblChaoMung = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();

            // ==========================================
            // menuStrip1
            // ==========================================
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.danhMucToolStripMenuItem,
                this.nghiepVuToolStripMenuItem,
                this.khachHangToolStripMenuItem,
                this.nhanVienToolStripMenuItem,
                this.baoCaoToolStripMenuItem,
                this.heThongToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1626, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // ==========================================
            // Danh Mục
            // ==========================================
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuSanPham,
                this.mnuTheLoai,
                this.mnuNhaCungCap,
                this.toolStripSeparator1 });
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.danhMucToolStripMenuItem.Text = "Danh Mục";

            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(198, 22);
            this.mnuSanPham.Text = "Quản Lý Sản Phẩm";
            this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);

            this.mnuTheLoai.Name = "mnuTheLoai";
            this.mnuTheLoai.Size = new System.Drawing.Size(198, 22);
            this.mnuTheLoai.Text = "Quản Lý Thể Loại";
            this.mnuTheLoai.Click += new System.EventHandler(this.mnuTheLoai_Click);

            this.mnuNhaCungCap.Name = "mnuNhaCungCap";
            this.mnuNhaCungCap.Size = new System.Drawing.Size(198, 22);
            this.mnuNhaCungCap.Text = "Quản Lý Nhà Cung Cấp";
            this.mnuNhaCungCap.Click += new System.EventHandler(this.mnuNhaCungCap_Click);

            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);

            // ==========================================
            // Nghiệp Vụ
            // ==========================================
            this.nghiepVuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuDonHang,
                this.mnuNhapHang });
            this.nghiepVuToolStripMenuItem.Name = "nghiepVuToolStripMenuItem";
            this.nghiepVuToolStripMenuItem.Size = new System.Drawing.Size(75, 19);
            this.nghiepVuToolStripMenuItem.Text = "Nghiệp Vụ";

            this.mnuDonHang.Name = "mnuDonHang";
            this.mnuDonHang.Size = new System.Drawing.Size(191, 22);
            this.mnuDonHang.Text = "Bán Hàng / Đơn Hàng";
            this.mnuDonHang.Click += new System.EventHandler(this.mnuDonHang_Click);

            this.mnuNhapHang.Name = "mnuNhapHang";
            this.mnuNhapHang.Size = new System.Drawing.Size(191, 22);
            this.mnuNhapHang.Text = "Nhập Hàng";
            this.mnuNhapHang.Click += new System.EventHandler(this.mnuNhapHang_Click);

            // ==========================================
            // Khách Hàng
            // ==========================================
            this.khachHangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuQLKhachHang });
            this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(84, 19);
            this.khachHangToolStripMenuItem.Text = "Khách Hàng";

            this.mnuQLKhachHang.Name = "mnuQLKhachHang";
            this.mnuQLKhachHang.Size = new System.Drawing.Size(185, 22);
            this.mnuQLKhachHang.Text = "Quản Lý Khách Hàng";
            this.mnuQLKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);

            // ==========================================
            // Nhân Viên
            // ==========================================
            this.nhanVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuQLNhanVien });
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.nhanVienToolStripMenuItem.Text = "Nhân Viên";

            this.mnuQLNhanVien.Name = "mnuQLNhanVien";
            this.mnuQLNhanVien.Size = new System.Drawing.Size(175, 22);
            this.mnuQLNhanVien.Text = "Quản Lý Nhân Viên";
            this.mnuQLNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);

            // ==========================================
            // Báo Cáo  ← mỗi mục gọi handler riêng
            // ==========================================
            this.baoCaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuDoanhThu,
                this.mnuTopGame,
                this.mnuKhoSapHet });
            this.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
            this.baoCaoToolStripMenuItem.Size = new System.Drawing.Size(64, 19);
            this.baoCaoToolStripMenuItem.Text = "Báo Cáo";

            // Doanh Thu Theo Ngày / Tháng
            this.mnuDoanhThu.Name = "mnuDoanhThu";
            this.mnuDoanhThu.Size = new System.Drawing.Size(239, 22);
            this.mnuDoanhThu.Text = "Doanh Thu Theo Ngày / Tháng";
            this.mnuDoanhThu.Click += new System.EventHandler(this.mnuDoanhThu_Click);

            // Top Game Bán Chạy
            this.mnuTopGame.Name = "mnuTopGame";
            this.mnuTopGame.Size = new System.Drawing.Size(239, 22);
            this.mnuTopGame.Text = "Top Game Bán Chạy";
            this.mnuTopGame.Click += new System.EventHandler(this.mnuTopGame_Click);

            // Kho Sắp Hết Hàng
            this.mnuKhoSapHet.Name = "mnuKhoSapHet";
            this.mnuKhoSapHet.Size = new System.Drawing.Size(239, 22);
            this.mnuKhoSapHet.Text = "Kho Sắp Hết Hàng";
            this.mnuKhoSapHet.Click += new System.EventHandler(this.mnuKhoSapHet_Click);

            // ==========================================
            // Hệ Thống
            // ==========================================
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuDoiMatKhau,
                this.toolStripSeparator2,
                this.mnuDangXuat,
                this.toolStripSeparator3,
                this.mnuThoat });
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(72, 19);
            this.heThongToolStripMenuItem.Text = "Hệ Thống";

            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(181, 22);
            this.mnuDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);

            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);

            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(181, 22);
            this.mnuDangXuat.Text = "Đăng Xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);

            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);

            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(181, 22);
            this.mnuThoat.Text = "Thoát Chương Trình";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);

            // ==========================================
            // statusStrip1
            // ==========================================
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblTrangThai,
                this.lblSpacer,
                this.lblNguoiDung,
                this.lblThoiGian });
            this.statusStrip1.Location = new System.Drawing.Point(0, 993);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1626, 24);
            this.statusStrip1.TabIndex = 1;

            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(54, 19);
            this.lblTrangThai.Text = "Sẵn sàng";

            this.lblSpacer.Name = "lblSpacer";
            this.lblSpacer.Size = new System.Drawing.Size(1421, 19);
            this.lblSpacer.Spring = true;

            this.lblNguoiDung.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(75, 19);
            this.lblNguoiDung.Text = "Người dùng";

            this.lblThoiGian.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(53, 19);
            this.lblThoiGian.Text = "00:00:00";

            // ==========================================
            // pnlDashboard
            // ==========================================
            this.pnlDashboard.Controls.Add(this.btnBaoCao);
            this.pnlDashboard.Controls.Add(this.btnNhapHang);
            this.pnlDashboard.Controls.Add(this.btnNhanVien);
            this.pnlDashboard.Controls.Add(this.btnKhachHang);
            this.pnlDashboard.Controls.Add(this.btnDonHang);
            this.pnlDashboard.Controls.Add(this.btnSanPham);
            this.pnlDashboard.Controls.Add(this.lblNgayHienTai);
            this.pnlDashboard.Controls.Add(this.lblChaoMung);
            this.pnlDashboard.Controls.Add(this.lblTieuDe);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 25);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1626, 968);
            this.pnlDashboard.TabIndex = 2;

            // ==========================================
            // Buttons
            // ==========================================
            this.btnSanPham.Location = new System.Drawing.Point(60, 231);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(300, 154);
            this.btnSanPham.TabIndex = 3;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);

            this.btnDonHang.Location = new System.Drawing.Point(390, 231);
            this.btnDonHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(300, 154);
            this.btnDonHang.TabIndex = 4;
            this.btnDonHang.Text = "Đơn Hàng";
            this.btnDonHang.UseVisualStyleBackColor = true;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);

            this.btnKhachHang.Location = new System.Drawing.Point(720, 231);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(300, 154);
            this.btnKhachHang.TabIndex = 5;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);

            this.btnNhanVien.Location = new System.Drawing.Point(60, 415);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(300, 154);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);

            this.btnNhapHang.Location = new System.Drawing.Point(390, 415);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(300, 154);
            this.btnNhapHang.TabIndex = 7;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);

            this.btnBaoCao.Location = new System.Drawing.Point(720, 415);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(300, 154);
            this.btnBaoCao.TabIndex = 8;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);

            // ==========================================
            // Labels
            // ==========================================
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(54, 46);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(315, 41);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ BÁN GAME";

            this.lblChaoMung.AutoSize = true;
            this.lblChaoMung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChaoMung.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblChaoMung.Location = new System.Drawing.Point(57, 123);
            this.lblChaoMung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChaoMung.Name = "lblChaoMung";
            this.lblChaoMung.Size = new System.Drawing.Size(88, 21);
            this.lblChaoMung.TabIndex = 1;
            this.lblChaoMung.Text = "Xin Chào, ...";

            this.lblNgayHienTai.AutoSize = true;
            this.lblNgayHienTai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHienTai.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblNgayHienTai.Location = new System.Drawing.Point(60, 166);
            this.lblNgayHienTai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayHienTai.Name = "lblNgayHienTai";
            this.lblNgayHienTai.Size = new System.Drawing.Size(50, 15);
            this.lblNgayHienTai.TabIndex = 2;
            this.lblNgayHienTai.Text = "Ngày: ...";

            // ==========================================
            // Timer
            // ==========================================
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // ==========================================
            // frmMain
            // ==========================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 1017);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1192, 748);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuTheLoai;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaCungCap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem nghiepVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDonHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHang;
        private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQLKhachHang;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem baoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuTopGame;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoSapHet;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.ToolStripStatusLabel lblSpacer;
        private System.Windows.Forms.ToolStripStatusLabel lblNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel lblThoiGian;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblChaoMung;
        private System.Windows.Forms.Label lblNgayHienTai;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Timer timer1;
    }
}