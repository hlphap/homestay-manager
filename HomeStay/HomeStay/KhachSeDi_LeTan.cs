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
    public partial class KhachSeDi_LeTan : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        string sql3 = "";
        public KhachSeDi_LeTan()
        {
            InitializeComponent();

            conn.Open();

            string sql1 = "select * from PHONGTHUE";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            Sophongtxt.DataSource = dt1;
            Sophongtxt.DisplayMember = "SOPHONG";
            Sophongtxt.ValueMember = "SOPHONG";

            string sql2 = "select LOAIPHONG from PHONG WHERE SOPHONG = " + Sophongtxt.ValueMember;
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            Loaiphongtxt.DataSource = dt2;
            Loaiphongtxt.DisplayMember = "LOAIPHONG";
            Loaiphongtxt.ValueMember = "LOAIPHONG";


            sql3 = "SELECT SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH";
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            cmd3.CommandType = CommandType.Text;
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            bunifuCustomDataGrid1.DataSource = dt3;
            conn.Close();
        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (Madatphongtxt.Text != null)
            {
                sql3 += " AND MADK = '" + Madatphongtxt.Text + "'";
            }


            if (Sophongtxt.ValueMember != null)
                sql3 += "AND SOPHONG = '" + Sophongtxt.Text + "'";
            
            // phong thue khong co LOAIPHONG
            /*if(Loaiphongtxt.ValueMember != null)
                sql3 += "AND LOAIPHONG = '" + Loaiphongtxt.Text + "'";
             */

            SqlCommand cmd4 = new SqlCommand(sql3, conn);
            cmd4.CommandType = CommandType.Text;
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            bunifuCustomDataGrid1.DataSource = dt4;
            conn.Close();
            sql3 = "SELECT SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH";
        }
    
    }
}
