namespace GUI
{
    partial class frmDanhMuc
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
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpLoc = new System.Windows.Forms.GroupBox();
            this.lblTim = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblGoiY = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.tmrTimKiem = new System.Windows.Forms.Timer(this.components);
            this.grpThongTin.SuspendLayout();
            this.grpLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            //
            // grpThongTin
            //
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Size = new System.Drawing.Size(1000, 120);
            this.grpThongTin.Text = "Thông tin";
            this.grpThongTin.BackColor = System.Drawing.Color.White;
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(8);
            this.grpThongTin.Controls.Add(this.btnLamMoi);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.txtTen);
            this.grpThongTin.Controls.Add(this.lblTen);
            this.grpThongTin.Controls.Add(this.txtMa);
            this.grpThongTin.Controls.Add(this.lblMa);
            //
            // lblMa
            //
            this.lblMa.Name = "lblMa";
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(15, 33);
            this.lblMa.Text = "Mã";
            //
            // txtMa
            //
            this.txtMa.Name = "txtMa";
            this.txtMa.Location = new System.Drawing.Point(110, 30);
            this.txtMa.Size = new System.Drawing.Size(80, 30);
            this.txtMa.ReadOnly = true;
            //
            // lblTen
            //
            this.lblTen.Name = "lblTen";
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(210, 33);
            this.lblTen.Text = "Tên";
            //
            // txtTen
            //
            this.txtTen.Name = "txtTen";
            this.txtTen.Location = new System.Drawing.Point(290, 30);
            this.txtTen.Size = new System.Drawing.Size(420, 30);
            //
            // btnThem
            //
            this.btnThem.Name = "btnThem";
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(110, 72);
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
            this.btnSua.Location = new System.Drawing.Point(220, 72);
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
            this.btnXoa.Location = new System.Drawing.Point(330, 72);
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
            this.btnLamMoi.Location = new System.Drawing.Point(440, 72);
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
            this.grpLoc.Text = "Tìm kiếm";
            this.grpLoc.BackColor = System.Drawing.Color.White;
            this.grpLoc.Padding = new System.Windows.Forms.Padding(8);
            this.grpLoc.Controls.Add(this.lblGoiY);
            this.grpLoc.Controls.Add(this.txtTimKiem);
            this.grpLoc.Controls.Add(this.lblTim);
            //
            // lblTim
            //
            this.lblTim.Name = "lblTim";
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(15, 33);
            this.lblTim.Text = "Từ khóa";
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
            this.lblGoiY.Text = "Không phân biệt dấu, hoa/thường";
            this.lblGoiY.ForeColor = System.Drawing.Color.Gray;
            this.lblGoiY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            //
            // lblKetQua
            //
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKetQua.Size = new System.Drawing.Size(1000, 28);
            this.lblKetQua.ForeColor = System.Drawing.Color.DimGray;
            this.lblKetQua.Text = "";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // dgvDanhMuc
            //
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhMuc.SelectionChanged += new System.EventHandler(this.dgvDanhMuc_SelectionChanged);
            //
            // tmrTimKiem
            //
            this.tmrTimKiem.Interval = 300;
            this.tmrTimKiem.Tick += new System.EventHandler(this.tmrTimKiem_Tick);
            //
            // frmDanhMuc
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.grpLoc);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmDanhMuc";
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.frmDanhMuc_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpLoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpLoc;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblGoiY;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Timer tmrTimKiem;
    }
}
