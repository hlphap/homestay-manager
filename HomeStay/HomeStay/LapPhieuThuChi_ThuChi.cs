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
    public partial class LapPhieuThuChi_ThuChi : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        string sql = "select  KHACHHANG.MAKH, HOTENKH,phong.SOPHONG,  gia as 'Giá' from LOAIPHONG, PHONG, PHONGTHUE, KHACHHANG where LOAIPHONG.LOAIPHONG = PHONG.LOAIPHONG AND PHONGTHUE.SOPHONG = PHONG.SOPHONG AND PHONGTHUE.MAKH = KHACHHANG.MAKH";

        public LapPhieuThuChi_ThuChi()
        {
            InitializeComponent();
            conn.Open();
            showdata(sql);
            tongtien();
            
        }
        void tongtien()
        {
            sql = "select sum(gia) tong from LOAIPHONG, PHONG, PHONGTHUE where LOAIPHONG.LOAIPHONG = PHONG.LOAIPHONG AND PHONGTHUE.SOPHONG = PHONG.SOPHONG AND NGAYDEN >'" + ngayden.Value.ToString("yyyy/MM/dd") + "' AND NGAYDI <= '"+ngaydi.Value.ToString("yyyy/MM/dd") +"'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            cmd1.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);

            object sum;
            sum = dt.Compute("max(tong)", "");
            tongtientxt.Text = sum.ToString(); 
        }

        void showdata(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            sql = "select  KHACHHANG.MAKH, HOTENKH,phong.SOPHONG,  gia as 'Giá' from LOAIPHONG, PHONG, PHONGTHUE, KHACHHANG where LOAIPHONG.LOAIPHONG = PHONG.LOAIPHONG AND PHONGTHUE.SOPHONG = PHONG.SOPHONG AND PHONGTHUE.MAKH = KHACHHANG.MAKH AND NGAYDEN >'" + ngayden.Value.ToString("yyyy/MM/dd") + "' AND NGAYDI <= '" + ngaydi.Value.ToString("yyyy/MM/dd") + "'";
            showdata(sql);
            tongtien();
        }
    }
}
