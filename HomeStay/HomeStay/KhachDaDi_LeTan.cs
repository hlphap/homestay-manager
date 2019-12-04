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
    public partial class KhachDaDi_LeTan : UserControl
    {
        public KhachDaDi_LeTan()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(DataSource.connectionString);
            conn.Open();

            string sql1 = "select * from PHONGTHUE";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBox3.DataSource = dt1;
            comboBox3.DisplayMember = "SOPHONG";
            comboBox3.ValueMember = "SOPHONG";

            string sql2 = "select LOAIPHONG from PHONG WHERE SOPHONG = " + comboBox3.ValueMember;
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "LOAIPHONG";
            comboBox2.ValueMember = "LOAIPHONG";

            string sql3 = "SELECT SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH";
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            cmd3.CommandType = CommandType.Text;
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            bunifuCustomDataGrid1.DataSource = dt3;
            conn.Close();
        }
    }
}
