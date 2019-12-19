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
            string sql1 = "select * from PHONG";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBox3.DataSource = dt1;
            comboBox3.DisplayMember = "SOPHONG";
            comboBox3.ValueMember = "SOPHONG";

            string sql2 = "select LOAIPHONG from PHONG WHERE SOPHONG = " + comboBox3.ValueMember;
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "LOAIPHONG";
            comboBox1.ValueMember = "LOAIPHONG";



        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {

        }

        private void KhachLe_TongHop_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                else if (ghichu.Text == "")
                    MessageBox.Show("khong duoc de ghi chu trong");
                else
                    try
                    {
                        string sql = "INSERT INTO KHACHHANG(MAKH,HOTENKH,NGAYSINH,GIOITINH,CMND,SDT,QUOCTICH) VALUES('" + bunifuTextBox2.Text + "','" + tenkhach.Text + "'," + bunifuDatepicker1.Value.Day + "/" + bunifuDatepicker1.Value.Month + "/" + bunifuDatepicker1.Value.Year + ",'" + gioitinhcombobox.Text + "','" + scmnt.Text + "','" + didong.Text + "','" + comboBox5.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        string st = comboBox3.Text;
                        string sql2 = "INSERT INTO PHONGTHUE(MAKH,MADK,SOPHONG,NGAYDEN,NGAYDI,NGAYDK) VALUES('" + bunifuTextBox2.Text + "','" + bunifuTextBox2.Text + "','" + comboBox3.Text + "'," + bunifuDatepicker2.Value.Day + "/" + bunifuDatepicker2.Value.Month + "/" + bunifuDatepicker2.Value.Year + "," + bunifuDatepicker3.Value.Day + "/" + bunifuDatepicker3.Value.Month + "/" + bunifuDatepicker3.Value.Year + "," + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "," + ")";
                        SqlCommand cmd2 = new SqlCommand(sql2, conn);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Them thanh cong");

                    }
                    catch
                    {
                        MessageBox.Show("xay ra loi");
                    }
                conn.Close();
            }
        }

        private void tenkhach_Leave(object sender, EventArgs e)
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
    }
}
