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
    public partial class CauHinh_ThemPhong : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        public CauHinh_ThemPhong()
        {
            InitializeComponent();
            conn.Open();
            showdata();
            showcombox();
        }
        void showdata()
        { 
            string sql = " select SOPHONG as'Số Phòng', LOAIPHONG.LOAIPHONG as'Loại Phòng', GIA as'Giá Phòng', TANG as'Tầng', TRANGTHAI as'Trạng Thái' FROM PHONG,LOAIPHONG WHERE LOAIPHONG.LOAIPHONG = PHONG.LOAIPHONG";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void showcombox()
        {
            string sql2 = "SELECT distinct LOAIPHONG FROM LOAIPHONG";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "LOAIPHONG";
            comboBox1.ValueMember = "LOAIPHONG";
        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            Sua.Enabled = false;
            xoa.Enabled = false;
            if(ButtonTimKiem.Text == "Luu")
            {
                if (SoPhong.Text == "")
                    MessageBox.Show("khong duoc de so phong trong");
                else if (comboBox1.Text == "Chọn loại")
                    MessageBox.Show("khong duoc de loai phong trong");
                else if (Tang.Text == "")
                    MessageBox.Show("khong duoc de tang trong");
                else
                {
                    try
                    {
                        string sql = "INSERT INTO PHONG (TANG , SOPHONG, LOAIPHONG, TRANGTHAI) values (" + Tang.Text + ",'" + SoPhong.Text + "',N'" + comboBox1.Text + "'," + 1 + ")";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        showdata();
                        MessageBox.Show("Luu thanh cong");
                    }
                    catch
                    {
                        MessageBox.Show("Loi !!! vui long kiem tra lai");
                    }
                }
            }
            ButtonTimKiem.Text = "Luu";

        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (SoPhong.Text == "")
                MessageBox.Show("khong duoc de so phong trong");
            else if (comboBox1.Text == "Chọn loại")
                MessageBox.Show("khong duoc de loai phong trong");
            else if (Tang.Text == "")
                MessageBox.Show("khong duoc de tang trong");
            
            else
                try
                {
                    string sql = "UPDATE PHONG SET TANG =" + Tang.Text + ", LOAIPHONG = N'" + comboBox1.Text + "', TRANGTHAI = " + 1 + " WHERE SOPHONG = '" + SoPhong.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    showdata();
                    MessageBox.Show("Sua thanh cong so phong "+ SoPhong.Text);
                }
                catch
                {
                    MessageBox.Show("Loi !!! vui long kiem tra lai");
                }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM PHONG WHERE SOPHONG ='"+SoPhong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            showdata();
            MessageBox.Show("Xoa thanh cong");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            SoPhong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            Tang.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_TroLai_Click(object sender, EventArgs e)
        {
            Sua.Enabled = true;
            xoa.Enabled = true;
            ButtonTimKiem.Enabled = true;
            ButtonTimKiem.Text = "Thêm";
        }
    }
}
