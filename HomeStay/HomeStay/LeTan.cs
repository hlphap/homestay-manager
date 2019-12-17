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
    public partial class LeTan : UserControl
    {
        private
            DatPhong CtrDP = new DatPhong();
            KhachSeDen_LeTan CtrKSD_LT = new KhachSeDen_LeTan();
            KhachSeDi_LeTan CtrKSDi_LT = new KhachSeDi_LeTan();
            KhachDaDi_LeTan CtrKDDi_LT = new KhachDaDi_LeTan();
            DanhSachKhach_LeTan CtrDSK_LT = new DanhSachKhach_LeTan();
        public LeTan()
        {
            InitializeComponent();
           
            
        }

        private void LeTan_Load(object sender, EventArgs e)
        {
            Thread newThread = new Thread(() =>
            {
                Invoke(new Action(() =>
                {
                    PanelNoiDungLeTan.Controls.Add(CtrDP);
                    PanelNoiDungLeTan.Controls.Add(CtrKSD_LT);
                    PanelNoiDungLeTan.Controls.Add(CtrKSDi_LT);
                    PanelNoiDungLeTan.Controls.Add(CtrKDDi_LT);
                    PanelNoiDungLeTan.Controls.Add(CtrDSK_LT);
                }));
            });
            newThread.Start();
        }

        private void ButtonDatPhong_Click(object sender, EventArgs e)
        {
            CtrDP.BringToFront();
            CtrDP.Show();
        }

        private void ButtonKhachSeDen_Click(object sender, EventArgs e)
        {
            CtrKSD_LT.BringToFront();
            CtrKSD_LT.Show();
        }

        private void KhachSeDi_Click(object sender, EventArgs e)
        {

            CtrKSDi_LT.BringToFront();
            CtrKSDi_LT.Show();
        }

        private void KhachDaDi_Click(object sender, EventArgs e)
        {
            CtrKDDi_LT.BringToFront();
            CtrKDDi_LT.Show();
        }

        private void DanhSachKhach_Click(object sender, EventArgs e)
        {
            CtrDSK_LT.BringToFront();
            CtrDSK_LT.Show();
        }

     
    }
}
