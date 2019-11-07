namespace HomeStay
{
    partial class TuyChon_KhachLe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TuyChon_KhachLe));
            this.Panel_TuyChon = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SuspendLayout();
            // 
            // Panel_TuyChon
            // 
            this.Panel_TuyChon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_TuyChon.BackgroundImage")));
            this.Panel_TuyChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_TuyChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_TuyChon.GradientBottomLeft = System.Drawing.Color.White;
            this.Panel_TuyChon.GradientBottomRight = System.Drawing.Color.White;
            this.Panel_TuyChon.GradientTopLeft = System.Drawing.Color.White;
            this.Panel_TuyChon.GradientTopRight = System.Drawing.Color.White;
            this.Panel_TuyChon.Location = new System.Drawing.Point(0, 0);
            this.Panel_TuyChon.Name = "Panel_TuyChon";
            this.Panel_TuyChon.Quality = 10;
            this.Panel_TuyChon.Size = new System.Drawing.Size(705, 354);
            this.Panel_TuyChon.TabIndex = 0;
            // 
            // TuyChon_KhachLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_TuyChon);
            this.Name = "TuyChon_KhachLe";
            this.Size = new System.Drawing.Size(705, 354);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel Panel_TuyChon;
    }
}
