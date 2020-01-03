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
    public partial class KhachDoan_Thongtindoan : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        public string tentd, sdttd, socmndtd, madoan;

        private void bunifuTextBox3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SElECT max(MAKH) max FROM KHACHHANG";     // madoan
                SqlCommand cmd1 = new SqlCommand(sql, conn);
                cmd1.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);

                object Max;
                Max = dt.Compute("Max(max)", "");
                string Str = Max.ToString();
                string Str1 = Str.Substring(2);
                int madoan = Int32.Parse(Str1);
                madoan++;
                Str = Str.Replace(Str1, madoan.ToString());
                bunifuTextBox3.Text = Str;                   // btn, lable, text madoan
            }
            catch
            {
                bunifuTextBox3.Text = "KD01";

            }
        }

        private void ButtonTimKiem_Click_1(object sender, EventArgs e)
        {
            if (ButtonTimKiem.Text == "Luu")
            {
                if (tentruongdoantxt.Text == "")
                    MessageBox.Show("khong duoc de ten truong doan trong");
                else if (comboBox3.Text == "")
                    MessageBox.Show("Chon gioi tinh");
                else if (sdttxt.Text == "")
                    MessageBox.Show("khong duoc de so dien thoai trong");
                else if (cmndtxt.Text == "")
                    MessageBox.Show("khong duoc de cmnd trong");
                else if (email.Text == "")
                    MessageBox.Show("Khong duoc de email trong");
                else if (quoctichtxt.Text == "")
                    MessageBox.Show("Khong duoc de quoc tich trong");
                else if (diachitxt.Text == "")
                    MessageBox.Show("Khong duoc de dia chi trong");
                else
                {
                    try
                    {
                        string sql = "INSERT INTO KHACHHANG  values ('" + bunifuTextBox3.Text + "','" + tentruongdoantxt.Text + "'," + bunifuDatePicker1.Value.ToString("yyyy/MM/dd") + ",'" + comboBox3.Text + "','" + cmndtxt.Text + "','" + sdttxt.Text + "','" + quoctichtxt.Text + "','" + diachitxt.Text + "','" + email.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Luu thanh cong");
                        tentd = tentruongdoantxt.Text;
                        sdttd = sdttxt.Text;
                        socmndtd = cmndtxt.Text;
                        madoan = bunifuTextBox3.Text;
                    }
                    catch
                    {
                        MessageBox.Show("Loi Ma Doan");
                    }
                }
            }
            ButtonTimKiem.Text = "Luu";
        }

        public KhachDoan_Thongtindoan()
        {
            InitializeComponent();
            conn.Open();
            try
            {
                string sql = "SElECT max(MAKH) max FROM KHACHHANG";     // madoan
                SqlCommand cmd1 = new SqlCommand(sql, conn);
                cmd1.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);

                object Max;
                Max = dt.Compute("Max(max)", "");
                string Str = Max.ToString();
                string Str1 = Str.Substring(2);
                int madoan = Int32.Parse(Str1);
                madoan++;
                Str = Str.Replace(Str1, madoan.ToString());
                bunifuTextBox3.Text = Str;                   // btn, lable, text madoan

            }
            catch
            {
                bunifuTextBox3.Text = "KD01";

            }

        }


    }
}
