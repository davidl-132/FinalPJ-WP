using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FinalPJ_WP.BS_layer;

namespace FinalPJ_WP.UI
{
    public partial class frmDonHang : Form
    {
        BLDonHang blDH = new BLDonHang();
        public int MaNhanVienHienTai { get; set; } = 0;


        // Giỏ hàng tạm: MaSanPham, TenGame, SoLuong, DonGia, SerialKey, ThanhTien
        DataTable dtGioHang = null;

        // Khách hàng đang chọn
        int maKhachHangChon = 0;
        int diemHienTai = 0;

        // Nhân viên đang đăng nhập (set từ ngoài truyền vào)
        public int MaNhanVien { get; set; } = 1;

        public frmDonHang()
        {
            InitializeComponent();
        }

        // =============================================
        // LOAD FORM
        // =============================================
        private void frmDonHang_Load(object sender, EventArgs e)
        {
            KhoiTaoGioHang();
            KhoiTaoCboSanPham();
            KhoiTaoCboTrangThai();
            LoadDanhSachDon();
            ChuyenTabDanhSach();
        }

        // =============================================
        // KHỞI TẠO GIỎ HÀNG
        // =============================================
        void KhoiTaoGioHang()
        {
            dtGioHang = new DataTable();
            dtGioHang.Columns.Add("MaSanPham", typeof(int));
            dtGioHang.Columns.Add("TenGame", typeof(string));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("DonGia", typeof(decimal));
            dtGioHang.Columns.Add("SerialKey", typeof(string));

            DataColumn colTT = new DataColumn("ThanhTien", typeof(decimal));
            colTT.Expression = "SoLuong * DonGia";
            dtGioHang.Columns.Add(colTT);

            dgvGioHang.DataSource = dtGioHang;
            CauHinhCotGioHang();
        }

        void CauHinhCotGioHang()
        {
            if (dgvGioHang.Columns["MaSanPham"] != null) dgvGioHang.Columns["MaSanPham"].Visible = false;
            if (dgvGioHang.Columns["TenGame"] != null) dgvGioHang.Columns["TenGame"].HeaderText = "Tên Game";
            if (dgvGioHang.Columns["SoLuong"] != null) dgvGioHang.Columns["SoLuong"].HeaderText = "SL";
            if (dgvGioHang.Columns["DonGia"] != null) dgvGioHang.Columns["DonGia"].HeaderText = "Đơn Giá";
            if (dgvGioHang.Columns["SerialKey"] != null) dgvGioHang.Columns["SerialKey"].HeaderText = "Serial Key";
            if (dgvGioHang.Columns["ThanhTien"] != null) dgvGioHang.Columns["ThanhTien"].HeaderText = "Thành Tiền";
        }

        void KhoiTaoCboSanPham()
        {
            try
            {
                DataSet ds = blDH.LayDanhSachSanPham();
                cboSanPham.DataSource = ds.Tables[0];
                cboSanPham.DisplayMember = "TenGame";
                cboSanPham.ValueMember = "MaSanPham";
                cboSanPham.SelectedIndex = -1;
            }
            catch { }
        }

        void KhoiTaoCboTrangThai()
        {
            cboLocTrangThai.Items.Clear();
            cboLocTrangThai.Items.AddRange(new object[] { "Tất cả", "HoanThanh", "DaHuy", "ChoXuLy" });
            cboLocTrangThai.SelectedIndex = 0;
        }

        // =============================================
        // LOAD DANH SÁCH ĐƠN HÀNG
        // =============================================
        void LoadDanhSachDon()
        {
            try
            {
                DataSet ds = blDH.LayTatCaDonHang();
                dgvDonHang.DataSource = ds.Tables[0];
                CauHinhCotDonHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CauHinhCotDonHang()
        {
            if (dgvDonHang.Columns["MaKhachHang"] != null) dgvDonHang.Columns["MaKhachHang"].Visible = false;

            if (dgvDonHang.Columns["MaDonHang"] != null) dgvDonHang.Columns["MaDonHang"].HeaderText = "Mã ĐH";
            if (dgvDonHang.Columns["TenKhachHang"] != null) dgvDonHang.Columns["TenKhachHang"].HeaderText = "Khách Hàng";
            if (dgvDonHang.Columns["SoDienThoai"] != null) dgvDonHang.Columns["SoDienThoai"].HeaderText = "SĐT";
            if (dgvDonHang.Columns["TenNhanVien"] != null) dgvDonHang.Columns["TenNhanVien"].HeaderText = "Nhân Viên";
            if (dgvDonHang.Columns["NgayBan"] != null) dgvDonHang.Columns["NgayBan"].HeaderText = "Ngày Bán";
            if (dgvDonHang.Columns["TongTien"] != null) dgvDonHang.Columns["TongTien"].HeaderText = "Tổng Tiền";
            if (dgvDonHang.Columns["GiamGia"] != null) dgvDonHang.Columns["GiamGia"].HeaderText = "Giảm Giá";
            if (dgvDonHang.Columns["ThanhToan"] != null) dgvDonHang.Columns["ThanhToan"].HeaderText = "Thanh Toán";
            if (dgvDonHang.Columns["PhuongThucTT"] != null) dgvDonHang.Columns["PhuongThucTT"].HeaderText = "PTTT";
            if (dgvDonHang.Columns["DiemSuDung"] != null) dgvDonHang.Columns["DiemSuDung"].HeaderText = "Điểm Dùng";
            if (dgvDonHang.Columns["DiemTichLuy"] != null) dgvDonHang.Columns["DiemTichLuy"].HeaderText = "Điểm Tích";
            if (dgvDonHang.Columns["TrangThai"] != null) dgvDonHang.Columns["TrangThai"].HeaderText = "Trạng Thái";

            dgvDonHang.AutoResizeColumns();
            dgvDonHang.ReadOnly = true;
            dgvDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // =============================================
        // CLICK DÒNG ĐƠN HÀNG — load chi tiết
        // =============================================
        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                int maDH = Convert.ToInt32(dgvDonHang.Rows[e.RowIndex].Cells["MaDonHang"].Value);
                DataSet ds = blDH.LayChiTietDonHang(maDH);
                dgvChiTiet.DataSource = ds.Tables[0];
                CauHinhCotChiTiet();

                // Bật nút hủy chỉ khi đơn chưa hủy
                string tt = dgvDonHang.Rows[e.RowIndex].Cells["TrangThai"].Value?.ToString();
                btnHuyDon.Enabled = (tt != "DaHuy");
            }
            catch { }
        }

        void CauHinhCotChiTiet()
        {
            if (dgvChiTiet.Columns["MaChiTietDH"] != null) dgvChiTiet.Columns["MaChiTietDH"].Visible = false;
            if (dgvChiTiet.Columns["MaSanPham"] != null) dgvChiTiet.Columns["MaSanPham"].Visible = false;
            if (dgvChiTiet.Columns["TenGame"] != null) dgvChiTiet.Columns["TenGame"].HeaderText = "Tên Game";
            if (dgvChiTiet.Columns["SoLuong"] != null) dgvChiTiet.Columns["SoLuong"].HeaderText = "SL";
            if (dgvChiTiet.Columns["DonGia"] != null) dgvChiTiet.Columns["DonGia"].HeaderText = "Đơn Giá";
            if (dgvChiTiet.Columns["ThanhTien"] != null) dgvChiTiet.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            if (dgvChiTiet.Columns["SerialKey"] != null) dgvChiTiet.Columns["SerialKey"].HeaderText = "Serial Key";
            dgvChiTiet.AutoResizeColumns();
            dgvChiTiet.ReadOnly = true;
        }

        // =============================================
        // TÌM KIẾM ĐƠN HÀNG
        // =============================================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();
                string trangThai = cboLocTrangThai.SelectedItem?.ToString() ?? "Tất cả";
                DataSet ds = blDH.TimKiemDonHang(tuKhoa, trangThai);
                dgvDonHang.DataSource = ds.Tables[0];
                CauHinhCotDonHang();
                dgvChiTiet.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnTimKiem_Click(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLocTrangThai.SelectedIndex = 0;
            LoadDanhSachDon();
            dgvChiTiet.DataSource = null;
            btnHuyDon.Enabled = false;
        }

        // =============================================
        // HỦY ĐƠN HÀNG
        // =============================================
        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.CurrentRow == null) return;

            int maDH = Convert.ToInt32(dgvDonHang.CurrentRow.Cells["MaDonHang"].Value);
            string tenKH = dgvDonHang.CurrentRow.Cells["TenKhachHang"].Value?.ToString();

            DialogResult traloi = MessageBox.Show(
                "Chắc muốn hủy đơn #" + maDH + " của " + tenKH + " không?\nTồn kho sẽ được hoàn lại.",
                "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (traloi == DialogResult.Yes)
            {
                string err = "";
                if (blDH.HuyDonHang(maDH, ref err))
                {
                    MessageBox.Show("Đã hủy đơn hàng #" + maDH + "!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDon();
                    dgvChiTiet.DataSource = null;
                    btnHuyDon.Enabled = false;
                }
                else
                    MessageBox.Show("Lỗi: " + err, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =============================================
        // CHUYỂN SANG TAB TẠO ĐƠN
        // =============================================
        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            XoaTrangTaoDon();
            tabControl.SelectedTab = tabTaoDon;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ChuyenTabDanhSach()
        {
            tabControl.SelectedTab = tabDanhSach;
        }

        // =============================================
        // TÌM KHÁCH HÀNG THEO SĐT
        // =============================================
        private void btnTimKH_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataSet ds = blDH.TimKhachHangTheoSDT(sdt);
                if (ds == null || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng. Đơn sẽ ghi là khách vãng lai.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaThongTinKH();
                    return;
                }

                // Nếu tìm được — lấy dòng đầu tiên
                DataRow r = ds.Tables[0].Rows[0];
                maKhachHangChon = Convert.ToInt32(r["MaKhachHang"]);
                diemHienTai = Convert.ToInt32(r["DiemHienTai"]);

                lblTenKH.Text = "Họ tên: " + r["HoTen"];
                lblHangKH.Text = "Hạng: " + r["HangThanhVien"];
                lblDiemKH.Text = "Điểm hiện tại: " + diemHienTai;
                numDiemSuDung.Maximum = diemHienTai;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm khách hàng: " + ex.Message);
            }
        }

        void XoaThongTinKH()
        {
            maKhachHangChon = 0;
            diemHienTai = 0;
            lblTenKH.Text = "Họ tên: —";
            lblHangKH.Text = "Hạng: —";
            lblDiemKH.Text = "Điểm hiện tại: —";
            numDiemSuDung.Maximum = 0;
            numDiemSuDung.Value = 0;
        }

        // =============================================
        // THÊM SẢN PHẨM VÀO GIỎ HÀNG
        // =============================================
        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maSP = Convert.ToInt32(cboSanPham.SelectedValue);
            string tenGame = cboSanPham.Text;
            int soLuong = (int)numSoLuong.Value;
            decimal donGia = numDonGia.Value;
            string serial = txtSerialKey.Text.Trim();

            // Kiểm tra trùng — nếu đã có thì cộng số lượng
            foreach (DataRow row in dtGioHang.Rows)
            {
                if ((int)row["MaSanPham"] == maSP)
                {
                    row["SoLuong"] = (int)row["SoLuong"] + soLuong;
                    TinhTongTien();
                    return;
                }
            }

            dtGioHang.Rows.Add(maSP, tenGame, soLuong, donGia, serial);
            TinhTongTien();
        }

        // =============================================
        // XÓA DÒNG KHỎI GIỎ HÀNG
        // =============================================
        private void btnXoaKhoiGio_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null) return;
            int idx = dgvGioHang.CurrentRow.Index;
            dtGioHang.Rows[idx].Delete();
            TinhTongTien();
        }

        // =============================================
        // TÍNH TỔNG TIỀN
        // =============================================
        void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataRow row in dtGioHang.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                    tong += (decimal)row["ThanhTien"];
            }
            lblTongTien.Text = "Tổng tiền: " + tong.ToString("N0") + " VNĐ";
            decimal giamGia = numGiamGia.Value;
            decimal thanh = tong - giamGia;
            lblThanhToan.Text = "Thanh toán: " + (thanh < 0 ? 0 : thanh).ToString("N0") + " VNĐ";
        }

        private void numGiamGia_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        // =============================================
        // CHỌN SẢN PHẨM — tự điền giá
        // =============================================
        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue == null) return;
            try
            {
                DataRowView drv = (DataRowView)cboSanPham.SelectedItem;
                numDonGia.Value = Convert.ToDecimal(drv["GiaBan"]);
                bool isDigital = Convert.ToInt32(drv["LoaiSanPham"]) == 1;
                lblSerialKey.Visible = isDigital;
                txtSerialKey.Visible = isDigital;
            }
            catch { }
        }

        // =============================================
        // LƯU ĐƠN HÀNG
        // =============================================
        private void btnLuuDon_Click(object sender, EventArgs e)
        {
            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống! Vui lòng thêm sản phẩm.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongTien = 0;
            foreach (DataRow row in dtGioHang.Rows)
                tongTien += (decimal)row["ThanhTien"];

            decimal giamGia = numGiamGia.Value;
            int diemDung = (int)numDiemSuDung.Value;
            int diemTich = (int)(tongTien / 10000); // 1 điểm / 10.000 VNĐ
            string pttt = cboPhuongThucTT.SelectedItem?.ToString() ?? "TienMat";

            string err = "";
            bool ketQua = blDH.TaoDonHang(
                maKhachHangChon, MaNhanVienHienTai,
                tongTien, giamGia, pttt,
                diemDung, diemTich,
                dtGioHang, ref err);

            if (ketQua)
            {
                MessageBox.Show("Tạo đơn hàng thành công!\nĐiểm tích lũy: +" + diemTich, "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                XoaTrangTaoDon();
                LoadDanhSachDon();
                ChuyenTabDanhSach();
            }
            else
                MessageBox.Show("Lỗi: " + err, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // =============================================
        // HỦY TẠO ĐƠN
        // =============================================
        private void btnHuyTao_Click(object sender, EventArgs e)
        {
            XoaTrangTaoDon();
            ChuyenTabDanhSach();
        }

        void XoaTrangTaoDon()
        {
            txtSDT.Clear();
            XoaThongTinKH();
            dtGioHang.Clear();
            cboSanPham.SelectedIndex = -1;
            numSoLuong.Value = 1;
            numDonGia.Value = 0;
            numGiamGia.Value = 0;
            numDiemSuDung.Value = 0;
            txtSerialKey.Clear();
            cboPhuongThucTT.SelectedIndex = 0;
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            lblThanhToan.Text = "Thanh toán: 0 VNĐ";
            lblSerialKey.Visible = false;
            txtSerialKey.Visible = false;
        }
    }
}