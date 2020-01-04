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
    public partial class CauHinh_ThongTinNhanVien : UserControl
    {
        public CauHinh_ThongTinNhanVien()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(DataSource.connectionString);

        private void btThemNV_Click(object sender, EventArgs e)
        {
            tao_tai_khoan ttk = new tao_tai_khoan();
            ttk.Show();
            
        }

        private void CauHinh_ThongTinNhanVien_Load(object sender, EventArgs e)
        {
      
            string sql = "SELECT TOP (1000) [TaiKhoan] as'Tài Khoản',[MANV]  as 'Mã NV',[HOTEN] as'Họ tên',[NGAYSINH] as'Ngày sinh',[CMND_NV] as'Số cmnd',[DIACHI] as'Địa chỉ' FROM NHANVIEN";
            showdata(sql);
            
        }

    
        void showdata(string sql)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Loi thong tin nhan vien !!!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {

            string sql = string.Format("SELECT TOP (1000) [TaiKhoan] as'Tài Khoản',[MANV]  as 'Mã NV',[HOTEN] as'Họ tên',[NGAYSINH] as'Ngày sinh',[CMND_NV] as'Số cmnd',[DIACHI] as'Địa chỉ' FROM[HomeStay].[dbo].[NHANVIEN] WHERE MANV like N'%{0}%'", MaNV.Text);
            showdata(sql);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tao_tai_khoan.ktclick == "1")
            {
                CauHinh_ThongTinNhanVien_Load(sender, e);
            }
           
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            CauHinh_ThongTinNhanVien_Load(sender, e);
        }
    }
}
