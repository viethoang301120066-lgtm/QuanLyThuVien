namespace GUI
{
    partial class frmSach
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
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblNamXB = new System.Windows.Forms.Label();
            this.numNamXB = new System.Windows.Forms.NumericUpDown();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.cbTacGia = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblNXB = new System.Windows.Forms.Label();
            this.cbNXB = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpLoc = new System.Windows.Forms.GroupBox();
            this.lblTim = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblGoiY = new System.Windows.Forms.Label();
            this.cbLocTheLoai = new System.Windows.Forms.ComboBox();
            this.cbLocTacGia = new System.Windows.Forms.ComboBox();
            this.cbLocNXB = new System.Windows.Forms.ComboBox();
            this.lblNamTu = new System.Windows.Forms.Label();
            this.numNamTu = new System.Windows.Forms.NumericUpDown();
            this.lblDen = new System.Windows.Forms.Label();
            this.numNamDen = new System.Windows.Forms.NumericUpDown();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnXoaLoc = new System.Windows.Forms.Button();
            this.pnlDuoi = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.tmrTimKiem = new System.Windows.Forms.Timer(this.components);
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNamXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.grpLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNamTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamDen)).BeginInit();
            this.pnlDuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            //
            // grpThongTin
            //
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Size = new System.Drawing.Size(1000, 160);
            this.grpThongTin.Text = "Thông tin sách";
            this.grpThongTin.BackColor = System.Drawing.Color.White;
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(8);
            this.grpThongTin.Controls.Add(this.btnLamMoi);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.cbNXB);
            this.grpThongTin.Controls.Add(this.lblNXB);
            this.grpThongTin.Controls.Add(this.numSoLuong);
            this.grpThongTin.Controls.Add(this.lblSoLuong);
            this.grpThongTin.Controls.Add(this.cbTacGia);
            this.grpThongTin.Controls.Add(this.lblTacGia);
            this.grpThongTin.Controls.Add(this.cbTheLoai);
            this.grpThongTin.Controls.Add(this.lblTheLoai);
            this.grpThongTin.Controls.Add(this.numNamXB);
            this.grpThongTin.Controls.Add(this.lblNamXB);
            this.grpThongTin.Controls.Add(this.txtTenSach);
            this.grpThongTin.Controls.Add(this.lblTen);
            this.grpThongTin.Controls.Add(this.txtMaSach);
            this.grpThongTin.Controls.Add(this.lblMa);
            //
            // lblMa
            //
            this.lblMa.Name = "lblMa";
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(15, 33);
            this.lblMa.Text = "Mã sách";
            //
            // txtMaSach
            //
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Location = new System.Drawing.Point(110, 30);
            this.txtMaSach.Size = new System.Drawing.Size(80, 30);
            this.txtMaSach.ReadOnly = true;
            //
            // lblTen
            //
            this.lblTen.Name = "lblTen";
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(210, 33);
            this.lblTen.Text = "Tên sách";
            //
            // txtTenSach
            //
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Location = new System.Drawing.Point(290, 30);
            this.txtTenSach.Size = new System.Drawing.Size(360, 30);
            //
            // lblNamXB
            //
            this.lblNamXB.Name = "lblNamXB";
            this.lblNamXB.AutoSize = true;
            this.lblNamXB.Location = new System.Drawing.Point(670, 33);
            this.lblNamXB.Text = "Năm XB";
            //
            // numNamXB
            //
            this.numNamXB.Name = "numNamXB";
            this.numNamXB.Location = new System.Drawing.Point(760, 30);
            this.numNamXB.Size = new System.Drawing.Size(100, 30);
            this.numNamXB.Minimum = new decimal(1900);
            this.numNamXB.Maximum = new decimal(2100);
            this.numNamXB.Value = new decimal(2024);
            //
            // lblTheLoai
            //
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(15, 73);
            this.lblTheLoai.Text = "Thể loại";
            //
            // cbTheLoai
            //
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheLoai.Location = new System.Drawing.Point(110, 70);
            this.cbTheLoai.Size = new System.Drawing.Size(200, 31);
            //
            // lblTacGia
            //
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(330, 73);
            this.lblTacGia.Text = "Tác giả";
            //
            // cbTacGia
            //
            this.cbTacGia.Name = "cbTacGia";
            this.cbTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTacGia.Location = new System.Drawing.Point(410, 70);
            this.cbTacGia.Size = new System.Drawing.Size(240, 31);
            //
            // lblSoLuong
            //
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(670, 73);
            this.lblSoLuong.Text = "Số lượng";
            //
            // numSoLuong
            //
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Location = new System.Drawing.Point(760, 70);
            this.numSoLuong.Size = new System.Drawing.Size(100, 30);
            this.numSoLuong.Minimum = new decimal(0);
            this.numSoLuong.Maximum = new decimal(10000);
            this.numSoLuong.Value = new decimal(1);
            //
            // lblNXB
            //
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.AutoSize = true;
            this.lblNXB.Location = new System.Drawing.Point(15, 113);
            this.lblNXB.Text = "Nhà XB";
            //
            // cbNXB
            //
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNXB.Location = new System.Drawing.Point(110, 110);
            this.cbNXB.Size = new System.Drawing.Size(200, 31);
            //
            // btnThem
            //
            this.btnThem.Name = "btnThem";
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(410, 108);
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
            this.btnSua.Location = new System.Drawing.Point(520, 108);
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
            this.btnXoa.Location = new System.Drawing.Point(630, 108);
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
            this.btnLamMoi.Location = new System.Drawing.Point(740, 108);
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
            this.grpLoc.Size = new System.Drawing.Size(1000, 110);
            this.grpLoc.Text = "Lọc và tìm kiếm thông minh";
            this.grpLoc.BackColor = System.Drawing.Color.White;
            this.grpLoc.Padding = new System.Windows.Forms.Padding(8);
            this.grpLoc.Controls.Add(this.btnXoaLoc);
            this.grpLoc.Controls.Add(this.cbTinhTrang);
            this.grpLoc.Controls.Add(this.numNamDen);
            this.grpLoc.Controls.Add(this.lblDen);
            this.grpLoc.Controls.Add(this.numNamTu);
            this.grpLoc.Controls.Add(this.lblNamTu);
            this.grpLoc.Controls.Add(this.cbLocNXB);
            this.grpLoc.Controls.Add(this.cbLocTacGia);
            this.grpLoc.Controls.Add(this.cbLocTheLoai);
            this.grpLoc.Controls.Add(this.lblGoiY);
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
            this.txtTimKiem.Size = new System.Drawing.Size(420, 30);
            //
            // lblGoiY
            //
            this.lblGoiY.Name = "lblGoiY";
            this.lblGoiY.AutoSize = true;
            this.lblGoiY.Location = new System.Drawing.Point(540, 34);
            this.lblGoiY.Text = "Gõ không dấu, nhiều từ, theo tên/tác giả/thể loại/NXB/năm. VD: \"clean martin\"";
            this.lblGoiY.ForeColor = System.Drawing.Color.Gray;
            this.lblGoiY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            //
            // cbLocTheLoai
            //
            this.cbLocTheLoai.Name = "cbLocTheLoai";
            this.cbLocTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocTheLoai.Location = new System.Drawing.Point(15, 68);
            this.cbLocTheLoai.Size = new System.Drawing.Size(170, 31);
            this.cbLocTheLoai.SelectedIndexChanged += new System.EventHandler(this.BoLoc_Changed);
            //
            // cbLocTacGia
            //
            this.cbLocTacGia.Name = "cbLocTacGia";
            this.cbLocTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocTacGia.Location = new System.Drawing.Point(195, 68);
            this.cbLocTacGia.Size = new System.Drawing.Size(170, 31);
            this.cbLocTacGia.SelectedIndexChanged += new System.EventHandler(this.BoLoc_Changed);
            //
            // cbLocNXB
            //
            this.cbLocNXB.Name = "cbLocNXB";
            this.cbLocNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocNXB.Location = new System.Drawing.Point(375, 68);
            this.cbLocNXB.Size = new System.Drawing.Size(170, 31);
            this.cbLocNXB.SelectedIndexChanged += new System.EventHandler(this.BoLoc_Changed);
            //
            // lblNamTu
            //
            this.lblNamTu.Name = "lblNamTu";
            this.lblNamTu.AutoSize = true;
            this.lblNamTu.Location = new System.Drawing.Point(555, 71);
            this.lblNamTu.Text = "Năm";
            //
            // numNamTu
            //
            this.numNamTu.Name = "numNamTu";
            this.numNamTu.Location = new System.Drawing.Point(600, 68);
            this.numNamTu.Size = new System.Drawing.Size(75, 30);
            this.numNamTu.Minimum = new decimal(0);
            this.numNamTu.Maximum = new decimal(2100);
            this.numNamTu.Value = new decimal(0);
            this.numNamTu.ValueChanged += new System.EventHandler(this.BoLoc_Changed);
            //
            // lblDen
            //
            this.lblDen.Name = "lblDen";
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(678, 71);
            this.lblDen.Text = "-";
            //
            // numNamDen
            //
            this.numNamDen.Name = "numNamDen";
            this.numNamDen.Location = new System.Drawing.Point(692, 68);
            this.numNamDen.Size = new System.Drawing.Size(75, 30);
            this.numNamDen.Minimum = new decimal(0);
            this.numNamDen.Maximum = new decimal(2100);
            this.numNamDen.Value = new decimal(0);
            this.numNamDen.ValueChanged += new System.EventHandler(this.BoLoc_Changed);
            //
            // cbTinhTrang
            //
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhTrang.Location = new System.Drawing.Point(777, 68);
            this.cbTinhTrang.Size = new System.Drawing.Size(110, 31);
            this.cbTinhTrang.SelectedIndexChanged += new System.EventHandler(this.BoLoc_Changed);
            //
            // btnXoaLoc
            //
            this.btnXoaLoc.Name = "btnXoaLoc";
            this.btnXoaLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLoc.Location = new System.Drawing.Point(895, 67);
            this.btnXoaLoc.Size = new System.Drawing.Size(90, 34);
            this.btnXoaLoc.Text = "Xóa lọc";
            this.btnXoaLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLoc.BackColor = System.Drawing.Color.White;
            this.btnXoaLoc.UseVisualStyleBackColor = false;
            this.btnXoaLoc.Click += new System.EventHandler(this.btnXoaLoc_Click);
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
            // dgvSach
            //
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.SelectionChanged += new System.EventHandler(this.dgvSach_SelectionChanged);
            this.dgvSach.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSach_DataBindingComplete);
            //
            // tmrTimKiem
            //
            this.tmrTimKiem.Interval = 300;
            this.tmrTimKiem.Tick += new System.EventHandler(this.tmrTimKiem_Tick);
            //
            // frmSach
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.pnlDuoi);
            this.Controls.Add(this.grpLoc);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmSach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNamXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.grpLoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNamTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamDen)).EndInit();
            this.pnlDuoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblNamXB;
        private System.Windows.Forms.NumericUpDown numNamXB;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.ComboBox cbTacGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblNXB;
        private System.Windows.Forms.ComboBox cbNXB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpLoc;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblGoiY;
        private System.Windows.Forms.ComboBox cbLocTheLoai;
        private System.Windows.Forms.ComboBox cbLocTacGia;
        private System.Windows.Forms.ComboBox cbLocNXB;
        private System.Windows.Forms.Label lblNamTu;
        private System.Windows.Forms.NumericUpDown numNamTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.NumericUpDown numNamDen;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Button btnXoaLoc;
        private System.Windows.Forms.Panel pnlDuoi;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Timer tmrTimKiem;
    }
}
