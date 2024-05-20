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
    public partial class Beli_Tiket : Form
    {
        public Beli_Tiket()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tiket_Saya tiket_Saya = new Tiket_Saya();
            tiket_Saya.Show();
            Hide();
        }

        private void Beli_Tiket_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            list_Penerbangan list_Penerbangan = new list_Penerbangan();
            list_Penerbangan.Show();
            Hide();
        }
    }
}
