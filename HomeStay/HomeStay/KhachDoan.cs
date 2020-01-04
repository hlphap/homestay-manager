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
              
                }));
            });
            newThread.Start();
        }

        private void ButtonTD_Click(object sender, EventArgs e)
        {
            CtrTD.BringToFront();
            CtrTD.Show();


        }


        
    }
}
