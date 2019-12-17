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

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            
            //string sql = "SELECT SUM( GIAPHONG) FROM KHACHHANG, PHONGTHUE, PHONG WHERE KHACHHANG.MAKH = PHONGTHUE.MAKH AND PHONGTHUE.SOPHONG = PHONG.SOPHONG AND ";
            string sql = "";
            int dong = DataGridPhongDaChon.RowCount;
            for (int j = 0; j < dong; j++)
            {
                Random radmadk = new Random();
                int madk = radmadk.Next(0, 99999);
                try
                {
                    sql = "INSERT INTO PHONGTHUE VALUES('" + madk + "','" + madoantxt.Text + "','" + DataGridPhongDaChon.Rows[j].Cells[0].Value + "'," + DateTime.Today.Year + "/" + DateTime.Today.Month + "/" + DateTime.Today.Day + "," + DateTime.Today.Year + "/" + DateTime.Today.Month + "/" + DateTime.Today.Day + "," + DateTime.Today.Year + "/" + DateTime.Today.Month + "/" + DateTime.Today.Day + ")";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Loi phong so "+ DataGridPhongDaChon.Rows[j].Cells[0].Value);
                }
            }

            sql = "SElECT SUM(GIAPHONG) tong FROM PHONG, PHONGTHUE WHERE PHONGTHUE.SOPHONG = PHONG.SOPHONG AND MAKH = '" + madoantxt.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            cmd1.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);

            object SUM;
            SUM = dt.Compute("Max(tong)", "");
            Tinhtientxt.Text = SUM.ToString();
        }   
    }
}
