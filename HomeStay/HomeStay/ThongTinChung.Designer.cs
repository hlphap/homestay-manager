namespace HomeStay
{
    partial class ThongTinChung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinChung));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.Panel_NoiDung = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Panel_NDThongTin = new System.Windows.Forms.Panel();
            this.msbRong = new System.Windows.Forms.Label();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.ComboBoxSearch = new System.Windows.Forms.ComboBox();
            this.btnDangO = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSeDi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSeDen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Panel_NoiDung.SuspendLayout();
            this.Panel_NDThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_NoiDung
            // 
            this.Panel_NoiDung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_NoiDung.BackgroundImage")));
            this.Panel_NoiDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_NoiDung.Controls.Add(this.Panel_NDThongTin);
            this.Panel_NoiDung.Controls.Add(this.panel1);
            this.Panel_NoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_NoiDung.GradientBottomLeft = System.Drawing.Color.OldLace;
            this.Panel_NoiDung.GradientBottomRight = System.Drawing.Color.SpringGreen;
            this.Panel_NoiDung.GradientTopLeft = System.Drawing.Color.Navy;
            this.Panel_NoiDung.GradientTopRight = System.Drawing.Color.SpringGreen;
            this.Panel_NoiDung.Location = new System.Drawing.Point(0, 0);
            this.Panel_NoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_NoiDung.Name = "Panel_NoiDung";
            this.Panel_NoiDung.Quality = 10;
            this.Panel_NoiDung.Size = new System.Drawing.Size(1087, 622);
            this.Panel_NoiDung.TabIndex = 2;
            // 
            // Panel_NDThongTin
            // 
            this.Panel_NDThongTin.BackColor = System.Drawing.Color.White;
            this.Panel_NDThongTin.Controls.Add(this.msbRong);
            this.Panel_NDThongTin.Controls.Add(this.dataGridView1);
            this.Panel_NDThongTin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_NDThongTin.Location = new System.Drawing.Point(0, 58);
            this.Panel_NDThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_NDThongTin.Name = "Panel_NDThongTin";
            this.Panel_NDThongTin.Size = new System.Drawing.Size(1087, 564);
            this.Panel_NDThongTin.TabIndex = 1;
            // 
            // msbRong
            // 
            this.msbRong.AutoSize = true;
            this.msbRong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msbRong.ForeColor = System.Drawing.Color.Red;
            this.msbRong.Location = new System.Drawing.Point(337, 101);
            this.msbRong.Name = "msbRong";
            this.msbRong.Size = new System.Drawing.Size(336, 28);
            this.msbRong.TabIndex = 1;
            this.msbRong.Text = "Không tìm thấy thông tin đặt phòng";
            this.msbRong.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.HeaderBgColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.Navy;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 564);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.ComboBoxSearch);
            this.panel1.Controls.Add(this.btnDangO);
            this.panel1.Controls.Add(this.btnSeDi);
            this.panel1.Controls.Add(this.btnSeDen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 50);
            this.panel1.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.AcceptsReturn = false;
            this.Search.AcceptsTab = false;
            this.Search.AnimationSpeed = 200;
            this.Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search.BackgroundImage")));
            this.Search.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Search.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Search.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Search.BorderColorIdle = System.Drawing.Color.Silver;
            this.Search.BorderRadius = 25;
            this.Search.BorderThickness = 1;
            this.Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Search.DefaultText = "";
            this.Search.FillColor = System.Drawing.Color.White;
            this.Search.HideSelection = true;
            this.Search.IconLeft = null;
            this.Search.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Search.IconPadding = 3;
            this.Search.IconRight = ((System.Drawing.Image)(resources.GetObject("Search.IconRight")));
            this.Search.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Search.Lines = new string[0];
            this.Search.Location = new System.Drawing.Point(639, 10);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.MaxLength = 32767;
            this.Search.MinimumSize = new System.Drawing.Size(1, 1);
            this.Search.Modified = false;
            this.Search.Multiline = false;
            this.Search.Name = "Search";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Search.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Search.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Search.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Search.OnIdleState = stateProperties4;
            this.Search.PasswordChar = '\0';
            this.Search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Search.PlaceholderText = "Tìm kiếm.....";
            this.Search.ReadOnly = false;
            this.Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Search.SelectedText = "";
            this.Search.SelectionLength = 0;
            this.Search.SelectionStart = 0;
            this.Search.ShortcutsEnabled = true;
            this.Search.Size = new System.Drawing.Size(259, 31);
            this.Search.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.Search.TabIndex = 4;
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Search.TextMarginBottom = 0;
            this.Search.TextMarginLeft = 5;
            this.Search.TextMarginTop = 0;
            this.Search.TextPlaceholder = "Tìm kiếm.....";
            this.Search.UseSystemPasswordChar = false;
            this.Search.WordWrap = true;
            this.Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            this.Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_KeyPress);
            // 
            // ComboBoxSearch
            // 
            this.ComboBoxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBoxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.ComboBoxSearch.FormattingEnabled = true;
            this.ComboBoxSearch.Items.AddRange(new object[] {
            "Số phòng",
            "Mã ĐP",
            "Họ tên",
            "Ngày đến",
            "Ngày đi"});
            this.ComboBoxSearch.Location = new System.Drawing.Point(916, 11);
            this.ComboBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxSearch.Name = "ComboBoxSearch";
            this.ComboBoxSearch.Size = new System.Drawing.Size(165, 29);
            this.ComboBoxSearch.TabIndex = 0;
            // 
            // btnDangO
            // 
            this.btnDangO.Active = false;
            this.btnDangO.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDangO.BackColor = System.Drawing.Color.Transparent;
            this.btnDangO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangO.BorderRadius = 5;
            this.btnDangO.ButtonText = "Đang ở";
            this.btnDangO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangO.DisabledColor = System.Drawing.Color.Gray;
            this.btnDangO.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDangO.Iconimage = null;
            this.btnDangO.Iconimage_right = null;
            this.btnDangO.Iconimage_right_Selected = null;
            this.btnDangO.Iconimage_Selected = null;
            this.btnDangO.IconMarginLeft = 0;
            this.btnDangO.IconMarginRight = 0;
            this.btnDangO.IconRightVisible = true;
            this.btnDangO.IconRightZoom = 0D;
            this.btnDangO.IconVisible = true;
            this.btnDangO.IconZoom = 50D;
            this.btnDangO.IsTab = true;
            this.btnDangO.Location = new System.Drawing.Point(369, 2);
            this.btnDangO.Margin = new System.Windows.Forms.Padding(5);
            this.btnDangO.Name = "btnDangO";
            this.btnDangO.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDangO.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDangO.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDangO.selected = false;
            this.btnDangO.Size = new System.Drawing.Size(173, 39);
            this.btnDangO.TabIndex = 3;
            this.btnDangO.Text = "Đang ở";
            this.btnDangO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangO.Textcolor = System.Drawing.Color.White;
            this.btnDangO.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangO.Click += new System.EventHandler(this.DangO_Click);
            // 
            // btnSeDi
            // 
            this.btnSeDi.Active = false;
            this.btnSeDi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSeDi.BackColor = System.Drawing.Color.Transparent;
            this.btnSeDi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeDi.BorderRadius = 5;
            this.btnSeDi.ButtonText = "Sẽ đi";
            this.btnSeDi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeDi.DisabledColor = System.Drawing.Color.Gray;
            this.btnSeDi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSeDi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSeDi.Iconimage")));
            this.btnSeDi.Iconimage_right = null;
            this.btnSeDi.Iconimage_right_Selected = null;
            this.btnSeDi.Iconimage_Selected = null;
            this.btnSeDi.IconMarginLeft = 0;
            this.btnSeDi.IconMarginRight = 0;
            this.btnSeDi.IconRightVisible = true;
            this.btnSeDi.IconRightZoom = 0D;
            this.btnSeDi.IconVisible = true;
            this.btnSeDi.IconZoom = 50D;
            this.btnSeDi.IsTab = true;
            this.btnSeDi.Location = new System.Drawing.Point(187, 2);
            this.btnSeDi.Margin = new System.Windows.Forms.Padding(5);
            this.btnSeDi.Name = "btnSeDi";
            this.btnSeDi.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSeDi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSeDi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSeDi.selected = false;
            this.btnSeDi.Size = new System.Drawing.Size(173, 39);
            this.btnSeDi.TabIndex = 2;
            this.btnSeDi.Text = "Sẽ đi";
            this.btnSeDi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeDi.Textcolor = System.Drawing.Color.White;
            this.btnSeDi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeDi.Click += new System.EventHandler(this.SeDi_Click);
            // 
            // btnSeDen
            // 
            this.btnSeDen.Active = true;
            this.btnSeDen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSeDen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSeDen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeDen.BorderRadius = 5;
            this.btnSeDen.ButtonText = "Sẽ đến";
            this.btnSeDen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeDen.DisabledColor = System.Drawing.Color.Gray;
            this.btnSeDen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSeDen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSeDen.Iconimage")));
            this.btnSeDen.Iconimage_right = null;
            this.btnSeDen.Iconimage_right_Selected = null;
            this.btnSeDen.Iconimage_Selected = null;
            this.btnSeDen.IconMarginLeft = 0;
            this.btnSeDen.IconMarginRight = 0;
            this.btnSeDen.IconRightVisible = true;
            this.btnSeDen.IconRightZoom = 0D;
            this.btnSeDen.IconVisible = true;
            this.btnSeDen.IconZoom = 50D;
            this.btnSeDen.IsTab = true;
            this.btnSeDen.Location = new System.Drawing.Point(2, 2);
            this.btnSeDen.Margin = new System.Windows.Forms.Padding(5);
            this.btnSeDen.Name = "btnSeDen";
            this.btnSeDen.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSeDen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSeDen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSeDen.selected = true;
            this.btnSeDen.Size = new System.Drawing.Size(173, 39);
            this.btnSeDen.TabIndex = 1;
            this.btnSeDen.Text = "Sẽ đến";
            this.btnSeDen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeDen.Textcolor = System.Drawing.Color.White;
            this.btnSeDen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeDen.Click += new System.EventHandler(this.SeDen_Click);
            // 
            // ThongTinChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.Panel_NoiDung);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTinChung";
            this.Size = new System.Drawing.Size(1087, 622);
            this.Load += new System.EventHandler(this.ThongTinChung_Load);
            this.Panel_NoiDung.ResumeLayout(false);
            this.Panel_NDThongTin.ResumeLayout(false);
            this.Panel_NDThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel Panel_NoiDung;
        private Bunifu.Framework.UI.BunifuFlatButton btnSeDen;
        private Bunifu.Framework.UI.BunifuFlatButton btnSeDi;
        private Bunifu.Framework.UI.BunifuFlatButton btnDangO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_NDThongTin;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private System.Windows.Forms.Label msbRong;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Search;
        private System.Windows.Forms.ComboBox ComboBoxSearch;
    }
}
