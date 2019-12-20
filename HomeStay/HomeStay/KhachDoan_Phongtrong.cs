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
            string sql5 = "SELECT SOPHONG FROM PHONG EXCEPT (SELECT P.SOPHONG FROM PHONGTHUE PT, PHONG P, KHACHHANG KH WHERE PT.SOPHONG = P.SOPHONG AND KH.MAKH = PT.MAKH AND((' " + NgayDenApp.Value.ToString("yyyy-MM-dd") + "'<=NgayDen) AND('" + NgayDiApp.Value.ToString("yyyy-MM-dd") + "' >= NGAYDI)))";
            LoadData(sql5, dataGridViewphongtrong);

        }
        private void LoadData(string sql, DataGridView ViewDTA)
        {
            SqlConnection conn = new SqlConnection(DataSource.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ViewDTA.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi", "Lỗi kết nối Server");
            }
            finally
            {
                conn.Close();
            }

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
