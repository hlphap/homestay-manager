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
    public partial class ThongKe_BieuDoThongKe : UserControl
    {
        public ThongKe_BieuDoThongKe()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(DataSource.connectionString);


        private void ThongKe_BieuDoThongKe_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM DOANHTHU";
            fillchart(sql);
        }
        void fillchart(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            conn.Open();
            Bieudodoanhthu.DataSource = ds;
            Bieudodoanhthu.Series["Thang"].XValueMember = "Thang";
            Bieudodoanhthu.Series["Thang"].YValueMembers = "TongTien";
            Bieudodoanhthu.Titles.Add("Tổng doanh thu");
            conn.Close();
        }
    }
}
