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
        public ThanhToan_KhachLe()
        {
            InitializeComponent();
            conn.Open();
            string sql2 = "SELECT SOPHONG FROM PHONG";
            showdata(sql2);
        }
        public void loaddatathongtinkhach(string sophong)
        {
            string HoTenz, scmndz, DiaChiz, SDTz;
            string sql = "SELECT HOTEN FROM KHACHHANG,PHONG WHERE KHACHHANG.MAKH = PHONG.MAKH AND SOPHONG ='" + sophong + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            //HoTen.Text = HoTenz;
            //scmnd.Text = scmndz;
            //SDT.Text = SDTz;
            //DiaChi.Text = DiaChiz;
            showinfo();
        }
        public void showinfo()
        {
            string sql = "SElECT HOTENKH  FROM PHONGTHUE WHERE SOPHONG = '" + sophong + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            cmd1.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            object SUM;
            SUM = dt.Compute("(HOTENKH)", "");
            HoTen.Text = SUM.ToString();
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void DataGridPhongDaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DataGridPhongDaChon.CurrentRow.Index;
            sophong = DataGridPhongDaChon.Rows[i].Cells[0].Value.ToString();
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

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string sql = "SElECT GIA  FROM PHONG, PHONGTHUE,LOAIPHONG WHERE PHONGTHUE.SOPHONG = PHONG.SOPHONG AND LOAIPHONG.LOAIPHONG = PHONG.LOAIPHONG AND PHONG.SOPHONG = '" + sophong + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            cmd1.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);

            object SUM;
            SUM = dt.Compute("Max(GIA)", "");
            thanhtientext.Text = SUM.ToString();
        }
    }
}
