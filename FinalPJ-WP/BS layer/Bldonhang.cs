using FinalPJ_WP.DB_layer;
using System;
using System.Data;
using System.Globalization;

namespace FinalPJ_WP.BS_layer
{
    class BLDonHang
    {
        DBMain db = null;

        public BLDonHang()
        {
            db = new DBMain();
        }

        // =============================================
        // LẤY TẤT CẢ ĐƠN HÀNG
        // =============================================
        public DataSet LayTatCaDonHang()
        {
            string sql = @"
                SELECT  dh.MaDonHang,
                        dh.MaKhachHang,
                        ISNULL(kh.HoTen, N'Khách vãng lai') AS TenKhachHang,
                        ISNULL(kh.SoDienThoai, '')          AS SoDienThoai,
                        nd.HoTen        AS TenNhanVien,
                        dh.NgayBan,
                        dh.TongTien,
                        dh.GiamGia,
                        dh.ThanhToan,
                        dh.PhuongThucTT,
                        dh.DiemSuDung,
                        dh.DiemTichLuy,
                        dh.TrangThai
                FROM    DonHang dh
                LEFT JOIN KhachHang  kh ON kh.MaKhachHang = dh.MaKhachHang
                LEFT JOIN NhanVien   nv ON nv.MaNhanVien   = dh.MaNhanVien
                LEFT JOIN NguoiDung  nd ON nd.MaNguoiDung  = nv.MaNguoiDung
                ORDER BY dh.NgayBan DESC";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // TÌM KIẾM ĐƠN HÀNG
        // =============================================
        public DataSet TimKiemDonHang(string tuKhoa, string trangThai)
        {
            string sql = @"
                SELECT  dh.MaDonHang,
                        dh.MaKhachHang,
                        ISNULL(kh.HoTen, N'Khách vãng lai') AS TenKhachHang,
                        ISNULL(kh.SoDienThoai, '')          AS SoDienThoai,
                        nd.HoTen        AS TenNhanVien,
                        dh.NgayBan,
                        dh.TongTien,
                        dh.GiamGia,
                        dh.ThanhToan,
                        dh.PhuongThucTT,
                        dh.DiemSuDung,
                        dh.DiemTichLuy,
                        dh.TrangThai
                FROM    DonHang dh
                LEFT JOIN KhachHang  kh ON kh.MaKhachHang = dh.MaKhachHang
                LEFT JOIN NhanVien   nv ON nv.MaNhanVien   = dh.MaNhanVien
                LEFT JOIN NguoiDung  nd ON nd.MaNguoiDung  = nv.MaNguoiDung
                WHERE   1=1";

            if (!string.IsNullOrEmpty(tuKhoa))
                sql += " AND (kh.HoTen LIKE N'%" + tuKhoa + "%'" +
                       " OR kh.SoDienThoai LIKE N'%" + tuKhoa + "%'" +
                       " OR CAST(dh.MaDonHang AS NVARCHAR) LIKE '%" + tuKhoa + "%')";

            if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                sql += " AND dh.TrangThai = N'" + trangThai + "'";

            sql += " ORDER BY dh.NgayBan DESC";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // LẤY CHI TIẾT ĐƠN HÀNG (giỏ hàng)
        // =============================================
        public DataSet LayChiTietDonHang(int maDonHang)
        {
            string sql = @"
                SELECT  ct.MaChiTietDH,
                        ct.MaSanPham,
                        sp.TenGame,
                        ct.SoLuong,
                        ct.DonGia,
                        ct.ThanhTien,
                        ct.SerialKey
                FROM    ChiTietDonHang ct
                JOIN    SanPham sp ON sp.MaSanPham = ct.MaSanPham
                WHERE   ct.MaDonHang = " + maDonHang;
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // TÌM KHÁCH HÀNG THEO SĐT
        // =============================================
        public DataSet TimKhachHangTheoSDT(string sdt)
        {
            string sql = "SELECT MaKhachHang, HoTen, SoDienThoai, DiemHienTai, HangThanhVien " +
                         "FROM KhachHang WHERE SoDienThoai LIKE N'%" + sdt + "%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // LẤY DANH SÁCH SẢN PHẨM ĐỂ THÊM VÀO ĐƠN
        // =============================================
        public DataSet LayDanhSachSanPham()
        {
            string sql = @"
                SELECT  sp.MaSanPham,
                        sp.TenGame,
                        sp.GiaBan,
                        sp.LoaiSanPham,
                        ISNULL(k.SoLuongTon, 0) AS SoLuongTon
                FROM    SanPham sp
                LEFT JOIN Kho k ON k.MaSanPham = sp.MaSanPham
                WHERE   sp.TrangThai = 1
                ORDER BY sp.TenGame";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // TẠO ĐƠN HÀNG MỚI
        // dtChiTiet: DataTable gồm MaSanPham, SoLuong, DonGia, SerialKey
        // =============================================
        public bool TaoDonHang(
            int maKhachHang,
            int maNhanVien,
            decimal tongTien,
            decimal giamGia,
            string phuongThucTT,
            int diemSuDung,
            int diemTichLuy,
            DataTable dtChiTiet,
            ref string err)
        {
            // 1. Insert DonHang, lấy MaDonHang mới
            string sqlDH = @"
                INSERT INTO DonHang
                    (MaKhachHang, MaNhanVien, TongTien, GiamGia,
                     PhuongThucTT, DiemSuDung, DiemTichLuy, TrangThai)
                VALUES (" +
                (maKhachHang > 0 ? maKhachHang.ToString() : "NULL") + ", " +
                maNhanVien + ", " +
                tongTien.ToString(CultureInfo.InvariantCulture) + ", " +
                giamGia.ToString(CultureInfo.InvariantCulture) + ", N'" +
                phuongThucTT + "', " +
                diemSuDung + ", " +
                diemTichLuy + @", N'HoanThanh');
                SELECT SCOPE_IDENTITY();";

            DataSet dsMa = db.ExecuteQueryDataSet(sqlDH, CommandType.Text);
            if (dsMa == null || dsMa.Tables.Count == 0 || dsMa.Tables[0].Rows.Count == 0)
            {
                err = "Không tạo được đơn hàng!";
                return false;
            }
            int maDonHang = int.Parse(dsMa.Tables[0].Rows[0][0].ToString());

            // 2. Insert ChiTietDonHang + cập nhật tồn kho
            foreach (DataRow row in dtChiTiet.Rows)
            {
                int maSanPham = int.Parse(row["MaSanPham"].ToString());
                int soLuong = int.Parse(row["SoLuong"].ToString());
                decimal donGia = decimal.Parse(row["DonGia"].ToString());
                string serialKey = row["SerialKey"] != null ? row["SerialKey"].ToString() : "";

                string sqlCT = @"
                    INSERT INTO ChiTietDonHang (MaDonHang, MaSanPham, SoLuong, DonGia, SerialKey)
                    VALUES (" +
                    maDonHang + ", " + maSanPham + ", " + soLuong + ", " +
                    donGia.ToString(CultureInfo.InvariantCulture) + ", N'" + serialKey + "')";

                if (!db.MyExecuteNonQuery(sqlCT, CommandType.Text, ref err))
                    return false;

                // Trừ tồn kho
                string sqlKho = @"
                    UPDATE Kho SET
                        SoLuongTon  = SoLuongTon - " + soLuong + @",
                        NgayCapNhat = GETDATE()
                    WHERE MaSanPham = " + maSanPham;

                if (!db.MyExecuteNonQuery(sqlKho, CommandType.Text, ref err))
                    return false;
            }

            // 3. Cập nhật điểm tích lũy cho khách hàng
            if (maKhachHang > 0 && diemTichLuy > 0)
            {
                string sqlDiem = @"
                    UPDATE KhachHang SET
                        DiemHienTai     = DiemHienTai + " + diemTichLuy + @" - " + diemSuDung + @",
                        TongDiemTichLuy = TongDiemTichLuy + " + diemTichLuy + @"
                    WHERE MaKhachHang = " + maKhachHang;

                if (!db.MyExecuteNonQuery(sqlDiem, CommandType.Text, ref err))
                    return false;
            }

            return true;
        }

        // =============================================
        // HỦY ĐƠN HÀNG (hoàn tồn kho)
        // =============================================
        public bool HuyDonHang(int maDonHang, ref string err)
        {
            // Lấy chi tiết để hoàn kho
            DataSet dsChiTiet = LayChiTietDonHang(maDonHang);
            if (dsChiTiet != null && dsChiTiet.Tables.Count > 0)
            {
                foreach (DataRow row in dsChiTiet.Tables[0].Rows)
                {
                    int maSanPham = int.Parse(row["MaSanPham"].ToString());
                    int soLuong = int.Parse(row["SoLuong"].ToString());

                    string sqlKho = @"
                        UPDATE Kho SET
                            SoLuongTon  = SoLuongTon + " + soLuong + @",
                            NgayCapNhat = GETDATE()
                        WHERE MaSanPham = " + maSanPham;

                    if (!db.MyExecuteNonQuery(sqlKho, CommandType.Text, ref err))
                        return false;
                }
            }

            // Cập nhật trạng thái đơn
            string sqlHuy = "UPDATE DonHang SET TrangThai = N'DaHuy' WHERE MaDonHang = " + maDonHang;
            return db.MyExecuteNonQuery(sqlHuy, CommandType.Text, ref err);
        }
        // Doanh thu theo ngày (lọc theo khoảng thời gian)
        public DataSet ThongKeDoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            string sql = @"
                SELECT  CONVERT(NVARCHAR(10), dh.NgayBan, 103) AS Ngay,
                        COUNT(dh.MaDonHang)                    AS SoDonHang,
                        SUM(dh.ThanhToan)                      AS DoanhThu
                FROM    DonHang dh
                WHERE   dh.TrangThai = N'HoanThanh'
                  AND   CAST(dh.NgayBan AS DATE) 
                        BETWEEN '" + tuNgay.ToString("yyyy-MM-dd") + @"'
                            AND '" + denNgay.ToString("yyyy-MM-dd") + @"'
                GROUP BY CONVERT(NVARCHAR(10), dh.NgayBan, 103),
                         CAST(dh.NgayBan AS DATE)
                ORDER BY CAST(dh.NgayBan AS DATE)";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // Doanh thu theo tháng (lọc theo năm)
        public DataSet ThongKeDoanhThuTheoThang(int nam)
        {
            string sql = @"
                SELECT  MONTH(dh.NgayBan)       AS Thang,
                        COUNT(dh.MaDonHang)     AS SoDonHang,
                        SUM(dh.ThanhToan)       AS DoanhThu
                FROM    DonHang dh
                WHERE   dh.TrangThai = N'HoanThanh'
                  AND   YEAR(dh.NgayBan) = " + nam + @"
                GROUP BY MONTH(dh.NgayBan)
                ORDER BY MONTH(dh.NgayBan)";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        // =============================================
        // GAME BÁN CHẠY (Top N)
        // =============================================
        public DataSet ThongKeGameBanChay(int topN)
        {
            string sql = @"
        SELECT  TOP " + topN + @"
                sp.TenGame,
                SUM(ct.SoLuong)         AS TongBan,
                SUM(ct.ThanhTien)       AS DoanhThu,
                sp.GiaBan
        FROM    ChiTietDonHang ct
        JOIN    SanPham sp  ON sp.MaSanPham = ct.MaSanPham
        JOIN    DonHang dh  ON dh.MaDonHang = ct.MaDonHang
        WHERE   dh.TrangThai = N'HoanThanh'
        GROUP BY sp.MaSanPham, sp.TenGame, sp.GiaBan
        ORDER BY TongBan DESC";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // KHO SẮP HẾT HÀNG
        // =============================================
        public DataSet ThongKeKhoSapHet()
        {
            string sql = @"
        SELECT  sp.TenGame,
                k.SoLuongTon,
                k.SoLuongToiThieu,
                (k.SoLuongTon - k.SoLuongToiThieu)  AS SoLuongConLai,
                k.NgayCapNhat,
                CASE
                    WHEN k.SoLuongTon = 0              THEN N'Hết hàng'
                    WHEN k.SoLuongTon <= k.SoLuongToiThieu THEN N'Sắp hết'
                    ELSE N'Còn hàng'
                END AS TinhTrangKho
        FROM    Kho k
        JOIN    SanPham sp ON sp.MaSanPham = k.MaSanPham
        WHERE   k.SoLuongTon <= k.SoLuongToiThieu
           AND  k.SoLuongToiThieu > 0
        ORDER BY k.SoLuongTon ASC";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
    }
}