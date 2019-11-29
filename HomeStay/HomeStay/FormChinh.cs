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
        ThongTinChung CtrTTC = new ThongTinChung();
        SoDoPhong CtrSDP = new SoDoPhong();
        LeTan CtrLT = new LeTan();
        KhachLe CtrKL = new KhachLe();
        KhachDoan CtrKD = new KhachDoan();
        ThuChi CtrTC = new ThuChi();
        ThongKe CtrTK = new ThongKe();
        BaoCao CtrBC = new BaoCao();


        public FormChinh()
        {
            InitializeComponent();
            PanelNoiDung.Controls.Add(CtrTTC);
            PanelNoiDung.Controls.Add(CtrSDP);
            PanelNoiDung.Controls.Add(CtrLT);
            PanelNoiDung.Controls.Add(CtrKL);
            PanelNoiDung.Controls.Add(CtrKD);
            PanelNoiDung.Controls.Add(CtrTC);
            PanelNoiDung.Controls.Add(CtrTK);
            PanelNoiDung.Controls.Add(CtrBC);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonThongTinChung_Click(object sender, EventArgs e)
        {
            CtrTTC.BringToFront();
            Animator.ShowSync(CtrTTC);
        }



        private void ButtonSoDoPhong_Click(object sender, EventArgs e)
        {
           
            CtrSDP.BringToFront();
            Animator.ShowSync(CtrSDP);
        }



        private void ButtonLeTan_Click(object sender, EventArgs e)
        {
            CtrLT.BringToFront();
            Animator.ShowSync(CtrLT);
        }

        private void ButtonKhachLe_Click(object sender, EventArgs e)
        {
            CtrKL.BringToFront();
            Animator.ShowSync(CtrKL);
        }

        private void ButtonKhachDoan_Click(object sender, EventArgs e)
        {
            CtrKD.BringToFront();
            Animator.ShowSync(CtrKD);
        }

        private void ButtonThuChi_Click(object sender, EventArgs e)
        {
            CtrTC.BringToFront();
            Animator.ShowSync(CtrTC);
        }

        private void ButtonThongKe_Click(object sender, EventArgs e)
        {
            CtrTK.BringToFront();
            Animator.ShowSync(CtrTK);
        }

        private void ButtonBaoCao_Click(object sender, EventArgs e)
        {
            CtrBC.BringToFront();
            Animator.ShowSync(CtrBC);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
        private void Panel_NoiDung_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
