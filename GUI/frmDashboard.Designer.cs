namespace GUI
{
    partial class frmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.flpThe = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpNoiDung = new System.Windows.Forms.TableLayoutPanel();
            this.chartMuon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTheLoai = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpQuaHan = new System.Windows.Forms.GroupBox();
            this.dgvQuaHan = new System.Windows.Forms.DataGridView();
            this.grpTopSach = new System.Windows.Forms.GroupBox();
            this.dgvTopSach = new System.Windows.Forms.DataGridView();
            this.tlpNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTheLoai)).BeginInit();
            this.grpQuaHan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuaHan)).BeginInit();
            this.grpTopSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSach)).BeginInit();
            this.SuspendLayout();
            //
            // flpThe
            //
            this.flpThe.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpThe.Name = "flpThe";
            this.flpThe.Size = new System.Drawing.Size(1000, 100);
            //
            // tlpNoiDung
            //
            this.tlpNoiDung.ColumnCount = 2;
            this.tlpNoiDung.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpNoiDung.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpNoiDung.Controls.Add(this.chartMuon, 0, 0);
            this.tlpNoiDung.Controls.Add(this.chartTheLoai, 1, 0);
            this.tlpNoiDung.Controls.Add(this.grpQuaHan, 0, 1);
            this.tlpNoiDung.Controls.Add(this.grpTopSach, 1, 1);
            this.tlpNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNoiDung.Name = "tlpNoiDung";
            this.tlpNoiDung.RowCount = 2;
            this.tlpNoiDung.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNoiDung.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            //
            // chartMuon
            //
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.Name = "ChartArea1";
            this.chartMuon.ChartAreas.Add(chartArea1);
            this.chartMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMuon.Name = "chartMuon";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(37, 99, 235);
            series1.IsValueShownAsLabel = true;
            series1.Name = "Lượt mượn";
            this.chartMuon.Series.Add(series1);
            title1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            title1.Text = "Lượt mượn 6 tháng gần nhất";
            this.chartMuon.Titles.Add(title1);
            //
            // chartTheLoai
            //
            chartArea2.Name = "ChartArea1";
            this.chartTheLoai.ChartAreas.Add(chartArea2);
            this.chartTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartTheLoai.Legends.Add(legend2);
            this.chartTheLoai.Name = "chartTheLoai";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Thể loại";
            this.chartTheLoai.Series.Add(series2);
            title2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            title2.Text = "Số cuốn theo thể loại";
            this.chartTheLoai.Titles.Add(title2);
            //
            // grpQuaHan
            //
            this.grpQuaHan.Controls.Add(this.dgvQuaHan);
            this.grpQuaHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpQuaHan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpQuaHan.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.grpQuaHan.Name = "grpQuaHan";
            this.grpQuaHan.Text = "Sách quá hạn cần thu hồi";
            //
            // dgvQuaHan
            //
            this.dgvQuaHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuaHan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvQuaHan.Name = "dgvQuaHan";
            //
            // grpTopSach
            //
            this.grpTopSach.Controls.Add(this.dgvTopSach);
            this.grpTopSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTopSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTopSach.Name = "grpTopSach";
            this.grpTopSach.Text = "Top 5 sách được mượn nhiều nhất";
            //
            // dgvTopSach
            //
            this.dgvTopSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopSach.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvTopSach.Name = "dgvTopSach";
            //
            // frmDashboard
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.tlpNoiDung);
            this.Controls.Add(this.flpThe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmDashboard";
            this.Text = "Tổng quan";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.tlpNoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTheLoai)).EndInit();
            this.grpQuaHan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuaHan)).EndInit();
            this.grpTopSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSach)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpThe;
        private System.Windows.Forms.TableLayoutPanel tlpNoiDung;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMuon;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTheLoai;
        private System.Windows.Forms.GroupBox grpQuaHan;
        private System.Windows.Forms.DataGridView dgvQuaHan;
        private System.Windows.Forms.GroupBox grpTopSach;
        private System.Windows.Forms.DataGridView dgvTopSach;
    }
}
