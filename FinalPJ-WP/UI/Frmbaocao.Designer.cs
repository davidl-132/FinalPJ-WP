namespace FinalPJ_WP
{
    partial class frmBaoCao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.grpLoaiBaoCao = new System.Windows.Forms.GroupBox();
            this.rdoNgay = new System.Windows.Forms.RadioButton();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.rdoGameBanChay = new System.Windows.Forms.RadioButton();
            this.rdoKhoSapHet = new System.Windows.Forms.RadioButton();
            this.pnlDieuKien = new System.Windows.Forms.Panel();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNam = new System.Windows.Forms.Label();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlTop.SuspendLayout();
            this.grpLoaiBaoCao.SuspendLayout();
            this.pnlDieuKien.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlTop.Controls.Add(this.grpLoaiBaoCao);
            this.pnlTop.Controls.Add(this.pnlDieuKien);
            this.pnlTop.Controls.Add(this.btnXem);
            this.pnlTop.Controls.Add(this.btnTroVe);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnlTop.Size = new System.Drawing.Size(1281, 80);
            this.pnlTop.TabIndex = 1;
            // 
            // grpLoaiBaoCao
            // 
            this.grpLoaiBaoCao.Controls.Add(this.rdoNgay);
            this.grpLoaiBaoCao.Controls.Add(this.rdoThang);
            this.grpLoaiBaoCao.Controls.Add(this.rdoGameBanChay);
            this.grpLoaiBaoCao.Controls.Add(this.rdoKhoSapHet);
            this.grpLoaiBaoCao.ForeColor = System.Drawing.Color.White;
            this.grpLoaiBaoCao.Location = new System.Drawing.Point(10, 5);
            this.grpLoaiBaoCao.Name = "grpLoaiBaoCao";
            this.grpLoaiBaoCao.Size = new System.Drawing.Size(460, 68);
            this.grpLoaiBaoCao.TabIndex = 0;
            this.grpLoaiBaoCao.TabStop = false;
            this.grpLoaiBaoCao.Text = "Loại báo cáo";
            // 
            // rdoNgay
            // 
            this.rdoNgay.Checked = true;
            this.rdoNgay.ForeColor = System.Drawing.Color.White;
            this.rdoNgay.Location = new System.Drawing.Point(10, 20);
            this.rdoNgay.Name = "rdoNgay";
            this.rdoNgay.Size = new System.Drawing.Size(155, 20);
            this.rdoNgay.TabIndex = 0;
            this.rdoNgay.TabStop = true;
            this.rdoNgay.Text = "Doanh thu theo ngày";
            this.rdoNgay.CheckedChanged += new System.EventHandler(this.rdoNgay_CheckedChanged);
            // 
            // rdoThang
            // 
            this.rdoThang.ForeColor = System.Drawing.Color.White;
            this.rdoThang.Location = new System.Drawing.Point(200, 20);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Size = new System.Drawing.Size(165, 20);
            this.rdoThang.TabIndex = 1;
            this.rdoThang.Text = "Doanh thu theo tháng";
            this.rdoThang.CheckedChanged += new System.EventHandler(this.rdoThang_CheckedChanged);
            // 
            // rdoGameBanChay
            // 
            this.rdoGameBanChay.ForeColor = System.Drawing.Color.White;
            this.rdoGameBanChay.Location = new System.Drawing.Point(10, 44);
            this.rdoGameBanChay.Name = "rdoGameBanChay";
            this.rdoGameBanChay.Size = new System.Drawing.Size(175, 20);
            this.rdoGameBanChay.TabIndex = 2;
            this.rdoGameBanChay.Text = "Game bán chạy (Top 10)";
            this.rdoGameBanChay.CheckedChanged += new System.EventHandler(this.rdoGameBanChay_CheckedChanged);
            // 
            // rdoKhoSapHet
            // 
            this.rdoKhoSapHet.ForeColor = System.Drawing.Color.White;
            this.rdoKhoSapHet.Location = new System.Drawing.Point(200, 42);
            this.rdoKhoSapHet.Name = "rdoKhoSapHet";
            this.rdoKhoSapHet.Size = new System.Drawing.Size(155, 20);
            this.rdoKhoSapHet.TabIndex = 3;
            this.rdoKhoSapHet.Text = "Kho sắp hết hàng";
            this.rdoKhoSapHet.CheckedChanged += new System.EventHandler(this.rdoKhoSapHet_CheckedChanged);
            // 
            // pnlDieuKien
            // 
            this.pnlDieuKien.BackColor = System.Drawing.Color.Transparent;
            this.pnlDieuKien.Controls.Add(this.lblTuNgay);
            this.pnlDieuKien.Controls.Add(this.dtpTuNgay);
            this.pnlDieuKien.Controls.Add(this.lblDenNgay);
            this.pnlDieuKien.Controls.Add(this.dtpDenNgay);
            this.pnlDieuKien.Controls.Add(this.lblNam);
            this.pnlDieuKien.Controls.Add(this.cboNam);
            this.pnlDieuKien.Location = new System.Drawing.Point(485, 12);
            this.pnlDieuKien.Name = "pnlDieuKien";
            this.pnlDieuKien.Size = new System.Drawing.Size(480, 55);
            this.pnlDieuKien.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.ForeColor = System.Drawing.Color.White;
            this.lblTuNgay.Location = new System.Drawing.Point(0, 18);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(58, 17);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(65, 14);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(125, 24);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.ForeColor = System.Drawing.Color.White;
            this.lblDenNgay.Location = new System.Drawing.Point(200, 18);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(66, 17);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(270, 14);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(125, 24);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.ForeColor = System.Drawing.Color.White;
            this.lblNam.Location = new System.Drawing.Point(0, 18);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(39, 17);
            this.lblNam.TabIndex = 4;
            this.lblNam.Text = "Năm:";
            this.lblNam.Visible = false;
            // 
            // cboNam
            // 
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.Location = new System.Drawing.Point(45, 14);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(100, 25);
            this.cboNam.TabIndex = 5;
            this.cboNam.Visible = false;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(980, 15);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(130, 34);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "▶  Xem báo cáo";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnTroVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTroVe.FlatAppearance.BorderSize = 0;
            this.btnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroVe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(1120, 15);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(85, 34);
            this.btnTroVe.TabIndex = 3;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.Location = new System.Drawing.Point(0, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1281, 631);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmBaoCao
            // 
            this.ClientSize = new System.Drawing.Size(1281, 711);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Thống Kê";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.pnlTop.ResumeLayout(false);
            this.grpLoaiBaoCao.ResumeLayout(false);
            this.pnlDieuKien.ResumeLayout(false);
            this.pnlDieuKien.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grpLoaiBaoCao;
        private System.Windows.Forms.RadioButton rdoNgay;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.RadioButton rdoGameBanChay;
        private System.Windows.Forms.RadioButton rdoKhoSapHet;
        private System.Windows.Forms.Panel pnlDieuKien;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnTroVe;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}