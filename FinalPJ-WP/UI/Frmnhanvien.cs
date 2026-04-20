using FinalPJ_WP.BS_layer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FinalPJ_WP
{
    public partial class frmNhanVien : Form
    {
        BLNhanVien blNV = new BLNhanVien();

        bool dangThem = false;
        int maNVDangChon = 0;
        int maNguoiDungChon = 0;
        string err = "";

        public frmNhanVien()
        {
            InitializeComponent();
        }

        // =============================================
        // LOAD FORM
        // =============================================
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
            tabControl.SelectedTab = tabDanhSach;
        }

        // =============================================
        // LOAD DANH SACH
        // =============================================
        void LoadDanhSach()
        {
            try
            {
                DataSet ds = blNV.LayTatCaNhanVien();
                dgvNhanVien.DataSource = ds.Tables[0];
                CauHinhCot();
                lblTong.Text = "Tong: " + blNV.DemNhanVien() + " NV";
                ResetLuong();
            }
            catch (SqlException)
            {
                MessageBox.Show("Khong lay duoc danh sach nhan vien. Loi roi!!!");
            }
        }

        void CauHinhCot()
        {
            if (dgvNhanVien.Columns["MaNguoiDung"] != null) dgvNhanVien.Columns["MaNguoiDung"].Visible = false;
            if (dgvNhanVien.Columns["MaNhanVien"] != null) dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Ma NV";
            if (dgvNhanVien.Columns["HoTen"] != null) dgvNhanVien.Columns["HoTen"].HeaderText = "Ho Ten";
            if (dgvNhanVien.Columns["SoDienThoai"] != null) dgvNhanVien.Columns["SoDienThoai"].HeaderText = "SDT";
            if (dgvNhanVien.Columns["Email"] != null) dgvNhanVien.Columns["Email"].HeaderText = "Email";
            if (dgvNhanVien.Columns["VaiTro"] != null) dgvNhanVien.Columns["VaiTro"].HeaderText = "Vai Tro";
            if (dgvNhanVien.Columns["TrangThai"] != null) dgvNhanVien.Columns["TrangThai"].HeaderText = "Trang Thai";
            if (dgvNhanVien.Columns["ChucVu"] != null) dgvNhanVien.Columns["ChucVu"].HeaderText = "Chuc Vu";
            if (dgvNhanVien.Columns["CaLam"] != null) dgvNhanVien.Columns["CaLam"].HeaderText = "Ca Lam";
            if (dgvNhanVien.Columns["LuongCoBan"] != null) dgvNhanVien.Columns["LuongCoBan"].HeaderText = "Luong Co Ban";
            if (dgvNhanVien.Columns["NgayVaoLam"] != null) dgvNhanVien.Columns["NgayVaoLam"].HeaderText = "Ngay Vao Lam";
            if (dgvNhanVien.Columns["CCCD"] != null) dgvNhanVien.Columns["CCCD"].Visible = false;
            if (dgvNhanVien.Columns["DiaChi"] != null) dgvNhanVien.Columns["DiaChi"].Visible = false;
            if (dgvNhanVien.Columns["NgaySinh"] != null) dgvNhanVien.Columns["NgaySinh"].Visible = false;
            if (dgvNhanVien.Columns["TenDangNhap"] != null) dgvNhanVien.Columns["TenDangNhap"].HeaderText = "Ten Dang Nhap";

            dgvNhanVien.AutoResizeColumns();
            dgvNhanVien.ReadOnly = true;

            // To mau theo trang thai
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                object tt = row.Cells["TrangThai"].Value;
                if (tt != null && tt.ToString() == "False")
                    row.DefaultCellStyle.ForeColor = Color.Gray;
            }
        }

        // =============================================
        // CELL CLICK — hien thong tin len panel
        // =============================================
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvNhanVien.Rows.Count == 0) return;

            DataGridViewRow r = dgvNhanVien.Rows[e.RowIndex];

            maNVDangChon = Convert.ToInt32(r.Cells["MaNhanVien"].Value);
            maNguoiDungChon = Convert.ToInt32(r.Cells["MaNguoiDung"].Value);

            decimal luong = r.Cells["LuongCoBan"].Value != null
                             ? Convert.ToDecimal(r.Cells["LuongCoBan"].Value) : 0;
            string caLam = r.Cells["CaLam"].Value?.ToString() ?? "";
            decimal tongL = blNV.TinhLuong(luong, caLam);
            decimal phuCap = tongL - luong;

            lblLuongCoBan.Text = "Luong co ban: " + luong.ToString("N0") + " VND";
            lblPhuCap.Text = "Phu cap ca " + caLam + ": +" + phuCap.ToString("N0") + " VND";
            lblTongLuong.Text = "Tong luong: " + tongL.ToString("N0") + " VND";
        }

        void ResetLuong()
        {
            lblLuongCoBan.Text = "Luong co ban: —";
            lblPhuCap.Text = "Phu cap: —";
            lblTongLuong.Text = "Tong luong: — VND";
        }

        // =============================================
        // TIM KIEM
        // =============================================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = blNV.TimKiemNhanVien(txtTimKiem.Text.Trim());
                dgvNhanVien.DataSource = ds.Tables[0];
                CauHinhCot();
                lblTong.Text = "Tim duoc: " + ds.Tables[0].Rows.Count + " ket qua";
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi tim kiem. Loi roi!");
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnTimKiem_Click(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadDanhSach();
        }

        // =============================================
        // TINH LUONG
        // =============================================
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui long chon mot nhan vien!", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvNhanVien_CellClick(null,
                new DataGridViewCellEventArgs(0, dgvNhanVien.CurrentCell.RowIndex));
        }

        // =============================================
        // THEM — mo tab Chi tiet o trang Them
        // =============================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            dangThem = true;
            XoaForm();

            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            lblMatKhau.Text = "Mat khau (*):";

            tabControl.SelectedTab = tabChiTiet;
            txtTenDangNhap.Focus();
        }

        // =============================================
        // SUA — mo tab Chi tiet voi du lieu da chon
        // =============================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui long chon nhan vien can sua!", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dangThem = false;
            DataGridViewRow r = dgvNhanVien.CurrentRow;

            txtMaNV.Text = r.Cells["MaNhanVien"].Value.ToString();
            txtTenDangNhap.Text = r.Cells["TenDangNhap"].Value?.ToString();
            txtHoTen.Text = r.Cells["HoTen"].Value?.ToString();
            txtEmail.Text = r.Cells["Email"].Value?.ToString();
            txtSDT.Text = r.Cells["SoDienThoai"].Value?.ToString();
            txtCCCD.Text = r.Cells["CCCD"].Value?.ToString();
            txtDiaChi.Text = r.Cells["DiaChi"].Value?.ToString();
            txtChucVu.Text = r.Cells["ChucVu"].Value?.ToString();
            chkTrangThai.Checked = r.Cells["TrangThai"].Value?.ToString() == "True";

            // VaiTro
            string vaiTro = r.Cells["VaiTro"].Value?.ToString() ?? "";
            int idxVT = cboVaiTro.Items.IndexOf(vaiTro);
            cboVaiTro.SelectedIndex = idxVT >= 0 ? idxVT : 0;

            // CaLam
            string caLam = r.Cells["CaLam"].Value?.ToString() ?? "";
            int idxCL = cboCaLam.Items.IndexOf(caLam);
            cboCaLam.SelectedIndex = idxCL >= 0 ? idxCL : 0;

            // Luong
            if (r.Cells["LuongCoBan"].Value != null)
                numLuong.Value = Convert.ToDecimal(r.Cells["LuongCoBan"].Value);
            else
                numLuong.Value = 0;

            // Khoa ten dang nhap + mat khau khi sua
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            lblMatKhau.Text = "Mat khau (dung btnDoiMK):";

            tabControl.SelectedTab = tabChiTiet;
        }

        // =============================================
        // XOA (xoa mem)
        // =============================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui long chon nhan vien can xoa!", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenNV = dgvNhanVien.CurrentRow.Cells["HoTen"].Value?.ToString();
            DialogResult confirm = MessageBox.Show(
                "Ban co chac chan muon xoa nhan vien [" + tenNV + "] khong?\n(Du lieu se bi an, khong xoa vinh vien)",
                "Xac nhan xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            if (blNV.XoaNhanVien(maNguoiDungChon, ref err))
            {
                MessageBox.Show("Da xoa (an) nhan vien " + tenNV + " thanh cong!");
                LoadDanhSach();
            }
            else
                MessageBox.Show("Loi khi xoa: " + err);
        }

        // =============================================
        // DOI MAT KHAU — dung form tu tao thay InputBox
        // =============================================
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui long chon nhan vien!", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenNV = dgvNhanVien.CurrentRow.Cells["HoTen"].Value?.ToString();
            string mkMoi = HienInputBox("Nhap mat khau moi cho nhan vien [" + tenNV + "]:", "Doi mat khau");

            if (string.IsNullOrWhiteSpace(mkMoi)) return;
            if (mkMoi.Length < 6)
            {
                MessageBox.Show("Mat khau phai co it nhat 6 ky tu!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (blNV.DoiMatKhau(maNguoiDungChon, mkMoi, ref err))
                MessageBox.Show("Da doi mat khau thanh cong cho " + tenNV + "!");
            else
                MessageBox.Show("Loi: " + err);
        }

        // Ham thay the InputBox cua Microsoft.VisualBasic
        private string HienInputBox(string message, string title)
        {
            Form inputForm = new Form();
            Label lbl = new Label();
            TextBox txt = new TextBox();
            Button btnOK = new Button();
            Button btnCancel = new Button();

            inputForm.Text = title;
            inputForm.Size = new Size(360, 160);
            inputForm.StartPosition = FormStartPosition.CenterParent;
            inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputForm.MaximizeBox = false;
            inputForm.MinimizeBox = false;

            lbl.Text = message;
            lbl.AutoSize = true;
            lbl.Location = new Point(12, 15);

            txt.Location = new Point(12, 40);
            txt.Size = new Size(320, 24);
            txt.PasswordChar = '*';

            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(175, 80);
            btnOK.Size = new Size(75, 28);

            btnCancel.Text = "Huy";
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(257, 80);
            btnCancel.Size = new Size(75, 28);

            inputForm.Controls.Add(lbl);
            inputForm.Controls.Add(txt);
            inputForm.Controls.Add(btnOK);
            inputForm.Controls.Add(btnCancel);
            inputForm.AcceptButton = btnOK;
            inputForm.CancelButton = btnCancel;

            return inputForm.ShowDialog() == DialogResult.OK ? txt.Text : "";
        }

        // =============================================
        // TRO VE
        // =============================================
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show(
                "Chac khong?", "Tra loi",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        // =============================================
        // LUU (xu ly ca Them va Sua)
        // =============================================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui long nhap Ho Ten!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus(); return;
            }

            if (dangThem)
            {
                if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                {
                    MessageBox.Show("Vui long nhap Ten dang nhap!", "Canh bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenDangNhap.Focus(); return;
                }
                if (string.IsNullOrWhiteSpace(txtMatKhau.Text) || txtMatKhau.Text.Length < 6)
                {
                    MessageBox.Show("Mat khau phai co it nhat 6 ky tu!", "Canh bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus(); return;
                }
                if (blNV.KiemTraTenDangNhap(txtTenDangNhap.Text.Trim()))
                {
                    MessageBox.Show("Ten dang nhap da ton tai! Vui long chon ten khac.", "Canh bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenDangNhap.Focus(); return;
                }

                try
                {
                    bool ok = blNV.ThemNhanVien(
                        txtTenDangNhap.Text.Trim(),
                        txtMatKhau.Text.Trim(),
                        txtHoTen.Text.Trim(),
                        txtEmail.Text.Trim(),
                        txtSDT.Text.Trim(),
                        cboVaiTro.Text,
                        txtCCCD.Text.Trim(),
                        txtDiaChi.Text.Trim(),
                        txtChucVu.Text.Trim(),
                        cboCaLam.Text,
                        numLuong.Value,
                        ref err);

                    if (ok)
                    {
                        MessageBox.Show("Da them nhan vien thanh cong!");
                        LoadDanhSach();
                        tabControl.SelectedTab = tabDanhSach;
                    }
                    else
                        MessageBox.Show("Khong them duoc: " + err);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Khong them duoc. Loi roi!");
                }
            }
            else
            {
                try
                {
                    bool ok = blNV.CapNhatNhanVien(
                        maNguoiDungChon, maNVDangChon,
                        txtHoTen.Text.Trim(),
                        txtEmail.Text.Trim(),
                        txtSDT.Text.Trim(),
                        cboVaiTro.Text,
                        chkTrangThai.Checked,
                        txtCCCD.Text.Trim(),
                        txtDiaChi.Text.Trim(),
                        txtChucVu.Text.Trim(),
                        cboCaLam.Text,
                        numLuong.Value,
                        ref err);

                    if (ok)
                    {
                        MessageBox.Show("Da cap nhat thanh cong!");
                        LoadDanhSach();
                        tabControl.SelectedTab = tabDanhSach;
                    }
                    else
                        MessageBox.Show("Khong cap nhat duoc: " + err);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Khong cap nhat duoc. Loi roi!");
                }
            }
        }

        // =============================================
        // HUY BO — quay ve tab danh sach
        // =============================================
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            XoaForm();
            tabControl.SelectedTab = tabDanhSach;
        }

        // =============================================
        // RESET FORM NHAP
        // =============================================
        void XoaForm()
        {
            txtMaNV.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtChucVu.Clear();
            cboVaiTro.SelectedIndex = 0;
            cboCaLam.SelectedIndex = 0;
            numLuong.Value = 0;
            chkTrangThai.Checked = true;
            txtMatKhau.Enabled = true;
            txtTenDangNhap.Enabled = true;
            lblMatKhau.Text = "Mat khau (*):";
            lblLuongTinh.Text = "=> Tong luong thuc nhan: 0 VND";
        }

        // =============================================
        // CAP NHAT LUONG TINH KHI THAY DOI
        // =============================================
        void CapNhatLuongTinh()
        {
            decimal tongL = blNV.TinhLuong(numLuong.Value, cboCaLam.Text);
            decimal phuCap = tongL - numLuong.Value;
            lblLuongTinh.Text = "=> Tong luong thuc nhan: " + tongL.ToString("N0") +
                                " VND  (Phu cap: +" + phuCap.ToString("N0") + ")";
        }

        private void numLuong_ValueChanged(object sender, EventArgs e)
        {
            CapNhatLuongTinh();
        }

        private void cboCaLam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatLuongTinh();
        }
    }
}