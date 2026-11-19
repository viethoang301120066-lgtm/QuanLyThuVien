namespace GUI
{
    partial class frmDocGia
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
            this.components = new System.ComponentModel.Container();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.dtpNgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.lblHetHan = new System.Windows.Forms.Label();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpLoc = new System.Windows.Forms.GroupBox();
            this.lblTim = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.lblGoiY = new System.Windows.Forms.Label();
            this.pnlDuoi = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.tmrTimKiem = new System.Windows.Forms.Timer(this.components);
            this.grpThongTin.SuspendLayout();
            this.grpLoc.SuspendLayout();
            this.pnlDuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            //
            // grpThongTin
            //
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Size = new System.Drawing.Size(1000, 200);
            this.grpThongTin.Text = "Thông tin độc giả";
            this.grpThongTin.BackColor = System.Drawing.Color.White;
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(8);
            this.grpThongTin.Controls.Add(this.btnLamMoi);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.dtpNgayHetHan);
            this.grpThongTin.Controls.Add(this.lblHetHan);
            this.grpThongTin.Controls.Add(this.dtpNgayLapThe);
            this.grpThongTin.Controls.Add(this.lblNgayLap);
            this.grpThongTin.Controls.Add(this.txtDiaChi);
            this.grpThongTin.Controls.Add(this.lblDiaChi);
            this.grpThongTin.Controls.Add(this.txtEmail);
            this.grpThongTin.Controls.Add(this.lblEmail);
            this.grpThongTin.Controls.Add(this.txtSoDienThoai);
            this.grpThongTin.Controls.Add(this.lblSDT);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.lblNgaySinh);
            this.grpThongTin.Controls.Add(this.cbGioiTinh);
            this.grpThongTin.Controls.Add(this.lblGioiTinh);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtMaDocGia);
            this.grpThongTin.Controls.Add(this.lblMa);
            //
            // lblMa
            //
            this.lblMa.Name = "lblMa";
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(15, 33);
            this.lblMa.Text = "Mã ĐG";
            //
            // txtMaDocGia
            //
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Location = new System.Drawing.Point(110, 30);
            this.txtMaDocGia.Size = new System.Drawing.Size(80, 30);
            this.txtMaDocGia.ReadOnly = true;
            //
            // lblHoTen
            //
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(210, 33);
            this.lblHoTen.Text = "Họ tên";
            //
            // txtHoTen
            //
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Location = new System.Drawing.Point(290, 30);
            this.txtHoTen.Size = new System.Drawing.Size(260, 30);
            //
            // lblGioiTinh
            //
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(570, 33);
            this.lblGioiTinh.Text = "Giới tính";
            //
            // cbGioiTinh
            //
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.Location = new System.Drawing.Point(660, 30);
            this.cbGioiTinh.Size = new System.Drawing.Size(90, 31);
            //
            // lblNgaySinh
            //
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 73);
            this.lblNgaySinh.Text = "Ngày sinh";
            //
            // dtpNgaySinh
            //
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Location = new System.Drawing.Point(110, 70);
            this.dtpNgaySinh.Size = new System.Drawing.Size(140, 30);
            this.dtpNgaySinh.ShowCheckBox = true;
            //
            // lblSDT
            //
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(270, 73);
            this.lblSDT.Text = "SĐT";
            //
            // txtSoDienThoai
            //
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Location = new System.Drawing.Point(330, 70);
            this.txtSoDienThoai.Size = new System.Drawing.Size(150, 30);
            //
            // lblEmail
            //
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(500, 73);
            this.lblEmail.Text = "Email";
            //
            // txtEmail
            //
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Location = new System.Drawing.Point(560, 70);
            this.txtEmail.Size = new System.Drawing.Size(260, 30);
            //
            // lblDiaChi
            //
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(15, 113);
            this.lblDiaChi.Text = "Địa chỉ";
            //
            // txtDiaChi
            //
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Location = new System.Drawing.Point(110, 110);
            this.txtDiaChi.Size = new System.Drawing.Size(370, 30);
            //
            // lblNgayLap
            //
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(500, 113);
            this.lblNgayLap.Text = "Lập thẻ";
            //
            // dtpNgayLapThe
            //
            this.dtpNgayLapThe.Name = "dtpNgayLapThe";
            this.dtpNgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapThe.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLapThe.Location = new System.Drawing.Point(560, 110);
            this.dtpNgayLapThe.Size = new System.Drawing.Size(120, 30);
            //
            // lblHetHan
            //
            this.lblHetHan.Name = "lblHetHan";
            this.lblHetHan.AutoSize = true;
            this.lblHetHan.Location = new System.Drawing.Point(690, 113);
            this.lblHetHan.Text = "Hết hạn";
            //
            // dtpNgayHetHan
            //
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHetHan.Location = new System.Drawing.Point(760, 110);
            this.dtpNgayHetHan.Size = new System.Drawing.Size(120, 30);
            //
            // btnThem
            //
            this.btnThem.Name = "btnThem";
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(110, 152);
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
            this.btnSua.Location = new System.Drawing.Point(220, 152);
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
            this.btnXoa.Location = new System.Drawing.Point(330, 152);
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
            this.btnLamMoi.Location = new System.Drawing.Point(440, 152);
            this.btnLamMoi.Size = new System.Drawing.Size(100, 34);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            //
            // grpLoc
            //
            this.grpLoc.Name = "grpLoc";
            this.grpLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpLoc.Size = new System.Drawing.Size(1000, 75);
            this.grpLoc.Text = "Lọc và tìm kiếm thông minh";
            this.grpLoc.BackColor = System.Drawing.Color.White;
            this.grpLoc.Padding = new System.Windows.Forms.Padding(8);
            this.grpLoc.Controls.Add(this.lblGoiY);
            this.grpLoc.Controls.Add(this.cbTinhTrang);
            this.grpLoc.Controls.Add(this.lblTinhTrang);
            this.grpLoc.Controls.Add(this.txtTimKiem);
            this.grpLoc.Controls.Add(this.lblTim);
            //
            // lblTim
            //
            this.lblTim.Name = "lblTim";
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(15, 33);
            this.lblTim.Text = "Tìm kiếm";
            //
            // txtTimKiem
            //
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Location = new System.Drawing.Point(110, 30);
            this.txtTimKiem.Size = new System.Drawing.Size(340, 30);
            //
            // lblTinhTrang
            //
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(465, 33);
            this.lblTinhTrang.Text = "Tình trạng";
            //
            // cbTinhTrang
            //
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhTrang.Location = new System.Drawing.Point(555, 30);
            this.cbTinhTrang.Size = new System.Drawing.Size(200, 31);
            this.cbTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbTinhTrang_SelectedIndexChanged);
            //
            // lblGoiY
            //
            this.lblGoiY.Name = "lblGoiY";
            this.lblGoiY.AutoSize = true;
            this.lblGoiY.Location = new System.Drawing.Point(765, 34);
            this.lblGoiY.Text = "Tên / SĐT / email / địa chỉ, không dấu";
            this.lblGoiY.ForeColor = System.Drawing.Color.Gray;
            this.lblGoiY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            //
            // pnlDuoi
            //
            this.pnlDuoi.Name = "pnlDuoi";
            this.pnlDuoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDuoi.Size = new System.Drawing.Size(1000, 42);
            this.pnlDuoi.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.pnlDuoi.Controls.Add(this.lblKetQua);
            this.pnlDuoi.Controls.Add(this.btnXuatExcel);
            this.pnlDuoi.Controls.Add(this.btnIn);
            //
            // btnIn
            //
            this.btnIn.Name = "btnIn";
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIn.Size = new System.Drawing.Size(110, 34);
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Text = "In / Xem trước";
            this.btnIn.BackColor = System.Drawing.Color.White;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            //
            // btnXuatExcel
            //
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXuatExcel.Size = new System.Drawing.Size(110, 34);
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            //
            // lblKetQua
            //
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKetQua.ForeColor = System.Drawing.Color.DimGray;
            this.lblKetQua.Text = "";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // dgvDocGia
            //
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocGia.SelectionChanged += new System.EventHandler(this.dgvDocGia_SelectionChanged);
            this.dgvDocGia.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDocGia_DataBindingComplete);
            //
            // tmrTimKiem
            //
            this.tmrTimKiem.Interval = 300;
            this.tmrTimKiem.Tick += new System.EventHandler(this.tmrTimKiem_Tick);
            //
            // frmDocGia
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.pnlDuoi);
            this.Controls.Add(this.grpLoc);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmDocGia";
            this.Text = "Quản lý độc giả";
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpLoc.ResumeLayout(false);
            this.pnlDuoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.DateTimePicker dtpNgayLapThe;
        private System.Windows.Forms.Label lblHetHan;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpLoc;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Label lblGoiY;
        private System.Windows.Forms.Panel pnlDuoi;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Timer tmrTimKiem;
    }
}
