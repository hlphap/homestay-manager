namespace HomeStay
{
    partial class CaiDat_DsTang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNoiDung_DsTang = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChonTang = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGrid_DSTang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panelNoiDung_DsTang.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_DSTang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNoiDung_DsTang
            // 
            this.panelNoiDung_DsTang.Controls.Add(this.panel1);
            this.panelNoiDung_DsTang.Controls.Add(this.ChonTang);
            this.panelNoiDung_DsTang.Controls.Add(this.bunifuCustomLabel4);
            this.panelNoiDung_DsTang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung_DsTang.Location = new System.Drawing.Point(0, 0);
            this.panelNoiDung_DsTang.Name = "panelNoiDung_DsTang";
            this.panelNoiDung_DsTang.Size = new System.Drawing.Size(1087, 571);
            this.panelNoiDung_DsTang.TabIndex = 0;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(90, 28);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(237, 29);
            this.bunifuCustomLabel4.TabIndex = 30;
            this.bunifuCustomLabel4.Text = "DANH SÁCH TẦNG";
            // 
            // ChonTang
            // 
            this.ChonTang.BackColor = System.Drawing.Color.White;
            this.ChonTang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChonTang.FormattingEnabled = true;
            this.ChonTang.Location = new System.Drawing.Point(895, 73);
            this.ChonTang.Margin = new System.Windows.Forms.Padding(4);
            this.ChonTang.Name = "ChonTang";
            this.ChonTang.Size = new System.Drawing.Size(128, 29);
            this.ChonTang.TabIndex = 31;
            this.ChonTang.Text = "Chọn Tầng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGrid_DSTang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 418);
            this.panel1.TabIndex = 32;
            // 
            // DataGrid_DSTang
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_DSTang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGrid_DSTang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_DSTang.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_DSTang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_DSTang.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGrid_DSTang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_DSTang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGrid_DSTang.ColumnHeadersHeight = 29;
            this.DataGrid_DSTang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_DSTang.DoubleBuffered = true;
            this.DataGrid_DSTang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DataGrid_DSTang.EnableHeadersVisualStyles = false;
            this.DataGrid_DSTang.GridColor = System.Drawing.Color.Black;
            this.DataGrid_DSTang.HeaderBgColor = System.Drawing.SystemColors.ButtonShadow;
            this.DataGrid_DSTang.HeaderForeColor = System.Drawing.Color.Navy;
            this.DataGrid_DSTang.Location = new System.Drawing.Point(0, 0);
            this.DataGrid_DSTang.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid_DSTang.Name = "DataGrid_DSTang";
            this.DataGrid_DSTang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_DSTang.RowHeadersWidth = 51;
            this.DataGrid_DSTang.Size = new System.Drawing.Size(1087, 418);
            this.DataGrid_DSTang.TabIndex = 2;
            // 
            // CaiDat_DsTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelNoiDung_DsTang);
            this.Name = "CaiDat_DsTang";
            this.Size = new System.Drawing.Size(1087, 571);
            this.panelNoiDung_DsTang.ResumeLayout(false);
            this.panelNoiDung_DsTang.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_DSTang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNoiDung_DsTang;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.ComboBox ChonTang;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_DSTang;
    }
}
