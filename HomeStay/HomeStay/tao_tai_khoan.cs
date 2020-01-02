using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomeStay
{
    public partial class tao_tai_khoan : Form
    {
        public tao_tai_khoan()
        {
            InitializeComponent();
        }

 
        private void Button_Shutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tao_tai_khoan_Click_1(object sender, EventArgs e)
        {
            string sql;
            SqlConnection conn = new SqlConnection(DataSource.connectionString);

            if (txt_hoten.Text == "")
            {
                MessageBox.Show("ho ten khong duoc de trong");
            }
            else if (txt_manv.Text == "")
            {
                MessageBox.Show("ma nhan vien khong duoc de trong");
            }
            else if (txt_dia_chi.Text == "")
            {
                MessageBox.Show("dia chi khong duoc de trong");
            }
            else if (txt_cmnd.Text == "")
            {
                MessageBox.Show("cmnd khong duoc de trong");
            }
            else if (txt_mat_khau.Text == "")
            {
                MessageBox.Show("mat khau khong duoc de trong");
            }
            if (txt_mat_nhau_nhap_lai.Text != txt_mat_khau.Text)
            {
                MessageBox.Show("Mat khau nhap lai khac voi mat khau. nhap lai mat khau");
            }
            else
            {
                try
                {
                    conn.Open();
                    sql = "INSERT INTO Sign_in(TAIKHOAN, MATKHAU,ChucVu)VALUES ('";
                    sql += txt_tai_khoan.Text + "','" + txt_mat_khau.Text + "',2) ";
                    sql += "INSERT INTO NHANVIEN(TaiKhoan,MANV,HOTEN,NGAYSINH,CMND_NV,DIACHI)VALUES (";
                    sql += "'" + txt_tai_khoan.Text + "','" + txt_manv.Text + "','" + txt_hoten.Text + "','" + ngaysinh.Value.Date + "','" + txt_cmnd.Text + "','" + txt_dia_chi.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("tao tai khoan thanh cong !!");
                }
                catch
                {
                    MessageBox.Show("Loi !!!");
                }
            }
        }
    }
}
