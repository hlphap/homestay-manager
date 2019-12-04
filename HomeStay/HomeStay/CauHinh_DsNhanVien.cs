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
    public partial class CauHinh_DsNhanVien : Form
    {
        public CauHinh_DsNhanVien()
        {
            InitializeComponent();
            
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataSource.connectionString);
            conn.Open();

            string sql3 = "SELECT MANV as 'Mã nhân viên', HOTEN as 'Họ tên nhân viên', NGAYSINH as 'Ngày sinh', CMND_NV as 'Số CMND', DIACHI as 'Địa chỉ' FROM NHANVIEN WHERE MANV = '"+MaNV.Text+"' OR HOTEN = '"+ tenNV.Text+"'";
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            cmd3.CommandType = CommandType.Text;
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            bunifuCustomDataGrid1.DataSource = dt3;
            conn.Close();
        }
    }
}
