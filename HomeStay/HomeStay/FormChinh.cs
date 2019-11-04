using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay
{
    public partial class FormChinh : Form
    {
      

        public FormChinh()
        {
            InitializeComponent();
            ThongTinChung us = new ThongTinChung();
            Panel_NoiDung.Controls.Clear();
            Panel_NoiDung.Controls.Add(us);
            

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ThongTinChung us = new ThongTinChung();
            Panel_NoiDung.Controls.Clear();
            Panel_NoiDung.Controls.Add(us);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel_NoiDung_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {

            SoDoPhong sdp = new SoDoPhong();
            Panel_NoiDung.Controls.Clear();
            Panel_NoiDung.Controls.Add(sdp);
     
        }

        private void Panel_NoiDung_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton3_ControlAdded(object sender, ControlEventArgs e)
        {
        
        }

        private void bunifuImageButton3_Resize(object sender, EventArgs e)
        {
         
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            DatPhong LT = new DatPhong();
            Panel_NoiDung.Controls.Clear();
            Panel_NoiDung.Controls.Add(LT);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            KhachLe Gust_Le = new KhachLe();
            Panel_NoiDung.Controls.Clear();
            Panel_NoiDung.Controls.Add(Gust_Le);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            KhachDoan Guest_Doan = new KhachDoan();
            Panel_NoiDung.Controls.Clear();
            Panel_NoiDung.Controls.Add(Guest_Doan);
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            ThuChi TC = new ThuChi();
            Panel_NoiDung.Controls.Clear();
            Panel_NoiDung.Controls.Add(TC);
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            ThongKe TK = new ThongKe();
            Panel_NoiDung.Controls.Clear();
            Panel_NoiDung.Controls.Add(TK);
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            BaoCao BC = new BaoCao();
            Panel_NoiDung.Controls.Clear();
            Panel_NoiDung.Controls.Add(BC);
        }
    }
}
