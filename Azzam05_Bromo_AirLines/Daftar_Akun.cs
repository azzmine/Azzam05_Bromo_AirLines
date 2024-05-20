using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azzam05_Bromo_AirLines
{
    public partial class Daftar_Akun : Form
    {
        public Daftar_Akun()
        {
            InitializeComponent();
        }

        private void Daftar_Akun_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_bromo admin_Bromo = new admin_bromo();
            admin_Bromo.Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Form loginForm = new Login_Form();   
            loginForm.Show();
            Hide();
        }
    }
}
