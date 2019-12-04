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
        public KhachLe_TongHop()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(DataSource.connectionString);
            conn.Open();

            string sql1 = "select * from PHONGTHUE";
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

            string sql3 = "select * from PHONG WHERE SOPHONG = " + comboBox3.ValueMember;
            SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            comboBox2.DataSource = dt3;
            comboBox2.DisplayMember = "GIAPHONG";
            comboBox2.ValueMember = "GIAPHONG";
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
    }
}
