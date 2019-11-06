namespace HomeStay
{
    partial class ThongKe
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
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.Black;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(4, 4);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(463, 32);
            this.bunifuDatepicker1.TabIndex = 0;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 11, 6, 20, 54, 31, 0);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bunifuDatepicker1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1087, 622);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(1087, 622);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
