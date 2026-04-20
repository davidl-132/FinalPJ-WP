using FinalPJ_WP.DB_layer;
using System;
using System.Data;

namespace FinalPJ_WP.BS_layer
{
    class BLNhanVien
    {
        DBMain db = null;

        public BLNhanVien()
        {
            db = new DBMain();
        }

        // Lay tat ca nhan vien (join NguoiDung)
        public DataSet LayTatCaNhanVien()
        {
            string sql = @"SELECT nv.MaNhanVien, nd.HoTen, nd.Email, nd.SoDienThoai,
                                  nd.VaiTro, nd.TrangThai,
                                  nv.CCCD, nv.NgaySinh, nv.DiaChi,
                                  nv.LuongCoBan, nv.NgayVaoLam,
                                  nv.ChucVu, nv.CaLam,
                                  nd.TenDangNhap, nd.MaNguoiDung
                           FROM NhanVien nv
                           INNER JOIN NguoiDung nd ON nv.MaNguoiDung = nd.MaNguoiDung
                           ORDER BY nv.MaNhanVien DESC";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // Tim kiem theo ten hoac SDT
        public DataSet TimKiemNhanVien(string tuKhoa)
        {
            string sql = @"SELECT nv.MaNhanVien, nd.HoTen, nd.Email, nd.SoDienThoai,
                                  nd.VaiTro, nd.TrangThai,
                                  nv.LuongCoBan, nv.ChucVu, nv.CaLam,
                                  nd.TenDangNhap, nd.MaNguoiDung
                           FROM NhanVien nv
                           INNER JOIN NguoiDung nd ON nv.MaNguoiDung = nd.MaNguoiDung
                           WHERE nd.HoTen LIKE N'%" + tuKhoa + @"%'
                              OR nd.SoDienThoai LIKE '%" + tuKhoa + @"%'
                              OR nv.ChucVu LIKE N'%" + tuKhoa + @"%'
                           ORDER BY nv.MaNhanVien DESC";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // Them nhan vien moi (them ca NguoiDung + NhanVien)
        public bool ThemNhanVien(string tenDangNhap, string matKhau, string hoTen,
                                  string email, string sdt, string vaiTro,
                                  string cccd, string diaChi, string chucVu,
                                  string caLam, decimal luongCoBan, ref string err)
        {
            string matKhauHash = MD5Helper.Hash(matKhau);
            // Buoc 1: them NguoiDung
            string sql1 = "INSERT INTO NguoiDung(TenDangNhap, MatKhau, HoTen, Email, SoDienThoai, VaiTro) " +
                          "VALUES('" + tenDangNhap + "', '" + matKhauHash + "', N'" + hoTen + "', " +
                          "'" + email + "', '" + sdt + "', '" + vaiTro + "')";
            if (!db.MyExecuteNonQuery(sql1, CommandType.Text, ref err)) return false;

            // Buoc 2: lay MaNguoiDung vua tao
            object maNDObj = db.MyExecuteScalar(
                "SELECT TOP 1 MaNguoiDung FROM NguoiDung WHERE TenDangNhap='" + tenDangNhap + "'",
                CommandType.Text);
            if (maNDObj == null) { err = "Khong lay duoc MaNguoiDung"; return false; }
            int maNguoiDung = Convert.ToInt32(maNDObj);

            // Buoc 3: them NhanVien
            string caLamSQL = string.IsNullOrWhiteSpace(caLam) ? "NULL" : "'" + caLam + "'";
            string sql2 = "INSERT INTO NhanVien(MaNguoiDung, CCCD, DiaChi, ChucVu, CaLam, LuongCoBan) " +
                          "VALUES(" + maNguoiDung + ", '" + cccd + "', N'" + diaChi + "', " +
                          "N'" + chucVu + "', " + caLamSQL + ", " + luongCoBan + ")";
            return db.MyExecuteNonQuery(sql2, CommandType.Text, ref err);
        }

        // Cap nhat thong tin nhan vien
        public bool CapNhatNhanVien(int maNguoiDung, int maNhanVien,
                                    string hoTen, string email, string sdt,
                                    string vaiTro, bool trangThai,
                                    string cccd, string diaChi, string chucVu,
                                    string caLam, decimal luongCoBan, ref string err)
        {
            // Cap nhat NguoiDung
            string sql1 = "UPDATE NguoiDung SET " +
                          "HoTen=N'" + hoTen + "', Email='" + email + "', " +
                          "SoDienThoai='" + sdt + "', VaiTro='" + vaiTro + "', " +
                          "TrangThai=" + (trangThai ? 1 : 0) + " " +
                          "WHERE MaNguoiDung=" + maNguoiDung;
            if (!db.MyExecuteNonQuery(sql1, CommandType.Text, ref err)) return false;

            // Cap nhat NhanVien
            string caLamSQL = string.IsNullOrWhiteSpace(caLam) ? "NULL" : "'" + caLam + "'";
            string sql2 = "UPDATE NhanVien SET " +
                          "CCCD='" + cccd + "', DiaChi=N'" + diaChi + "', " +
                          "ChucVu=N'" + chucVu + "', CaLam=" + caLamSQL + ", " +
                          "LuongCoBan=" + luongCoBan + " " +
                          "WHERE MaNhanVien=" + maNhanVien;
            return db.MyExecuteNonQuery(sql2, CommandType.Text, ref err);
        }

        // Xoa mem nhan vien (tat TrangThai)
        public bool XoaNhanVien(int maNguoiDung, ref string err)
        {
            string sql = "UPDATE NguoiDung SET TrangThai=0 WHERE MaNguoiDung=" + maNguoiDung;
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        // Doi mat khau
        public bool DoiMatKhau(int maNguoiDung, string matKhauMoi, ref string err)
        {
            string sql = "UPDATE NguoiDung SET MatKhau='" + matKhauMoi + "' " +
                         "WHERE MaNguoiDung=" + maNguoiDung;
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        // Dem tong nhan vien dang lam
        public int DemNhanVien()
        {
            object result = db.MyExecuteScalar(
            "SELECT COUNT(*) FROM NhanVien nv INNER JOIN NguoiDung nd ON nv.MaNguoiDung = nd.MaNguoiDung WHERE nd.TrangThai=1",
                CommandType.Text);
            return Convert.ToInt32(result);
        }

        // Tinh luong: luong co ban + phu cap theo ca lam
        public decimal TinhLuong(decimal luongCoBan, string caLam)
        {
            decimal phuCap = 0;
            switch (caLam)
            {
                case "Toi": phuCap = 500000; break;
                case "Sang": phuCap = 200000; break;
                case "Chieu": phuCap = 300000; break;
                case "HanhChinh": phuCap = 0; break;
            }
            return luongCoBan + phuCap;
        }

        // Kiem tra ten dang nhap da ton tai
        public bool KiemTraTenDangNhap(string tenDangNhap)
        {
            object result = db.MyExecuteScalar(
                "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap='" + tenDangNhap + "'",
                CommandType.Text);
            return Convert.ToInt32(result) > 0;
        }
    }
}