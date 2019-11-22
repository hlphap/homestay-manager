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
    public partial class KhachDoan : UserControl
    {
        private
            TaoDoan_KhachDoan CtrTD = new TaoDoan_KhachDoan();
            DoanDangO_KhachDoan CtrDDO = new DoanDangO_KhachDoan();
            DoanDaDat_KhachDoan CtrDDDat = new DoanDaDat_KhachDoan();
            DoanDaDi_KhachDoan CtrDDDi = new DoanDaDi_KhachDoan();
        public KhachDoan()
        {
            InitializeComponent();
            PanelNoiDungKhachDoan.Controls.Add(CtrTD);
            PanelNoiDungKhachDoan.Controls.Add(CtrDDO);
            PanelNoiDungKhachDoan.Controls.Add(CtrDDDi);
            PanelNoiDungKhachDoan.Controls.Add(CtrDDDat);
        }

        private void ButtonTD_Click(object sender, EventArgs e)
        {
            CtrTD.BringToFront();
            CtrTD.Show();
        }

        private void ButtonDDO_Click(object sender, EventArgs e)
        {
            CtrDDO.BringToFront();
            CtrDDO.Show();
        }

        private void ButtonDDDi_Click(object sender, EventArgs e)
        {
            CtrDDDi.BringToFront();
            CtrDDDi.Show();
        }

        private void buttonDDDat_Click(object sender, EventArgs e)
        {
            CtrDDDat.BringToFront();
            CtrDDDat.Show();
        }
    }
}
