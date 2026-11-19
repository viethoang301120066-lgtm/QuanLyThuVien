namespace GUI
{
    partial class frmTraSach
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabDangMuon = new System.Windows.Forms.TabPage();
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.lblTim = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.chkQuaHan = new System.Windows.Forms.CheckBox();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.pnlDuoi = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.dgvDangMuon = new System.Windows.Forms.DataGridView();
            this.tabLichSu = new System.Windows.Forms.TabPage();
            this.pnlLocLS = new System.Windows.Forms.Panel();
            this.lblTimLS = new System.Windows.Forms.Label();
            this.txtTimLichSu = new System.Windows.Forms.TextBox();
            this.pnlDuoiLS = new System.Windows.Forms.Panel();
            this.btnInLS = new System.Windows.Forms.Button();
            this.btnXuatExcelLS = new System.Windows.Forms.Button();
            this.lblKetQuaLS = new System.Windows.Forms.Label();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.tmrTimKiem = new System.Windows.Forms.Timer(this.components);
            this.tabMain.SuspendLayout();
            this.tabDangMuon.SuspendLayout();
            this.pnlLoc.SuspendLayout();
            this.pnlDuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).BeginInit();
            this.tabLichSu.SuspendLayout();
            this.pnlLocLS.SuspendLayout();
            this.pnlDuoiLS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            //
            // tabMain
            //
            this.tabMain.Name = "tabMain";
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Controls.Add(this.tabLichSu);
            this.tabMain.Controls.Add(this.tabDangMuon);
            //
            // tabDangMuon
            //
            this.tabDangMuon.Name = "tabDangMuon";
            this.tabDangMuon.Text = "Sách đang mượn";
            this.tabDangMuon.Padding = new System.Windows.Forms.Padding(6);
            this.tabDangMuon.Controls.Add(this.dgvDangMuon);
            this.tabDangMuon.Controls.Add(this.pnlDuoi);
            this.tabDangMuon.Controls.Add(this.pnlLoc);
            //
            // pnlLoc
            //
            this.pnlLoc.Name = "pnlLoc";
            this.pnlLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoc.Size = new System.Drawing.Size(980, 50);
            this.pnlLoc.Controls.Add(this.btnTraSach);
            this.pnlLoc.Controls.Add(this.chkQuaHan);
            this.pnlLoc.Controls.Add(this.txtTimKiem);
            this.pnlLoc.Controls.Add(this.lblTim);
            //
            // lblTim
            //
            this.lblTim.Name = "lblTim";
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(4, 13);
            this.lblTim.Text = "Tìm kiếm";
            //
            // txtTimKiem
            //
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Location = new System.Drawing.Point(90, 10);
            this.txtTimKiem.Size = new System.Drawing.Size(340, 30);
            //
            // chkQuaHan
            //
            this.chkQuaHan.Name = "chkQuaHan";
            this.chkQuaHan.AutoSize = true;
            this.chkQuaHan.Location = new System.Drawing.Point(445, 12);
            this.chkQuaHan.Text = "Chỉ hiện sách quá hạn";
            this.chkQuaHan.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.chkQuaHan.CheckedChanged += new System.EventHandler(this.chkQuaHan_CheckedChanged);
            //
            // btnTraSach
            //
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraSach.Location = new System.Drawing.Point(650, 7);
            this.btnTraSach.Size = new System.Drawing.Size(170, 34);
            this.btnTraSach.Text = "Trả sách đã chọn";
            this.btnTraSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraSach.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnTraSach.ForeColor = System.Drawing.Color.White;
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
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
            this.lblKetQua.Text = "Mẹo: giữ Ctrl/Shift để chọn nhiều sách và trả cùng lúc.";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // dgvDangMuon
            //
            this.dgvDangMuon.Name = "dgvDangMuon";
            this.dgvDangMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDangMuon.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDangMuon_DataBindingComplete);
            //
            // tabLichSu
            //
            this.tabLichSu.Name = "tabLichSu";
            this.tabLichSu.Text = "Lịch sử trả sách";
            this.tabLichSu.Padding = new System.Windows.Forms.Padding(6);
            this.tabLichSu.Controls.Add(this.dgvLichSu);
            this.tabLichSu.Controls.Add(this.pnlDuoiLS);
            this.tabLichSu.Controls.Add(this.pnlLocLS);
            //
            // pnlLocLS
            //
            this.pnlLocLS.Name = "pnlLocLS";
            this.pnlLocLS.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLocLS.Size = new System.Drawing.Size(980, 50);
            this.pnlLocLS.Controls.Add(this.txtTimLichSu);
            this.pnlLocLS.Controls.Add(this.lblTimLS);
            //
            // lblTimLS
            //
            this.lblTimLS.Name = "lblTimLS";
            this.lblTimLS.AutoSize = true;
            this.lblTimLS.Location = new System.Drawing.Point(4, 13);
            this.lblTimLS.Text = "Tìm kiếm";
            //
            // txtTimLichSu
            //
            this.txtTimLichSu.Name = "txtTimLichSu";
            this.txtTimLichSu.Location = new System.Drawing.Point(90, 10);
            this.txtTimLichSu.Size = new System.Drawing.Size(340, 30);
            //
            // pnlDuoiLS
            //
            this.pnlDuoiLS.Name = "pnlDuoiLS";
            this.pnlDuoiLS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDuoiLS.Size = new System.Drawing.Size(1000, 42);
            this.pnlDuoiLS.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.pnlDuoiLS.Controls.Add(this.lblKetQuaLS);
            this.pnlDuoiLS.Controls.Add(this.btnXuatExcelLS);
            this.pnlDuoiLS.Controls.Add(this.btnInLS);
            //
            // btnInLS
            //
            this.btnInLS.Name = "btnInLS";
            this.btnInLS.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInLS.Size = new System.Drawing.Size(110, 34);
            this.btnInLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInLS.Text = "In / Xem trước";
            this.btnInLS.BackColor = System.Drawing.Color.White;
            this.btnInLS.UseVisualStyleBackColor = false;
            this.btnInLS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInLS.Click += new System.EventHandler(this.btnInLS_Click);
            //
            // btnXuatExcelLS
            //
            this.btnXuatExcelLS.Name = "btnXuatExcelLS";
            this.btnXuatExcelLS.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXuatExcelLS.Size = new System.Drawing.Size(110, 34);
            this.btnXuatExcelLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcelLS.Text = "Xuất Excel";
            this.btnXuatExcelLS.BackColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btnXuatExcelLS.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelLS.UseVisualStyleBackColor = false;
            this.btnXuatExcelLS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcelLS.Click += new System.EventHandler(this.btnXuatExcelLS_Click);
            //
            // lblKetQuaLS
            //
            this.lblKetQuaLS.Name = "lblKetQuaLS";
            this.lblKetQuaLS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKetQuaLS.ForeColor = System.Drawing.Color.DimGray;
            this.lblKetQuaLS.Text = "";
            this.lblKetQuaLS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // dgvLichSu
            //
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            //
            // tmrTimKiem
            //
            this.tmrTimKiem.Interval = 300;
            this.tmrTimKiem.Tick += new System.EventHandler(this.tmrTimKiem_Tick);
            //
            // frmTraSach
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmTraSach";
            this.Text = "Trả sách";
            this.Load += new System.EventHandler(this.frmTraSach_Load);
            this.tabMain.ResumeLayout(false);
            this.tabDangMuon.ResumeLayout(false);
            this.pnlLoc.ResumeLayout(false);
            this.pnlDuoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).EndInit();
            this.tabLichSu.ResumeLayout(false);
            this.pnlLocLS.ResumeLayout(false);
            this.pnlDuoiLS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabDangMuon;
        private System.Windows.Forms.Panel pnlLoc;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.CheckBox chkQuaHan;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Panel pnlDuoi;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.DataGridView dgvDangMuon;
        private System.Windows.Forms.TabPage tabLichSu;
        private System.Windows.Forms.Panel pnlLocLS;
        private System.Windows.Forms.Label lblTimLS;
        private System.Windows.Forms.TextBox txtTimLichSu;
        private System.Windows.Forms.Panel pnlDuoiLS;
        private System.Windows.Forms.Button btnInLS;
        private System.Windows.Forms.Button btnXuatExcelLS;
        private System.Windows.Forms.Label lblKetQuaLS;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Timer tmrTimKiem;
    }
}
