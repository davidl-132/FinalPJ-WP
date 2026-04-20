using System.Data;
using FinalPJ_WP.DB_layer;

namespace FinalPJ_WP.BS_layer
{
    class BLKhachHang
    {
        DBMain db = null;

        public BLKhachHang()
        {
            db = new DBMain();
        }

        // =============================================
        // LẤY TẤT CẢ KHÁCH HÀNG
        // =============================================
        public DataSet LayKhachHang()
        {
            string sql = @"
                SELECT MaKhachHang, HoTen, Email, SoDienThoai,
                       NgaySinh, DiaChi, TongDiemTichLuy,
                       DiemHienTai, HangThanhVien, NgayDangKy
                FROM KhachHang
                ORDER BY HoTen";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // ĐẾM KHÁCH HÀNG
        // =============================================
        public int DemKhachHang()
        {
            string sql = "SELECT COUNT(*) FROM KhachHang";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            return 0;
        }

        // =============================================
        // TÌM KIẾM KHÁCH HÀNG (theo tên/SĐT + hạng)
        // =============================================
        public DataSet TimKiemKhachHang(string tuKhoa, string hang = "")
        {
            string sql = @"
                SELECT MaKhachHang, HoTen, Email, SoDienThoai,
                       NgaySinh, DiaChi, TongDiemTichLuy,
                       DiemHienTai, HangThanhVien, NgayDangKy
                FROM KhachHang
                WHERE 1=1";

            if (!string.IsNullOrEmpty(tuKhoa))
                sql += " AND (HoTen LIKE N'%" + tuKhoa + "%'" +
                       " OR SoDienThoai LIKE '%" + tuKhoa + "%'" +
                       " OR Email LIKE '%" + tuKhoa + "%')";

            if (!string.IsNullOrEmpty(hang))
                sql += " AND HangThanhVien = N'" + hang + "'";

            sql += " ORDER BY HoTen";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // THÊM KHÁCH HÀNG
        // =============================================
        public bool ThemKhachHang(string hoTen, string sdt,
            string email, string diaChi, string ngaySinh, ref string err)
        {
            string sqlNgaySinh = string.IsNullOrEmpty(ngaySinh) ? "NULL" : "'" + ngaySinh + "'";

            string sql = @"
                INSERT INTO KhachHang (HoTen, Email, SoDienThoai, NgaySinh, DiaChi)
                VALUES (N'" + hoTen + "', N'" + email + "', N'" + sdt + "', " +
                sqlNgaySinh + ", N'" + diaChi + "')";

            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        // =============================================
        // CẬP NHẬT KHÁCH HÀNG
        // =============================================
        public bool CapNhatKhachHang(int maKH, string hoTen, string sdt,
            string email, string diaChi, string ngaySinh, ref string err)
        {
            string sqlNgaySinh = string.IsNullOrEmpty(ngaySinh) ? "NULL" : "'" + ngaySinh + "'";

            string sql = @"
                UPDATE KhachHang SET
                    HoTen       = N'" + hoTen + "', " +
                   "Email       = N'" + email + "', " +
                   "SoDienThoai = N'" + sdt + "', " +
                   "NgaySinh    = " + sqlNgaySinh + ", " +
                   "DiaChi      = N'" + diaChi + "'" +
                   " WHERE MaKhachHang = " + maKH;

            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        // =============================================
        // XÓA KHÁCH HÀNG
        // =============================================
        public bool XoaKhachHang(int maKH, ref string err)
        {
            string sql = "DELETE FROM KhachHang WHERE MaKhachHang = " + maKH;
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        // =============================================
        // LẤY LỊCH SỬ ĐƠN HÀNG
        // =============================================
        public DataSet LayLichSuDonHang(int maKH)
        {
            string sql = @"
                SELECT  dh.MaDonHang,
                        dh.NgayBan,
                        dh.TongTien,
                        dh.GiamGia,
                        dh.ThanhToan,
                        dh.PhuongThucTT,
                        dh.DiemSuDung,
                        dh.DiemTichLuy,
                        dh.TrangThai
                FROM    DonHang dh
                WHERE   dh.MaKhachHang = " + maKH + @"
                ORDER BY dh.NgayBan DESC";

            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
    }
}