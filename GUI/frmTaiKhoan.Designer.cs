namespace GUI
{
    partial class frmTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.cbVaiTro = new System.Windows.Forms.ComboBox();
            this.lblGoiY = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDatLaiMK = new System.Windows.Forms.Button();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            //
            // grpThongTin
            //
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Size = new System.Drawing.Size(1000, 160);
            this.grpThongTin.Text = "Thông tin tài khoản";
            this.grpThongTin.BackColor = System.Drawing.Color.White;
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(8);
            this.grpThongTin.Controls.Add(this.btnDatLaiMK);
            this.grpThongTin.Controls.Add(this.btnLamMoi);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.lblGoiY);
            this.grpThongTin.Controls.Add(this.cbVaiTro);
            this.grpThongTin.Controls.Add(this.lblVaiTro);
            this.grpThongTin.Controls.Add(this.txtMatKhau);
            this.grpThongTin.Controls.Add(this.lblMatKhau);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtTenDangNhap);
            this.grpThongTin.Controls.Add(this.lblTenDN);
            //
            // lblTenDN
            //
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Location = new System.Drawing.Point(15, 33);
            this.lblTenDN.Text = "Tên đăng nhập";
            //
            // txtTenDangNhap
            //
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Location = new System.Drawing.Point(140, 30);
            this.txtTenDangNhap.Size = new System.Drawing.Size(200, 30);
            //
            // lblHoTen
            //
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(360, 33);
            this.lblHoTen.Text = "Họ tên";
            //
            // txtHoTen
            //
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Location = new System.Drawing.Point(440, 30);
            this.txtHoTen.Size = new System.Drawing.Size(280, 30);
            //
            // lblMatKhau
            //
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(15, 73);
            this.lblMatKhau.Text = "Mật khẩu";
            //
            // txtMatKhau
            //
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Location = new System.Drawing.Point(140, 70);
            this.txtMatKhau.Size = new System.Drawing.Size(200, 30);
            this.txtMatKhau.UseSystemPasswordChar = true;
            //
            // lblVaiTro
            //
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Location = new System.Drawing.Point(360, 73);
            this.lblVaiTro.Text = "Vai trò";
            //
            // cbVaiTro
            //
            this.cbVaiTro.Name = "cbVaiTro";
            this.cbVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVaiTro.Location = new System.Drawing.Point(440, 70);
            this.cbVaiTro.Size = new System.Drawing.Size(160, 31);
            //
            // lblGoiY
            //
            this.lblGoiY.Name = "lblGoiY";
            this.lblGoiY.AutoSize = true;
            this.lblGoiY.Location = new System.Drawing.Point(620, 74);
            this.lblGoiY.Text = "Mật khẩu chỉ dùng khi Thêm / Đặt lại";
            this.lblGoiY.ForeColor = System.Drawing.Color.Gray;
            this.lblGoiY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            //
            // btnThem
            //
            this.btnThem.Name = "btnThem";
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(140, 112);
            this.btnThem.Size = new System.Drawing.Size(100, 34);
            this.btnThem.Text = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            //
            // btnSua
            //
            this.btnSua.Name = "btnSua";
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(250, 112);
            this.btnSua.Size = new System.Drawing.Size(100, 34);
            this.btnSua.Text = "Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            //
            // btnXoa
            //
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(360, 112);
            this.btnXoa.Size = new System.Drawing.Size(100, 34);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            //
            // btnLamMoi
            //
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Location = new System.Drawing.Point(470, 112);
            this.btnLamMoi.Size = new System.Drawing.Size(100, 34);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            //
            // btnDatLaiMK
            //
            this.btnDatLaiMK.Name = "btnDatLaiMK";
            this.btnDatLaiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLaiMK.Location = new System.Drawing.Point(580, 112);
            this.btnDatLaiMK.Size = new System.Drawing.Size(160, 34);
            this.btnDatLaiMK.Text = "Đặt lại mật khẩu";
            this.btnDatLaiMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatLaiMK.BackColor = System.Drawing.Color.White;
            this.btnDatLaiMK.UseVisualStyleBackColor = false;
            this.btnDatLaiMK.Click += new System.EventHandler(this.btnDatLaiMK_Click);
            //
            // dgvTaiKhoan
            //
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.SelectionChanged += new System.EventHandler(this.dgvTaiKhoan_SelectionChanged);
            //
            // frmTaiKhoan
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmTaiKhoan";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.ComboBox cbVaiTro;
        private System.Windows.Forms.Label lblGoiY;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDatLaiMK;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
    }
}
