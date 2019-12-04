﻿using System;
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
    public partial class DanhSachKhach_LeTan : UserControl
    {
        public DanhSachKhach_LeTan()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(DataSource.connectionString);
            conn.Open();

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
