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
    public partial class KhachDoan_TaoDoan : UserControl
    {
        private
        KhachDoan_Phongtrong CtrPhongTrong = new KhachDoan_Phongtrong();
        KhachDoan_Thongtindoan CtrTTDoan = new KhachDoan_Thongtindoan();
        KhachDoan_ThanhToan CtrTToan = new KhachDoan_ThanhToan();
        public KhachDoan_TaoDoan()
        {
            InitializeComponent();
            PanelTaoDoan2.Controls.Add(CtrPhongTrong);
            PanelTaoDoan2.Controls.Add(CtrTTDoan);
            PanelTaoDoan2.Controls.Add(CtrTToan);
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void BtnPhongTrong(object sender, EventArgs e)
        {
            CtrPhongTrong.BringToFront();
            CtrPhongTrong.Show();
        }

        private void BtnTTDoan(object sender, EventArgs e)
        {
            CtrTTDoan.BringToFront();
            CtrTTDoan.Show();
        }

        private void BtnThanhToan(object sender, EventArgs e)
        {
            CtrTToan.BringToFront();
            CtrTToan.Show();
        }
    }
}
