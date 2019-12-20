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
    public partial class ThuChi : UserControl
    {
        private
            LapPhieuThuChi_ThuChi CrtLPTC = new LapPhieuThuChi_ThuChi();

        public ThuChi()
        {
            InitializeComponent();
            
                       
        }


        private void ThuChi_Load(object sender, EventArgs e)
        {
            Thread newThread = new Thread(() =>
            {
                Invoke(new Action(() =>
                {
                    PanelNoiDungThuChi.Controls.Add(CrtLPTC);
                }));
            });
            newThread.Start();
        }


        private void ButtonLapPhieuThuChi_Click(object sender, EventArgs e)
        {
            CrtLPTC.BringToFront();
            CrtLPTC.Show();
        }

    }
}
