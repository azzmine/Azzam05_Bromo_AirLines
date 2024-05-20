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
    public partial class Master_Kode : Form
    {
        public Master_Kode()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
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
            dataGridView1.Rows.Add(textBox1.Text, dateTimePicker1.Text, numericUpDown2.Text, numericUpDown3.Text, textBox4.Text);
        }

        private void Master_Kode_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("BROMOAJAYUK", "15", "100000", "09 - 09 - 2023", "Yuk pakai diskon disinii");
            dataGridView1.Rows.Add("NAIKBROMOAIRLINES", "10", "100000", "09 - 09 - 2023", "Bromo Ailines");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
