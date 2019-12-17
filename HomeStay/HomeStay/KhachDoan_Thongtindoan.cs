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
        public KhachDoan_Thongtindoan()
        {
            InitializeComponent();
            conn.Open();
            
        }

        private void KhachDoan_Thongtindoan_Load(object sender, EventArgs e)
        {

        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            if (ButtonTimKiem.Text == "Luu")
            {
                if (tentruongdoantxt.Text == "")
                    MessageBox.Show("khong duoc de ten truong doan trong");
                else if (comboBox3.Text == "")
                    MessageBox.Show("Chon gioi tinh");
                /*else if (bunifuDatePicker1.Value.Date < DateTime.Today)
                    MessageBox.Show("Loi ngay sinh");*/
                else if (sdttxt.Text == "")
                    MessageBox.Show("khong duoc de so dien thoai trong");
                else if (cmndtxt.Text == "")
                    MessageBox.Show("khong duoc de cmnd trong");
                else
                {
                    try
                    {
                        string sql = "INSERT INTO KHACHHANG  values ('" + bunifuTextBox3.Text + "','" + tentruongdoantxt.Text + "'," + bunifuDatePicker1.Value.Year +"/" + bunifuDatePicker1.Value.Month + "/" + bunifuDatePicker1.Value.Day + ",'" + comboBox3.Text + "','" + cmndtxt.Text + "','"+sdttxt.Text +"','"+quoctichtxt.Text+"')";
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
                        MessageBox.Show("Loi");
                    }
                }
            }
            ButtonTimKiem.Text = "Luu";
        }
    }
}
