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
    public partial class CaiDat_CauHinh : UserControl
    {
        private
            CauHinh_ThongTinNhanVien CtrTTNV = new CauHinh_ThongTinNhanVien();
        public CaiDat_CauHinh()
        {
            InitializeComponent();
            PanelCauHinh.Controls.Add(CtrTTNV);
        }

    

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            CtrTTNV.BringToFront();
        }
    }
}
