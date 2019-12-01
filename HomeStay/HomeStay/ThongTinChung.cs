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
    public partial class ThongTinChung : UserControl
    {
        
        public ThongTinChung()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4BQDKGPF;Initial Catalog=HomeStay;Integrated Security=True");


   

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

   

        
        private void ThongTinChung_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridTTC.DataSource = dt;
            conn.Close();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
