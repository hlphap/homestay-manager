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
    public partial class KhachDoan_ThanhToan : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        string ngaydenttoan, ngaydittoan;
        public KhachDoan_ThanhToan()
        {
            InitializeComponent();
            conn.Open();
        }

        public void loaddata(string[] sophong, int demsophong)
        {
            
            int dem = 0;
            int dong = DataGridPhongDaChon.RowCount;

            for (int j = 0; j < dong; j++)
            {
                for (int i = 0; i < demsophong + 1; i++)
                {
                    if (DataGridPhongDaChon.Rows[j].Cells[0].Value.ToString() == sophong[i] || DataGridPhongDaChon.Rows[j].Cells[0].Value.ToString() == "")
                        dem++;
                }
                
            }
            if (dem == 0)
            {
                for(int i = 0; i < demsophong + 1; i++)
                {
                    int n = DataGridPhongDaChon.Rows.Add();
                    DataGridPhongDaChon.Rows[n].Cells[0].Value = sophong[i];
                }
            }
            
        }
        public void loaddatathongtindoan(string tentd, string sdttd, string socmndtd, string madoan)
        {
            madoantxt.Text = madoan;
            tentdtxt.Text = tentd;
            sdttdtxt.Text = sdttd;
            socmndtdtxt.Text = socmndtd;
        }
        public void loaddataphongtrong(string ngayden, string ngaydi)
        {
            ngaydenttoan = ngayden;
            ngaydittoan = ngaydi;
        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "";
            int dong = DataGridPhongDaChon.RowCount;
            for (int j = 0; j < dong; j++)
            {
                Random radmadk = new Random();
                int madk = radmadk.Next(0, 99999);
                try
                {
                    sql = "INSERT INTO PHONGTHUE VALUES('" + madk + "','" + madoantxt.Text + "','" + DataGridPhongDaChon.Rows[j].Cells[0].Value + "'," + DateTime.Today.ToString("yyyy/MM/dd") + ",'" + ngaydenttoan + "','" +ngaydittoan +"',"+ DateTime.Today.ToString("yyyy/MM/dd")+ ")";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Loi phong so "+ DataGridPhongDaChon.Rows[j].Cells[0].Value);
                }
            }

            sql = "SElECT SUM(GIA) tong FROM PHONG, PHONGTHUE, LOAIPHONG WHERE PHONGTHUE.SOPHONG = PHONG.SOPHONG AND LOAIPHONG.LOAIPHONG = PHONg.LOAIPHONG AND MAKH = '" + madoantxt.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            cmd1.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);

            object SUM;
            SUM = dt.Compute("Max(tong)", "");
            Tinhtientxt.Text = SUM.ToString();

            string doanhthu = "UPDATE DOANHTHU SET TONGTIEN = TONGTIEN + " + Tinhtientxt.Text + " WHERE THANG = " + DateTime.Today.Month.ToString();
            SqlCommand cmddoanhthu = new SqlCommand(doanhthu, conn);  //cong tien vao doanh thu trong thang
            cmddoanhthu.ExecuteNonQuery();

        }   
    }
}
