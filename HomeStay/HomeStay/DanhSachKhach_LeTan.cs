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

        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        public DanhSachKhach_LeTan()
        {
            InitializeComponent();
     
        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            conn.Open();
           string  sql = "SELECT PHONGTHUE.SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', LOAIPHONG as 'Loại phòng', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE, PHONG WHERE PHONG.SOPHONG = PHONGTHUE.SOPHONG AND KHACHHANG.MAKH = PHONGTHUE.MAKH AND '" + NgayDenApp.Value.ToString() + "' <= NGAYDEN AND NGAYDI <= '" + NgayDiApp.Value.ToString() + "'";
           sql = sql + string.Format(" AND MADK like N'%{0}%' AND HOTENKH like N'%{1}%' AND SDT like N'%{2}%'", Madatphongtxt.Text, Tenkhachtxt.Text,SDTtxt.Text);

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da4 = new SqlDataAdapter(cmd);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            GridDataViewDSK.DataSource = dt4;
            conn.Close();
        }

        private void Panel_KhachSeDi_Click(object sender, EventArgs e)
        {

        }
        private void LoadData(string sql, DataGridView ViewDTA)
        {
            SqlConnection conn = new SqlConnection(DataSource.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ViewDTA.DataSource = dt;
                if (ViewDTA.RowCount == 0)
                {
                    msbRong.Show();
                }
                else
                {
                    msbRong.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Lỗi kết nối Server");
            }
            finally
            {
                conn.Close();
            }

        }

        private void DanhSachKhach_LeTan_Load(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
              
                string sql4 = "SELECT PHONGTHUE.SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', LOAIPHONG as 'Loại phòng', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE, PHONG WHERE PHONG.SOPHONG = PHONGTHUE.SOPHONG AND KHACHHANG.MAKH = PHONGTHUE.MAKH ";
                LoadData(sql4, GridDataViewDSK);
            }
            catch
            {
                MessageBox.Show("Lỗi", "Lỗi kết nối Server");
            }


            conn.Close();
        }
    }
}
