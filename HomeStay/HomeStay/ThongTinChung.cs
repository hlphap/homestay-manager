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
using System.Data.Common;
namespace HomeStay
{
    public partial class ThongTinChung : UserControl
    {
        
        public ThongTinChung()
        {
            InitializeComponent();
            Tester.Text = Sign_in.ChucVu;
        }
        SqlConnection conn = new SqlConnection(DataSource.connectionString);


   

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
      
        private void ThongTinChung_Load(object sender, EventArgs e)
        {
            SeDen_Click(sender, e);
        }
               

        private void SeDen_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            string sql = "SELECT SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND GETDATE() < NGAYDEN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if (dataGridView1.RowCount == 0)
            {
                msbRong.Show();
            }
            else
            {
                msbRong.Hide();
            }
            conn.Close();
        }

        private void SeDi_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND GETDATE() = NGAYDI";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if (dataGridView1.RowCount==0)
            {
                msbRong.Show();
            }
            else
            {
                msbRong.Hide();
            }
            conn.Close();
        }

        private void DangO_Click(object sender, EventArgs e)
        {
            conn.Open();
           

            string sql = "SELECT SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND NGAYDEN<GETDATE() AND NGAYDI > GETDATE()";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if (dataGridView1.RowCount == 0)
            {
                msbRong.Show();
            }
            else
            {
                msbRong.Hide();
            }
            conn.Close();
        }
    }
}
