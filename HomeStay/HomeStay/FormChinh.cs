using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
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
        CaiDat_CauHinh setting = new CaiDat_CauHinh();

        public FormChinh()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);   
        }

        public void Form_Load(object sender, EventArgs e)
        {
            Thread newThread = new Thread(() =>
            {
                Invoke(new Action(() =>
                {
                    PanelNoiDung.Controls.Add(CtrTTC);
                    PanelNoiDung.Controls.Add(CtrSDP);
                    PanelNoiDung.Controls.Add(CtrLT);
                    PanelNoiDung.Controls.Add(CtrKL);
                    PanelNoiDung.Controls.Add(CtrKD);
                    PanelNoiDung.Controls.Add(CtrTC);
                    PanelNoiDung.Controls.Add(CtrTK);
                    PanelNoiDung.Controls.Add(CtrBC);
                    PanelNoiDung.Controls.Add(setting);
                }));
            });
            newThread.Start();
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonThongTinChung_Click(object sender, EventArgs e)
        {
            CtrTTC.BringToFront();
            CtrTTC.ThongTinChung_Load(sender, e);
        }



        private void ButtonSoDoPhong_Click(object sender, EventArgs e)
        {
           
            CtrSDP.BringToFront();
            CtrSDP.SoDoPhong_Load(sender, e);

        }



        private void ButtonLeTan_Click(object sender, EventArgs e)
        {
            CtrLT.BringToFront();
           
        }

        private void ButtonKhachLe_Click(object sender, EventArgs e)
        {
            CtrKL.BringToFront();
         
        }

        private void ButtonKhachDoan_Click(object sender, EventArgs e)
        {
            CtrKD.BringToFront();
            
        }

        private void ButtonThuChi_Click(object sender, EventArgs e)
        {
            CtrTC.BringToFront();
          
        }

        private void ButtonThongKe_Click(object sender, EventArgs e)
        {
            CtrTK.BringToFront();
            
        }

        private void ButtonBaoCao_Click(object sender, EventArgs e)
        {
            CtrBC.BringToFront();
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
        private void Panel_NoiDung_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            setting.PanelCauHinh.Hide();
            setting.BringToFront();
        }
    }
}
