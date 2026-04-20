namespace FinalPJ_WP.UI
{
    partial class frmDonHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDanhSach = new System.Windows.Forms.TabPage();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLocTrangThai = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.btnTaoDon = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.tabTaoDon = new System.Windows.Forms.TabPage();
            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblHangKH = new System.Windows.Forms.Label();
            this.lblDiemKH = new System.Windows.Forms.Label();
            this.lblDiemSuDung = new System.Windows.Forms.Label();
            this.numDiemSuDung = new System.Windows.Forms.NumericUpDown();
            this.grpChonSP = new System.Windows.Forms.GroupBox();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.lblSerialKey = new System.Windows.Forms.Label();
            this.txtSerialKey = new System.Windows.Forms.TextBox();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.btnXoaKhoiGio = new System.Windows.Forms.Button();
            this.grpGioHang = new System.Windows.Forms.GroupBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.lblPTTT = new System.Windows.Forms.Label();
            this.cboPhuongThucTT = new System.Windows.Forms.ComboBox();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.numGiamGia = new System.Windows.Forms.NumericUpDown();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.btnLuuDon = new System.Windows.Forms.Button();
            this.btnHuyTao = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabDanhSach.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.grpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.tabTaoDon.SuspendLayout();
            this.grpKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemSuDung)).BeginInit();
            this.grpChonSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            this.grpGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.grpThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDanhSach);
            this.tabControl.Controls.Add(this.tabTaoDon);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1349, 797);
            this.tabControl.TabIndex = 0;
            // 
            // tabDanhSach
            // 
            this.tabDanhSach.Controls.Add(this.grpTimKiem);
            this.tabDanhSach.Controls.Add(this.dgvDonHang);
            this.tabDanhSach.Controls.Add(this.grpChiTiet);
            this.tabDanhSach.Controls.Add(this.btnHuyDon);
            this.tabDanhSach.Controls.Add(this.btnTaoDon);
            this.tabDanhSach.Controls.Add(this.btnTroVe);
            this.tabDanhSach.Location = new System.Drawing.Point(4, 26);
            this.tabDanhSach.Name = "tabDanhSach";
            this.tabDanhSach.Size = new System.Drawing.Size(1341, 767);
            this.tabDanhSach.TabIndex = 0;
            this.tabDanhSach.Text = "  Danh sách đơn hàng  ";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.lblTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Controls.Add(this.lblLocTrangThai);
            this.grpTimKiem.Controls.Add(this.cboLocTrangThai);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.btnReload);
            this.grpTimKiem.Location = new System.Drawing.Point(10, 10);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(800, 60);
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(10, 25);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(92, 17);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Khách/Mã ĐH:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(100, 22);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 24);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // lblLocTrangThai
            // 
            this.lblLocTrangThai.AutoSize = true;
            this.lblLocTrangThai.Location = new System.Drawing.Point(315, 25);
            this.lblLocTrangThai.Name = "lblLocTrangThai";
            this.lblLocTrangThai.Size = new System.Drawing.Size(69, 17);
            this.lblLocTrangThai.TabIndex = 2;
            this.lblLocTrangThai.Text = "Trạng thái:";
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.Location = new System.Drawing.Point(395, 22);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(150, 25);
            this.cboLocTrangThai.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(560, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 28);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(660, 20);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(90, 28);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToAddRows = false;
            this.dgvDonHang.AllowUserToDeleteRows = false;
            this.dgvDonHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonHang.ColumnHeadersHeight = 35;
            this.dgvDonHang.Location = new System.Drawing.Point(10, 80);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowTemplate.Height = 28;
            this.dgvDonHang.Size = new System.Drawing.Size(1310, 420);
            this.dgvDonHang.TabIndex = 1;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Controls.Add(this.dgvChiTiet);
            this.grpChiTiet.Location = new System.Drawing.Point(10, 506);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(1310, 194);
            this.grpChiTiet.TabIndex = 2;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "Chi tiết đơn hàng";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTiet.ColumnHeadersHeight = 35;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(3, 20);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowTemplate.Height = 28;
            this.dgvChiTiet.Size = new System.Drawing.Size(1304, 171);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHuyDon.Enabled = false;
            this.btnHuyDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHuyDon.ForeColor = System.Drawing.Color.White;
            this.btnHuyDon.Location = new System.Drawing.Point(1130, 718);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(90, 32);
            this.btnHuyDon.TabIndex = 3;
            this.btnHuyDon.Text = "Hủy đơn";
            this.btnHuyDon.UseVisualStyleBackColor = false;
            this.btnHuyDon.Click += new System.EventHandler(this.btnHuyDon_Click);
            // 
            // btnTaoDon
            // 
            this.btnTaoDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnTaoDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoDon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTaoDon.ForeColor = System.Drawing.Color.White;
            this.btnTaoDon.Location = new System.Drawing.Point(1010, 718);
            this.btnTaoDon.Name = "btnTaoDon";
            this.btnTaoDon.Size = new System.Drawing.Size(110, 32);
            this.btnTaoDon.TabIndex = 4;
            this.btnTaoDon.Text = "Tạo đơn mới";
            this.btnTaoDon.UseVisualStyleBackColor = false;
            this.btnTaoDon.Click += new System.EventHandler(this.btnTaoDon_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroVe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(10, 718);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(100, 32);
            this.btnTroVe.TabIndex = 5;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // tabTaoDon
            // 
            this.tabTaoDon.Controls.Add(this.grpKhachHang);
            this.tabTaoDon.Controls.Add(this.grpChonSP);
            this.tabTaoDon.Controls.Add(this.grpGioHang);
            this.tabTaoDon.Controls.Add(this.grpThanhToan);
            this.tabTaoDon.Controls.Add(this.btnLuuDon);
            this.tabTaoDon.Controls.Add(this.btnHuyTao);
            this.tabTaoDon.Location = new System.Drawing.Point(4, 22);
            this.tabTaoDon.Name = "tabTaoDon";
            this.tabTaoDon.Size = new System.Drawing.Size(1341, 771);
            this.tabTaoDon.TabIndex = 1;
            this.tabTaoDon.Text = "  Tạo đơn hàng mới  ";
            // 
            // grpKhachHang
            // 
            this.grpKhachHang.Controls.Add(this.lblSDT);
            this.grpKhachHang.Controls.Add(this.txtSDT);
            this.grpKhachHang.Controls.Add(this.btnTimKH);
            this.grpKhachHang.Controls.Add(this.lblTenKH);
            this.grpKhachHang.Controls.Add(this.lblHangKH);
            this.grpKhachHang.Controls.Add(this.lblDiemKH);
            this.grpKhachHang.Controls.Add(this.lblDiemSuDung);
            this.grpKhachHang.Controls.Add(this.numDiemSuDung);
            this.grpKhachHang.Location = new System.Drawing.Point(10, 10);
            this.grpKhachHang.Name = "grpKhachHang";
            this.grpKhachHang.Size = new System.Drawing.Size(420, 145);
            this.grpKhachHang.TabIndex = 0;
            this.grpKhachHang.TabStop = false;
            this.grpKhachHang.Text = "Thông tin khách hàng";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(10, 28);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(88, 17);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(115, 25);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(180, 24);
            this.txtSDT.TabIndex = 1;
            // 
            // btnTimKH
            // 
            this.btnTimKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTimKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKH.ForeColor = System.Drawing.Color.White;
            this.btnTimKH.Location = new System.Drawing.Point(305, 24);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(90, 26);
            this.btnTimKH.TabIndex = 2;
            this.btnTimKH.Text = "Tìm";
            this.btnTimKH.UseVisualStyleBackColor = false;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(10, 60);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(67, 17);
            this.lblTenKH.TabIndex = 3;
            this.lblTenKH.Text = "Họ tên: —";
            // 
            // lblHangKH
            // 
            this.lblHangKH.AutoSize = true;
            this.lblHangKH.Location = new System.Drawing.Point(10, 82);
            this.lblHangKH.Name = "lblHangKH";
            this.lblHangKH.Size = new System.Drawing.Size(59, 17);
            this.lblHangKH.TabIndex = 4;
            this.lblHangKH.Text = "Hạng: —";
            // 
            // lblDiemKH
            // 
            this.lblDiemKH.AutoSize = true;
            this.lblDiemKH.Location = new System.Drawing.Point(10, 104);
            this.lblDiemKH.Name = "lblDiemKH";
            this.lblDiemKH.Size = new System.Drawing.Size(104, 17);
            this.lblDiemKH.TabIndex = 5;
            this.lblDiemKH.Text = "Điểm hiện tại: —";
            // 
            // lblDiemSuDung
            // 
            this.lblDiemSuDung.AutoSize = true;
            this.lblDiemSuDung.Location = new System.Drawing.Point(200, 104);
            this.lblDiemSuDung.Name = "lblDiemSuDung";
            this.lblDiemSuDung.Size = new System.Drawing.Size(75, 17);
            this.lblDiemSuDung.TabIndex = 6;
            this.lblDiemSuDung.Text = "Dùng điểm:";
            // 
            // numDiemSuDung
            // 
            this.numDiemSuDung.Location = new System.Drawing.Point(280, 101);
            this.numDiemSuDung.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numDiemSuDung.Name = "numDiemSuDung";
            this.numDiemSuDung.Size = new System.Drawing.Size(110, 24);
            this.numDiemSuDung.TabIndex = 7;
            // 
            // grpChonSP
            // 
            this.grpChonSP.Controls.Add(this.lblSanPham);
            this.grpChonSP.Controls.Add(this.cboSanPham);
            this.grpChonSP.Controls.Add(this.lblSoLuong);
            this.grpChonSP.Controls.Add(this.numSoLuong);
            this.grpChonSP.Controls.Add(this.lblDonGia);
            this.grpChonSP.Controls.Add(this.numDonGia);
            this.grpChonSP.Controls.Add(this.lblSerialKey);
            this.grpChonSP.Controls.Add(this.txtSerialKey);
            this.grpChonSP.Controls.Add(this.btnThemVaoGio);
            this.grpChonSP.Controls.Add(this.btnXoaKhoiGio);
            this.grpChonSP.Location = new System.Drawing.Point(440, 10);
            this.grpChonSP.Name = "grpChonSP";
            this.grpChonSP.Size = new System.Drawing.Size(880, 145);
            this.grpChonSP.TabIndex = 1;
            this.grpChonSP.TabStop = false;
            this.grpChonSP.Text = "Chọn sản phẩm";
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Location = new System.Drawing.Point(10, 28);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(69, 17);
            this.lblSanPham.TabIndex = 0;
            this.lblSanPham.Text = "Sản phẩm:";
            // 
            // cboSanPham
            // 
            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.Location = new System.Drawing.Point(85, 25);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(380, 25);
            this.cboSanPham.TabIndex = 1;
            this.cboSanPham.SelectedIndexChanged += new System.EventHandler(this.cboSanPham_SelectedIndexChanged);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(475, 28);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(64, 17);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(545, 25);
            this.numSoLuong.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(70, 24);
            this.numSoLuong.TabIndex = 3;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(625, 28);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(57, 17);
            this.lblDonGia.TabIndex = 4;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // numDonGia
            // 
            this.numDonGia.Location = new System.Drawing.Point(685, 25);
            this.numDonGia.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(120, 24);
            this.numDonGia.TabIndex = 5;
            this.numDonGia.ThousandsSeparator = true;
            // 
            // lblSerialKey
            // 
            this.lblSerialKey.AutoSize = true;
            this.lblSerialKey.Location = new System.Drawing.Point(10, 65);
            this.lblSerialKey.Name = "lblSerialKey";
            this.lblSerialKey.Size = new System.Drawing.Size(68, 17);
            this.lblSerialKey.TabIndex = 6;
            this.lblSerialKey.Text = "Serial Key:";
            this.lblSerialKey.Visible = false;
            // 
            // txtSerialKey
            // 
            this.txtSerialKey.Location = new System.Drawing.Point(85, 62);
            this.txtSerialKey.Name = "txtSerialKey";
            this.txtSerialKey.Size = new System.Drawing.Size(380, 24);
            this.txtSerialKey.TabIndex = 7;
            this.txtSerialKey.Visible = false;
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThemVaoGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoGio.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoGio.Location = new System.Drawing.Point(630, 100);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(110, 30);
            this.btnThemVaoGio.TabIndex = 8;
            this.btnThemVaoGio.Text = "+ Thêm vào giỏ";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // btnXoaKhoiGio
            // 
            this.btnXoaKhoiGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoaKhoiGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKhoiGio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoaKhoiGio.ForeColor = System.Drawing.Color.White;
            this.btnXoaKhoiGio.Location = new System.Drawing.Point(750, 100);
            this.btnXoaKhoiGio.Name = "btnXoaKhoiGio";
            this.btnXoaKhoiGio.Size = new System.Drawing.Size(110, 30);
            this.btnXoaKhoiGio.TabIndex = 9;
            this.btnXoaKhoiGio.Text = "Xóa dòng";
            this.btnXoaKhoiGio.UseVisualStyleBackColor = false;
            this.btnXoaKhoiGio.Click += new System.EventHandler(this.btnXoaKhoiGio_Click);
            // 
            // grpGioHang
            // 
            this.grpGioHang.Controls.Add(this.dgvGioHang);
            this.grpGioHang.Location = new System.Drawing.Point(10, 165);
            this.grpGioHang.Name = "grpGioHang";
            this.grpGioHang.Size = new System.Drawing.Size(1310, 370);
            this.grpGioHang.TabIndex = 2;
            this.grpGioHang.TabStop = false;
            this.grpGioHang.Text = "Giỏ hàng";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGioHang.ColumnHeadersHeight = 35;
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.Location = new System.Drawing.Point(3, 20);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowTemplate.Height = 28;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(1304, 347);
            this.dgvGioHang.TabIndex = 0;
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.Controls.Add(this.lblPTTT);
            this.grpThanhToan.Controls.Add(this.cboPhuongThucTT);
            this.grpThanhToan.Controls.Add(this.lblGiamGia);
            this.grpThanhToan.Controls.Add(this.numGiamGia);
            this.grpThanhToan.Controls.Add(this.lblTongTien);
            this.grpThanhToan.Controls.Add(this.lblThanhToan);
            this.grpThanhToan.Location = new System.Drawing.Point(10, 545);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(1310, 100);
            this.grpThanhToan.TabIndex = 3;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Thanh toán";
            // 
            // lblPTTT
            // 
            this.lblPTTT.AutoSize = true;
            this.lblPTTT.Location = new System.Drawing.Point(10, 35);
            this.lblPTTT.Name = "lblPTTT";
            this.lblPTTT.Size = new System.Drawing.Size(103, 17);
            this.lblPTTT.TabIndex = 0;
            this.lblPTTT.Text = "Phương thức TT:";
            // 
            // cboPhuongThucTT
            // 
            this.cboPhuongThucTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuongThucTT.Items.AddRange(new object[] {
            "TienMat",
            "ChuyenKhoan",
            "TheNganHang",
            "Vi"});
            this.cboPhuongThucTT.Location = new System.Drawing.Point(120, 32);
            this.cboPhuongThucTT.Name = "cboPhuongThucTT";
            this.cboPhuongThucTT.Size = new System.Drawing.Size(160, 25);
            this.cboPhuongThucTT.TabIndex = 1;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(300, 35);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(102, 17);
            this.lblGiamGia.TabIndex = 2;
            this.lblGiamGia.Text = "Giảm giá (VNĐ):";
            // 
            // numGiamGia
            // 
            this.numGiamGia.Location = new System.Drawing.Point(400, 32);
            this.numGiamGia.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numGiamGia.Name = "numGiamGia";
            this.numGiamGia.Size = new System.Drawing.Size(140, 24);
            this.numGiamGia.TabIndex = 3;
            this.numGiamGia.ThousandsSeparator = true;
            this.numGiamGia.ValueChanged += new System.EventHandler(this.numGiamGia_ValueChanged);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.Location = new System.Drawing.Point(700, 28);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(122, 19);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblThanhToan.Location = new System.Drawing.Point(950, 26);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(143, 20);
            this.lblThanhToan.TabIndex = 5;
            this.lblThanhToan.Text = "Thanh toán: 0 VNĐ";
            // 
            // btnLuuDon
            // 
            this.btnLuuDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLuuDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuDon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuuDon.ForeColor = System.Drawing.Color.White;
            this.btnLuuDon.Location = new System.Drawing.Point(1120, 655);
            this.btnLuuDon.Name = "btnLuuDon";
            this.btnLuuDon.Size = new System.Drawing.Size(100, 32);
            this.btnLuuDon.TabIndex = 4;
            this.btnLuuDon.Text = "Lưu đơn";
            this.btnLuuDon.UseVisualStyleBackColor = false;
            this.btnLuuDon.Click += new System.EventHandler(this.btnLuuDon_Click);
            // 
            // btnHuyTao
            // 
            this.btnHuyTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnHuyTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyTao.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHuyTao.ForeColor = System.Drawing.Color.White;
            this.btnHuyTao.Location = new System.Drawing.Point(1230, 655);
            this.btnHuyTao.Name = "btnHuyTao";
            this.btnHuyTao.Size = new System.Drawing.Size(100, 32);
            this.btnHuyTao.TabIndex = 5;
            this.btnHuyTao.Text = "Hủy";
            this.btnHuyTao.UseVisualStyleBackColor = false;
            this.btnHuyTao.Click += new System.EventHandler(this.btnHuyTao_Click);
            // 
            // frmDonHang
            // 
            this.ClientSize = new System.Drawing.Size(1349, 797);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "frmDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đơn Hàng";
            this.Load += new System.EventHandler(this.frmDonHang_Load);
            this.tabControl.ResumeLayout(false);
            this.tabDanhSach.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.grpChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.tabTaoDon.ResumeLayout(false);
            this.grpKhachHang.ResumeLayout(false);
            this.grpKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemSuDung)).EndInit();
            this.grpChonSP.ResumeLayout(false);
            this.grpChonSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            this.grpGioHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).EndInit();
            this.ResumeLayout(false);

        }

        // ── Khai báo controls ──────────────────────────
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDanhSach;
        private System.Windows.Forms.TabPage tabTaoDon;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.Button btnTaoDon;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.GroupBox grpKhachHang;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblHangKH;
        private System.Windows.Forms.Label lblDiemKH;
        private System.Windows.Forms.Label lblDiemSuDung;
        private System.Windows.Forms.NumericUpDown numDiemSuDung;
        private System.Windows.Forms.GroupBox grpChonSP;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.Label lblSerialKey;
        private System.Windows.Forms.TextBox txtSerialKey;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.Button btnXoaKhoiGio;
        private System.Windows.Forms.GroupBox grpGioHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.Label lblPTTT;
        private System.Windows.Forms.ComboBox cboPhuongThucTT;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.NumericUpDown numGiamGia;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Button btnLuuDon;
        private System.Windows.Forms.Button btnHuyTao;
    }
}