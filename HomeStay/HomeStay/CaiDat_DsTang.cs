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
    public partial class CaiDat_DsTang : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        public static string ktload = "0";
        public CaiDat_DsTang()
        {
            InitializeComponent();
            conn.Open();
            showdata();
            themtang.Hide();
        }
        
        void showdata()
        {
            string sql = " select TANG.TANG as 'Tầng' FROM TANG ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid_DSTang.DataSource = dt;
        }
        private void Tangtxt_TextChange(object sender, EventArgs e)
        {
            string sql = " select TANG as 'Tầng' FROM TANG ";
            if (Tangtxt.Text != "")
                 sql = " select TANG as 'Tầng' FROM TANG WHERE TANG = " + Tangtxt.Text;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid_DSTang.DataSource = dt;
        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            xoa.Enabled = false;
            themtang.Show();
            if (ButtonTimKiem.Text =="Luu")
            {
                try
                {
                    string sql = "INSERT INTO TANG(TANG) VALUES (" + themtang.Text + ")";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    showdata();
                    MessageBox.Show("Them thanh cong");
                    xoa.Enabled = true;
                    ktload = "1";
                }
                catch
                {
                    MessageBox.Show("loi them tang, vui  long kiem tra lai");
                }
            }
            ButtonTimKiem.Text = "Luu";
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM PHONG WHERE TANG ='" + Tangtxt.Text + "'";
            string sql2 = "DELETE FROM TANG WHERE TANG ='" + Tangtxt.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            showdata();
            MessageBox.Show("Xoa thanh cong");
        }

        private void DataGrid_DSTang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = DataGrid_DSTang.CurrentRow.Index;
            Tangtxt.Text = DataGrid_DSTang.Rows[i].Cells[0].Value.ToString();
        }
    }
}
