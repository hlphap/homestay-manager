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
using System.Data.Common;
namespace HomeStay
{
    public partial class SoDoPhong : UserControl
    {
        public SoDoPhong()
        {
             InitializeComponent();
           
        }
        private void SoDoPhong_Load(object sender, EventArgs e)
        {
            LoadPhong();
        }
        private void LoadPhong()
        {
            SqlConnection conn = new SqlConnection(DataSource.connectionString);
            conn.Open();
            string sql = "SELECT SOPHONG, LOAIPHONG, TRANGTHAI FROM PHONG ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int i = 0;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                    
                {
                    while (reader.Read())
                    {

                        x1Phong us1 = new x1Phong();
                        us1.Location = new Point(i % 4 * 212, i / 4 * 98);
                        us1.Size = new Size(200, 90);
                        PanelNoiDung.Controls.Add(us1);
                        us1.SoPhong.Text = reader.GetString(0);
                        us1.LoaiPhong.Text = reader.GetString(1);
                        
                        i++;
                    }
                 
                }
                reader.Close();
            }
            conn.Close();

        }
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelNoiDung_Paint(object sender, PaintEventArgs e)
        {
            LoadPhong();
        }
    }
}
