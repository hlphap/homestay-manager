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
    public partial class ThongKe_ThongKe : UserControl
    {
        public ThongKe_ThongKe()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(DataSource.connectionString);

        int demgiatri(string sql,string dem, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox text)
        {
            conn.Open();
            SqlCommand cmd2 = new SqlCommand(sql, conn);
            cmd2.CommandType = CommandType.Text;
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            object GIA;
            GIA = dt2.Compute(dem, "");
            text.Text = text.Text +": "+ GIA.ToString();
            conn.Close();
            return 0;
        }

        private void ThongKe_ThongKe_Load(object sender, EventArgs e)
        {
            // 1 trong
            // 3 dang o
            // 4 da dat
            // 5 ban
            string sql = "SELECT SOPHONG FROM PHONG";
            demgiatri(sql,"count(SOPHONG)" , TongSoPhong);
            sql = "SELECT SOPHONG FROM PHONG WHERE TRANGTHAI = 3";
            demgiatri(sql, "count(SOPHONG)", PhongCoKhach);
            sql = "SELECT SOPHONG FROM PHONG WHERE TRANGTHAI = 1";
            demgiatri(sql, "count(SOPHONG)", TongPhongSanSang);
            sql = "SELECT SOPHONG FROM PHONG WHERE TRANGTHAI = 4";
            demgiatri(sql, "count(SOPHONG)", PhongDuKienDen);
            sql = "SELECT SOPHONG FROM PHONG WHERE TRANGTHAI = 5";
            demgiatri(sql, "count(SOPHONG)", PhongHong);
            sql = "SELECT SOPHONG FROM PHONGTHUE WHERE NGAYDEN < GETDATE() AND NGAYDI > GETDATE()";
            demgiatri(sql, "count(SOPHONG)", PhongOQuaNgay);
            sql = "SELECT SOPHONG FROM PHONGTHUE WHERE NGAYDI = GETDATE()";
            demgiatri(sql, "count(SOPHONG)", PhongDuKienDi);

            sql = "SELECT KHACHHANG.MAKH FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND NGAYDEN < GETDATE() AND NGAYDI > GETDATE()";
            demgiatri(sql, "count(MAKH)", KhachDangO);
            sql = "SELECT KHACHHANG.MAKH FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND NGAYDI = GETDATE()";
            demgiatri(sql, "count(MAKH)", KhachDuKienDi);
            sql = "SELECT KHACHHANG.MAKH FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND GETDATE() < NGAYDEN AND GETDATE() < NGAYDI";
            demgiatri(sql, "count(MAKH)", KhachDuKienDen);
            sql = "SELECT KHACHHANG.MAKH FROM KHACHHANG, PHONGTHUE WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND NGAYDEN < NGAYDI";
            demgiatri(sql, "count(MAKH)", KhachOQuaNgay);
        }
    }
}
