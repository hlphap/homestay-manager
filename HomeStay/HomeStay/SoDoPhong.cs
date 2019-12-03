using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay
{
    public partial class SoDoPhong : UserControl
    {
        public SoDoPhong()
        {
            InitializeComponent();
        }
        public
            int x=212;
            int y;

        public System.Windows.Forms.UserControl AddUCx1Phong()
        {
            x1Phong uc = new x1Phong();
            PanelNoiDung.Controls.Add(uc);
            uc.Location = new System.Drawing.Point(x, y);
            uc.Size = new System.Drawing.Size(212, 98);
            x = x + 230;
            btAdd.Location = new Point(x + 10, 30);
            return uc;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddUCx1Phong();
        }
    }
}
