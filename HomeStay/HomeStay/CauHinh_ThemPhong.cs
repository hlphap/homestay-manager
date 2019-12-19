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
        }
        void showdata()
        { 
            string sql = " select SOPHONG as'    Số Phòng    ', LOAIPHONG.LOAIPHONG as'    Loại Phòng  ', GIA as' Giá Phòng   ', TANG as'   Tầng    ', TRANGTHAI as'  Trạng Thái  ' FROM PHONG,LOAIPHONG WHERE LOAIPHONG.LOAIPHONG = PHONG.LOAIPHONG";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            Sua.Enabled = false;
            xoa.Enabled = false;
            if(ButtonTimKiem.Text == "Luu")
            {
                if (SoPhong.Text == "")
                    MessageBox.Show("khong duoc de so phong trong");
                else if (LoaiPhong.Text == "")
                    MessageBox.Show("khong duoc de loai phong trong");
                else if (GiaPhong.Text == "")
                    MessageBox.Show("khong duoc de gia phong trong");
                else if (Tang.Text == "")
                    MessageBox.Show("khong duoc de tang trong");
                else if (TrangThai.Text == "")
                    MessageBox.Show("khong duoc de trang thai trong");
                else
                {
                    try
                    {
                        string sql = "INSERT INTO PHONG (TANG , SOPHONG, LOAIPHONG, TRANGTHAI) values (" + Tang.Text + ",'" + SoPhong.Text + "','" + LoaiPhong.Text + "," + TrangThai.Text + ")";
                        string sql2 = "INSERT INTO LOAIPHONG(LOAIPHONG, GIA) VALUES ('" + LoaiPhong.Text + "','" + GiaPhong.Text + "')";
                        SqlCommand cmd2 = new SqlCommand(sql2, conn);
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd2.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        showdata();
                        MessageBox.Show("Luu thanh cong");
                    }
                    catch
                    {
                        MessageBox.Show("trung so phong, vui long kiem tra lai");
                    }
                }
            }
            ButtonTimKiem.Text = "Luu";

        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (SoPhong.Text == "")
                MessageBox.Show("khong duoc de so phong trong");
            else if (LoaiPhong.Text == "")
                MessageBox.Show("khong duoc de loai phong trong");
            else if (GiaPhong.Text == "")
                MessageBox.Show("khong duoc de gia phong trong");
            else if (Tang.Text == "")
                MessageBox.Show("khong duoc de tang trong");
            else if (TrangThai.Text == "")
                MessageBox.Show("khong duoc de trang thai trong");
            else
                try
                {
                    string sql = "UPDATE PHONG SET TANG =" + Tang.Text + ", SOPHONG = '" + SoPhong.Text + "', LOAIPHONG = '" + LoaiPhong.Text + "',GIAPHONG = " + GiaPhong.Text + ", TRANGTHAI = " + TrangThai.Text + " WHERE SOPHONG = '" + SoPhong.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    showdata();
                    MessageBox.Show("Sua thanh cong");
                }
                catch
                {
                    MessageBox.Show("Loi so phong, vui long kiem tra lai");
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
            LoaiPhong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            GiaPhong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            Tang.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            TrangThai.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
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
