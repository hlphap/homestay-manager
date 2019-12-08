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
            CauHinh_ThemPhong CtrTP = new CauHinh_ThemPhong();
            CaiDat_DsTang CtrDST = new CaiDat_DsTang();
        public CaiDat_CauHinh()
        {
            InitializeComponent();
            PanelCauHinh.Controls.Add(CtrTTNV);
            PanelCauHinh.Controls.Add(CtrTP);
        }

    

    

        private void btNhanVien_Click_1(object sender, EventArgs e)
        {
            PanelCauHinh.Show();
            CtrTTNV.BringToFront();
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            PanelCauHinh.Show();
            CtrDST.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            PanelCauHinh.Show();
            CtrTP.BringToFront();
        }
    }
}
