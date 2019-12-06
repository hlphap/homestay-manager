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
    public partial class CauHinh_ThongTinNhanVien : UserControl
    {
        public CauHinh_ThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            tao_tai_khoan ttk = new tao_tai_khoan();
            ttk.Show();
        }
    }
}
