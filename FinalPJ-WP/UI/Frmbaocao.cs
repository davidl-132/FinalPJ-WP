using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using FinalPJ_WP.BS_layer;

namespace FinalPJ_WP
{
    // Enum dùng chung trong toàn project
    public enum LoaiBaoCao
    {
        DoanhThuNgay,
        DoanhThuThang,
        GameBanChay,
        KhoSapHet
    }

    public partial class frmBaoCao : Form
    {
        BLDonHang blDH = new BLDonHang();
        private LoaiBaoCao _loai;

        // =============================================
        // CONSTRUCTOR MẶC ĐỊNH (mở form bình thường)
        // =============================================
        public frmBaoCao()
        {
            InitializeComponent();
            _loai = LoaiBaoCao.DoanhThuNgay;
        }

        // =============================================
        // CONSTRUCTOR NHẬN LOẠI BÁO CÁO TỪ MENU
        // =============================================
        public frmBaoCao(LoaiBaoCao loai)
        {
            InitializeComponent();
            _loai = loai;
        }

        // =============================================
        // LOAD FORM
        // =============================================
        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.AddDays(-30);
            dtpDenNgay.Value = DateTime.Now;

            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 4; i--)
                cboNam.Items.Add(i);
            cboNam.SelectedIndex = 0;

            // Chọn radio button và hiển thị báo cáo tương ứng
            switch (_loai)
            {
                case LoaiBaoCao.DoanhThuNgay:
                    rdoNgay.Checked = true;
                    CapNhatDieuKien();
                    HienThiBaoCaoNgay();
                    break;

                case LoaiBaoCao.DoanhThuThang:
                    rdoThang.Checked = true;
                    CapNhatDieuKien();
                    HienThiBaoCaoThang();
                    break;

                case LoaiBaoCao.GameBanChay:
                    rdoGameBanChay.Checked = true;
                    CapNhatDieuKien();
                    HienThiGameBanChay();
                    break;

                case LoaiBaoCao.KhoSapHet:
                    rdoKhoSapHet.Checked = true;
                    CapNhatDieuKien();
                    HienThiKhoSapHet();
                    break;

                default:
                    rdoNgay.Checked = true;
                    CapNhatDieuKien();
                    HienThiBaoCaoNgay();
                    break;
            }
        }

        // =============================================
        // ẨN HIỆN ĐIỀU KIỆN LỌC THEO LOẠI BÁO CÁO
        // =============================================
        void CapNhatDieuKien()
        {
            bool laNgay = rdoNgay.Checked;
            bool laThang = rdoThang.Checked;

            lblTuNgay.Visible = laNgay;
            dtpTuNgay.Visible = laNgay;
            lblDenNgay.Visible = laNgay;
            dtpDenNgay.Visible = laNgay;

            lblNam.Visible = laThang;
            cboNam.Visible = laThang;

            // Game bán chạy và Kho sắp hết không cần điều kiện lọc
            pnlDieuKien.Visible = laNgay || laThang;
        }

        private void rdoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNgay.Checked) CapNhatDieuKien();
        }

        private void rdoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThang.Checked) CapNhatDieuKien();
        }

        private void rdoGameBanChay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGameBanChay.Checked) CapNhatDieuKien();
        }

        private void rdoKhoSapHet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKhoSapHet.Checked) CapNhatDieuKien();
        }

        // =============================================
        // NÚT XEM BÁO CÁO
        // =============================================
        private void btnXem_Click(object sender, EventArgs e)
        {
            if (rdoNgay.Checked) HienThiBaoCaoNgay();
            else if (rdoThang.Checked) HienThiBaoCaoThang();
            else if (rdoGameBanChay.Checked) HienThiGameBanChay();
            else if (rdoKhoSapHet.Checked) HienThiKhoSapHet();
        }

        // =============================================
        // BÁO CÁO DOANH THU THEO NGÀY
        // =============================================
        void HienThiBaoCaoNgay()
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Từ ngày phải nhỏ hơn Đến ngày!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DataSet ds = blDH.ThongKeDoanhThuTheoNgay(
                    dtpTuNgay.Value, dtpDenNgay.Value);

                GanReport("RptDoanhThu",
                          "FinalPJ_WP.Report.RptDoanhThuNgay.rdlc",
                          ds.Tables[0]);
            }
            catch (Exception ex) { HienThiLoi(ex); }
        }

        // =============================================
        // BÁO CÁO DOANH THU THEO THÁNG
        // =============================================
        void HienThiBaoCaoThang()
        {
            try
            {
                int nam = Convert.ToInt32(cboNam.SelectedItem);
                DataSet ds = blDH.ThongKeDoanhThuTheoThang(nam);

                GanReport("RptDoanhThuThang",
                          "FinalPJ_WP.Report.RptDoanhThuThang.rdlc",
                          ds.Tables[0]);
            }
            catch (Exception ex) { HienThiLoi(ex); }
        }

        // =============================================
        // BÁO CÁO GAME BÁN CHẠY
        // =============================================
        void HienThiGameBanChay()
        {
            try
            {
                DataSet ds = blDH.ThongKeGameBanChay(10);

                DataTable dt = ds.Tables[0];
                DataView dv = dt.DefaultView;
                dv.Sort = "TongBan DESC";
                DataTable dtSorted = dv.ToTable();

                GanReport("GameBanChay",
                          "FinalPJ_WP.Report.RptGameBanChay.rdlc",
                          dtSorted);
            }
            catch (Exception ex) { HienThiLoi(ex); }
        }

        // =============================================
        // BÁO CÁO KHO SẮP HẾT HÀNG
        // =============================================
        void HienThiKhoSapHet()
        {
            try
            {
                DataSet ds = blDH.ThongKeKhoSapHet();

                GanReport("KhoSapHet",
                          "FinalPJ_WP.Report.RptKhoSapHet.rdlc",
                          ds.Tables[0]);
            }
            catch (Exception ex) { HienThiLoi(ex); }
        }

        // =============================================
        // HELPER: Gán data vào ReportViewer
        // =============================================
        void GanReport(string tenDataSource, string tenRdlc, DataTable dt)
        {
            ReportDataSource rds = new ReportDataSource(tenDataSource, dt);

            reportViewer1.LocalReport.ReportEmbeddedResource = tenRdlc;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        void HienThiLoi(Exception ex)
        {
            MessageBox.Show("Lỗi hiển thị báo cáo:\n" + ex.Message,
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // =============================================
        // NÚT TRỞ VỀ
        // =============================================
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}