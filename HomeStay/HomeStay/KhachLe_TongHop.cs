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
    public partial class KhachLe_TongHop : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);

        public KhachLe_TongHop()
        {
            InitializeComponent();
            conn.Open();
        }


        private void Them_Click(object sender, EventArgs e)
        {
            {
                if (tenkhach.Text == "")
                    MessageBox.Show("khong duoc de ten khach trong");
                else if (scmnt.Text == "")
                    MessageBox.Show("khong duoc de cmnd trong");
                else if (didong.Text == "")
                    MessageBox.Show("khong duoc de sdt trong");
                else if (email.Text == "")
                    MessageBox.Show("khong duoc de email trong");
                else if (diachi.Text == "")
                    MessageBox.Show("khong duoc de dia chi trong");
                else
                    try
                    {
                        string sql = "INSERT INTO KHACHHANG(MAKH,HOTENKH,NGAYSINH,GIOITINH,CMND,SDT,QUOCTICH) VALUES('" + bunifuTextBox2.Text.Trim() + "','" + tenkhach.Text + "','" + bunifuDatepicker1.Value.ToString("yyyy/MM/dd")+ "','" + gioitinhcombobox.Text + "','" + scmnt.Text + "','" + didong.Text + "','" + comboBox5.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        string st = comboBox3.Text;
                        string sql2 = "INSERT INTO PHONGTHUE(MAKH,MADK,SOPHONG,NGAYDEN,NGAYDI,NGAYDK) VALUES('" + bunifuTextBox2.Text.Trim() + "','" + bunifuTextBox2.Text + "','" + comboBox3.Text + "','" + bunifuDatepicker2.Value.ToString("yyyy/MM/dd") + "','" + bunifuDatepicker3.Value.ToString("yyyy/MM/dd") + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "')";
                        SqlCommand cmd2 = new SqlCommand(sql2, conn);
                        cmd2.ExecuteNonQuery();
                        
                        MessageBox.Show("Them thanh cong");

                    }
                    catch
                    {
                        MessageBox.Show("Xay ra loi");
                    }
                conn.Close();
            }
            FormChinh.LoadTrangThai();
        }

        private void tenkhach_Leave(object sender, EventArgs e)
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
                bunifuTextBox2.Text = Str;
            }
            catch
            {
                bunifuTextBox2.Text = "KH01";
            }

        }


        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string sql1 = "SELECT SOPHONG FROM PHONG WHERE LOAIPHONG = N'"+comboBox1.Text+"'EXCEPT (SELECT P.SOPHONG FROM PHONGTHUE PT, PHONG P, KHACHHANG KH WHERE PT.SOPHONG = P.SOPHONG AND KH.MAKH = PT.MAKH AND (('" + bunifuDatepicker2.Value.ToString("yyyy-MM-dd") + "'<=NgayDen) AND('" + bunifuDatepicker3.Value.ToString("yyyy-MM-dd") + "' >= NGAYDI)))";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBox3.DataSource = dt1;
            comboBox3.DisplayMember = "SOPHONG";
            comboBox3.ValueMember = "SOPHONG";
            comboBox3.Enabled = true;

        }

        private void bunifuDatepicker3_Leave(object sender, EventArgs e)
        {
            string sql2 = "SELECT distinct LOAIPHONG FROM PHONG WHERE SOPHONG NOT IN ( SELECT SOPHONG FROM PHONGTHUE WHERE '" + bunifuDatepicker2.Value.ToString("yyyy-MM-dd") + "'<=NgayDen AND'" + bunifuDatepicker3.Value.ToString("yyyy-MM-dd") + "'>= NGAYDI)";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "LOAIPHONG";      
            comboBox1.ValueMember = "LOAIPHONG";
            comboBox1.Enabled = true;
        }
    }
}
