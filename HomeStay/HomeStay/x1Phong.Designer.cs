namespace HomeStay
{
    partial class x1Phong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SoPhong = new System.Windows.Forms.Label();
            this.LoaiPhong = new System.Windows.Forms.Label();
            this.TrangThai = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.SoPhong);
            this.panel1.Controls.Add(this.LoaiPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 120);
            this.panel1.TabIndex = 0;
            // 
            // SoPhong
            // 
            this.SoPhong.AutoSize = true;
            this.SoPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoPhong.Location = new System.Drawing.Point(26, 50);
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.Size = new System.Drawing.Size(23, 19);
            this.SoPhong.TabIndex = 1;
            this.SoPhong.Text = "01";
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.AutoSize = true;
            this.LoaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiPhong.Location = new System.Drawing.Point(3, 22);
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Size = new System.Drawing.Size(79, 19);
            this.LoaiPhong.TabIndex = 0;
            this.LoaiPhong.Text = "Phòng đơn";
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSize = true;
            this.TrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangThai.Location = new System.Drawing.Point(130, 46);
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Size = new System.Drawing.Size(45, 19);
            this.TrangThai.TabIndex = 1;
            this.TrangThai.Text = "Trống";
            // 
            // x1Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.TrangThai);
            this.Controls.Add(this.panel1);
            this.Name = "x1Phong";
            this.Size = new System.Drawing.Size(260, 120);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label SoPhong;
        public System.Windows.Forms.Label LoaiPhong;
        public System.Windows.Forms.Label TrangThai;
    }
}
