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
    public partial class KhachLe : UserControl
    {
        public KhachLe()
        {
            InitializeComponent();
            TongHop_KhachLe th = new TongHop_KhachLe();
            Panel_NoiDung_TH.Controls.Clear();
            Panel_NoiDung_TH.Controls.Add(th);
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            // Code thêm panel
            TongHop_KhachLe th = new TongHop_KhachLe();
            Panel_NoiDung_TH.Controls.Clear();
            Panel_NoiDung_TH.Controls.Add(th);

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            TuyChon_KhachLe tc = new TuyChon_KhachLe();
            Panel_NoiDung_TH.Controls.Clear();
            Panel_NoiDung_TH.Controls.Add(tc);
        }
    }
}
