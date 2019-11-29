namespace HomeStay
{
    partial class NhanVien
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
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(19, 19);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(131, 29);
            this.bunifuCustomLabel4.TabIndex = 30;
            this.bunifuCustomLabel4.Text = "Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 499);
            this.panel1.TabIndex = 31;
            // 
            // ButtonTimKiem
            // 
            this.ButtonTimKiem.Active = false;
            this.ButtonTimKiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ButtonTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ButtonTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonTimKiem.BorderRadius = 0;
            this.ButtonTimKiem.ButtonText = "      Thêm";
            this.ButtonTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTimKiem.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonTimKiem.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonTimKiem.Iconimage = null;
            this.ButtonTimKiem.Iconimage_right = null;
            this.ButtonTimKiem.Iconimage_right_Selected = null;
            this.ButtonTimKiem.Iconimage_Selected = null;
            this.ButtonTimKiem.IconMarginLeft = 0;
            this.ButtonTimKiem.IconMarginRight = 0;
            this.ButtonTimKiem.IconRightVisible = true;
            this.ButtonTimKiem.IconRightZoom = 0D;
            this.ButtonTimKiem.IconVisible = true;
            this.ButtonTimKiem.IconZoom = 50D;
            this.ButtonTimKiem.IsTab = false;
            this.ButtonTimKiem.Location = new System.Drawing.Point(821, 12);
            this.ButtonTimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonTimKiem.Name = "ButtonTimKiem";
            this.ButtonTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ButtonTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ButtonTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonTimKiem.selected = false;
            this.ButtonTimKiem.Size = new System.Drawing.Size(137, 43);
            this.ButtonTimKiem.TabIndex = 32;
            this.ButtonTimKiem.Text = "      Thêm";
            this.ButtonTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTimKiem.Textcolor = System.Drawing.Color.White;
            this.ButtonTimKiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonTimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Name = "NhanVien";
            this.Size = new System.Drawing.Size(976, 569);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonTimKiem;
    }
}
