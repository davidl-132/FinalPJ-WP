using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalPJ_WP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // =============================================
        // LOAD FORM
        // =============================================
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin người đăng nhập
            lblChaoMung.Text = "Xin Chào, " + SessionManager.HoTen +
                                 "   |   Vai Trò: " + SessionManager.VaiTro;
            lblNgayHienTai.Text = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy");
            lblNguoiDung.Text = "  " + SessionManager.HoTen +
                                 " (" + SessionManager.VaiTro + ")  ";
            lblThoiGian.Text = "  " + DateTime.Now.ToString("HH:mm:ss") + "  ";

            // Style cho 6 button
            StyleButton(btnSanPham, Color.FromArgb(52, 152, 219));
            StyleButton(btnDonHang, Color.FromArgb(39, 174, 96));
            StyleButton(btnKhachHang, Color.FromArgb(155, 89, 182));
            StyleButton(btnNhanVien, Color.FromArgb(230, 126, 34));
            StyleButton(btnNhapHang, Color.FromArgb(231, 76, 60));
            StyleButton(btnBaoCao, Color.FromArgb(22, 160, 133));

            // Phân quyền theo vai trò
            PhanQuyenMenu();

            // Bật timer
            timer1.Start();
        }

        // =============================================
        // STYLE BUTTON
        // =============================================
        private void StyleButton(Button btn, Color color)
        {
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        // =============================================
        // PHÂN QUYỀN MENU
        // =============================================
        private void PhanQuyenMenu()
        {
            if (SessionManager.VaiTro == "NhanVien")
            {
                nhanVienToolStripMenuItem.Enabled = false;
                btnNhanVien.Enabled = false;
            }
        }

        // =============================================
        // TIMER
        // =============================================
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = "  " + DateTime.Now.ToString("HH:mm:ss") + "  ";
        }

        // =============================================
        // MENU — Danh mục
        // =============================================
        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            MoFormSanPham();
        }

        private void mnuTheLoai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form Thể Loại đang phát triển!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form Nhà Cung Cấp đang phát triển!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // =============================================
        // MENU — Nghiệp vụ
        // =============================================
        private void mnuDonHang_Click(object sender, EventArgs e)
        {
            MoFormDonHang();
        }

        private void mnuNhapHang_Click(object sender, EventArgs e)
        {
            MoFormNhapHang();
        }

        // =============================================
        // MENU — Khách hàng
        // =============================================
        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            MoFormKhachHang();
        }

        // =============================================
        // MENU — Nhân viên
        // =============================================
        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            MoFormNhanVien();
        }

        // =============================================
        // MENU — Báo cáo (mỗi mục mở đúng báo cáo)
        // =============================================
        private void mnuDoanhThu_Click(object sender, EventArgs e)
        {
            // Mở thẳng vào tab Doanh thu theo ngày
            // (chọn DoanhThuNgay mặc định; người dùng có thể chuyển sang Tháng bên trong)
            new frmBaoCao(LoaiBaoCao.DoanhThuNgay).ShowDialog();
        }

        private void mnuTopGame_Click(object sender, EventArgs e)
        {
            new frmBaoCao(LoaiBaoCao.GameBanChay).ShowDialog();
        }

        private void mnuKhoSapHet_Click(object sender, EventArgs e)
        {
            new frmBaoCao(LoaiBaoCao.KhoSapHet).ShowDialog();
        }

        // =============================================
        // MENU — Hệ thống
        // =============================================
        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form Đổi Mật Khẩu đang phát triển!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show(
                "Bạn muốn đăng xuất?", "Đăng Xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (traloi == DialogResult.Yes)
            {
                // Xóa session
                SessionManager.MaNguoiDung = 0;
                SessionManager.HoTen = "";
                SessionManager.VaiTro = "";
                SessionManager.MaNhanVien = 0;

                // Khởi động lại (quay về frmLogin)
                Application.Restart();
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show(
                "Bạn muốn thoát chương trình?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        // =============================================
        // FORM CLOSING
        // =============================================
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult traloi = MessageBox.Show(
                    "Bạn muốn thoát chương trình?", "Trả lời",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (traloi != DialogResult.OK)
                    e.Cancel = true;
                else
                    Application.Exit();
            }
        }

        // =============================================
        // 6 SHORTCUT BUTTONS
        // =============================================
        private void btnSanPham_Click(object sender, EventArgs e) => MoFormSanPham();
        private void btnDonHang_Click(object sender, EventArgs e) => MoFormDonHang();
        private void btnKhachHang_Click(object sender, EventArgs e) => MoFormKhachHang();
        private void btnNhanVien_Click(object sender, EventArgs e) => MoFormNhanVien();
        private void btnNhapHang_Click(object sender, EventArgs e) => MoFormNhapHang();

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            // Nút shortcut → mở form báo cáo mặc định (doanh thu theo ngày)
            new frmBaoCao(LoaiBaoCao.DoanhThuNgay).ShowDialog();
        }

        // =============================================
        // HELPER: Mở các form con
        // =============================================
        private void MoFormSanPham()
        {
            FinalPJ_WP.UI.frmSanPham frm = new FinalPJ_WP.UI.frmSanPham();
            frm.ShowDialog();
        }

        private void MoFormDonHang()
        {
            FinalPJ_WP.UI.frmDonHang frm = new FinalPJ_WP.UI.frmDonHang();
            frm.MaNhanVienHienTai = SessionManager.MaNhanVien;
            frm.ShowDialog();
        }

        private void MoFormKhachHang()
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void MoFormNhanVien()
        {
            if (SessionManager.VaiTro == "NhanVien")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Từ chối",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void MoFormNhapHang()
        {
            frmNhapHang frm = new frmNhapHang();
            frm.MaNhanVienHienTai = SessionManager.MaNhanVien;
            frm.ShowDialog();
        }
    }
}