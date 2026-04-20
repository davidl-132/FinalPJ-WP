using FinalPJ_WP.DB_layer;
using System;
using System.Data;

namespace FinalPJ_WP.BS_layer
{
    class BLNhapHang
    {
        DBMain db = null;

        public BLNhapHang()
        {
            db = new DBMain();
        }

        // =============================================
        // LAY DANH SACH PHIEU NHAP
        // =============================================
        public DataSet LayTatCaPhieuNhap()
        {
            string sql = @"SELECT pn.MaPhieuNhap, ncc.TenNhaCungCap, nd.HoTen AS TenNhanVien,
                                  pn.NgayNhap, pn.TongTien, pn.TrangThai, pn.GhiChu,
                                  pn.MaNhaCungCap, pn.MaNhanVien
                           FROM PhieuNhapHang pn
                           INNER JOIN NhaCungCap ncc ON pn.MaNhaCungCap = ncc.MaNhaCungCap
                           INNER JOIN NhanVien nv    ON pn.MaNhanVien   = nv.MaNhanVien
                           INNER JOIN NguoiDung nd   ON nv.MaNguoiDung  = nd.MaNguoiDung
                           ORDER BY pn.MaPhieuNhap DESC";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // TIM KIEM PHIEU NHAP
        // =============================================
        public DataSet TimKiemPhieuNhap(string tuKhoa)
        {
            string sql = @"SELECT pn.MaPhieuNhap, ncc.TenNhaCungCap, nd.HoTen AS TenNhanVien,
                                  pn.NgayNhap, pn.TongTien, pn.TrangThai, pn.GhiChu,
                                  pn.MaNhaCungCap, pn.MaNhanVien
                           FROM PhieuNhapHang pn
                           INNER JOIN NhaCungCap ncc ON pn.MaNhaCungCap = ncc.MaNhaCungCap
                           INNER JOIN NhanVien nv    ON pn.MaNhanVien   = nv.MaNhanVien
                           INNER JOIN NguoiDung nd   ON nv.MaNguoiDung  = nd.MaNguoiDung
                           WHERE ncc.TenNhaCungCap LIKE N'%" + tuKhoa + @"%'
                              OR nd.HoTen          LIKE N'%" + tuKhoa + @"%'
                              OR pn.TrangThai      LIKE N'%" + tuKhoa + @"%'
                           ORDER BY pn.MaPhieuNhap DESC";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // LAY CHI TIET PHIEU NHAP
        // =============================================
        public DataSet LayChiTietPhieuNhap(int maPhieuNhap)
        {
            string sql = @"SELECT ct.MaChiTietNhap, sp.TenGame, ct.MaSanPham,
                                  ct.SoLuong, ct.DonGiaNhap, ct.ThanhTien
                           FROM ChiTietPhieuNhap ct
                           INNER JOIN SanPham sp ON ct.MaSanPham = sp.MaSanPham
                           WHERE ct.MaPhieuNhap = " + maPhieuNhap;
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // LAY DANH SACH NHA CUNG CAP (cho ComboBox)
        // =============================================
        public DataSet LayNhaCungCap()
        {
            string sql = "SELECT MaNhaCungCap, TenNhaCungCap FROM NhaCungCap WHERE TrangThai=1 ORDER BY TenNhaCungCap";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // LAY DANH SACH SAN PHAM (cho ComboBox)
        // =============================================
        public DataSet LaySanPham()
        {
            string sql = "SELECT MaSanPham, TenGame, GiaBan FROM SanPham WHERE TrangThai=1 ORDER BY TenGame";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // THEM PHIEU NHAP (them PhieuNhap + ChiTiet + cap nhat Kho)
        // =============================================
        public bool ThemPhieuNhap(int maNhaCungCap, int maNhanVien, string ghiChu,
                                   DataTable chiTiet, ref string err)
        {
            // Buoc 1: tinh tong tien
            decimal tongTien = 0;
            foreach (DataRow row in chiTiet.Rows)
                tongTien += Convert.ToDecimal(row["ThanhTien"]);

            // Buoc 2: them PhieuNhapHang
            string sql1 = "INSERT INTO PhieuNhapHang(MaNhaCungCap, MaNhanVien, TongTien, GhiChu) " +
                          "VALUES(" + maNhaCungCap + ", " + maNhanVien + ", " +
                          tongTien.ToString("F2").Replace(",", ".") + ", N'" + ghiChu + "')";
            if (!db.MyExecuteNonQuery(sql1, CommandType.Text, ref err)) return false;

            // Buoc 3: lay MaPhieuNhap vua tao
            object maPN = db.MyExecuteScalar(
                "SELECT TOP 1 MaPhieuNhap FROM PhieuNhapHang ORDER BY MaPhieuNhap DESC",
                CommandType.Text);
            if (maPN == null) { err = "Khong lay duoc MaPhieuNhap"; return false; }
            int maPhieuNhap = Convert.ToInt32(maPN);

            // Buoc 4: them ChiTietPhieuNhap + cap nhat Kho
            foreach (DataRow row in chiTiet.Rows)
            {
                int maSP = Convert.ToInt32(row["MaSanPham"]);
                int soLuong = Convert.ToInt32(row["SoLuong"]);
                decimal donGia = Convert.ToDecimal(row["DonGiaNhap"]);

                string sqlCT = "INSERT INTO ChiTietPhieuNhap(MaPhieuNhap, MaSanPham, SoLuong, DonGiaNhap) " +
                               "VALUES(" + maPhieuNhap + ", " + maSP + ", " + soLuong + ", " +
                               donGia.ToString("F2").Replace(",", ".") + ")";
                if (!db.MyExecuteNonQuery(sqlCT, CommandType.Text, ref err)) return false;

                // Cap nhat kho: neu da co thi tang, chua co thi them moi
                string sqlKho = @"IF EXISTS (SELECT 1 FROM Kho WHERE MaSanPham=" + maSP + @")
                                      UPDATE Kho SET SoLuongTon = SoLuongTon + " + soLuong + @",
                                                     NgayCapNhat = GETDATE()
                                      WHERE MaSanPham=" + maSP + @"
                                  ELSE
                                      INSERT INTO Kho(MaSanPham, SoLuongTon) VALUES(" + maSP + ", " + soLuong + ")";
                if (!db.MyExecuteNonQuery(sqlKho, CommandType.Text, ref err)) return false;
            }

            return true;
        }

        // =============================================
        // HUY PHIEU NHAP (cap nhat TrangThai + tru kho)
        // =============================================
        public bool HuyPhieuNhap(int maPhieuNhap, ref string err)
        {
            // Kiem tra trang thai hien tai
            object ttObj = db.MyExecuteScalar(
                "SELECT TrangThai FROM PhieuNhapHang WHERE MaPhieuNhap=" + maPhieuNhap,
                CommandType.Text);
            if (ttObj == null) { err = "Khong tim thay phieu nhap"; return false; }
            if (ttObj.ToString() == "DaHuy") { err = "Phieu nay da bi huy truoc do"; return false; }

            // Lay chi tiet de tru kho
            DataSet dsCT = LayChiTietPhieuNhap(maPhieuNhap);
            foreach (DataRow row in dsCT.Tables[0].Rows)
            {
                int maSP = Convert.ToInt32(row["MaSanPham"]);
                int soLuong = Convert.ToInt32(row["SoLuong"]);

                string sqlKho = "UPDATE Kho SET SoLuongTon = SoLuongTon - " + soLuong + ", " +
                                "NgayCapNhat = GETDATE() WHERE MaSanPham=" + maSP +
                                " AND SoLuongTon >= " + soLuong;
                if (!db.MyExecuteNonQuery(sqlKho, CommandType.Text, ref err)) return false;
            }

            // Cap nhat trang thai phieu
            string sql = "UPDATE PhieuNhapHang SET TrangThai='DaHuy' WHERE MaPhieuNhap=" + maPhieuNhap;
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        // =============================================
        // DEM TONG PHIEU NHAP
        // =============================================
        public int DemPhieuNhap()
        {
            object result = db.MyExecuteScalar(
                "SELECT COUNT(*) FROM PhieuNhapHang WHERE TrangThai='DaNhap'",
                CommandType.Text);
            return Convert.ToInt32(result);
        }
    }
}