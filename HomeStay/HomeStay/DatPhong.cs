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
    public partial class DatPhong : UserControl
    {
        string sql4="";
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        public DatPhong()
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

            string sql3 = "select * from PHONG WHERE SOPHONG = " + Sophongtxt.ValueMember;
            SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            Trangthaitxt.DataSource = dt3;
            Trangthaitxt.DisplayMember = "TRANGTHAI";
            Trangthaitxt.ValueMember = "TRANGTHAI";

            sql4 = "SELECT SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH";
            SqlCommand cmd4 = new SqlCommand(sql4, conn);
            cmd4.CommandType = CommandType.Text;
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            bunifuCustomDataGrid1.DataSource = dt4;
            conn.Close();
        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (Madatphongtxt.Text != null)
            {
                sql4 += " AND MADK = '" + Madatphongtxt.Text + "'";
            }

            if(Tenkhachtxt.Text!= null)
            {
               
                sql4 += " AND HOTENKH = '" + Tenkhachtxt.Text + "'";
            }

            if (Sophongtxt.ValueMember != null)
                sql4 += "AND SOPHONG = '" + Sophongtxt.Text + "'";
            /*if(Loaiphongtxt.ValueMember != null)
                sql4 += "AND LOAIPHONG = '" + Loaiphongtxt.Text + "'";
            if (Trangthaitxt.ValueMember != null)
                sql4 += "AND TRANGTHAI = '" + Trangthaitxt.Text + "'";*/

            SqlCommand cmd4 = new SqlCommand(sql4, conn);
            cmd4.CommandType = CommandType.Text;
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            bunifuCustomDataGrid1.DataSource = dt4;
            conn.Close();
            sql4 = "SELECT SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH";
        }
    }
}
