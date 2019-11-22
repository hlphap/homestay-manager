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
    public partial class ThongKe : UserControl
    {
        private
            ThongKe_DoanhThu CrtDT = new ThongKe_DoanhThu();
            ThongKe_ThongKe CrtTK = new ThongKe_ThongKe();
            ThongKe_BieuDoThongKe CrtBDTK = new ThongKe_BieuDoThongKe();

        public ThongKe()
        {
            InitializeComponent();
            PanelNoiDung.Controls.Add(CrtDT);
            PanelNoiDung.Controls.Add(CrtTK);
            PanelNoiDung.Controls.Add(CrtBDTK);
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }


       
        private void ButtonDoanhThu_Click(object sender, EventArgs e)
        {
            CrtDT.BringToFront();
            CrtDT.Show();
        }

        private void ButtonThongKe_Click(object sender, EventArgs e)
        {
            CrtTK.BringToFront();
            CrtTK.Show();
        }

        private void ButtonBieuDoThongKe_Click(object sender, EventArgs e)
        {
            CrtBDTK.BringToFront();
            CrtBDTK.Show();
        }
    }
}
