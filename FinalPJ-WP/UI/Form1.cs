using System;
using System.Data;
using System.Windows.Forms;
using FinalPJ_WP.BS_layer;

namespace FinalPJ_WP
{
    public partial class Form1 : Form
    {
        BLNguoiDung blND = new BLNguoiDung();

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string tenDangNhap = usernameTextBox.Text.Trim();
            string matKhau = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash MD5
            string matKhauHash = MD5Helper.Hash(matKhau);

            // Gọi BS layer
            DataSet ds = blND.DangNhap(tenDangNhap, matKhauHash);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                // Lưu session
                SessionManager.MaNguoiDung = Convert.ToInt32(row["MaNguoiDung"]);
                SessionManager.HoTen = row["HoTen"].ToString();
                SessionManager.VaiTro = row["VaiTro"].ToString();
                SessionManager.MaNhanVien = Convert.ToInt32(row["MaNhanVien"]);

                // Cập nhật ngày đăng nhập
                string err = "";
                blND.CapNhatNgayDangNhap(SessionManager.MaNguoiDung, ref err);

                // Mở frmMain
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!",
                    "Đăng nhập thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loginButton_Click(sender, e);
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}