using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
namespace HomeStay
{
    public partial class SoDoPhong : UserControl
    {
        private int TypeSearch = 0;
        private string sql = "";
        public SoDoPhong()
        {
             InitializeComponent();
             
        }
        public async void SoDoPhong_Load(object sender, EventArgs e)
        {
       
            sql = "SELECT PHONG.SOPHONG, LOAIPHONG, TRANGTHAI, NGAYDEN, NGAYDI, HOTENKH, THOIGIANNHAN FROM PHONGTHUE JOIN KHACHHANG ON KHACHHANG.MAKH = PHONGTHUE.MAKH RIGHT JOIN PHONG ON PHONG.SOPHONG = PHONGTHUE.SOPHONG";
          //  PanelTemp.Show();
            int x = await (LoadPhong(sql));
          //  PanelTemp.Hide();
            Animator.ShowSync(PanelNoiDung);
        }
     
        private void SetMauPhong(ref Phong us1)
        {
            us1.SoPhong.BackColor = us1.panel1.BackColor;
            us1.LoaiPhong.BackColor = us1.panel1.BackColor;
            us1.txtNgDen.ForeColor = us1.panel1.BackColor;
            us1.txtNgDi.ForeColor = us1.panel1.BackColor;
            us1.txtHoTen.ForeColor = us1.panel1.BackColor;
            us1.txtTGNhan.ForeColor = us1.panel1.BackColor;
            us1.txtTrangThai.ForeColor = us1.panel1.BackColor;
            us1.txtNgDen.BackColor = us1.BackColor;
            us1.txtNgDi.BackColor = us1.BackColor;
            us1.txtHoTen.BackColor = us1.BackColor;
            us1.txtTGNhan.BackColor = us1.BackColor;
            us1.txtTrangThai.BackColor = us1.BackColor;
            us1.TrangThai.Hide();
            us1.txtNgDen.Enabled = true;
            us1.txtNgDen.Visible = true;
            us1.txtNgDi.Enabled = true;
            us1.txtNgDi.Visible = true;
            us1.txtHoTen.Enabled = true;
            us1.txtHoTen.Visible = true;
            us1.txtTGNhan.Enabled = true;
            us1.txtTGNhan.Visible = true;
            us1.txtTrangThai.Enabled = true;
            us1.txtTrangThai.Visible = true;
        }
        private async Task<int> LoadPhong(string sql)
        {
            PanelNoiDung.Hide();
            string TypeSapXep = "";
            switch (ComboboxSapXep.Text)
            {
                case "Số phòng":
                    TypeSapXep = "SOPHONG";
                    break;
                case "Loại phòng":
                    TypeSapXep = "LOAIPHONG";
                    break;
                case "Trạng thái":
                    TypeSapXep = "TRANGTHAI";
                    break;
                default:
                    TypeSapXep = "SOPHONG";
                    break;
            }
            sql = sql + " ORDER BY " + TypeSapXep + " ASC ";
            PanelNoiDung.Controls.Clear();
            SqlConnection conn = new SqlConnection(DataSource.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int i = 0;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Phong us1 = new Phong();
                        us1.Location = new Point(i % 3 * 250, i / 3 * 110);
                        us1.Size = new Size(240, 100);
                        //Set mau cho usercontrol
                        switch (Convert.ToInt64(reader.GetValue(2)))
                        {
                            case 1: // Phong Trong80
                                us1.panel1.BackColor = Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
                                us1.BackColor = Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
                                us1.TrangThai.Show();
                                us1.TrangThai.BringToFront();
                                us1.panel1.Name = reader.GetString(0);
                                break;
                            case 2: //Thông tin phòng đã nhận trong ngày 255, 204, 230 255, 51, 153
                                us1.panel1.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
                                us1.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(230)))));

                                SetMauPhong(ref us1);
                                us1.panel1.Name = reader.GetString(0);
                             
                                break;
                            case 3: //Thông tin phòng quá hạn ngày hôm trước ko đến 255, 102, 0
                                us1.panel1.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
                                us1.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
                                SetMauPhong(ref us1);
                                us1.panel1.Name = reader.GetString(0);
                              
                              
                                break;
                            case 4: //Thông tin phòng sẽ đặt trong ngày hôm nay rgb(77, 121, 255)

                                us1.panel1.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(179)))));
                                us1.BackColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
                                SetMauPhong(ref us1);
                                us1.panel1.Name = reader.GetString(0);
                               
                       
                                break;
                            case 5: //Phòng bận 217, 179, 140)
                                us1.panel1.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                                us1.BackColor = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(140)))));
                                SetMauPhong(ref us1);
                                us1.panel1.Name = reader.GetString(0);
                                break;

                        }
                        PanelNoiDung.Controls.Add(us1);
                        us1.SoPhong.Text = reader.GetString(0);
                        us1.LoaiPhong.Text = reader.GetString(1);
                        try
                        {
                            if (Convert.ToInt64(reader.GetValue(2)) != 1)
                            {
                                us1.txtNgDen.Text = reader.GetDateTime(3).ToString("dd/MM" + "," + "hh:mm");
                                us1.txtNgDi.Text = reader.GetDateTime(4).ToString("dd/MM" + "," + "hh:mm");
                                us1.txtHoTen.Text = reader.GetString(5);
                                //us1.txtTGNhan.Text = reader.GetDateTime(6).ToString();
                            }
                        }
                        catch
                        {
                          
                        }
                        i++;
                    }
                }
                reader.Close();
            
            }
            conn.Close();
            return 1;
        }

        private async void btnAll_Click(object sender, EventArgs e)
        {
            TypeSearch = 0;
            sql = "SELECT PHONG.SOPHONG, LOAIPHONG, TRANGTHAI, NGAYDEN, NGAYDI, HOTENKH, THOIGIANNHAN FROM PHONGTHUE JOIN KHACHHANG ON KHACHHANG.MAKH = PHONGTHUE.MAKH RIGHT JOIN PHONG ON PHONG.SOPHONG = PHONGTHUE.SOPHONG";
          //  PanelTemp.Show();
            int x = await (LoadPhong(sql));
          //  PanelTemp.Hide();
           Animator.ShowSync(PanelNoiDung);
        }

        private async void btnTrong_Click(object sender, EventArgs e)
        {
            TypeSearch = 1;
            sql = "SELECT PHONG.SOPHONG, LOAIPHONG, TRANGTHAI, NGAYDEN, NGAYDI, HOTENKH, THOIGIANNHAN FROM PHONGTHUE JOIN KHACHHANG ON KHACHHANG.MAKH = PHONGTHUE.MAKH RIGHT JOIN PHONG ON PHONG.SOPHONG = PHONGTHUE.SOPHONG WHERE TRANGTHAI = 1";
          //  PanelTemp.Show();
            int x = await (LoadPhong(sql));
         //   PanelTemp.Hide();
            Animator.ShowSync(PanelNoiDung);
        }

        private async void btnNhanPhong_Click(object sender, EventArgs e)
        {
            TypeSearch = 2;
            sql = "SELECT PHONG.SOPHONG, LOAIPHONG, TRANGTHAI, NGAYDEN, NGAYDI, HOTENKH, THOIGIANNHAN FROM PHONGTHUE JOIN KHACHHANG ON KHACHHANG.MAKH = PHONGTHUE.MAKH RIGHT JOIN PHONG ON PHONG.SOPHONG = PHONGTHUE.SOPHONG WHERE TRANGTHAI = 2";
         //   PanelTemp.Show();
            int x = await (LoadPhong(sql));
         //   PanelTemp.Hide();
            Animator.ShowSync(PanelNoiDung);
        }

        private async void btnQuaHan_Click(object sender, EventArgs e)
        {
            TypeSearch = 3;
            sql = "SELECT PHONG.SOPHONG, LOAIPHONG, TRANGTHAI, NGAYDEN, NGAYDI, HOTENKH, THOIGIANNHAN FROM PHONGTHUE JOIN KHACHHANG ON KHACHHANG.MAKH = PHONGTHUE.MAKH RIGHT JOIN PHONG ON PHONG.SOPHONG = PHONGTHUE.SOPHONG WHERE TRANGTHAI = 3";
         //   PanelTemp.Show();
            int x = await (LoadPhong(sql));
       //     PanelTemp.Hide();
            Animator.ShowSync(PanelNoiDung);
        }

        private async void btnDaDat_Click(object sender, EventArgs e)
        {
            TypeSearch = 4;
            sql = "SELECT PHONG.SOPHONG, LOAIPHONG, TRANGTHAI, NGAYDEN, NGAYDI, HOTENKH, THOIGIANNHAN FROM PHONGTHUE JOIN KHACHHANG ON KHACHHANG.MAKH = PHONGTHUE.MAKH RIGHT JOIN PHONG ON PHONG.SOPHONG = PHONGTHUE.SOPHONG WHERE TRANGTHAI = 4";
          //  PanelTemp.Show();
            int x = await (LoadPhong(sql));
         //   PanelTemp.Hide();
            Animator.ShowSync(PanelNoiDung);
        }

        private async void btnBan_Click(object sender, EventArgs e)
        {
            TypeSearch = 5;
            sql = "SELECT PHONG.SOPHONG, LOAIPHONG, TRANGTHAI, NGAYDEN, NGAYDI, HOTENKH, THOIGIANNHAN FROM PHONGTHUE JOIN KHACHHANG ON KHACHHANG.MAKH = PHONGTHUE.MAKH RIGHT JOIN PHONG ON PHONG.SOPHONG = PHONGTHUE.SOPHONG WHERE TRANGTHAI = 5";
          //  PanelTemp.Show();
            int x = await (LoadPhong(sql));
       //     PanelTemp.Hide();
            Animator.ShowSync(PanelNoiDung);
        }

      

        private async void Search_KeyDown(object sender, KeyEventArgs e)
        {
  
            if ((Search.Text != "")&&(e.KeyCode == Keys.Enter))
            {
                if (TypeSearch == 0)
                {
                    sql = string.Format("SELECT PHONG.SOPHONG, LOAIPHONG, TRANGTHAI, NGAYDEN, NGAYDI, HOTENKH, THOIGIANNHAN FROM PHONGTHUE JOIN KHACHHANG ON KHACHHANG.MAKH = PHONGTHUE.MAKH RIGHT JOIN PHONG ON PHONG.SOPHONG = PHONGTHUE.SOPHONG WHERE  PHONG.SOPHONG LIKE N'%{0}%'", Search.Text);
                }
                else
                    sql = string.Format("SELECT PHONG.SOPHONG, LOAIPHONG, TRANGTHAI, NGAYDEN, NGAYDI, HOTENKH, THOIGIANNHAN FROM PHONGTHUE JOIN KHACHHANG ON KHACHHANG.MAKH = PHONGTHUE.MAKH RIGHT JOIN PHONG ON PHONG.SOPHONG = PHONGTHUE.SOPHONG WHERE TRANGTHAI = '" + TypeSearch + "' AND PHONG.SOPHONG like N'%{0}%'", Search.Text);
           //     PanelTemp.Show();
                int x = await (LoadPhong(sql));
            //    PanelTemp.Hide();
                Animator.ShowSync(PanelNoiDung);
            }
           
        }

        private async void ComboboxSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
      //      PanelTemp.Show();
            int x = await (LoadPhong(sql));
            //      PanelTemp.Hide();
            PanelNoiDung.BringToFront(); 
            Animator.ShowSync(PanelNoiDung);

        }

        private void PanelNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
