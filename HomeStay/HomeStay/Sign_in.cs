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
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();           
          

        }

       

        private void Button_Signin_Click(object sender, EventArgs e)
        {
            Form NewForm = new FormChinh();
            string user = Textbox_Username.Text;
            string pass = Textbox_Password.Text;
            if ((user=="admin")&&(pass=="admin"))
            {
                this.Hide();
                NewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai Mat Khau! Nhap Lai? ","Loi",MessageBoxButtons.YesNo);
            }

        }

        private void Button_Shutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Textbox_Username_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void Button_Shutdown_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Signin_DragEnter(object sender, DragEventArgs e)
        {
            Form NewForm = new FormChinh();
            string user = Textbox_Username.Text;
            string pass = Textbox_Password.Text;
            if ((user == "admin") && (pass == "admin"))
            {
                this.Hide();
                NewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai Mat Khau! Nhap Lai? ", "Loi", MessageBoxButtons.YesNo);
            }
        }
    }
}
