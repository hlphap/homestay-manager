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
    public partial class KhachSeDen_LeTan : UserControl
    {

        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        bool kttoday;
        public KhachSeDen_LeTan()
        {
            InitializeComponent();
            kttoday = true;

      
        }

        private void KhachSeDen_LeTan_Load(object sender, EventArgs e)
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



                string sql4 = "SELECT PHONGTHUE.SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', LOAIPHONG as 'Loại phòng', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE, PHONG WHERE PHONG.SOPHONG = PHONGTHUE.SOPHONG AND KHACHHANG.MAKH = PHONGTHUE.MAKH AND GETDATE() < NGAYDEN";
                LoadData(sql4, GridViewDSKSD);


               
            }
            catch
            {
                MessageBox.Show("Lỗi", "Lỗi kết nối Server");
            }


            conn.Close();
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
        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {

            conn.Open();
            string sql = "";
            if (kttoday == true)
            {
                sql = "SELECT PHONGTHUE.SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', LOAIPHONG as 'Loại phòng', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE, PHONG WHERE PHONG.SOPHONG = PHONGTHUE.SOPHONG AND KHACHHANG.MAKH = PHONGTHUE.MAKH AND GETDATE() = NGAYDEN";

            }
            else
            {
                sql = "SELECT PHONGTHUE.SOPHONG as 'Số phòng', MADK as 'Mã đặt phòng', HOTENKH as 'Họ tên', LOAIPHONG as 'Loại phòng', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE, PHONG WHERE PHONG.SOPHONG = PHONGTHUE.SOPHONG AND KHACHHANG.MAKH = PHONGTHUE.MAKH AND '" + NgayDenApp.Value.ToString() + "' <= NGAYDEN AND NGAYDI <= '" + NgayDiApp.Value.ToString() + "'";
            }

            sql = sql + string.Format(" AND MADK like N'%{0}%' AND HOTENKH like N'%{1}%'", Madatphongtxt.Text, Tenkhachtxt.Text);
            if (Sophongtxt.ValueMember != null)
                sql = sql + string.Format(" AND PHONGTHUE.SOPHONG like N'%{0}%'", Sophongtxt.Text);

            if (Loaiphongtxt.ValueMember != null)
                sql += " AND LOAIPHONG = N'" + Loaiphongtxt.Text + "'";


            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da4 = new SqlDataAdapter(cmd);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            GridViewDSKSD.DataSource = dt4;
            conn.Close();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            if (kttoday == true)
            {
                btnToday.BorderStyle = BorderStyle.Fixed3D;
                kttoday = false;
                NgayDenApp.Enabled = true;
                NgayDiApp.Enabled = true;
            }
            else
            {
                btnToday.BorderStyle = BorderStyle.None;
                kttoday = true;
                NgayDiApp.Enabled = false;
                NgayDenApp.Enabled = false;
            }

        }

      
    }
}
