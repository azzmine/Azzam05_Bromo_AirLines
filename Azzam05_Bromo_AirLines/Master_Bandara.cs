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
    public partial class Master_Bandara : Form
    {
        public Master_Bandara()
        {
            InitializeComponent();
        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void masterBandaraToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, numericUpDown1.Text,textBox4.Text );
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void Master_Bandara_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Abdul Rachman Saleh", "MLG", "Malang", "Indonesia", "2", "Malang");
            dataGridView1.Rows.Add("Abresso", "RSK", "Manokwari", "Indonesia", "2", "Manokwari");
            dataGridView1.Rows.Add("Achmad Yani", "SRG", "Semarang", "Indonesia", "2", "Semarang");
            dataGridView1.Rows.Add("Adi Sucipto", "JOG", "Yogyakarta", "Indonesia", "2", "Yogyakarta");
            dataGridView1.Rows.Add("Adisumarmo", "SOC", "Solo", "Indonesia", "2", "Solo");
        }
    }
}
