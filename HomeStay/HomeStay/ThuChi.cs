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
    public partial class ThuChi : UserControl
    {
        private
            KiemKe CrtKK = new KiemKe();
            LapPhieuThuChi_ThuChi CrtLPTC = new LapPhieuThuChi_ThuChi();
            SoChiTietTienGui_ChiTiet CrtSCTTG = new SoChiTietTienGui_ChiTiet();
        public ThuChi()
        {
            InitializeComponent();
            PanelNoiDungThuChi.Controls.Add(CrtLPTC);
            PanelNoiDungThuChi.Controls.Add(CrtKK);
            PanelNoiDungThuChi.Controls.Add(CrtSCTTG);
                       
        }


        private void ThuChi_Load(object sender, EventArgs e)
        {

        }

     

        private void bunifuGradientPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonLapPhieuThuChi_Click(object sender, EventArgs e)
        {
            CrtLPTC.BringToFront();
            CrtLPTC.Show();
        }

        private void ButtonKiemKe_Click(object sender, EventArgs e)
        {
            CrtKK.BringToFront();
            CrtKK.Show();
        }

        private void ButtonSoChiTieu_Click(object sender, EventArgs e)
        {
            CrtSCTTG.BringToFront();
            CrtSCTTG.Show();
        }
    }
}
