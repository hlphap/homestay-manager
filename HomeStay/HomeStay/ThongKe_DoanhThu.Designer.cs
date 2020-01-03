namespace HomeStay
{
    partial class ThongKe_DoanhThu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Bieudodoanhthu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Bieudodoanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // Bieudodoanhthu
            // 
            chartArea3.Name = "ChartArea1";
            this.Bieudodoanhthu.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Bieudodoanhthu.Legends.Add(legend3);
            this.Bieudodoanhthu.Location = new System.Drawing.Point(3, 79);
            this.Bieudodoanhthu.Name = "Bieudodoanhthu";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Thang";
            this.Bieudodoanhthu.Series.Add(series3);
            this.Bieudodoanhthu.Size = new System.Drawing.Size(1081, 471);
            this.Bieudodoanhthu.TabIndex = 25;
            this.Bieudodoanhthu.Text = "chart1";
            // 
            // ThongKe_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Bieudodoanhthu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThongKe_DoanhThu";
            this.Size = new System.Drawing.Size(1087, 571);
            this.Load += new System.EventHandler(this.ThongKe_DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bieudodoanhthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart Bieudodoanhthu;
    }
}
