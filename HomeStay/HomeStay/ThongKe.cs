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
            ThongKe_ThongKe CrtTK = new ThongKe_ThongKe();

        public ThongKe()
        {
            InitializeComponent();
            PanelNoiDung.Controls.Add(CrtTK);
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }
        private void ButtonThongKe_Click(object sender, EventArgs e)
        {
            CrtTK.BringToFront();
            CrtTK.Show();
        }
    }
}
