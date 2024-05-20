using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Azzam05_Bromo_AirLines
{
    public partial class Master_Jadwal : Form
    {
        public Master_Jadwal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox2.Text, comboBox2.Text, comboBox1.Text, comboBox3.Text, dateTimePicker1.Text, textBox1.Text, textBox3.Text, numericUpDown1.Text);
        }

        private void Master_Jadwal_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("ID-7518", "Juanda", "Halim Perdanakusumah", "Batik Airlines", "30-05-2024", "19:55", "01 jam 15 menit", "829891");
            dataGridView1.Rows.Add("IP-0203", "Juanda", "Soekarno-Hatta", "Pelita Airlines", "30-05-2024", "19:50", "01 jam 30 menit", "684000");
            dataGridView1.Rows.Add("QG-0719", "Juanda", "Soekarno-Hatta", "Citilink", "30-05-2023", "19:30", "01 jam 10 menit", "1317538");
            dataGridView1.Rows.Add("QG-0173", "Juanda", "Halim Perdanakusuma", "Citilink", "30-05-2023", "19:00", "01 jam 20 menit", "772601");
            dataGridView1.Rows.Add("GA-0325", "Juanda", "Soekarno - Hatta", "Garuda Indonesia", "30 - 05 - 2023", "18:40", "01 jam 30 menit", "1536880");
            dataGridView1.Rows.Add("OG-0737", "Juanda", "Soekarno-Hatta", "Citilink", "30-05-2024", "18:40", "01 jam 10 menit", "1317538");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }
    }
}
