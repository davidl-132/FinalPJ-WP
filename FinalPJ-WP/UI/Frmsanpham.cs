using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FinalPJ_WP.BS_layer;

namespace FinalPJ_WP.UI
{
    public partial class frmSanPham : Form
    {
        BLSanPham blSP = new BLSanPham();
        DataTable dtSanPham = null;
        bool dangThem = false;

        public frmSanPham()
        {
            InitializeComponent();
        }

        // =============================================
        // LOAD FORM
        // =============================================
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadTheLoai();
            LoadDuLieu();
        }

        // =============================================
        // LOAD DỮ LIỆU
        // =============================================
        void LoadDuLieu()
        {
            try
            {
                bool hienCaAn = chkHienSanPhamAn.Checked;
                DataSet ds = hienCaAn
                    ? blSP.TimKiemSanPham("", 0, true)
                    : blSP.LayTatCaSanPham();
                dtSanPham = ds.Tables[0];
                dgvSanPham.DataSource = dtSanPham;
                CauHinhCot();
                TrangThaiNut(false);
                XoaTrong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadTheLoai()
        {
            try
            {
                DataSet ds = blSP.LayTheLoai();
                cboTheLoai.DataSource = ds.Tables[0];
                cboTheLoai.DisplayMember = "TenTheLoai";
                cboTheLoai.ValueMember = "MaTheLoai";
                cboTheLoai.SelectedIndex = -1;

                cboLocTheLoai.DataSource = ds.Tables[0].Copy();
                cboLocTheLoai.DisplayMember = "TenTheLoai";
                cboLocTheLoai.ValueMember = "MaTheLoai";
                cboLocTheLoai.SelectedIndex = -1;
            }
            catch { }
        }

        void CauHinhCot()
        {
            if (dgvSanPham.Columns["MaSanPham"] != null) dgvSanPham.Columns["MaSanPham"].Visible = false;
            if (dgvSanPham.Columns["MaTheLoai"] != null) dgvSanPham.Columns["MaTheLoai"].Visible = false;
            if (dgvSanPham.Columns["MoTa"] != null) dgvSanPham.Columns["MoTa"].Visible = false;
            if (dgvSanPham.Columns["HinhAnh"] != null) dgvSanPham.Columns["HinhAnh"].Visible = false;
            if (dgvSanPham.Columns["NhaPhatTrien"] != null) dgvSanPham.Columns["NhaPhatTrien"].Visible = false;

            if (dgvSanPham.Columns["TenGame"] != null) dgvSanPham.Columns["TenGame"].HeaderText = "Tên Game";
            if (dgvSanPham.Columns["GiaBan"] != null) dgvSanPham.Columns["GiaBan"].HeaderText = "Giá Bán";
            if (dgvSanPham.Columns["NenTang"] != null) dgvSanPham.Columns["NenTang"].HeaderText = "Nền Tảng";
            if (dgvSanPham.Columns["NhaPhatHanh"] != null) dgvSanPham.Columns["NhaPhatHanh"].HeaderText = "Nhà Phát Hành";
            if (dgvSanPham.Columns["NgayPhatHanh"] != null) dgvSanPham.Columns["NgayPhatHanh"].HeaderText = "Ngày Phát Hành";
            if (dgvSanPham.Columns["LoaiSanPham"] != null) dgvSanPham.Columns["LoaiSanPham"].HeaderText = "Loại";
            if (dgvSanPham.Columns["TrangThai"] != null) dgvSanPham.Columns["TrangThai"].HeaderText = "Trạng Thái";
            if (dgvSanPham.Columns["TenTheLoai"] != null) dgvSanPham.Columns["TenTheLoai"].HeaderText = "Thể Loại";

            dgvSanPham.AutoResizeColumns();
            dgvSanPham.ReadOnly = true;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Tô xám các dòng đang ẩn (TrangThai = 0)
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells["TrangThai"] != null &&
                    Convert.ToInt32(row.Cells["TrangThai"].Value) == 0)
                {
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                    row.DefaultCellStyle.Font = new Font(dgvSanPham.Font, FontStyle.Italic);
                }
            }
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
            btnReload.Enabled = !dangNhap;
            grpTimKiem.Enabled = !dangNhap;

            btnLuu.Enabled = dangNhap;
            btnHuyBo.Enabled = dangNhap;
            grpThongTin.Enabled = dangNhap;

            // grpVatLy và grpDigital luôn enabled để hiển thị đúng khi xem
            if (!dangNhap)
            {
                grpVatLy.Enabled = true;
                grpDigital.Enabled = true;
            }
        }

        // =============================================
        // XÓA TRỐNG PANEL NHẬP LIỆU
        // =============================================
        void XoaTrong()
        {
            txtTenGame.Clear();
            txtNhaPhatHanh.Clear();
            txtNhaPhatTrien.Clear();
            txtNenTang.Clear();
            txtGiaBan.Clear();
            txtMoTa.Clear();
            txtHinhAnh.Clear();
            dtpNgayPhatHanh.Value = DateTime.Now;
            cboTheLoai.SelectedIndex = -1;
            chkTrangThai.Checked = true;

            txtMaSKU.Clear();
            txtLoaiDia.Clear();
            if (cboTinhTrang.Items.Count > 0) cboTinhTrang.SelectedIndex = 0;

            txtNenTangPhanPhoi.Clear();
            txtKhuVuc.Clear();

            // Reset radio và ẩn cả 2 group khi chưa chọn dòng
            rdoVatLy.Checked = false;
            rdoDigital.Checked = false;
            grpVatLy.Visible = false;
            grpDigital.Visible = false;

            picHinhAnh.Image = null;
        }

        // =============================================
        // CLICK DÒNG TRÊN GRID
        // =============================================
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                txtTenGame.Text = row.Cells["TenGame"].Value?.ToString();
                txtNhaPhatHanh.Text = row.Cells["NhaPhatHanh"].Value?.ToString();
                txtNhaPhatTrien.Text = row.Cells["NhaPhatTrien"].Value?.ToString();
                txtNenTang.Text = row.Cells["NenTang"].Value?.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
                txtHinhAnh.Text = row.Cells["HinhAnh"].Value?.ToString();
                chkTrangThai.Checked = Convert.ToInt32(row.Cells["TrangThai"].Value) == 1;

                if (row.Cells["NgayPhatHanh"].Value != null &&
                    row.Cells["NgayPhatHanh"].Value != DBNull.Value)
                    dtpNgayPhatHanh.Value = Convert.ToDateTime(row.Cells["NgayPhatHanh"].Value);

                if (row.Cells["MaTheLoai"].Value != null &&
                    row.Cells["MaTheLoai"].Value != DBNull.Value)
                    cboTheLoai.SelectedValue = row.Cells["MaTheLoai"].Value;

                // Đổi text nút Ẩn/Hiện lại theo trạng thái sản phẩm đang chọn
                bool dangAn = Convert.ToInt32(row.Cells["TrangThai"].Value) == 0;
                btnXoa.Text = dangAn ? "Hiện lại" : "Ẩn";
                btnXoa.BackColor = dangAn
                    ? System.Drawing.Color.FromArgb(39, 174, 96)   // xanh lá = hiện lại
                    : System.Drawing.Color.FromArgb(231, 76, 60);  // đỏ = ẩn

                int maSP = Convert.ToInt32(row.Cells["MaSanPham"].Value);
                LoadThongTinMoRong(maSP);
                HienThiHinhAnh(txtHinhAnh.Text);
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maSP = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["MaSanPham"].Value);
            string tenGame = dgvSanPham.CurrentRow.Cells["TenGame"].Value?.ToString();
            bool dangAn = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["TrangThai"].Value) == 0;
            string err = "";

            if (dangAn)
            {
                // Hiện lại sản phẩm đã ẩn
                DialogResult traloi = MessageBox.Show(
                    "Hiện lại sản phẩm \"" + tenGame + "\"?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    if (blSP.HienLaiSanPham(maSP, ref err))
                    {
                        MessageBox.Show("Đã hiện lại sản phẩm!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDuLieu();
                    }
                    else
                        MessageBox.Show("Lỗi: " + err, "Thất bại",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Ẩn sản phẩm
                DialogResult traloi = MessageBox.Show(
                    "Chắc muốn ẩn sản phẩm \"" + tenGame + "\" không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    if (blSP.XoaSanPham(maSP, ref err))
                    {
                        MessageBox.Show("Đã ẩn sản phẩm!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDuLieu();
                    }
                    else
                        MessageBox.Show("Lỗi: " + err, "Thất bại",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =============================================
        // LOAD THÔNG TIN MỞ RỘNG — tự detect từ DB
        // =============================================
        void LoadThongTinMoRong(int maSanPham)
        {
            try
            {
                // Kiểm tra có bản vật lý không
                DataSet dsVL = blSP.LayChiTietVatLy(maSanPham);
                bool coVatLy = dsVL != null && dsVL.Tables.Count > 0 && dsVL.Tables[0].Rows.Count > 0;

                // Kiểm tra có bản digital không
                DataSet dsDG = blSP.LayChiTietDigital(maSanPham);
                bool coDigital = dsDG != null && dsDG.Tables.Count > 0 && dsDG.Tables[0].Rows.Count > 0;

                // Chỉ hiện group nào có dữ liệu
                grpVatLy.Visible = coVatLy;
                grpDigital.Visible = coDigital;

                if (coVatLy)
                {
                    DataRow r = dsVL.Tables[0].Rows[0];
                    txtMaSKU.Text = r["MaSKU"]?.ToString();
                    txtLoaiDia.Text = r["LoaiDia"]?.ToString();
                    string tt = r["TinhTrang"]?.ToString();
                    if (!string.IsNullOrEmpty(tt) && cboTinhTrang.Items.Contains(tt))
                        cboTinhTrang.SelectedItem = tt;
                    else if (cboTinhTrang.Items.Count > 0)
                        cboTinhTrang.SelectedIndex = 0;
                }
                else
                {
                    txtMaSKU.Clear();
                    txtLoaiDia.Clear();
                    if (cboTinhTrang.Items.Count > 0) cboTinhTrang.SelectedIndex = 0;
                }

                if (coDigital)
                {
                    DataRow r = dsDG.Tables[0].Rows[0];
                    txtNenTangPhanPhoi.Text = r["NenTangPhanPhoi"]?.ToString();
                    txtKhuVuc.Text = r["KhuVucHoTro"]?.ToString();
                }
                else
                {
                    txtNenTangPhanPhoi.Clear();
                    txtKhuVuc.Clear();
                }
            }
            catch { }
        }

        // =============================================
        // HIỂN THỊ HÌNH ẢNH
        // =============================================
        void HienThiHinhAnh(string duongDan)
        {
            try
            {
                if (string.IsNullOrEmpty(duongDan)) { picHinhAnh.Image = null; return; }

                string tenFile = System.IO.Path.GetFileName(duongDan);
                string[] cauHinh = new string[]
                {
                    duongDan,
                    System.IO.Path.Combine(Application.StartupPath, "Images", "Image Game", tenFile),
                    System.IO.Path.Combine(Application.StartupPath, "Images", tenFile),
                    System.IO.Path.Combine(Application.StartupPath, duongDan),
                };

                foreach (string path in cauHinh)
                {
                    if (System.IO.File.Exists(path))
                    {
                        picHinhAnh.Image = Image.FromFile(path);
                        return;
                    }
                }
                picHinhAnh.Image = null;
            }
            catch { picHinhAnh.Image = null; }
        }

        // =============================================
        // NÚT RELOAD
        // =============================================
        private void btnReload_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLocTheLoai.SelectedIndex = -1;
            LoadDuLieu();
        }

        // Tick checkbox → reload ngay
        private void chkHienSanPhamAn_CheckedChanged(object sender, EventArgs e)
        {
            LoadDuLieu();
            // Reset text nút Ẩn về mặc định khi chưa chọn dòng nào
            btnXoa.Text = "Ẩn";
            btnXoa.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
        }

        // =============================================
        // TÌM KIẾM
        // =============================================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();
                int maTheLoai = cboLocTheLoai.SelectedValue != null
                    ? Convert.ToInt32(cboLocTheLoai.SelectedValue) : 0;
                bool hienCaAn = chkHienSanPhamAn.Checked;

                DataSet ds = blSP.TimKiemSanPham(tuKhoa, maTheLoai, hienCaAn);
                dtSanPham = ds.Tables[0];
                dgvSanPham.DataSource = dtSanPham;
                CauHinhCot();
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

        // =============================================
        // NÚT THÊM
        // =============================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            dangThem = true;
            XoaTrong();
            TrangThaiNut(true);

            // Mặc định chọn Vật lý, user tự chọn radio để đổi
            rdoVatLy.Checked = true;
            grpVatLy.Visible = true;
            grpDigital.Visible = false;

            txtTenGame.Focus();
        }

        private void rdoVatLy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVatLy.Checked)
            {
                grpVatLy.Visible = true;
                grpDigital.Visible = false;
            }
        }

        private void rdoDigital_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDigital.Checked)
            {
                grpVatLy.Visible = false;
                grpDigital.Visible = true;
            }
        }

        // =============================================
        // NÚT SỬA
        // =============================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dangThem = false;
            TrangThaiNut(true);
            txtTenGame.Focus();
        }

        // =============================================
        // NÚT LƯU
        // =============================================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtGiaBan.Text.Trim(), out decimal giaBan))
            {
                MessageBox.Show("Giá bán không hợp lệ!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBan.Focus();
                return;
            }

            int maTheLoai = cboTheLoai.SelectedValue != null
                ? Convert.ToInt32(cboTheLoai.SelectedValue) : 0;

            string ngayPH = dtpNgayPhatHanh.Value.ToString("yyyy-MM-dd");

            // Lấy trạng thái hiện tại của 2 group để biết lưu cái nào
            bool coVatLy = grpVatLy.Visible;
            bool coDigital = grpDigital.Visible;

            string maSKU = coVatLy ? txtMaSKU.Text.Trim() : "";
            string loaiDia = coVatLy ? txtLoaiDia.Text.Trim() : "";
            string tinhTrang = coVatLy ? (cboTinhTrang.SelectedItem?.ToString() ?? "Moi") : "Moi";
            string nenTangPhanPhoi = coDigital ? txtNenTangPhanPhoi.Text.Trim() : "";
            string khuVucHoTro = coDigital ? txtKhuVuc.Text.Trim() : "";

            // LoaiSanPham: digital-only = 1, còn lại = 0
            bool isDigital = coDigital && !coVatLy;

            string err = "";
            bool ketQua;

            if (dangThem)
            {
                ketQua = blSP.ThemSanPham(
                    txtTenGame.Text.Trim(), maTheLoai,
                    txtNhaPhatHanh.Text.Trim(), txtNhaPhatTrien.Text.Trim(),
                    ngayPH, txtNenTang.Text.Trim(),
                    txtMoTa.Text.Trim(), txtHinhAnh.Text.Trim(),
                    giaBan, isDigital,
                    coVatLy, coDigital,
                    maSKU, loaiDia, tinhTrang,
                    nenTangPhanPhoi, khuVucHoTro,
                    ref err);

                if (ketQua)
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Lỗi: " + err, "Thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int maSP = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["MaSanPham"].Value);

                ketQua = blSP.SuaSanPham(
                    maSP, txtTenGame.Text.Trim(), maTheLoai,
                    txtNhaPhatHanh.Text.Trim(), txtNhaPhatTrien.Text.Trim(),
                    ngayPH, txtNenTang.Text.Trim(),
                    txtMoTa.Text.Trim(), txtHinhAnh.Text.Trim(),
                    giaBan, isDigital, chkTrangThai.Checked,
                    coVatLy, coDigital,
                    maSKU, loaiDia, tinhTrang,
                    nenTangPhanPhoi, khuVucHoTro,
                    ref err);

                if (ketQua)
                    MessageBox.Show("Cập nhật thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Lỗi: " + err, "Thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ketQua)
            {
                LoadDuLieu();
                TrangThaiNut(false);
            }
        }

        // =============================================
        // NÚT HỦY BỎ
        // =============================================
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            TrangThaiNut(false);
            XoaTrong();
            if (dgvSanPham.CurrentRow != null)
                dgvSanPham_CellClick(null,
                    new DataGridViewCellEventArgs(0, dgvSanPham.CurrentRow.Index));
        }

        // =============================================
        // NÚT CHỌN HÌNH ẢNH
        // =============================================
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn hình ảnh";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string folderImages = System.IO.Path.Combine(
                            Application.StartupPath, "Images", "Image Game");

                        if (!System.IO.Directory.Exists(folderImages))
                            System.IO.Directory.CreateDirectory(folderImages);

                        string tenFile = System.IO.Path.GetFileName(ofd.FileName);
                        string duongDanDich = System.IO.Path.Combine(folderImages, tenFile);
                        System.IO.File.Copy(ofd.FileName, duongDanDich, overwrite: true);

                        txtHinhAnh.Text = "Images\\Image Game\\" + tenFile;
                        HienThiHinhAnh(duongDanDich);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi copy ảnh: " + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // =============================================
        // NÚT TRỞ VỀ
        // =============================================
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}