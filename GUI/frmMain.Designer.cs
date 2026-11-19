namespace GUI
{
    partial class frmMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnTongQuan = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnTheLoai = new System.Windows.Forms.Button();
            this.btnTacGia = new System.Windows.Forms.Button();
            this.btnNXB = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnMuonSach = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.pnlNoiDung = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlMenu
            //
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlMenu.Controls.Add(this.btnTaiKhoan);
            this.pnlMenu.Controls.Add(this.btnTraSach);
            this.pnlMenu.Controls.Add(this.btnMuonSach);
            this.pnlMenu.Controls.Add(this.btnDocGia);
            this.pnlMenu.Controls.Add(this.btnNXB);
            this.pnlMenu.Controls.Add(this.btnTacGia);
            this.pnlMenu.Controls.Add(this.btnTheLoai);
            this.pnlMenu.Controls.Add(this.btnSach);
            this.pnlMenu.Controls.Add(this.btnTongQuan);
            this.pnlMenu.Controls.Add(this.btnDangXuat);
            this.pnlMenu.Controls.Add(this.btnDoiMatKhau);
            this.pnlMenu.Controls.Add(this.lblLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 720);
            //
            // lblLogo
            //
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 80);
            this.lblLogo.Text = "THƯ VIỆN";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnTongQuan
            //
            this.btnTongQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTongQuan.FlatAppearance.BorderSize = 0;
            this.btnTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongQuan.ForeColor = System.Drawing.Color.White;
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Size = new System.Drawing.Size(220, 46);
            this.btnTongQuan.Text = "  Tổng quan";
            this.btnTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.Click += new System.EventHandler(this.Menu_Click);
            //
            // btnSach
            //
            this.btnSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSach.FlatAppearance.BorderSize = 0;
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.ForeColor = System.Drawing.Color.White;
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(220, 46);
            this.btnSach.Text = "  Quản lý sách";
            this.btnSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSach.Click += new System.EventHandler(this.Menu_Click);
            //
            // btnTheLoai
            //
            this.btnTheLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTheLoai.FlatAppearance.BorderSize = 0;
            this.btnTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheLoai.ForeColor = System.Drawing.Color.White;
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(220, 46);
            this.btnTheLoai.Text = "  Thể loại";
            this.btnTheLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheLoai.Click += new System.EventHandler(this.Menu_Click);
            //
            // btnTacGia
            //
            this.btnTacGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTacGia.FlatAppearance.BorderSize = 0;
            this.btnTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTacGia.ForeColor = System.Drawing.Color.White;
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(220, 46);
            this.btnTacGia.Text = "  Tác giả";
            this.btnTacGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTacGia.Click += new System.EventHandler(this.Menu_Click);
            //
            // btnNXB
            //
            this.btnNXB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNXB.FlatAppearance.BorderSize = 0;
            this.btnNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNXB.ForeColor = System.Drawing.Color.White;
            this.btnNXB.Name = "btnNXB";
            this.btnNXB.Size = new System.Drawing.Size(220, 46);
            this.btnNXB.Text = "  Nhà xuất bản";
            this.btnNXB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNXB.Click += new System.EventHandler(this.Menu_Click);
            //
            // btnDocGia
            //
            this.btnDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocGia.FlatAppearance.BorderSize = 0;
            this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocGia.ForeColor = System.Drawing.Color.White;
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(220, 46);
            this.btnDocGia.Text = "  Độc giả";
            this.btnDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocGia.Click += new System.EventHandler(this.Menu_Click);
            //
            // btnMuonSach
            //
            this.btnMuonSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMuonSach.FlatAppearance.BorderSize = 0;
            this.btnMuonSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuonSach.ForeColor = System.Drawing.Color.White;
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.Size = new System.Drawing.Size(220, 46);
            this.btnMuonSach.Text = "  Mượn sách";
            this.btnMuonSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuonSach.Click += new System.EventHandler(this.Menu_Click);
            //
            // btnTraSach
            //
            this.btnTraSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraSach.FlatAppearance.BorderSize = 0;
            this.btnTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraSach.ForeColor = System.Drawing.Color.White;
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(220, 46);
            this.btnTraSach.Text = "  Trả sách";
            this.btnTraSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraSach.Click += new System.EventHandler(this.Menu_Click);
            //
            // btnTaiKhoan
            //
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(220, 46);
            this.btnTaiKhoan.Text = "  Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Click += new System.EventHandler(this.Menu_Click);
            //
            // btnDangXuat
            //
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(220, 46);
            this.btnDangXuat.Text = "  Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            //
            // btnDoiMatKhau
            //
            this.btnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(220, 46);
            this.btnDoiMatKhau.Text = "  Đổi mật khẩu";
            this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Controls.Add(this.lblXinChao);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1060, 60);
            //
            // lblTieuDe
            //
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Text = "Tổng quan";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblXinChao
            //
            this.lblXinChao.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXinChao.ForeColor = System.Drawing.Color.DimGray;
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(400, 60);
            this.lblXinChao.Text = "Xin chào";
            this.lblXinChao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // pnlNoiDung
            //
            this.pnlNoiDung.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.pnlNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Padding = new System.Windows.Forms.Padding(12);
            //
            // frmMain
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý Thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnTheLoai;
        private System.Windows.Forms.Button btnTacGia;
        private System.Windows.Forms.Button btnNXB;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnMuonSach;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.Panel pnlNoiDung;
    }
}
