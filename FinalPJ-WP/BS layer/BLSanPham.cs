using System.Data;
using System.Globalization;
using FinalPJ_WP.DB_layer;

namespace FinalPJ_WP.BS_layer
{
    class BLSanPham
    {
        DBMain db = null;

        public BLSanPham()
        {
            db = new DBMain();
        }

        // =============================================
        // LẤY TẤT CẢ SẢN PHẨM
        // =============================================
        public DataSet LayTatCaSanPham()
        {
            string sql = @"
                SELECT  sp.MaSanPham,
                        sp.TenGame,
                        sp.MaTheLoai,
                        tl.TenTheLoai,
                        sp.NhaPhatHanh,
                        sp.NhaPhatTrien,
                        sp.NgayPhatHanh,
                        sp.NenTang,
                        sp.MoTa,
                        sp.HinhAnh,
                        sp.GiaBan,
                        sp.LoaiSanPham,
                        sp.TrangThai
                FROM    SanPham sp
                LEFT JOIN TheLoai tl ON tl.MaTheLoai = sp.MaTheLoai
                WHERE   sp.TrangThai = 1
                ORDER BY sp.TenGame";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // LẤY DANH SÁCH THỂ LOẠI
        // =============================================
        public DataSet LayTheLoai()
        {
            string sql = "SELECT MaTheLoai, TenTheLoai FROM TheLoai ORDER BY TenTheLoai";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // TÌM KIẾM SẢN PHẨM
        // =============================================
        public DataSet TimKiemSanPham(string tuKhoa, int maTheLoai, bool hienCaAn = false)
        {
            string sql = @"
                SELECT  sp.MaSanPham,
                        sp.TenGame,
                        sp.MaTheLoai,
                        tl.TenTheLoai,
                        sp.NhaPhatHanh,
                        sp.NhaPhatTrien,
                        sp.NgayPhatHanh,
                        sp.NenTang,
                        sp.MoTa,
                        sp.HinhAnh,
                        sp.GiaBan,
                        sp.LoaiSanPham,
                        sp.TrangThai
                FROM    SanPham sp
                LEFT JOIN TheLoai tl ON tl.MaTheLoai = sp.MaTheLoai
                WHERE   1=1";

            if (!hienCaAn)
                sql += " AND sp.TrangThai = 1";

            if (!string.IsNullOrEmpty(tuKhoa))
                sql += " AND (sp.TenGame LIKE N'%" + tuKhoa + "%'" +
                       " OR sp.NhaPhatHanh LIKE N'%" + tuKhoa + "%')";

            if (maTheLoai > 0)
                sql += " AND sp.MaTheLoai = " + maTheLoai;

            sql += " ORDER BY sp.TenGame";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // LẤY CHI TIẾT VẬT LÝ
        // =============================================
        public DataSet LayChiTietVatLy(int maSanPham)
        {
            string sql = "SELECT MaSKU, LoaiDia, TinhTrang " +
                         "FROM SanPhamVatLy WHERE MaSanPham = " + maSanPham;
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // LẤY CHI TIẾT DIGITAL
        // =============================================
        public DataSet LayChiTietDigital(int maSanPham)
        {
            string sql = "SELECT NenTangPhanPhoi, KhuVucHoTro " +
                         "FROM SanPhamDigital WHERE MaSanPham = " + maSanPham;
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // =============================================
        // THÊM SẢN PHẨM
        // coVatLy / coDigital: UI truyền xuống biết cần lưu bảng nào
        // =============================================
        public bool ThemSanPham(string tenGame, int maTheLoai,
            string nhaPhatHanh, string nhaPhatTrien,
            string ngayPhatHanh, string nenTang,
            string moTa, string hinhAnh,
            decimal giaBan, bool isDigital,
            bool coVatLy, bool coDigital,
            string maSKU, string loaiDia, string tinhTrang,
            string nenTangPhanPhoi, string khuVucHoTro,
            ref string err)
        {
            int loaiSanPham = isDigital ? 1 : 0;

            // 1. Insert SanPham và lấy ID mới
            string sqlSP = @"
                INSERT INTO SanPham
                    (TenGame, MaTheLoai, NhaPhatHanh, NhaPhatTrien,
                     NgayPhatHanh, NenTang, MoTa, HinhAnh,
                     GiaBan, LoaiSanPham, TrangThai)
                VALUES (
                    N'" + tenGame + "', " +
                    maTheLoai + ", N'" +
                    nhaPhatHanh + "', N'" +
                    nhaPhatTrien + "', '" +
                    ngayPhatHanh + "', N'" +
                    nenTang + "', N'" +
                    moTa + "', N'" +
                    hinhAnh + "', " +
                    giaBan.ToString(CultureInfo.InvariantCulture) + ", " +
                    loaiSanPham + @", 1);
                SELECT SCOPE_IDENTITY();";

            DataSet dsMa = db.ExecuteQueryDataSet(sqlSP, CommandType.Text);
            if (dsMa == null || dsMa.Tables.Count == 0 || dsMa.Tables[0].Rows.Count == 0)
            {
                err = "Không lấy được mã sản phẩm sau khi thêm!";
                return false;
            }
            int maSanPham = int.Parse(dsMa.Tables[0].Rows[0][0].ToString());

            // 2. Insert bảng mở rộng theo loại UI chỉ định
            if (coVatLy)
            {
                string sqlVL = "INSERT INTO SanPhamVatLy (MaSanPham, MaSKU, LoaiDia, TinhTrang) VALUES (" +
                    maSanPham + ", N'" + maSKU + "', N'" + loaiDia + "', N'" + tinhTrang + "')";
                if (!db.MyExecuteNonQuery(sqlVL, CommandType.Text, ref err))
                    return false;
            }

            if (coDigital)
            {
                string sqlDG = "INSERT INTO SanPhamDigital (MaSanPham, NenTangPhanPhoi, KhuVucHoTro) VALUES (" +
                    maSanPham + ", N'" + nenTangPhanPhoi + "', N'" + khuVucHoTro + "')";
                if (!db.MyExecuteNonQuery(sqlDG, CommandType.Text, ref err))
                    return false;
            }

            // 3. Tạo bản ghi Kho mặc định
            string sqlKho = "INSERT INTO Kho (MaSanPham, SoLuongTon, SoLuongToiThieu) VALUES (" +
                maSanPham + ", 0, 5)";
            return db.MyExecuteNonQuery(sqlKho, CommandType.Text, ref err);
        }

        // =============================================
        // SỬA SẢN PHẨM
        // coVatLy / coDigital: UI truyền xuống biết cần lưu bảng nào
        // =============================================
        public bool SuaSanPham(int maSanPham,
            string tenGame, int maTheLoai,
            string nhaPhatHanh, string nhaPhatTrien,
            string ngayPhatHanh, string nenTang,
            string moTa, string hinhAnh,
            decimal giaBan, bool isDigital, bool trangThai,
            bool coVatLy, bool coDigital,
            string maSKU, string loaiDia, string tinhTrang,
            string nenTangPhanPhoi, string khuVucHoTro,
            ref string err)
        {
            int loaiSanPham = isDigital ? 1 : 0;
            int tt = trangThai ? 1 : 0;

            // 1. Update SanPham
            string sqlSP = @"
                UPDATE SanPham SET
                    TenGame      = N'" + tenGame + "', " +
                   "MaTheLoai    = " + maTheLoai + ", " +
                   "NhaPhatHanh  = N'" + nhaPhatHanh + "', " +
                   "NhaPhatTrien = N'" + nhaPhatTrien + "', " +
                   "NgayPhatHanh = '" + ngayPhatHanh + "', " +
                   "NenTang      = N'" + nenTang + "', " +
                   "MoTa         = N'" + moTa + "', " +
                   "HinhAnh      = N'" + hinhAnh + "', " +
                   "GiaBan       = " + giaBan.ToString(CultureInfo.InvariantCulture) + ", " +
                   "LoaiSanPham  = " + loaiSanPham + ", " +
                   "TrangThai    = " + tt +
                   " WHERE MaSanPham = " + maSanPham;

            if (!db.MyExecuteNonQuery(sqlSP, CommandType.Text, ref err))
                return false;

            // 2. Xóa bản ghi mở rộng cũ
            string sqlXoa =
                "DELETE FROM SanPhamVatLy   WHERE MaSanPham = " + maSanPham + "; " +
                "DELETE FROM SanPhamDigital WHERE MaSanPham = " + maSanPham;
            if (!db.MyExecuteNonQuery(sqlXoa, CommandType.Text, ref err))
                return false;

            // 3. Insert lại bảng mở rộng theo loại UI chỉ định
            if (coVatLy)
            {
                string sqlVL = "INSERT INTO SanPhamVatLy (MaSanPham, MaSKU, LoaiDia, TinhTrang) VALUES (" +
                    maSanPham + ", N'" + maSKU + "', N'" + loaiDia + "', N'" + tinhTrang + "')";
                if (!db.MyExecuteNonQuery(sqlVL, CommandType.Text, ref err))
                    return false;
            }

            if (coDigital)
            {
                string sqlDG = "INSERT INTO SanPhamDigital (MaSanPham, NenTangPhanPhoi, KhuVucHoTro) VALUES (" +
                    maSanPham + ", N'" + nenTangPhanPhoi + "', N'" + khuVucHoTro + "')";
                if (!db.MyExecuteNonQuery(sqlDG, CommandType.Text, ref err))
                    return false;
            }

            return true;
        }

        // =============================================
        // XÓA (ẨN) SẢN PHẨM — soft delete
        // =============================================
        public bool XoaSanPham(int maSanPham, ref string err)
        {
            string sql = "UPDATE SanPham SET TrangThai = 0 WHERE MaSanPham = " + maSanPham;
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        // =============================================
        // HIỆN LẠI SẢN PHẨM ĐÃ ẨN
        // =============================================
        public bool HienLaiSanPham(int maSanPham, ref string err)
        {
            string sql = "UPDATE SanPham SET TrangThai = 1 WHERE MaSanPham = " + maSanPham;
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
    }
}