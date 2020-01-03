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
        private int btnclick = 1;
        public ThongTinChung()
        {
            InitializeComponent();
        }

        public void ThongTinChung_Load(object sender, EventArgs e)
        {
            SeDen_Click(sender, e);
        }
        private void LoadData(string sql)
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
                dataGridView1.DataSource = dt;
                if (dataGridView1.RowCount == 0)
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
     
               

        private void SeDen_Click(object sender, EventArgs e)
        {
            string sql = "SELECT KHACHHANG.MAKH as 'Mã KH', MADK as 'Mã đặt phòng',  SOPHONG as 'Số phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND '" + DateTime.Now.ToString("yyyy / MM / dd") + " 00:00:00.000' = NGAYDEN";
            LoadData(sql);
            btnclick = 1; 
        }

        private void SeDi_Click(object sender, EventArgs e)
        {
            btnclick = 2;
            string sql = "SELECT KHACHHANG.MAKH as 'Mã KH', MADK as 'Mã đặt phòng',  SOPHONG as 'Số phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND '" + DateTime.Now.ToString("yyyy / MM / dd") + " 00:00:00.000' = NGAYDI";
            LoadData(sql);
       
        }

        private void DangO_Click(object sender, EventArgs e)
        {
            btnclick = 3;
            string sql = "SELECT KHACHHANG.MAKH as 'Mã KH', MADK as 'Mã đặt phòng',  SOPHONG as 'Số phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND NGAYDEN <= ' " + DateTime.Now.ToString("yyyy / MM / dd") + " 00:00:00.000' AND NGAYDI >= '" + DateTime.Now.ToString("yyyy / MM / dd") + " 00:00:00.000'";
            LoadData(sql);
      
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            string sql = "";
            string TypeSearch = "";

            switch (ComboBoxSearch.Text)
            {
                case "Số phòng":
                    TypeSearch = "SOPHONG";
                    break;
                case "Họ tên":
                    TypeSearch = "HOTENKH";
                    break;
                case "Mã ĐP":
                    TypeSearch = "MADK";
                    break;
                default:
                    TypeSearch = "HOTENKH";
                    break;
            }
            if (Search.Text != "")
            {
                switch (btnclick)
                {
                    case 1:
                        sql = string.Format("SELECT KHACHHANG.MAKH as 'Mã KH', MADK as 'Mã đặt phòng',  SOPHONG as 'Số phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi'  FROM KHACHHANG, PHONGTHUE WHERE (KHACHHANG.MAKH = PHONGTHUE.MAKH AND GETDATE() < NGAYDEN) AND (" + TypeSearch + " like N'%{0}%')", Search.Text);
                        break;
                    case 2:
                        sql = string.Format("SELECT KHACHHANG.MAKH as 'Mã KH', MADK as 'Mã đặt phòng',  SOPHONG as 'Số phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi'  FROM KHACHHANG, PHONGTHUE WHERE (KHACHHANG.MAKH = PHONGTHUE.MAKH AND GETDATE() = NGAYDI) AND (" + TypeSearch + " like N'%{0}%')", Search.Text);
                        break;
                    case 3:
                        sql = string.Format("SELECT KHACHHANG.MAKH as 'Mã KH', MADK as 'Mã đặt phòng',  SOPHONG as 'Số phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi'  FROM KHACHHANG, PHONGTHUE WHERE (KHACHHANG.MAKH = PHONGTHUE.MAKH AND NGAYDEN<GETDATE() AND NGAYDI > GETDATE()) AND (" + TypeSearch + " like N'%{0}%')", Search.Text);
                        break;
                }
                LoadData(sql);
            }
        }
    }
}
