using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace HomeStay
{
    public partial class KhachDoan : UserControl
    {
        private
            KhachDoan_TaoDoan CtrTD = new KhachDoan_TaoDoan();
            KhachDoan_DoanDangO CtrDDO = new KhachDoan_DoanDangO();
            KhachDoan_DoanDaDat CtrDDDat = new KhachDoan_DoanDaDat();
            KhachDoan_DoanDaDi CtrDDDi = new KhachDoan_DoanDaDi();
        public KhachDoan()
        {
            InitializeComponent();
           
        }

        private void KhachDoan_Load(object sender, EventArgs e)
        {
            Thread newThread = new Thread(() =>
            {
                Invoke(new Action(() =>
                {
                    PanelNoiDungKhachDoan.Controls.Add(CtrTD);
                    PanelNoiDungKhachDoan.Controls.Add(CtrDDO);
                    PanelNoiDungKhachDoan.Controls.Add(CtrDDDi);
                    PanelNoiDungKhachDoan.Controls.Add(CtrDDDat);
                }));
            });
            newThread.Start();
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
