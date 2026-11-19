namespace GUI
{
    partial class frmMuonSach
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
            this.grpDocGia = new System.Windows.Forms.GroupBox();
            this.lblDocGia = new System.Windows.Forms.Label();
            this.cbDocGia = new System.Windows.Forms.ComboBox();
            this.lblHanTra = new System.Windows.Forms.Label();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.lblThongTinDG = new System.Windows.Forms.Label();
            this.pnlPhai = new System.Windows.Forms.Panel();
            this.grpPhieu = new System.Windows.Forms.GroupBox();
            this.lstSachMuon = new System.Windows.Forms.ListBox();
            this.pnlNutPhieu = new System.Windows.Forms.Panel();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnBoChon = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.grpChonSach = new System.Windows.Forms.GroupBox();
            this.pnlTim = new System.Windows.Forms.Panel();
            this.lblTim = new System.Windows.Forms.Label();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.tmrTimKiem = new System.Windows.Forms.Timer(this.components);
            this.grpDocGia.SuspendLayout();
            this.pnlPhai.SuspendLayout();
            this.grpPhieu.SuspendLayout();
            this.pnlNutPhieu.SuspendLayout();
            this.grpChonSach.SuspendLayout();
            this.pnlTim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            //
            // grpDocGia
            //
            this.grpDocGia.Name = "grpDocGia";
            this.grpDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDocGia.Size = new System.Drawing.Size(1000, 110);
            this.grpDocGia.Text = "1. Chọn độc giả";
            this.grpDocGia.BackColor = System.Drawing.Color.White;
            this.grpDocGia.Padding = new System.Windows.Forms.Padding(8);
            this.grpDocGia.Controls.Add(this.lblThongTinDG);
            this.grpDocGia.Controls.Add(this.dtpHanTra);
            this.grpDocGia.Controls.Add(this.lblHanTra);
            this.grpDocGia.Controls.Add(this.cbDocGia);
            this.grpDocGia.Controls.Add(this.lblDocGia);
            //
            // lblDocGia
            //
            this.lblDocGia.Name = "lblDocGia";
            this.lblDocGia.AutoSize = true;
            this.lblDocGia.Location = new System.Drawing.Point(15, 33);
            this.lblDocGia.Text = "Độc giả";
            //
            // cbDocGia
            //
            this.cbDocGia.Name = "cbDocGia";
            this.cbDocGia.Location = new System.Drawing.Point(110, 30);
            this.cbDocGia.Size = new System.Drawing.Size(380, 31);
            this.cbDocGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDocGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDocGia.SelectedIndexChanged += new System.EventHandler(this.cbDocGia_SelectedIndexChanged);
            //
            // lblHanTra
            //
            this.lblHanTra.Name = "lblHanTra";
            this.lblHanTra.AutoSize = true;
            this.lblHanTra.Location = new System.Drawing.Point(510, 33);
            this.lblHanTra.Text = "Hạn trả";
            //
            // dtpHanTra
            //
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHanTra.CustomFormat = "dd/MM/yyyy";
            this.dtpHanTra.Location = new System.Drawing.Point(580, 30);
            this.dtpHanTra.Size = new System.Drawing.Size(140, 30);
            //
            // lblThongTinDG
            //
            this.lblThongTinDG.Name = "lblThongTinDG";
            this.lblThongTinDG.AutoSize = true;
            this.lblThongTinDG.Location = new System.Drawing.Point(110, 72);
            this.lblThongTinDG.Text = "";
            this.lblThongTinDG.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            //
            // pnlPhai
            //
            this.pnlPhai.Name = "pnlPhai";
            this.pnlPhai.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPhai.Size = new System.Drawing.Size(380, 500);
            this.pnlPhai.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlPhai.Controls.Add(this.grpPhieu);
            //
            // grpPhieu
            //
            this.grpPhieu.Name = "grpPhieu";
            this.grpPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPhieu.Size = new System.Drawing.Size(1000, 400);
            this.grpPhieu.Text = "3. Sách sẽ mượn";
            this.grpPhieu.BackColor = System.Drawing.Color.White;
            this.grpPhieu.Padding = new System.Windows.Forms.Padding(8);
            this.grpPhieu.Controls.Add(this.pnlNutPhieu);
            this.grpPhieu.Controls.Add(this.lstSachMuon);
            //
            // lstSachMuon
            //
            this.lstSachMuon.Name = "lstSachMuon";
            this.lstSachMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSachMuon.IntegralHeight = false;
            //
            // pnlNutPhieu
            //
            this.pnlNutPhieu.Name = "pnlNutPhieu";
            this.pnlNutPhieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNutPhieu.Size = new System.Drawing.Size(360, 90);
            this.pnlNutPhieu.Controls.Add(this.btnLapPhieu);
            this.pnlNutPhieu.Controls.Add(this.btnBoChon);
            this.pnlNutPhieu.Controls.Add(this.lblSoLuong);
            //
            // lblSoLuong
            //
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(4, 8);
            this.lblSoLuong.Text = "0 cuốn";
            //
            // btnBoChon
            //
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoChon.Location = new System.Drawing.Point(4, 40);
            this.btnBoChon.Size = new System.Drawing.Size(110, 34);
            this.btnBoChon.Text = "Bỏ chọn";
            this.btnBoChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoChon.BackColor = System.Drawing.Color.White;
            this.btnBoChon.UseVisualStyleBackColor = false;
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            //
            // btnLapPhieu
            //
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieu.Location = new System.Drawing.Point(124, 40);
            this.btnLapPhieu.Size = new System.Drawing.Size(200, 34);
            this.btnLapPhieu.Text = "Lập phiếu mượn";
            this.btnLapPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapPhieu.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnLapPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            //
            // grpChonSach
            //
            this.grpChonSach.Name = "grpChonSach";
            this.grpChonSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChonSach.Size = new System.Drawing.Size(1000, 500);
            this.grpChonSach.Text = "2. Chọn sách (nhấp đúp để thêm)";
            this.grpChonSach.BackColor = System.Drawing.Color.White;
            this.grpChonSach.Padding = new System.Windows.Forms.Padding(8);
            this.grpChonSach.Controls.Add(this.dgvSach);
            this.grpChonSach.Controls.Add(this.pnlTim);
            //
            // pnlTim
            //
            this.pnlTim.Name = "pnlTim";
            this.pnlTim.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTim.Size = new System.Drawing.Size(500, 44);
            this.pnlTim.Controls.Add(this.btnThemSach);
            this.pnlTim.Controls.Add(this.txtTimSach);
            this.pnlTim.Controls.Add(this.lblTim);
            //
            // lblTim
            //
            this.lblTim.Name = "lblTim";
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(4, 10);
            this.lblTim.Text = "Tìm sách";
            //
            // txtTimSach
            //
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Location = new System.Drawing.Point(90, 6);
            this.txtTimSach.Size = new System.Drawing.Size(300, 30);
            //
            // btnThemSach
            //
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSach.Location = new System.Drawing.Point(400, 4);
            this.btnThemSach.Size = new System.Drawing.Size(110, 34);
            this.btnThemSach.Text = "Thêm >>";
            this.btnThemSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSach.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnThemSach.ForeColor = System.Drawing.Color.White;
            this.btnThemSach.UseVisualStyleBackColor = false;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            //
            // dgvSach
            //
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellDoubleClick);
            this.dgvSach.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSach_DataBindingComplete);
            //
            // tmrTimKiem
            //
            this.tmrTimKiem.Interval = 300;
            this.tmrTimKiem.Tick += new System.EventHandler(this.tmrTimKiem_Tick);
            //
            // frmMuonSach
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.grpChonSach);
            this.Controls.Add(this.pnlPhai);
            this.Controls.Add(this.grpDocGia);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmMuonSach";
            this.Text = "Mượn sách";
            this.Load += new System.EventHandler(this.frmMuonSach_Load);
            this.grpDocGia.ResumeLayout(false);
            this.pnlPhai.ResumeLayout(false);
            this.grpPhieu.ResumeLayout(false);
            this.pnlNutPhieu.ResumeLayout(false);
            this.grpChonSach.ResumeLayout(false);
            this.pnlTim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpDocGia;
        private System.Windows.Forms.Label lblDocGia;
        private System.Windows.Forms.ComboBox cbDocGia;
        private System.Windows.Forms.Label lblHanTra;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.Label lblThongTinDG;
        private System.Windows.Forms.Panel pnlPhai;
        private System.Windows.Forms.GroupBox grpPhieu;
        private System.Windows.Forms.ListBox lstSachMuon;
        private System.Windows.Forms.Panel pnlNutPhieu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Button btnBoChon;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.GroupBox grpChonSach;
        private System.Windows.Forms.Panel pnlTim;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Timer tmrTimKiem;
    }
}
