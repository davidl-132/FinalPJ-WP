using System.Data;
using FinalPJ_WP.DB_layer;

namespace FinalPJ_WP.BS_layer
{
    class BLNguoiDung
    {
        DBMain db = null;

        public BLNguoiDung()
        {
            db = new DBMain();
        }

        // Đăng nhập — trả về DataSet chứa thông tin user
        public DataSet DangNhap(string tenDangNhap, string matKhauHash)
        {
            string sql = @"
                SELECT  nd.MaNguoiDung,
                        nd.HoTen,
                        nd.VaiTro,
                        ISNULL(nv.MaNhanVien, 0) AS MaNhanVien
                FROM    NguoiDung nd
                LEFT JOIN NhanVien nv ON nv.MaNguoiDung = nd.MaNguoiDung
                WHERE   nd.TenDangNhap = '" + tenDangNhap + @"'
                  AND   nd.MatKhau     = '" + matKhauHash + @"'
                  AND   nd.TrangThai   = 1";

            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // Cập nhật ngày đăng nhập cuối
        public bool CapNhatNgayDangNhap(int maNguoiDung, ref string err)
        {
            string sql = "UPDATE NguoiDung SET NgayDangNhapCuoi = GETDATE() " +
                         "WHERE MaNguoiDung = " + maNguoiDung;
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
    }
}