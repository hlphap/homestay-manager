using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HomeStay
{
    public static class DataSource
    {
        public static string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + @"\Database.mdf;Integrated Security=True;User Instance=True";
    }

}
