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
            CauHinh_DsNhanVien ch = new CauHinh_DsNhanVien();
        tao_tai_khoan taotk = new tao_tai_khoan();
        public CaiDat_CauHinh()
        {
            InitializeComponent();

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ch.BringToFront();
            ch.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            taotk.BringToFront();
            taotk.Show();
        }
    }
}
