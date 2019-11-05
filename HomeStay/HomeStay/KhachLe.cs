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
        private
            TongHop_KhachLe CtrTH = new TongHop_KhachLe();
        public KhachLe()
        {
            InitializeComponent();
            PanelNoiDungKhachLe.Controls.Add(CtrTH);
     
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
            CtrTH.BringToFront();
            CtrTH.Show();

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
