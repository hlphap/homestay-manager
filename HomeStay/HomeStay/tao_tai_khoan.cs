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

        private void tao_tai_khoan_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_tao_tai_khoan_Click(object sender, EventArgs e)
        {
            string sql;
            SqlConnection con = new SqlConnection();
            // DATA SOURCE
            con.ConnectionString = (@"Data Source = SE140697\SQLEXPRESS; Initial Catalog = HomeStay; Integrated Security = True");

            /*if (txt_hoten.Text == null)
            {
                MessageBox.Show("ho ten khong duoc de trong");
            }
            else if(txt_manv.Text == null)
            {
                MessageBox.Show("ma nhan vien khong duoc de trong");
            }
            else if (txt_dia_chi.Text == null)
            {
                MessageBox.Show("dia chi khong duoc de trong");
            }
            else if (txt_cmnd.Text == null)
            {
                MessageBox.Show("cmnd khong duoc de trong");
            }
            else if (txt_mat_khau.Text == null)
            {
                MessageBox.Show("mat khau khong duoc de trong");
            }*/
            if (txt_mat_nhau_nhap_lai.Text != txt_mat_khau.Text)
            {
                MessageBox.Show("Mat khau nhap lai khac voi mat khau. nhap lai mat khau");
            }
            else
            {
                con.Open();
                sql = "INSERT INTO NHANVIEN(TaiKhoan,MANV,HOTEN,NGAYSINH,CMND_NV,DIACHI)VALUES (";
                sql += "'" + txt_tai_khoan.Text + "','" + txt_manv.Text + "','" + txt_hoten.Text + "','" + ngaysinh.Value.Date + "','" + txt_cmnd.Text + "','" + txt_dia_chi.Text + "')";
                //sql = "INSERT INTO Sign_in(TAIKHOAN, MATKHAU)VALUES ('";
                //sql += txt_tai_khoan.Text + "','"+ txt_mat_khau.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("tao tai khoan thanh cong !!");
            }
        }


    }
}
