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
        private
        ThongTinChung us = new ThongTinChung();
        SoDoPhong sdp = new SoDoPhong();
        LeTan lt = new LeTan();
        KhachLe kl = new KhachLe();


        public FormChinh()
        {
            InitializeComponent();
            Panel_NoiDung.Controls.Add(us);
            Panel_NoiDung.Controls.Add(sdp);
            Panel_NoiDung.Controls.Add(lt);
            Panel_NoiDung.Controls.Add(kl);


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            us.BringToFront();
            SDus.Show()
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel_NoiDung_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            
            sdp.BringToFront();
            sdp.Show();
     
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
            lt.BringToFront();
            lt.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            kl.BringToFront();
            kl.Show();
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
