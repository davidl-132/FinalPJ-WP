using FinalPJ_WP.BS_layer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FinalPJ_WP
{
    public partial class frmNhapHang : Form
    {
        BLNhapHang blNH = new BLNhapHang();

        // DataTable tam luu chi tiet phieu nhap dang tao
        DataTable dtChiTiet = new DataTable();

        int maPhieuChon = 0;
        string err = "";

        // MaNhanVien cua nguoi dang dang nhap — truyen tu form login
        public int MaNhanVienHienTai { get; set; } = 0;

        public frmNhapHang()
        {
            InitializeComponent();
            KhoiTaoDtChiTiet();
        }

        // =============================================
        // KHOI TAO DATATABLE CHI TIET
        // =============================================
        void KhoiTaoDtChiTiet()
        {
            dtChiTiet.Columns.Add("MaSanPham", typeof(int));
            dtChiTiet.Columns.Add("TenGame", typeof(string));
            dtChiTiet.Columns.Add("SoLuong", typeof(int));
            dtChiTiet.Columns.Add("DonGiaNhap", typeof(decimal));
            dtChiTiet.Columns.Add("ThanhTien", typeof(decimal));
        }

        // =============================================
        // LOAD FORM
        // =============================================
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
            NapComboNhaCungCap();
            NapComboSanPham();
            tabControl.SelectedTab = tabDanhSach;
            dgvTaoPhieu.DataSource = dtChiTiet;
            CauHinhCotTaoPhieu();
        }

        // =============================================
        // LOAD DANH SACH PHIEU NHAP
        // =============================================
        void LoadDanhSach()
        {
            try
            {
                DataSet ds = blNH.LayTatCaPhieuNhap();
                dgvPhieuNhap.DataSource = ds.Tables[0];
                CauHinhCotPhieu();
                lblTong.Text = "Tong phieu DaNhap: " + blNH.DemPhieuNhap();
            }
            catch (SqlException)
            {
                MessageBox.Show("Khong lay duoc danh sach phieu nhap!");
            }
        }

        void CauHinhCotPhieu()
        {
            if (dgvPhieuNhap.Columns["MaNhaCungCap"] != null) dgvPhieuNhap.Columns["MaNhaCungCap"].Visible = false;
            if (dgvPhieuNhap.Columns["MaNhanVien"] != null) dgvPhieuNhap.Columns["MaNhanVien"].Visible = false;
            if (dgvPhieuNhap.Columns["MaPhieuNhap"] != null) dgvPhieuNhap.Columns["MaPhieuNhap"].HeaderText = "Ma Phieu";
            if (dgvPhieuNhap.Columns["TenNhaCungCap"] != null) dgvPhieuNhap.Columns["TenNhaCungCap"].HeaderText = "Nha Cung Cap";
            if (dgvPhieuNhap.Columns["TenNhanVien"] != null) dgvPhieuNhap.Columns["TenNhanVien"].HeaderText = "Nhan Vien Nhap";
            if (dgvPhieuNhap.Columns["NgayNhap"] != null) dgvPhieuNhap.Columns["NgayNhap"].HeaderText = "Ngay Nhap";
            if (dgvPhieuNhap.Columns["TongTien"] != null) dgvPhieuNhap.Columns["TongTien"].HeaderText = "Tong Tien";
            if (dgvPhieuNhap.Columns["TrangThai"] != null) dgvPhieuNhap.Columns["TrangThai"].HeaderText = "Trang Thai";
            if (dgvPhieuNhap.Columns["GhiChu"] != null) dgvPhieuNhap.Columns["GhiChu"].HeaderText = "Ghi Chu";

            dgvPhieuNhap.AutoResizeColumns();
            dgvPhieuNhap.ReadOnly = true;

            // To mau phieu da huy
            foreach (DataGridViewRow row in dgvPhieuNhap.Rows)
            {
                object tt = row.Cells["TrangThai"].Value;
                if (tt != null && tt.ToString() == "DaHuy")
                    row.DefaultCellStyle.ForeColor = Color.Gray;
            }
        }

        // =============================================
        // NAP COMBO NHA CUNG CAP
        // =============================================
        void NapComboNhaCungCap()
        {
            try
            {
                DataSet ds = blNH.LayNhaCungCap();
                cboNhaCungCap.DataSource = ds.Tables[0];
                cboNhaCungCap.DisplayMember = "TenNhaCungCap";
                cboNhaCungCap.ValueMember = "MaNhaCungCap";
            }
            catch { }
        }

        // =============================================
        // NAP COMBO SAN PHAM
        // =============================================
        void NapComboSanPham()
        {
            try
            {
                DataSet ds = blNH.LaySanPham();
                cboSanPham.DataSource = ds.Tables[0];
                cboSanPham.DisplayMember = "TenGame";
                cboSanPham.ValueMember = "MaSanPham";
            }
            catch { }
        }

        // =============================================
        // CELL CLICK PHIEU NHAP — hien chi tiet
        // =============================================
        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvPhieuNhap.Rows.Count == 0) return;

            DataGridViewRow r = dgvPhieuNhap.Rows[e.RowIndex];
            maPhieuChon = Convert.ToInt32(r.Cells["MaPhieuNhap"].Value);

            try
            {
                DataSet ds = blNH.LayChiTietPhieuNhap(maPhieuChon);
                dgvChiTiet.DataSource = ds.Tables[0];
                CauHinhCotChiTiet();

                lblMaPhieuChon.Text = "Phieu #" + maPhieuChon;
                lblNhaCungCap.Text = "NCC: " + r.Cells["TenNhaCungCap"].Value;
                lblNgayNhap.Text = "Ngay: " + Convert.ToDateTime(r.Cells["NgayNhap"].Value).ToString("dd/MM/yyyy");
                lblTongTienChon.Text = "Tong tien: " + Convert.ToDecimal(r.Cells["TongTien"].Value).ToString("N0") + " VND";
                lblTrangThaiChon.Text = "Trang thai: " + r.Cells["TrangThai"].Value;
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi khi lay chi tiet!");
            }
        }

        void CauHinhCotChiTiet()
        {
            if (dgvChiTiet.Columns["MaChiTietNhap"] != null) dgvChiTiet.Columns["MaChiTietNhap"].Visible = false;
            if (dgvChiTiet.Columns["MaSanPham"] != null) dgvChiTiet.Columns["MaSanPham"].Visible = false;
            if (dgvChiTiet.Columns["TenGame"] != null) dgvChiTiet.Columns["TenGame"].HeaderText = "Ten Game";
            if (dgvChiTiet.Columns["SoLuong"] != null) dgvChiTiet.Columns["SoLuong"].HeaderText = "So Luong";
            if (dgvChiTiet.Columns["DonGiaNhap"] != null) dgvChiTiet.Columns["DonGiaNhap"].HeaderText = "Don Gia Nhap";
            if (dgvChiTiet.Columns["ThanhTien"] != null) dgvChiTiet.Columns["ThanhTien"].HeaderText = "Thanh Tien";
            dgvChiTiet.AutoResizeColumns();
            dgvChiTiet.ReadOnly = true;
        }

        // =============================================
        // TIM KIEM
        // =============================================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = blNH.TimKiemPhieuNhap(txtTimKiem.Text.Trim());
                dgvPhieuNhap.DataSource = ds.Tables[0];
                CauHinhCotPhieu();
                lblTong.Text = "Tim duoc: " + ds.Tables[0].Rows.Count + " phieu";
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi tim kiem!");
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnTimKiem_Click(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            dgvChiTiet.DataSource = null;
            ResetThongTinChon();
            LoadDanhSach();
        }

        void ResetThongTinChon()
        {
            lblMaPhieuChon.Text = "Phieu: —";
            lblNhaCungCap.Text = "NCC: —";
            lblNgayNhap.Text = "Ngay: —";
            lblTongTienChon.Text = "Tong tien: —";
            lblTrangThaiChon.Text = "Trang thai: —";
        }

        // =============================================
        // THEM PHIEU NHAP — mo tab Tao Phieu
        // =============================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaFormTaoPhieu();
            tabControl.SelectedTab = tabTaoPhieu;
        }

        // =============================================
        // HUY PHIEU NHAP
        // =============================================
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (maPhieuChon == 0)
            {
                MessageBox.Show("Vui long chon phieu can huy!", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cf = MessageBox.Show(
                "Ban co chac chan muon huy Phieu #" + maPhieuChon + " khong?\nKho se bi tru lai so luong tuong ung.",
                "Xac nhan huy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cf != DialogResult.Yes) return;

            if (blNH.HuyPhieuNhap(maPhieuChon, ref err))
            {
                MessageBox.Show("Da huy phieu #" + maPhieuChon + " thanh cong!");
                LoadDanhSach();
                dgvChiTiet.DataSource = null;
                ResetThongTinChon();
            }
            else
                MessageBox.Show("Loi: " + err);
        }

        // =============================================
        // TRO VE
        // =============================================
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult cf = MessageBox.Show("Chac khong?", "Tra loi",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cf == DialogResult.OK) this.Close();
        }

        // =============================================
        // TAO PHIEU — THEM SAN PHAM VAO DANH SACH
        // =============================================
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue == null)
            {
                MessageBox.Show("Vui long chon san pham!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("So luong phai lon hon 0!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numDonGia.Value <= 0)
            {
                MessageBox.Show("Don gia phai lon hon 0!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maSP = Convert.ToInt32(cboSanPham.SelectedValue);
            string tenGame = cboSanPham.Text;
            int sl = Convert.ToInt32(numSoLuong.Value);
            decimal dg = numDonGia.Value;
            decimal tt = sl * dg;

            // Kiem tra neu san pham da co trong danh sach thi cap nhat
            foreach (DataRow row in dtChiTiet.Rows)
            {
                if (Convert.ToInt32(row["MaSanPham"]) == maSP)
                {
                    row["SoLuong"] = Convert.ToInt32(row["SoLuong"]) + sl;
                    row["ThanhTien"] = Convert.ToDecimal(row["ThanhTien"]) + tt;
                    CapNhatTongTien();
                    dgvTaoPhieu.Refresh();
                    return;
                }
            }

            // Them moi
            dtChiTiet.Rows.Add(maSP, tenGame, sl, dg, tt);
            CapNhatTongTien();
        }

        // =============================================
        // TAO PHIEU — XOA SAN PHAM KHOI DANH SACH
        // =============================================
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dgvTaoPhieu.CurrentRow == null || dgvTaoPhieu.Rows.Count == 0)
            {
                MessageBox.Show("Vui long chon dong can xoa!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idx = dgvTaoPhieu.CurrentRow.Index;
            dtChiTiet.Rows[idx].Delete();
            dtChiTiet.AcceptChanges();
            CapNhatTongTien();
        }

        void CapNhatTongTien()
        {
            decimal tong = 0;
            foreach (DataRow row in dtChiTiet.Rows)
                tong += Convert.ToDecimal(row["ThanhTien"]);
            lblTongTienTao.Text = "Tong tien: " + tong.ToString("N0") + " VND";
        }

        // =============================================
        // TAO PHIEU — LUU PHIEU NHAP
        // =============================================
        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            if (cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui long chon Nha Cung Cap!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Vui long them it nhat 1 san pham!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MaNhanVienHienTai == 0)
            {
                MessageBox.Show("Khong xac dinh duoc nhan vien dang nhap!", "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maNCC = Convert.ToInt32(cboNhaCungCap.SelectedValue);

            try
            {
                bool ok = blNH.ThemPhieuNhap(maNCC, MaNhanVienHienTai,
                                              txtGhiChu.Text.Trim(),
                                              dtChiTiet, ref err);
                if (ok)
                {
                    MessageBox.Show("Da tao phieu nhap thanh cong!");
                    LoadDanhSach();
                    XoaFormTaoPhieu();
                    tabControl.SelectedTab = tabDanhSach;
                }
                else
                    MessageBox.Show("Khong luu duoc: " + err);
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi SQL khi luu phieu nhap!");
            }
        }

        // =============================================
        // TAO PHIEU — HUY BO
        // =============================================
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (dtChiTiet.Rows.Count > 0)
            {
                DialogResult cf = MessageBox.Show(
                    "Ban co chac muon huy bo phieu dang tao?", "Xac nhan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cf != DialogResult.Yes) return;
            }
            XoaFormTaoPhieu();
            tabControl.SelectedTab = tabDanhSach;
        }

        // =============================================
        // RESET FORM TAO PHIEU
        // =============================================
        void XoaFormTaoPhieu()
        {
            dtChiTiet.Clear();
            dgvTaoPhieu.DataSource = null;
            dgvTaoPhieu.DataSource = dtChiTiet;
            CauHinhCotTaoPhieu();

            if (cboNhaCungCap.Items.Count > 0) cboNhaCungCap.SelectedIndex = 0;
            if (cboSanPham.Items.Count > 0) cboSanPham.SelectedIndex = 0;
            numSoLuong.Value = 1;
            numDonGia.Value = 0;
            txtGhiChu.Clear();
            lblTongTienTao.Text = "Tong tien: 0 VND";
        }

        void CauHinhCotTaoPhieu()
        {
            if (dgvTaoPhieu.Columns["MaSanPham"] != null) dgvTaoPhieu.Columns["MaSanPham"].Visible = false;
            if (dgvTaoPhieu.Columns["TenGame"] != null) dgvTaoPhieu.Columns["TenGame"].HeaderText = "Ten Game";
            if (dgvTaoPhieu.Columns["SoLuong"] != null) dgvTaoPhieu.Columns["SoLuong"].HeaderText = "So Luong";
            if (dgvTaoPhieu.Columns["DonGiaNhap"] != null) dgvTaoPhieu.Columns["DonGiaNhap"].HeaderText = "Don Gia Nhap";
            if (dgvTaoPhieu.Columns["ThanhTien"] != null) dgvTaoPhieu.Columns["ThanhTien"].HeaderText = "Thanh Tien";
            dgvTaoPhieu.AutoResizeColumns();
        }

        // Cap nhat don gia tu gia ban san pham khi chon combo
        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem == null) return;
            DataRowView row = cboSanPham.SelectedItem as DataRowView;
            if (row != null && row["GiaBan"] != DBNull.Value)
                numDonGia.Value = Convert.ToDecimal(row["GiaBan"]);
        }
    }
}