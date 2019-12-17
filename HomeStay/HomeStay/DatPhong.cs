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

        private void DatPhong_Load(object sender, EventArgs e)
        {
            try
            {
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


                sql4 = "SELECT SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND GETDATE() < NGAYDEN";
                LoadData(sql4, GridViewDSDP);


                string sql5 = "SELECT SOPHONG FROM PHONG EXCEPT (SELECT P.SOPHONG FROM PHONGTHUE PT, PHONG P, KHACHHANG KH WHERE PT.SOPHONG = P.SOPHONG AND KH.MAKH = PT.MAKH AND((' " + NgayDenApp.Value.ToString("yyyy-MM-dd") + "'<=NgayDen) AND('" + NgayDiApp.Value.ToString("yyyy-MM-dd") + "' >= NGAYDI)))";
                LoadData(sql5, DataGridViewPhongTrong);
            }
            catch
            {
                MessageBox.Show("Lỗi", "Lỗi kết nối Server");
            }

            
            conn.Close();
        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            //if (Madatphongtxt.Text != null)
            //{
            //    sql4 += " AND MADK LIKE '% " + Madatphongtxt.Text + "%'";
            //}

            //if(Tenkhachtxt.Text!= null)
            //{
               
            //    sql4 += " AND HOTENKH LIKE '%" + Tenkhachtxt.Text + "%'";
            //}

            //if (Sophongtxt.ValueMember != null)
            //    sql4 += "AND SOPHONG LIKE '% " + Sophongtxt.Text + "%'";
            ///*if(Loaiphongtxt.ValueMember != null)
            //    sql4 += "AND LOAIPHONG = '" + Loaiphongtxt.Text + "'";
            //if (Trangthaitxt.ValueMember != null)
            //    sql4 += "AND TRANGTHAI = '" + Trangthaitxt.Text + "'";*/

            //SqlCommand cmd4 = new SqlCommand(sql4, conn);
            //cmd4.CommandType = CommandType.Text;
            //SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            //DataTable dt4 = new DataTable();
            //da4.Fill(dt4);
            //GridViewDSDP.DataSource = dt4;
            //conn.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridViewPhongTrong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
