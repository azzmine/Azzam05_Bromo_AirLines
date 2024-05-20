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
    public partial class admin_bromo : Form
    {
        public admin_bromo()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (menuStrip1.Visible==false)
            { menuStrip1.Visible = true; }else { menuStrip1.Visible = false; }

        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master_Bandara form = new Master_Bandara();
            form.Show();
            this.Hide();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Master_Maskapai form = new Master_Maskapai();
            form.Show();
            this.Hide();
        }

        private void masterJadwalPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master_Jadwal master_Jadwal = new Master_Jadwal();
            master_Jadwal.Show();
            this.Hide();
        }

        private void masterKodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master_Kode master_Kode = new Master_Kode();
            master_Kode.Show();
            this.Hide();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ubah_Status ubah_Status = new Ubah_Status();
            ubah_Status.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login_Form loginForm = new Login_Form();
            loginForm.Show();
            this.Hide();
        }

        private void admin_bromo_Load(object sender, EventArgs e)
        {

        }
    }
}
