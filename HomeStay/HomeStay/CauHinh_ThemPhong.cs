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
    public partial class CauHinh_ThemPhong : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        public CauHinh_ThemPhong()
        {
            InitializeComponent();
            conn.Open();
            showdata();
        }
        void showdata()
        { 
            string sql = " select SOPHONG as'    Số Phòng    ', LOAIPHONG as'    Loại Phòng  ', GIAPHONG as' Giá Phòng   ', TANG as'   Tầng    ', TRANGTHAI as'  Trạng Thái  ' FROM PHONG";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO PHONG (TANG , SOPHONG, LOAIPHONG, GIAPHONG, TRANGTHAI) values ("+Tang.Text+",'"+SoPhong.Text + "','" + LoaiPhong.Text + "'," + GiaPhong.Text + "," + TrangThai.Text + ")";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE PHONG SET TANG =" + Tang.Text + ", SOPHONG = '" + SoPhong.Text + "', LOAIPHONG = '" + LoaiPhong.Text + "',GIAPHONG = " + GiaPhong.Text + ", TRANGTHAI = " + TrangThai.Text + " WHERE SOPHONG = '"+SoPhong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM PHONG WHERE SOPHONG ='"+SoPhong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            SoPhong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            LoaiPhong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            GiaPhong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            Tang.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            TrangThai.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
    }
}
