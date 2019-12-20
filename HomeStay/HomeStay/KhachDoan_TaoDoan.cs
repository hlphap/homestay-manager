using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomeStay
{
    public partial class KhachDoan_TaoDoan : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        public string[] sophongtt = new string[20];
        public int demsophongtt;
        public string tentdtt, sdttdtt, socmndtdtt, madoantt;
        public string ngaydentt, ngayditt;
        public
        KhachDoan_Phongtrong CtrPhongTrong = new KhachDoan_Phongtrong();
        KhachDoan_Thongtindoan CtrTTDoan = new KhachDoan_Thongtindoan();
        KhachDoan_ThanhToan CtrTToan = new KhachDoan_ThanhToan();
        public KhachDoan_TaoDoan()
        {
            InitializeComponent();
            PanelTaoDoan2.Controls.Add(CtrPhongTrong);
            PanelTaoDoan2.Controls.Add(CtrTTDoan);
            PanelTaoDoan2.Controls.Add(CtrTToan);
            string[] sophongtt = new string[20];
        }

        private void BtnPhongTrong(object sender, EventArgs e)
        {
            CtrPhongTrong.BringToFront();
            CtrPhongTrong.Show();
        }

        private void BtnTTDoan(object sender, EventArgs e)
        {
            CtrTTDoan.BringToFront();
            CtrTTDoan.Show();
            
        }

        private void BtnThanhToan(object sender, EventArgs e)
        {
            sophongtt = CtrPhongTrong.sophong;
            demsophongtt = CtrPhongTrong.demsophong;

            tentdtt = CtrTTDoan.tentd;
            sdttdtt = CtrTTDoan.sdttd;
            socmndtdtt = CtrTTDoan.socmndtd;
            madoantt = CtrTTDoan.madoan;

            ngaydentt = CtrPhongTrong.ngayden;
            ngayditt = CtrPhongTrong.ngaydi;

            CtrTToan.BringToFront();
            CtrTToan.Show();
            CtrTToan.loaddata(sophongtt, demsophongtt);
            CtrTToan.loaddatathongtindoan(tentdtt, sdttdtt, socmndtdtt, madoantt);
            CtrTToan.loaddataphongtrong(ngaydentt, ngayditt);
        }
        
    }
}
