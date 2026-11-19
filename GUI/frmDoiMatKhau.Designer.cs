namespace GUI
{
    partial class frmDoiMatKhau
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
            this.lblCu = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.lblMoi = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblXacNhan = new System.Windows.Forms.Label();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblCu
            //
            this.lblCu.Name = "lblCu";
            this.lblCu.AutoSize = true;
            this.lblCu.Location = new System.Drawing.Point(25, 25);
            this.lblCu.Text = "Mật khẩu cũ";
            //
            // txtMatKhauCu
            //
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Location = new System.Drawing.Point(160, 22);
            this.txtMatKhauCu.Size = new System.Drawing.Size(210, 30);
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            //
            // lblMoi
            //
            this.lblMoi.Name = "lblMoi";
            this.lblMoi.AutoSize = true;
            this.lblMoi.Location = new System.Drawing.Point(25, 70);
            this.lblMoi.Text = "Mật khẩu mới";
            //
            // txtMatKhauMoi
            //
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Location = new System.Drawing.Point(160, 67);
            this.txtMatKhauMoi.Size = new System.Drawing.Size(210, 30);
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            //
            // lblXacNhan
            //
            this.lblXacNhan.Name = "lblXacNhan";
            this.lblXacNhan.AutoSize = true;
            this.lblXacNhan.Location = new System.Drawing.Point(25, 115);
            this.lblXacNhan.Text = "Xác nhận";
            //
            // txtXacNhan
            //
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.Location = new System.Drawing.Point(160, 112);
            this.txtXacNhan.Size = new System.Drawing.Size(210, 30);
            this.txtXacNhan.UseSystemPasswordChar = true;
            //
            // btnLuu
            //
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(160, 170);
            this.btnLuu.Size = new System.Drawing.Size(100, 34);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            //
            // btnHuy
            //
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Location = new System.Drawing.Point(270, 170);
            this.btnHuy.Size = new System.Drawing.Size(100, 34);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            //
            // frmDoiMatKhau
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.lblXacNhan);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lblMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.lblCu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.AcceptButton = this.btnLuu;
            this.CancelButton = this.btnHuy;
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblCu;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lblMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblXacNhan;
        private System.Windows.Forms.TextBox txtXacNhan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}
