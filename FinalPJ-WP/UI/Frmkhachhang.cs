using FinalPJ_WP.BS_layer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FinalPJ_WP
{
    public partial class frmKhachHang : Form
    {
        bool Them;
        string err = "";
        int maKHDangChon = 0;

        BLKhachHang blKH = new BLKhachHang();

        public frmKhachHang()
        {
            InitializeComponent();
        }

        // =============================================
        // LOAD FORM
        // =============================================
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            CauHinhGrid();
            LoadData();
        }

        // =============================================
        // CẤU HÌNH GRID
        // =============================================
        void CauHinhGrid()
        {
            dgvKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvKhachHang.EnableHeadersVisualStyles = false;

            dgvLichSu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvLichSu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLichSu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvLichSu.EnableHeadersVisualStyles = false;
        }

        // =============================================
        // LOAD DATA
        // =============================================
        void LoadData()
        {
            try
            {
                DataSet ds = blKH.LayKhachHang();
                dgvKhachHang.DataSource = ds.Tables[0];
                dgvKhachHang.AutoResizeColumns();
                AnCotGrid();
                ToMauHangThanhVien();

                lblTong.Text = "Tổng: " + blKH.DemKhachHang() + " khách hàng";

                ResetPanel();

                if (dgvKhachHang.Rows.Count > 0)
                    dgvKhachHang_CellClick(null, new DataGridViewCellEventArgs(0, 0));
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu khách hàng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =============================================
        // ẨN CỘT KHÔNG CẦN THIẾT TRÊN GRID
        // =============================================
        void AnCotGrid()
        {
            string[] anCot = { "DiaChi", "NgayDangKy", "TongDiemTichLuy" };
            foreach (string col in anCot)
                if (dgvKhachHang.Columns[col] != null)
                    dgvKhachHang.Columns[col].Visible = false;

            // Đặt tiêu đề cột
            if (dgvKhachHang.Columns["MaKhachHang"] != null) dgvKhachHang.Columns["MaKhachHang"].HeaderText = "Mã KH";
            if (dgvKhachHang.Columns["HoTen"] != null) dgvKhachHang.Columns["HoTen"].HeaderText = "Họ tên";
            if (dgvKhachHang.Columns["SoDienThoai"] != null) dgvKhachHang.Columns["SoDienThoai"].HeaderText = "Số ĐT";
            if (dgvKhachHang.Columns["Email"] != null) dgvKhachHang.Columns["Email"].HeaderText = "Email";
            if (dgvKhachHang.Columns["NgaySinh"] != null) dgvKhachHang.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            if (dgvKhachHang.Columns["HangThanhVien"] != null) dgvKhachHang.Columns["HangThanhVien"].HeaderText = "Hạng";
            if (dgvKhachHang.Columns["DiemHienTai"] != null) dgvKhachHang.Columns["DiemHienTai"].HeaderText = "Điểm";
        }

        // =============================================
        // TÔ MÀU HẠNG THÀNH VIÊN
        // =============================================
        void ToMauHangThanhVien()
        {
            foreach (DataGridViewRow row in dgvKhachHang.Rows)
            {
                if (row.Cells["HangThanhVien"].Value == null) continue;
                string hang = row.Cells["HangThanhVien"].Value.ToString();
                switch (hang)
                {
                    case "KimCuong":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(173, 216, 230);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(21, 67, 96);
                        break;
                    case "Vang":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 176);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(120, 66, 18);
                        break;
                    case "Bac":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(220, 221, 225);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
                        break;
                    default:
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        break;
                }
            }
        }

        // =============================================
        // CẬP NHẬT BADGE HẠNG THÀNH VIÊN
        // =============================================
        void CapNhatBadge(string hang)
        {
            lblBadge.Text = hang;
            switch (hang)
            {
                case "KimCuong":
                    pnlHang.BackColor = Color.FromArgb(41, 128, 185);
                    break;
                case "Vang":
                    pnlHang.BackColor = Color.FromArgb(212, 172, 13);
                    break;
                case "Bac":
                    pnlHang.BackColor = Color.FromArgb(127, 140, 141);
                    break;
                default:
                    pnlHang.BackColor = Color.FromArgb(149, 165, 166);
                    break;
            }
        }

        // =============================================
        // RESET PANEL
        // =============================================
        void ResetPanel()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtHang.Clear();
            txtDiem.Clear();
            txtTongDiem.Clear();
            txtNgayDangKy.Clear();
            chkNgaySinh.Checked = false;
            dtpNgaySinh.Enabled = false;
            dtpNgaySinh.Value = DateTime.Now;
            lblBadge.Text = "Đồng";
            pnlHang.BackColor = Color.FromArgb(149, 165, 166);

            TrangThaiNut(false);
        }

        // =============================================
        // TRẠNG THÁI NÚT
        // =============================================
        void TrangThaiNut(bool dangNhap)
        {
            btnThem.Enabled = !dangNhap;
            btnSua.Enabled = !dangNhap;
            btnXoa.Enabled = !dangNhap;
            btnTroVe.Enabled = !dangNhap;
            grpTimKiem.Enabled = !dangNhap;

            btnLuu.Enabled = dangNhap;
            btnHuyBo.Enabled = dangNhap;
            grpThongTin.Enabled = dangNhap;

            // Các field chỉ đọc luôn readonly
            txtMaKH.ReadOnly = true;
            txtHang.ReadOnly = true;
            txtDiem.ReadOnly = true;
            txtTongDiem.ReadOnly = true;
            txtNgayDangKy.ReadOnly = true;
        }

        // =============================================
        // CELL CLICK
        // =============================================
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.CurrentCell == null) return;
            if (dgvKhachHang.Rows.Count == 0) return;

            int r = dgvKhachHang.CurrentCell.RowIndex;
            DataGridViewRow row = dgvKhachHang.Rows[r];

            txtMaKH.Text = row.Cells["MaKhachHang"].Value?.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
            txtSDT.Text = row.Cells["SoDienThoai"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            txtHang.Text = row.Cells["HangThanhVien"].Value?.ToString();
            txtDiem.Text = row.Cells["DiemHienTai"].Value?.ToString();
            txtTongDiem.Text = row.Cells["TongDiemTichLuy"].Value?.ToString();

            // Ngày đăng ký
            if (row.Cells["NgayDangKy"].Value != null && row.Cells["NgayDangKy"].Value != DBNull.Value)
                txtNgayDangKy.Text = Convert.ToDateTime(row.Cells["NgayDangKy"].Value).ToString("dd/MM/yyyy");

            // Ngày sinh
            if (row.Cells["NgaySinh"].Value != null && row.Cells["NgaySinh"].Value != DBNull.Value)
            {
                chkNgaySinh.Checked = true;
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            }
            else
            {
                chkNgaySinh.Checked = false;
            }

            maKHDangChon = int.Parse(txtMaKH.Text);

            // Cập nhật badge hạng
            CapNhatBadge(txtHang.Text);

            // Cập nhật label lịch sử
            lblLichSu.Text = "Lịch sử đơn hàng của: " + txtHoTen.Text;
        }

        // =============================================
        // LỌC THEO HẠNG THÀNH VIÊN
        // =============================================
        private void cboLocHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string hang = cboLocHang.SelectedIndex == 0 ? "" : cboLocHang.SelectedItem.ToString();
                string tuKhoa = txtTimKiem.Text.Trim();
                DataSet ds = blKH.TimKiemKhachHang(tuKhoa, hang);
                dgvKhachHang.DataSource = ds.Tables[0];
                dgvKhachHang.AutoResizeColumns();
                AnCotGrid();
                ToMauHangThanhVien();
                lblTong.Text = "Tìm được: " + ds.Tables[0].Rows.Count + " kết quả";
            }
            catch { }
        }

        // =============================================
        // THÊM
        // =============================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            ResetPanel();
            TrangThaiNut(true);
            txtHoTen.Focus();
        }

        // =============================================
        // SỬA
        // =============================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.Rows.Count == 0) return;
            Them = false;
            TrangThaiNut(true);
            txtHoTen.Focus();
        }

        // =============================================
        // LƯU
        // =============================================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ Tên!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // Validate SĐT nếu có nhập
            if (!string.IsNullOrEmpty(txtSDT.Text.Trim()) &&
                !System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text.Trim(), @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! (10 số, bắt đầu bằng 0)", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            string ngaySinh = chkNgaySinh.Checked
                ? dtpNgaySinh.Value.ToString("yyyy-MM-dd") : "";

            bool ok;
            if (Them)
            {
                ok = blKH.ThemKhachHang(
                    txtHoTen.Text.Trim(),
                    txtSDT.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtDiaChi.Text.Trim(),
                    ngaySinh, ref err);

                if (ok)
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Lỗi: " + err, "Thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ok = blKH.CapNhatKhachHang(
                    maKHDangChon,
                    txtHoTen.Text.Trim(),
                    txtSDT.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtDiaChi.Text.Trim(),
                    ngaySinh, ref err);

                if (ok)
                    MessageBox.Show("Cập nhật thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Lỗi: " + err, "Thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ok) LoadData();
        }

        // =============================================
        // HỦY BỎ
        // =============================================
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ResetPanel();
            if (dgvKhachHang.Rows.Count > 0)
                dgvKhachHang_CellClick(null, new DataGridViewCellEventArgs(0, dgvKhachHang.CurrentCell?.RowIndex ?? 0));
        }

        // =============================================
        // XÓA
        // =============================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.Rows.Count == 0) return;

            string tenKH = txtHoTen.Text;
            DialogResult traloi = MessageBox.Show(
                "Chắc chắn xóa khách hàng \"" + tenKH + "\" không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (traloi == DialogResult.Yes)
            {
                bool ok = blKH.XoaKhachHang(maKHDangChon, ref err);
                if (ok)
                {
                    MessageBox.Show("Đã xóa khách hàng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                    MessageBox.Show("Lỗi: " + err, "Thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =============================================
        // TRỞ VỀ
        // =============================================
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =============================================
        // TÌM KIẾM
        // =============================================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();
                string hang = cboLocHang.SelectedItem?.ToString() ?? "";
                if (hang == "Tất cả") hang = ""; DataSet ds = blKH.TimKiemKhachHang(tuKhoa, hang);
                dgvKhachHang.DataSource = ds.Tables[0];
                dgvKhachHang.AutoResizeColumns();
                AnCotGrid();
                ToMauHangThanhVien();
                lblTong.Text = "Tìm được: " + ds.Tables[0].Rows.Count + " kết quả";
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi tìm kiếm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnTimKiem_Click(null, null);
        }

        // =============================================
        // RELOAD
        // =============================================
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLocHang.SelectedIndex = 0;
            LoadData();
        }

        // =============================================
        // CHECKBOX NGÀY SINH
        // =============================================
        private void chkNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaySinh.Enabled = chkNgaySinh.Checked;
        }

        // =============================================
        // LOAD LỊCH SỬ KHI CHUYỂN TAB
        // =============================================
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1 && maKHDangChon > 0)
            {
                try
                {
                    DataSet ds = blKH.LayLichSuDonHang(maKHDangChon);
                    dgvLichSu.DataSource = ds.Tables[0];
                    dgvLichSu.AutoResizeColumns();

                    // Header lịch sử grid
                    if (dgvLichSu.Columns["MaDonHang"] != null) dgvLichSu.Columns["MaDonHang"].HeaderText = "Mã ĐH";
                    if (dgvLichSu.Columns["NgayBan"] != null) dgvLichSu.Columns["NgayBan"].HeaderText = "Ngày mua";
                    if (dgvLichSu.Columns["TongTien"] != null) dgvLichSu.Columns["TongTien"].HeaderText = "Tổng tiền";
                    if (dgvLichSu.Columns["ThanhToan"] != null) dgvLichSu.Columns["ThanhToan"].HeaderText = "Thanh toán";
                    if (dgvLichSu.Columns["TrangThai"] != null) dgvLichSu.Columns["TrangThai"].HeaderText = "Trạng thái";
                    if (dgvLichSu.Columns["DiemTichLuy"] != null) dgvLichSu.Columns["DiemTichLuy"].HeaderText = "Điểm tích";

                    lblLichSu.Text = "Lịch sử đơn hàng của: " + txtHoTen.Text +
                                     " (" + ds.Tables[0].Rows.Count + " đơn)";
                }
                catch
                {
                    MessageBox.Show("Không lấy được lịch sử đơn hàng!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}