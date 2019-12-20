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
    public partial class KhachDoan_DoanDangO : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        string sql = "SELECT KHACHHANG.MAKH as 'Mã KH', MADK as 'Mã đặt phòng',  SOPHONG as 'Số phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND NGAYDEN<GETDATE() AND NGAYDI > GETDATE()";
        public KhachDoan_DoanDangO()
        {
            InitializeComponent();
            showdata(sql);
        }
        void showdata(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewthongtindoan.DataSource = dt;
        }
        private void LoadData(string sql, DataGridView ViewDTA)
        {

            try
            {

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ViewDTA.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi", "Lỗi");
            }

        }
        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            
                try
                {
                string sql = "SELECT KHACHHANG.MAKH as 'Mã KH', MADK as 'Mã đặt phòng',  SOPHONG as 'Số phòng', HOTENKH as 'Họ tên', NGAYDEN as 'Ngày đến', NGAYDI as 'Ngày đi' FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND NGAYDEN<GETDATE() AND NGAYDI > GETDATE()";
                LoadData(sql, dataGridViewthongtindoan);
                }
                catch
                {
                    MessageBox.Show("Loi");
                }

        }
    }
}
