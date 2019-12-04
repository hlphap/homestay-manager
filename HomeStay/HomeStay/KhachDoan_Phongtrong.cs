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
    public partial class KhachDoan_Phongtrong : UserControl
    {
        public KhachDoan_Phongtrong()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(DataSource.connectionString);
            conn.Open();

            string sql2 = "select LOAIPHONG from PHONG";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "LOAIPHONG";
            comboBox1.ValueMember = "LOAIPHONG";
        }
    }
}
