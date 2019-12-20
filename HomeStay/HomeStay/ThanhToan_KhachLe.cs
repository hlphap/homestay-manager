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

namespace HomeStay.Resources
{
    public partial class ThanhToan_KhachLe : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        string sophong;
        string makh;
        public ThanhToan_KhachLe()
        {
            InitializeComponent();
            conn.Open();
            string sql2 = "SELECT SOPHONG FROM PHONG";
            showdata(sql2);
        }
        public void loaddatathongtinkhach(string sophong)
        {
            string sql = "SELECT HOTENKH FROM KHACHHANG,PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND SOPHONG ='" + sophong + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            showinfoMAKH();
            showinfohoten();
            showinfocmnd();
        }
        public void showinfohoten()
        {
            string sql = "SElECT HOTENKH  FROM PHONGTHUE, KHACHHANG WHERE PHONGTHUE.MAKH= KHACHHANG.MAKH AND PHONGTHUE.makh = '" + makh + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            cmd1.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            object ten;
            ten = dt.Compute("max(HOTENKH)", "");
            HoTen.Text = ten.ToString();
        }
        public void showinfocmnd()
        {
            string sql = "SElECT CMND FROM PHONGTHUE, KHACHHANG WHERE PHONGTHUE.MAKH= KHACHHANG.MAKH AND PHONGTHUE.makh = '" + makh + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            cmd1.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            object ten;
            ten = dt.Compute("max(CMND)", "");
            scmnd.Text = ten.ToString();
        }
        public void showinfoMAKH()
        {
            string sql = "SElECT KHACHHANG.MAKH FROM PHONGTHUE, KHACHHANG WHERE PHONGTHUE.MAKH= KHACHHANG.MAKH AND sophong = '" + sophong + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            cmd1.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            object ten;
            ten = dt.Compute("max(MAKH)", "");
            SDT.Text = ten.ToString();
            makh = SDT.Text;
        }
        private void DataGridPhongDaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DataGridPhongDaChon.CurrentRow.Index;
            sophongtxt.Text = DataGridPhongDaChon.Rows[i].Cells[0].Value.ToString();
            sophong = sophongtxt.Text;
            loaddatathongtinkhach(sophong);

        }

        void showdata(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridPhongDaChon.DataSource = dt;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string sql = "SELECT DATEDIFF (day, NGAYDEN, NGAYDI) AS ngayo From PHONGTHUE, KHACHHANG WHERE  SOPHONG = '" + sophong + "' AND khachhang.MAKH = '"+makh.Trim()+"'" ;
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            cmd1.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);

            object SUM;
            SUM = dt.Compute("Max(ngayo)", "");
            thanhtientext.Text = SUM.ToString();
            int ngayo = Int32.Parse(thanhtientext.Text);
            
            string sql2 = "SELECT gia AS GIA From PHONGTHUE, KHACHHANG, LOAIPHONG, PHONG WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND PHONGTHUE.SOPHONG = PHONG.SOPHONG AND PHONG.LOAIPHONG = LOAIPHONG.LOAIPHONG AND PHONGTHUE.SOPHONG  = '" + sophong + "' AND khachhang.MAKH = '" + makh.Trim() + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            cmd2.CommandType = CommandType.Text;
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            object GIA;
            GIA = dt2.Compute("Max(GIA)", "");
            thanhtientext.Text = GIA.ToString();
            double gia = Convert.ToDouble(thanhtientext.Text);

            thanhtientext.Text = (gia * ngayo).ToString();
        }

     }
}
