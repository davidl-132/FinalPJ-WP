namespace FinalPJ_WP.UI
{
    partial class frmSanPham
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblTenGame = new System.Windows.Forms.Label();
            this.txtTenGame = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.lblNhaPhatHanh = new System.Windows.Forms.Label();
            this.txtNhaPhatHanh = new System.Windows.Forms.TextBox();
            this.lblNhaPhatTrien = new System.Windows.Forms.Label();
            this.txtNhaPhatTrien = new System.Windows.Forms.TextBox();
            this.lblNenTang = new System.Windows.Forms.Label();
            this.txtNenTang = new System.Windows.Forms.TextBox();
            this.lblNgayPhatHanh = new System.Windows.Forms.Label();
            this.dtpNgayPhatHanh = new System.Windows.Forms.DateTimePicker();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.rdoVatLy = new System.Windows.Forms.RadioButton();
            this.rdoDigital = new System.Windows.Forms.RadioButton();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.grpVatLy = new System.Windows.Forms.GroupBox();
            this.lblMaSKU = new System.Windows.Forms.Label();
            this.txtMaSKU = new System.Windows.Forms.TextBox();
            this.lblLoaiDia = new System.Windows.Forms.Label();
            this.txtLoaiDia = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.grpDigital = new System.Windows.Forms.GroupBox();
            this.lblNenTangPhanPhoi = new System.Windows.Forms.Label();
            this.txtNenTangPhanPhoi = new System.Windows.Forms.TextBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.txtKhuVuc = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLocTheLoai = new System.Windows.Forms.Label();
            this.cboLocTheLoai = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.chkHienSanPhamAn = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.grpVatLy.SuspendLayout();
            this.grpDigital.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.grpTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.ColumnHeadersHeight = 35;
            this.dgvSanPham.Location = new System.Drawing.Point(12, 80);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.Size = new System.Drawing.Size(912, 790);
            this.dgvSanPham.TabIndex = 1;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblTenGame);
            this.grpThongTin.Controls.Add(this.txtTenGame);
            this.grpThongTin.Controls.Add(this.lblTheLoai);
            this.grpThongTin.Controls.Add(this.cboTheLoai);
            this.grpThongTin.Controls.Add(this.lblNhaPhatHanh);
            this.grpThongTin.Controls.Add(this.txtNhaPhatHanh);
            this.grpThongTin.Controls.Add(this.lblNhaPhatTrien);
            this.grpThongTin.Controls.Add(this.txtNhaPhatTrien);
            this.grpThongTin.Controls.Add(this.lblNenTang);
            this.grpThongTin.Controls.Add(this.txtNenTang);
            this.grpThongTin.Controls.Add(this.lblNgayPhatHanh);
            this.grpThongTin.Controls.Add(this.dtpNgayPhatHanh);
            this.grpThongTin.Controls.Add(this.lblGiaBan);
            this.grpThongTin.Controls.Add(this.txtGiaBan);
            this.grpThongTin.Controls.Add(this.rdoVatLy);
            this.grpThongTin.Controls.Add(this.rdoDigital);
            this.grpThongTin.Controls.Add(this.chkTrangThai);
            this.grpThongTin.Controls.Add(this.grpVatLy);
            this.grpThongTin.Controls.Add(this.grpDigital);
            this.grpThongTin.Controls.Add(this.lblMoTa);
            this.grpThongTin.Controls.Add(this.txtMoTa);
            this.grpThongTin.Controls.Add(this.lblHinhAnh);
            this.grpThongTin.Controls.Add(this.txtHinhAnh);
            this.grpThongTin.Controls.Add(this.btnChonAnh);
            this.grpThongTin.Controls.Add(this.picHinhAnh);
            this.grpThongTin.Location = new System.Drawing.Point(930, 10);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(395, 860);
            this.grpThongTin.TabIndex = 2;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin sản phẩm";
            // 
            // lblTenGame
            // 
            this.lblTenGame.AutoSize = true;
            this.lblTenGame.Location = new System.Drawing.Point(10, 25);
            this.lblTenGame.Name = "lblTenGame";
            this.lblTenGame.Size = new System.Drawing.Size(77, 17);
            this.lblTenGame.TabIndex = 0;
            this.lblTenGame.Text = "Tên game *:";
            // 
            // txtTenGame
            // 
            this.txtTenGame.Location = new System.Drawing.Point(130, 22);
            this.txtTenGame.Name = "txtTenGame";
            this.txtTenGame.Size = new System.Drawing.Size(240, 24);
            this.txtTenGame.TabIndex = 1;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(10, 60);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(57, 17);
            this.lblTheLoai.TabIndex = 2;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.Location = new System.Drawing.Point(130, 57);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(240, 25);
            this.cboTheLoai.TabIndex = 3;
            // 
            // lblNhaPhatHanh
            // 
            this.lblNhaPhatHanh.AutoSize = true;
            this.lblNhaPhatHanh.Location = new System.Drawing.Point(10, 95);
            this.lblNhaPhatHanh.Name = "lblNhaPhatHanh";
            this.lblNhaPhatHanh.Size = new System.Drawing.Size(97, 17);
            this.lblNhaPhatHanh.TabIndex = 4;
            this.lblNhaPhatHanh.Text = "Nhà phát hành:";
            // 
            // txtNhaPhatHanh
            // 
            this.txtNhaPhatHanh.Location = new System.Drawing.Point(130, 92);
            this.txtNhaPhatHanh.Name = "txtNhaPhatHanh";
            this.txtNhaPhatHanh.Size = new System.Drawing.Size(240, 24);
            this.txtNhaPhatHanh.TabIndex = 5;
            // 
            // lblNhaPhatTrien
            // 
            this.lblNhaPhatTrien.AutoSize = true;
            this.lblNhaPhatTrien.Location = new System.Drawing.Point(10, 130);
            this.lblNhaPhatTrien.Name = "lblNhaPhatTrien";
            this.lblNhaPhatTrien.Size = new System.Drawing.Size(95, 17);
            this.lblNhaPhatTrien.TabIndex = 6;
            this.lblNhaPhatTrien.Text = "Nhà phát triển:";
            // 
            // txtNhaPhatTrien
            // 
            this.txtNhaPhatTrien.Location = new System.Drawing.Point(130, 127);
            this.txtNhaPhatTrien.Name = "txtNhaPhatTrien";
            this.txtNhaPhatTrien.Size = new System.Drawing.Size(240, 24);
            this.txtNhaPhatTrien.TabIndex = 7;
            // 
            // lblNenTang
            // 
            this.lblNenTang.AutoSize = true;
            this.lblNenTang.Location = new System.Drawing.Point(10, 165);
            this.lblNenTang.Name = "lblNenTang";
            this.lblNenTang.Size = new System.Drawing.Size(65, 17);
            this.lblNenTang.TabIndex = 8;
            this.lblNenTang.Text = "Nền tảng:";
            // 
            // txtNenTang
            // 
            this.txtNenTang.Location = new System.Drawing.Point(130, 162);
            this.txtNenTang.Name = "txtNenTang";
            this.txtNenTang.Size = new System.Drawing.Size(240, 24);
            this.txtNenTang.TabIndex = 9;
            // 
            // lblNgayPhatHanh
            // 
            this.lblNgayPhatHanh.AutoSize = true;
            this.lblNgayPhatHanh.Location = new System.Drawing.Point(10, 200);
            this.lblNgayPhatHanh.Name = "lblNgayPhatHanh";
            this.lblNgayPhatHanh.Size = new System.Drawing.Size(104, 17);
            this.lblNgayPhatHanh.TabIndex = 10;
            this.lblNgayPhatHanh.Text = "Ngày phát hành:";
            // 
            // dtpNgayPhatHanh
            // 
            this.dtpNgayPhatHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayPhatHanh.Location = new System.Drawing.Point(130, 197);
            this.dtpNgayPhatHanh.Name = "dtpNgayPhatHanh";
            this.dtpNgayPhatHanh.Size = new System.Drawing.Size(240, 24);
            this.dtpNgayPhatHanh.TabIndex = 11;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(10, 235);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(104, 17);
            this.lblGiaBan.TabIndex = 12;
            this.lblGiaBan.Text = "Giá bán (VNĐ) *:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(130, 232);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(240, 24);
            this.txtGiaBan.TabIndex = 13;
            // 
            // rdoVatLy
            // 
            this.rdoVatLy.AutoSize = true;
            this.rdoVatLy.Checked = true;
            this.rdoVatLy.Location = new System.Drawing.Point(10, 295);
            this.rdoVatLy.Name = "rdoVatLy";
            this.rdoVatLy.Size = new System.Drawing.Size(80, 21);
            this.rdoVatLy.TabIndex = 14;
            this.rdoVatLy.Text = "Vật lý";
            this.rdoVatLy.CheckedChanged += new System.EventHandler(this.rdoVatLy_CheckedChanged);
            // 
            // rdoDigital
            // 
            this.rdoDigital.AutoSize = true;
            this.rdoDigital.Location = new System.Drawing.Point(100, 295);
            this.rdoDigital.Name = "rdoDigital";
            this.rdoDigital.Size = new System.Drawing.Size(80, 21);
            this.rdoDigital.TabIndex = 15;
            this.rdoDigital.Text = "Digital";
            this.rdoDigital.CheckedChanged += new System.EventHandler(this.rdoDigital_CheckedChanged);
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Checked = true;
            this.chkTrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrangThai.Location = new System.Drawing.Point(10, 268);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(126, 21);
            this.chkTrangThai.TabIndex = 15;
            this.chkTrangThai.Text = "Đang kinh doanh";
            // 
            // grpVatLy
            // 
            this.grpVatLy.Controls.Add(this.lblMaSKU);
            this.grpVatLy.Controls.Add(this.txtMaSKU);
            this.grpVatLy.Controls.Add(this.lblLoaiDia);
            this.grpVatLy.Controls.Add(this.txtLoaiDia);
            this.grpVatLy.Controls.Add(this.lblTinhTrang);
            this.grpVatLy.Controls.Add(this.cboTinhTrang);
            this.grpVatLy.Location = new System.Drawing.Point(5, 325);
            this.grpVatLy.Name = "grpVatLy";
            this.grpVatLy.Size = new System.Drawing.Size(378, 115);
            this.grpVatLy.TabIndex = 16;
            this.grpVatLy.TabStop = false;
            this.grpVatLy.Text = "Thông tin vật lý";
            // 
            // lblMaSKU
            // 
            this.lblMaSKU.AutoSize = true;
            this.lblMaSKU.Location = new System.Drawing.Point(10, 25);
            this.lblMaSKU.Name = "lblMaSKU";
            this.lblMaSKU.Size = new System.Drawing.Size(58, 17);
            this.lblMaSKU.TabIndex = 0;
            this.lblMaSKU.Text = "Mã SKU:";
            // 
            // txtMaSKU
            // 
            this.txtMaSKU.Location = new System.Drawing.Point(120, 22);
            this.txtMaSKU.Name = "txtMaSKU";
            this.txtMaSKU.Size = new System.Drawing.Size(240, 24);
            this.txtMaSKU.TabIndex = 16;
            // 
            // lblLoaiDia
            // 
            this.lblLoaiDia.AutoSize = true;
            this.lblLoaiDia.Location = new System.Drawing.Point(10, 57);
            this.lblLoaiDia.Name = "lblLoaiDia";
            this.lblLoaiDia.Size = new System.Drawing.Size(57, 17);
            this.lblLoaiDia.TabIndex = 17;
            this.lblLoaiDia.Text = "Loại đĩa:";
            // 
            // txtLoaiDia
            // 
            this.txtLoaiDia.Location = new System.Drawing.Point(120, 54);
            this.txtLoaiDia.Name = "txtLoaiDia";
            this.txtLoaiDia.Size = new System.Drawing.Size(240, 24);
            this.txtLoaiDia.TabIndex = 17;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(10, 88);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(70, 17);
            this.lblTinhTrang.TabIndex = 18;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Moi",
            "LikeNew",
            "Cu"});
            this.cboTinhTrang.Location = new System.Drawing.Point(120, 85);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(240, 25);
            this.cboTinhTrang.TabIndex = 18;
            // 
            // grpDigital
            // 
            this.grpDigital.Controls.Add(this.lblNenTangPhanPhoi);
            this.grpDigital.Controls.Add(this.txtNenTangPhanPhoi);
            this.grpDigital.Controls.Add(this.lblKhuVuc);
            this.grpDigital.Controls.Add(this.txtKhuVuc);
            this.grpDigital.Location = new System.Drawing.Point(5, 450);
            this.grpDigital.Name = "grpDigital";
            this.grpDigital.Size = new System.Drawing.Size(378, 90);
            this.grpDigital.TabIndex = 17;
            this.grpDigital.TabStop = false;
            this.grpDigital.Text = "Thông tin digital";
            this.grpDigital.Visible = false;
            // 
            // lblNenTangPhanPhoi
            // 
            this.lblNenTangPhanPhoi.AutoSize = true;
            this.lblNenTangPhanPhoi.Location = new System.Drawing.Point(10, 25);
            this.lblNenTangPhanPhoi.Name = "lblNenTangPhanPhoi";
            this.lblNenTangPhanPhoi.Size = new System.Drawing.Size(128, 17);
            this.lblNenTangPhanPhoi.TabIndex = 0;
            this.lblNenTangPhanPhoi.Text = "Nền tảng phân phối:";
            // 
            // txtNenTangPhanPhoi
            // 
            this.txtNenTangPhanPhoi.Location = new System.Drawing.Point(145, 22);
            this.txtNenTangPhanPhoi.Name = "txtNenTangPhanPhoi";
            this.txtNenTangPhanPhoi.Size = new System.Drawing.Size(215, 24);
            this.txtNenTangPhanPhoi.TabIndex = 19;
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Location = new System.Drawing.Point(10, 58);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(97, 17);
            this.lblKhuVuc.TabIndex = 20;
            this.lblKhuVuc.Text = "Khu vực hỗ trợ:";
            // 
            // txtKhuVuc
            // 
            this.txtKhuVuc.Location = new System.Drawing.Point(145, 55);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.Size = new System.Drawing.Size(215, 24);
            this.txtKhuVuc.TabIndex = 20;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(10, 555);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(46, 17);
            this.lblMoTa.TabIndex = 18;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(130, 552);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(240, 55);
            this.txtMoTa.TabIndex = 21;
            // 
            // lblHinhAnh
            // 
            this.lblHinhAnh.AutoSize = true;
            this.lblHinhAnh.Location = new System.Drawing.Point(10, 620);
            this.lblHinhAnh.Name = "lblHinhAnh";
            this.lblHinhAnh.Size = new System.Drawing.Size(62, 17);
            this.lblHinhAnh.TabIndex = 22;
            this.lblHinhAnh.Text = "Hình ảnh:";
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Location = new System.Drawing.Point(130, 617);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.ReadOnly = true;
            this.txtHinhAnh.Size = new System.Drawing.Size(170, 24);
            this.txtHinhAnh.TabIndex = 22;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(305, 617);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(30, 23);
            this.btnChonAnh.TabIndex = 23;
            this.btnChonAnh.Text = "...";
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.Location = new System.Drawing.Point(10, 650);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(360, 175);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 24;
            this.picHinhAnh.TabStop = false;
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.lblTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Controls.Add(this.lblLocTheLoai);
            this.grpTimKiem.Controls.Add(this.cboLocTheLoai);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.btnReload);
            this.grpTimKiem.Controls.Add(this.chkHienSanPhamAn);
            this.grpTimKiem.Location = new System.Drawing.Point(12, 8);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(912, 60);
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // chkHienSanPhamAn
            // 
            this.chkHienSanPhamAn.AutoSize = true;
            this.chkHienSanPhamAn.Location = new System.Drawing.Point(760, 24);
            this.chkHienSanPhamAn.Name = "chkHienSanPhamAn";
            this.chkHienSanPhamAn.Size = new System.Drawing.Size(140, 21);
            this.chkHienSanPhamAn.TabIndex = 6;
            this.chkHienSanPhamAn.Text = "Hiện sản phẩm đã ẩn";
            this.chkHienSanPhamAn.CheckedChanged += new System.EventHandler(this.chkHienSanPhamAn_CheckedChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(10, 25);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(68, 17);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tên game:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(80, 22);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 24);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // lblLocTheLoai
            // 
            this.lblLocTheLoai.AutoSize = true;
            this.lblLocTheLoai.Location = new System.Drawing.Point(295, 25);
            this.lblLocTheLoai.Name = "lblLocTheLoai";
            this.lblLocTheLoai.Size = new System.Drawing.Size(57, 17);
            this.lblLocTheLoai.TabIndex = 2;
            this.lblLocTheLoai.Text = "Thể loại:";
            // 
            // cboLocTheLoai
            // 
            this.cboLocTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTheLoai.Location = new System.Drawing.Point(360, 22);
            this.cboLocTheLoai.Name = "cboLocTheLoai";
            this.cboLocTheLoai.Size = new System.Drawing.Size(180, 25);
            this.cboLocTheLoai.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(555, 20);
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
            this.btnReload.Location = new System.Drawing.Point(655, 20);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(80, 28);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(796, 875);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(908, 875);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 32);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1014, 875);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 32);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Ẩn";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(1120, 875);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 32);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnHuyBo.Enabled = false;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHuyBo.ForeColor = System.Drawing.Color.White;
            this.btnHuyBo.Location = new System.Drawing.Point(1226, 875);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(96, 32);
            this.btnHuyBo.TabIndex = 7;
            this.btnHuyBo.Text = "Hủy";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroVe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(10, 875);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(100, 32);
            this.btnTroVe.TabIndex = 8;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // frmSanPham
            // 
            this.ClientSize = new System.Drawing.Size(1349, 930);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnTroVe);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpVatLy.ResumeLayout(false);
            this.grpVatLy.PerformLayout();
            this.grpDigital.ResumeLayout(false);
            this.grpDigital.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        // ── Khai báo controls ──────────────────────────────────
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Label lblTenGame;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblNhaPhatHanh;
        private System.Windows.Forms.Label lblNhaPhatTrien;
        private System.Windows.Forms.Label lblNenTang;
        private System.Windows.Forms.Label lblNgayPhatHanh;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblLocTheLoai;
        private System.Windows.Forms.TextBox txtTenGame;
        private System.Windows.Forms.TextBox txtNhaPhatHanh;
        private System.Windows.Forms.TextBox txtNhaPhatTrien;
        private System.Windows.Forms.TextBox txtNenTang;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.ComboBox cboLocTheLoai;
        private System.Windows.Forms.DateTimePicker dtpNgayPhatHanh;
        private System.Windows.Forms.RadioButton rdoVatLy;
        private System.Windows.Forms.RadioButton rdoDigital;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.CheckBox chkHienSanPhamAn;
        // Controls mới
        private System.Windows.Forms.GroupBox grpVatLy;
        private System.Windows.Forms.Label lblMaSKU;
        private System.Windows.Forms.TextBox txtMaSKU;
        private System.Windows.Forms.Label lblLoaiDia;
        private System.Windows.Forms.TextBox txtLoaiDia;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.GroupBox grpDigital;
        private System.Windows.Forms.Label lblNenTangPhanPhoi;
        private System.Windows.Forms.TextBox txtNenTangPhanPhoi;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.TextBox txtKhuVuc;
    }
}