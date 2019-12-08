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
    public partial class CaiDat_DsTang : UserControl
    {
        SqlConnection conn = new SqlConnection(DataSource.connectionString);
        public CaiDat_DsTang()
        {
            InitializeComponent();
            
            conn.Open();

            string sql = " select TANG as 'Tầng' SOPHONG 'Số Phòng' LOAIPHONG as'Loại Phòng' GIAPHONG as 'Giá Phòng' TRANGTHAI as'Trạng Thái' FROM PHONG WHERE TANG = '" + ChonTang.Text +"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid_DSTang.DataSource = dt;

            string sql1 = "select * from PHONG";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            ChonTang.DataSource = dt1;
            ChonTang.DisplayMember = "TANG";
            ChonTang.ValueMember = "TANG";
        }

    }
}
