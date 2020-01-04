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
    public partial class CauHinh_LoaiPhong : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        public static string ktload = "0";
        public CauHinh_LoaiPhong()
        {
            InitializeComponent();
        }
        private void CauHinh_LoaiPhong_Load(object sender, EventArgs e)
        {
            string sql = "SELECT LOAIPHONG as 'Loại phòng', GIA as 'Giá phòng' FROM LOAIPHONG";
            showdata(sql);
        }
        void showdata(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid_DSLoaiPhong.DataSource = dt;
        }

        private void txtPhong_TextChange(object sender, EventArgs e)
        {

        }

        private void txtPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPhong.Text != "")
            {
                string sql = string.Format(" SELECT LOAIPHONG as 'Loại phòng', GIA as 'Giá phòng' FROM LOAIPHONG WHERE LOAIPHONG like N'%{0}%'", txtPhong.Text);
                showdata(sql);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            GiaPhong.Enabled = true;
            GiaPhong.Visible = true;
            btnLuu.Enabled = true;
            btnLuu.Visible = true;

            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            conn.Open();
                try
                {
                    string sql1 = "INSERT INTO LOAIPHONG(LOAIPHONG, GIA) VALUES (N'" + txtPhong.Text + "'," + GiaPhong.Text + ")";
                    SqlCommand cmd = new SqlCommand(sql1, conn);
                    cmd.ExecuteNonQuery();
                    showdata("SELECT LOAIPHONG as 'Loại phòng', GIA as 'Giá phòng' FROM LOAIPHONG");
                    MessageBox.Show("Luu thanh cong");
                    btnTroLai_Click(sender, e);
                    ktload = "1";
                }
                catch
                {
                    MessageBox.Show("loi them tang, vui  long kiem tra lai");
                }
            conn.Close();
            
        
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            GiaPhong.Enabled = false;
            GiaPhong.Visible = false;
            btnLuu.Enabled = false;
            btnLuu.Visible = false;
           
        }

        private void txtPhong_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void CauHinh_LoaiPhong_MouseClick(object sender, MouseEventArgs e)
        {
            CauHinh_LoaiPhong_Load(sender, e);
        }
    }
}
