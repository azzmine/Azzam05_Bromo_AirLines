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
    public partial class Tiket_Saya : Form
    {
        public Tiket_Saya()
        {
            InitializeComponent();
        }

        private void Tiket_Saya_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("IP-0203", "Palita Air Service", "Juanda", "Soekarno-Hatta", "22-05-2023", "19:50 - 21:25", "Delay (selama +- 04 jam 10 menit)");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Beli_Tiket beli_Tiket = new Beli_Tiket();
            beli_Tiket.Show();
            Hide();
        }
    }
}
