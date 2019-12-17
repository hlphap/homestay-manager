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
    public partial class KhachDoan_DoanDaDi : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        string sql = "SELECT khachhang.MAKH AS'Mã khách hàng',HOTENKH AS'Họ Tên', MADK AS 'Mã đăng ký', LOAIPHONG AS'Loại phòng', NGAYDEN AS'Ngày đến', NGAYDI AS 'Ngày đi' FROM PHONGTHUE, PHONG, KHACHHANG WHERE PHONG.SOPHONG = PHONGTHUE.SOPHONG AND PHONGTHUE.MAKH = KHACHHANG.MAKH";

        public KhachDoan_DoanDaDi()
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
        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            if (madatphongtxt.Text == "")
                MessageBox.Show("Ma dat phong trong");
            else if (comboBox2.Text == "")
                MessageBox.Show("Phai chon loai phong");
            else
            {
                try
                {
                    sql = "SELECT khachhang.MAKH AS'Mã khách hàng',HOTENKH AS'Họ Tên', MADK AS 'Mã đăng ký', LOAIPHONG AS'Loại phòng', NGAYDEN AS'Ngày đến', NGAYDI AS 'Ngày đi' FROM PHONGTHUE, PHONG, KHACHHANG WHERE PHONG.SOPHONG = PHONGTHUE.SOPHONG AND PHONGTHUE.MAKH = KHACHHANG.MAKH AND NGAYDI > "  + DateTime.Today.Year + "/" + DateTime.Today.Month + "/" + DateTime.Today.Day + "AND MADK = '" + madatphongtxt.Text + "' AND LOAIPHONG = '" + comboBox2.Text + "'";
                    showdata(sql);
                }
                catch
                {
                    MessageBox.Show("Loi");
                }
            }
        }
    }
}
