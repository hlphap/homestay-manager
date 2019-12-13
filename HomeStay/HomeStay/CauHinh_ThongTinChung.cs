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
    public partial class CauHinh_ThongTinChung : UserControl
    {

      
        public CauHinh_ThongTinChung()
        {
            InitializeComponent();
        }

        private void CauHinh_ThongTinChung_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataSource.connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT TENHOMESTAY, EMAIL, SDT, DIACHI, WEBSITE FROM THONGTIN";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    txtTen.Text = dta.GetString(0);
                    txtEmail.Text = dta.GetString(1);
                    txtSoDT.Text = dta.GetString(2);
                    txtDiaChi.Text = dta.GetString(3);
                    txtWebSite.Text = dta.GetString(4);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            
          
        }
    }
}
