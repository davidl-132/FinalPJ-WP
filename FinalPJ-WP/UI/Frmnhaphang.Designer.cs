namespace FinalPJ_WP
{
    partial class frmNhapHang
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
            this.tabTaoPhieu = new System.Windows.Forms.TabPage();

            // Tab DanhSach controls
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.lblMaPhieuChon = new System.Windows.Forms.Label();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblTongTienChon = new System.Windows.Forms.Label();
            this.lblTrangThaiChon = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();

            // Tab TaoPhieu controls
            this.grpNCC = new System.Windows.Forms.GroupBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.grpThemSP = new System.Windows.Forms.GroupBox();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.dgvTaoPhieu = new System.Windows.Forms.DataGridView();
            this.lblTongTienTao = new System.Windows.Forms.Label();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            this.tabDanhSach.SuspendLayout();
            this.tabTaoPhieu.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.grpChiTiet.SuspendLayout();
            this.grpNCC.SuspendLayout();
            this.grpThemSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaoPhieu)).BeginInit();
            this.SuspendLayout();

            // =============================================
            // tabControl
            // =============================================
            this.tabControl.Controls.Add(this.tabDanhSach);
            this.tabControl.Controls.Add(this.tabTaoPhieu);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1100, 680);
            this.tabControl.TabIndex = 0;

            // =============================================
            // tabDanhSach
            // =============================================
            this.tabDanhSach.Controls.Add(this.grpTimKiem);
            this.tabDanhSach.Controls.Add(this.dgvPhieuNhap);
            this.tabDanhSach.Controls.Add(this.grpChiTiet);
            this.tabDanhSach.Controls.Add(this.lblTong);
            this.tabDanhSach.Controls.Add(this.btnThem);
            this.tabDanhSach.Controls.Add(this.btnHuy);
            this.tabDanhSach.Controls.Add(this.btnTroVe);
            this.tabDanhSach.Location = new System.Drawing.Point(4, 26);
            this.tabDanhSach.Name = "tabDanhSach";
            this.tabDanhSach.Size = new System.Drawing.Size(1092, 650);
            this.tabDanhSach.TabIndex = 0;
            this.tabDanhSach.Text = "  Danh sách phiếu nhập  ";

            // grpTimKiem
            this.grpTimKiem.Controls.Add(this.lblTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.btnReload);
            this.grpTimKiem.Location = new System.Drawing.Point(10, 10);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(700, 55);
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";

            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(10, 22);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Text = "NCC / NV / TrangThai:";

            this.txtTimKiem.Location = new System.Drawing.Point(155, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 24);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);

            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(365, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 28);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

            this.btnReload.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(465, 18);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(90, 28);
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);

            // dgvPhieuNhap
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(10, 75);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersVisible = false;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(1070, 250);
            this.dgvPhieuNhap.TabIndex = 1;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);

            // grpChiTiet
            this.grpChiTiet.Controls.Add(this.lblMaPhieuChon);
            this.grpChiTiet.Controls.Add(this.lblNhaCungCap);
            this.grpChiTiet.Controls.Add(this.lblNgayNhap);
            this.grpChiTiet.Controls.Add(this.lblTongTienChon);
            this.grpChiTiet.Controls.Add(this.lblTrangThaiChon);
            this.grpChiTiet.Controls.Add(this.dgvChiTiet);
            this.grpChiTiet.Location = new System.Drawing.Point(10, 335);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(1070, 260);
            this.grpChiTiet.TabIndex = 2;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "chi tiết phiếu nhập đang chọn";

            this.lblMaPhieuChon.AutoSize = true;
            this.lblMaPhieuChon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMaPhieuChon.Location = new System.Drawing.Point(10, 22);
            this.lblMaPhieuChon.Name = "lblMaPhieuChon";
            this.lblMaPhieuChon.Text = "Phieu: —";

            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Location = new System.Drawing.Point(130, 22);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Text = "NCC: —";

            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(400, 22);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Text = "Ngày: —";

            this.lblTongTienChon.AutoSize = true;
            this.lblTongTienChon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTongTienChon.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblTongTienChon.Location = new System.Drawing.Point(600, 22);
            this.lblTongTienChon.Name = "lblTongTienChon";
            this.lblTongTienChon.Text = "Tổng tiền: —";

            this.lblTrangThaiChon.AutoSize = true;
            this.lblTrangThaiChon.Location = new System.Drawing.Point(850, 22);
            this.lblTrangThaiChon.Name = "lblTrangThaiChon";
            this.lblTrangThaiChon.Text = "Trạng thái: —";

            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.Location = new System.Drawing.Point(10, 45);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(1050, 200);
            this.dgvChiTiet.TabIndex = 0;

            // lblTong + buttons
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTong.Location = new System.Drawing.Point(750, 25);
            this.lblTong.Name = "lblTong";
            this.lblTong.Text = "Tổng phiếu đã nhập: 0";

            this.btnThem.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(820, 605);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 32);
            this.btnThem.Text = "Tạo phiếu nhập";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(940, 605);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(70, 32);
            this.btnHuy.Text = "Hủy phiếu";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(1020, 605);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(60, 32);
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);

            // =============================================
            // tabTaoPhieu
            // =============================================
            this.tabTaoPhieu.Controls.Add(this.grpNCC);
            this.tabTaoPhieu.Controls.Add(this.grpThemSP);
            this.tabTaoPhieu.Controls.Add(this.dgvTaoPhieu);
            this.tabTaoPhieu.Controls.Add(this.lblTongTienTao);
            this.tabTaoPhieu.Controls.Add(this.btnLuuPhieu);
            this.tabTaoPhieu.Controls.Add(this.btnHuyBo);
            this.tabTaoPhieu.Location = new System.Drawing.Point(4, 26);
            this.tabTaoPhieu.Name = "tabTaoPhieu";
            this.tabTaoPhieu.Size = new System.Drawing.Size(1092, 650);
            this.tabTaoPhieu.TabIndex = 1;
            this.tabTaoPhieu.Text = "  Tạo phiếu nhập mới  ";

            // grpNCC
            this.grpNCC.Controls.Add(this.lblNCC);
            this.grpNCC.Controls.Add(this.cboNhaCungCap);
            this.grpNCC.Controls.Add(this.lblGhiChu);
            this.grpNCC.Controls.Add(this.txtGhiChu);
            this.grpNCC.Location = new System.Drawing.Point(10, 10);
            this.grpNCC.Name = "grpNCC";
            this.grpNCC.Size = new System.Drawing.Size(700, 70);
            this.grpNCC.TabIndex = 0;
            this.grpNCC.TabStop = false;
            this.grpNCC.Text = "thông tin phiếu nhập";

            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(10, 30);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Text = "Nhà Cung Cấp (*):";

            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.Location = new System.Drawing.Point(130, 27);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(200, 25);
            this.cboNhaCungCap.TabIndex = 0;

            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(345, 30);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Text = "Ghi Chú :";

            this.txtGhiChu.Location = new System.Drawing.Point(410, 27);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(270, 24);
            this.txtGhiChu.TabIndex = 1;

            // grpThemSP
            this.grpThemSP.Controls.Add(this.lblSanPham);
            this.grpThemSP.Controls.Add(this.cboSanPham);
            this.grpThemSP.Controls.Add(this.lblSoLuong);
            this.grpThemSP.Controls.Add(this.numSoLuong);
            this.grpThemSP.Controls.Add(this.lblDonGia);
            this.grpThemSP.Controls.Add(this.numDonGia);
            this.grpThemSP.Controls.Add(this.btnThemSP);
            this.grpThemSP.Controls.Add(this.btnXoaSP);
            this.grpThemSP.Location = new System.Drawing.Point(10, 90);
            this.grpThemSP.Name = "grpThemSP";
            this.grpThemSP.Size = new System.Drawing.Size(1070, 70);
            this.grpThemSP.TabIndex = 1;
            this.grpThemSP.TabStop = false;
            this.grpThemSP.Text = "Thêm sản phẩm vào phiếu nhập";

            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Location = new System.Drawing.Point(10, 30);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Text = "Sản phẩm:";

            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.Location = new System.Drawing.Point(80, 27);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(300, 25);
            this.cboSanPham.TabIndex = 0;
            this.cboSanPham.SelectedIndexChanged += new System.EventHandler(this.cboSanPham_SelectedIndexChanged);

            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(395, 30);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Text = "Số lượng:";

            this.numSoLuong.Location = new System.Drawing.Point(460, 27);
            this.numSoLuong.Minimum = 1;
            this.numSoLuong.Maximum = 9999;
            this.numSoLuong.Value = 1;
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(80, 24);
            this.numSoLuong.TabIndex = 1;

            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(555, 30);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Text = "Đơn giá nhập:";

            this.numDonGia.Location = new System.Drawing.Point(650, 27);
            this.numDonGia.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(150, 24);
            this.numDonGia.TabIndex = 2;
            this.numDonGia.ThousandsSeparator = true;

            this.btnThemSP.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(820, 25);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(100, 28);
            this.btnThemSP.Text = "+ Them SP";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);

            this.btnXoaSP.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Location = new System.Drawing.Point(930, 25);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(100, 28);
            this.btnXoaSP.Text = "Xóa Dòng";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);

            // dgvTaoPhieu
            this.dgvTaoPhieu.AllowUserToAddRows = false;
            this.dgvTaoPhieu.AllowUserToDeleteRows = false;
            this.dgvTaoPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaoPhieu.Location = new System.Drawing.Point(10, 170);
            this.dgvTaoPhieu.Name = "dgvTaoPhieu";
            this.dgvTaoPhieu.ReadOnly = true;
            this.dgvTaoPhieu.RowHeadersVisible = false;
            this.dgvTaoPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaoPhieu.Size = new System.Drawing.Size(1070, 400);
            this.dgvTaoPhieu.TabIndex = 2;

            // lblTongTienTao
            this.lblTongTienTao.AutoSize = true;
            this.lblTongTienTao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTienTao.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblTongTienTao.Location = new System.Drawing.Point(10, 580);
            this.lblTongTienTao.Name = "lblTongTienTao";
            this.lblTongTienTao.Text = "Tổng Tiền: 0 VND";

            // btnLuuPhieu
            this.btnLuuPhieu.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnLuuPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPhieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuuPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLuuPhieu.Location = new System.Drawing.Point(870, 575);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(100, 32);
            this.btnLuuPhieu.Text = "Lưu phiếu";
            this.btnLuuPhieu.UseVisualStyleBackColor = false;
            this.btnLuuPhieu.Click += new System.EventHandler(this.btnLuuPhieu_Click);

            // btnHuyBo
            this.btnHuyBo.BackColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHuyBo.ForeColor = System.Drawing.Color.White;
            this.btnHuyBo.Location = new System.Drawing.Point(980, 575);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(100, 32);
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);

            // =============================================
            // frmNhapHang
            // =============================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí phiếu nhập";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);

            this.tabControl.ResumeLayout(false);
            this.tabDanhSach.ResumeLayout(false);
            this.tabTaoPhieu.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.grpChiTiet.ResumeLayout(false);
            this.grpChiTiet.PerformLayout();
            this.grpNCC.ResumeLayout(false);
            this.grpNCC.PerformLayout();
            this.grpThemSP.ResumeLayout(false);
            this.grpThemSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaoPhieu)).EndInit();
            this.ResumeLayout(false);
        }

        // Controls
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDanhSach;
        private System.Windows.Forms.TabPage tabTaoPhieu;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label lblMaPhieuChon;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblTongTienChon;
        private System.Windows.Forms.Label lblTrangThaiChon;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.GroupBox grpNCC;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.GroupBox grpThemSP;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.DataGridView dgvTaoPhieu;
        private System.Windows.Forms.Label lblTongTienTao;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.Button btnHuyBo;
    }
}