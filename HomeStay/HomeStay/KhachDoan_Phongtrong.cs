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
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        string sql = " select SOPHONG as'Số Phòng', LOAIPHONG.loaiphong as'Loại Phòng', GIA as' Giá Phòng', TANG as'Tầng ' FROM PHONG,LOAIPHONG WHERE PHONG.LOAIPHONG=LOAIPHONG.LOAIPHONG AND TRANGTHAI = 1 ";
        public string[] sophong = new string[20];
        public int demsophong = -1;
        public KhachDoan_Phongtrong()
        {
            InitializeComponent();
            conn.Open();
            string sql2 = "select LOAIPHONG from PHONG";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "LOAIPHONG";
            comboBox1.ValueMember = "LOAIPHONG";
            showdata(sql);
            
        }
        void showdata(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewphongtrong.DataSource = dt;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            sql = " select SOPHONG as'Số Phòng', LOAIPHONG as'Loại Phòng', GIA as' Giá Phòng', TANG as'Tầng ' FROM PHONG, PHONGTHUE,LOAIPHONG WHERE PHONG.SOPHONG = PHONGTHUE.SOPHONG AND LOAIPHONG.LOAIPHONG = PHONG.LOAIPHONG AND TRANGTHAI = 1 ";

            /*try
            {
                sql += "AND SOPHONG = '" + comboBox1.ValueMember.ToString() + "'";
                sql += "AND NGAYDI > " + bunifuDatepicker1.Value.Date + " AND NGAYDEN < " + bunifuDatepicker2.Value.Date;
                showdata(sql);
            }
            catch
            {
                MessageBox.Show("Loi tim kiem");
            }*/
        }

        private void dataGridViewphongtrong_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewphongtrong.CurrentRow.Index;
            int dem = 0;
            int dong = DataGridPhongDaChon.RowCount;

            for ( int j = 0; j < dong;j++)
            {
                if (DataGridPhongDaChon.Rows[j].Cells[0].Value == dataGridViewphongtrong.Rows[i].Cells[0].Value)
                    dem++;
            }
            if(dem == 0)
            {
                int n = DataGridPhongDaChon.Rows.Add();
                DataGridPhongDaChon.Rows[n].Cells[0].Value = dataGridViewphongtrong.Rows[i].Cells[0].Value;
                //sophong = DataGridPhongDaChon.Rows[n].Cells[0].Value.ToString();
                demsophong++;
                sophong[demsophong] = DataGridPhongDaChon.Rows[n].Cells[0].Value.ToString();
            }
        }
    }
}
