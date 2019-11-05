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
    public partial class LeTan : UserControl
    {
        private
            DatPhong CtrDP = new DatPhong();
        public LeTan()
        {
            InitializeComponent();
            PanelNoiDungLeTan.Controls.Add(CtrDP);
        }

       

        private void ButtonDatPhong_Click(object sender, EventArgs e)
        {
            CtrDP.BringToFront();
            CtrDP.Show();
        }
    }
}
