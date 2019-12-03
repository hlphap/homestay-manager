using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomeStay
{
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();           
          

        }



        private void Button_Signin_Click(object sender, EventArgs e)
        {
            Form NewForm = new FormChinh();
            // DATA SOURCE
            SqlConnection conn = new SqlConnection(@"Data Source = SE140697\SQLEXPRESS; Initial Catalog = HomeStay; Integrated Security = True");
            conn.Open();
            string Taikhoan = Textbox_Username.Text;
            string MatKhau = Textbox_Password.Text;
            string sql = "SELECT TaiKhoan, MatKhau FROM Sign_in WHERE TaiKhoan = '" + Taikhoan + "' AND MatKhau = '" + MatKhau + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                this.Hide();
                NewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai Mat Khau! Nhap Lai? ", "Loi", MessageBoxButtons.OK);
            }
        }

        private void Button_Shutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Button_Shutdown_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Textbox_Password_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Form NewForm = new FormChinh();
                // DATA SOURCE
                SqlConnection conn = new SqlConnection(@"Data Source = SE140697\SQLEXPRESS; Initial Catalog = HomeStay; Integrated Security = True");
                conn.Open();
                string Taikhoan = Textbox_Username.Text;
                string MatKhau = Textbox_Password.Text;
                string sql = "SELECT TaiKhoan, MatKhau FROM Sign_in WHERE TaiKhoan = '" + Taikhoan + "' AND MatKhau = '" + MatKhau + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide();
                    NewForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai Mat Khau! Nhap Lai? ", "Loi", MessageBoxButtons.OK);
                }
            }
        }

        private void bnt_tao_tai_khoan_Click(object sender, EventArgs e)
        {
            tao_tai_khoan taotaikhoan = new tao_tai_khoan();
            this.Hide();
            taotaikhoan.ShowDialog();
        }
    }
}
