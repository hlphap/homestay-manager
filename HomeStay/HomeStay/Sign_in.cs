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

        public static string ChucVu = "";
        public Sign_in()
        {
            InitializeComponent();

        }
        private void Button_Shutdown_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private string GetID(string username, string password)
        {

            SqlConnection conn = new SqlConnection(DataSource.connectionString);
            string cv = "";
            try
            {
                conn.Open();
                string sql = "SELECT TaiKhoan, MatKhau, ChucVu FROM Sign_in WHERE TaiKhoan = '" + username + "' AND MatKhau = '" + password + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    cv = dta["ChucVu"].ToString();
                }
                else
                {
                    MessageBox.Show("Sai Mat Khau! Nhap Lai? ", "Loi", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                conn.Close();
            }

            return cv;

        }
            private void Button_Signin_Click(object sender, EventArgs e)
            {
                ChucVu = GetID(Textbox_Username.Text, Textbox_Password.Text);
                if (ChucVu != "")
                {
                    Form NewForm = new FormChinh();
                    NewForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoảng và mật khẩu không đúng !");
                }
            }

        private void Textbox_Password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Button_Signin_Click(sender, e);
            }
        }
    }
}
