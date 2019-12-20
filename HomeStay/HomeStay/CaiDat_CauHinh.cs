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
    public partial class CaiDat_CauHinh : UserControl
    {
        private
            CauHinh_ThongTinNhanVien CtrTTNV = new CauHinh_ThongTinNhanVien();
            CauHinh_ThemPhong CtrTP = new CauHinh_ThemPhong();
            CaiDat_DsTang CtrDST = new CaiDat_DsTang();
            CauHinh_ThongTinChung CtrTTC = new CauHinh_ThongTinChung();
            CauHinh_ThongTinCHST CtrTTCHST = new CauHinh_ThongTinCHST();
            CauHinh_LoaiPhong CtrLP = new CauHinh_LoaiPhong();
        public CaiDat_CauHinh()
        {
            InitializeComponent();
           
        }




        private void CaiDat_CauHinh_Load(object sender, EventArgs e)
        {
            Thread newThread = new Thread(() =>
            {
                Invoke(new Action(() =>
                {
                    PanelCauHinh.Controls.Add(CtrTTNV);
                    PanelCauHinh.Controls.Add(CtrTP);
                    PanelCauHinh.Controls.Add(CtrDST);
                    PanelCauHinh.Controls.Add(CtrTTC);
                    PanelCauHinh.Controls.Add(CtrTTCHST);
                    PanelCauHinh.Controls.Add(CtrLP);
                }));
            });
            newThread.Start();
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

        private void ThongTinCKS_Click(object sender, EventArgs e)
        {
            PanelCauHinh.Show();
            CtrTTCHST.BringToFront();
        }

        private void btnTTC_Click(object sender, EventArgs e)
        {

            PanelCauHinh.Show();
            CtrTTC.BringToFront();
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            PanelCauHinh.Show();
            CtrLP.BringToFront();
        }
    }
}
