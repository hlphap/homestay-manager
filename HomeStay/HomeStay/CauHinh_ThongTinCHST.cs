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
    public partial class CauHinh_ThongTinCHST : UserControl
    {
        public CauHinh_ThongTinCHST()
        {
            InitializeComponent();
        }

        private void CauHinh_ThongTinCHST_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(DataSource.connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT HOTEN, EMAIL, NGAYSINH, GIOITINH, SDT, DIACHI FROM THONGTIN_CHUHOMESTAY ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    txtTen.Text = dta.GetString(0);
                    txtEmail.Text = dta.GetString(1);
                    txtNgaySinh.Text = dta.GetDateTime(2).ToString();
                    txtGioiTinh.Text = dta.GetString(3);
                    txtSoDT.Text = dta.GetString(4);
                    txtDiaChi.Text = dta.GetString(5);
               
                }
            }
            catch
            {
            //    MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }

        }
    }
}
