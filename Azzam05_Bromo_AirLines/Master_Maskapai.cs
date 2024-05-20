using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azzam05_Bromo_AirLines
{
    public partial class Master_Maskapai : Form
    {
        public Master_Maskapai()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
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
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, numericUpDown1.Text, textBox4.Text);
        }

        private void Master_Maskapai_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Add("Adam Air", "PT Adam Air", "16", "Adam Air adalah salah satu di antara perusahaan penerbangan yang ada di Indonesia dan menerapkan Low Cost Carrier, Perusahaan bernama lengkap Adam SkyConnection Airlines ini didirikan pada tanggal 22 November 2002 oleh didirikan oleh Agung Laksono dan Sandra Ang");
            dataGridView1.Rows.Add("Aviastar", "PT Aviastar", "12", "Aviastar adalah maskapai penerbangan domestik berjadwal yang berbasis di Jakarta Timur, Jakarta, Indonesia.");
            dataGridView1.Rows.Add("Batavia Air", "PT Batavia Air", "6", "Batavia Air, adalah sebuah maskapai penerbangan di Indonesia. Batavia Air mulai beroperasi pada tanggal 5 Januari 2002, memulai dengan satu buah pesawat Fokker F28 dan dua buah Boeing 737-200.");
            dataGridView1.Rows.Add("Batik Air", "PT Batik Air", "17", "Batik Air adalah maskapai purlayanan swasta Indonesia yang didirikan pada tahun 2013. Maskapai ini merupakan anak perusahaan Lion Air yang berlayanan penuh. Penerbangan perdana dilaksanakan pada hari Jumat, 3 Mei 2013 dari Jakarta ke Manado dan Balikpapan");
            dataGridView1.Rows.Add("Bouraq Indonesia", "PT Bouraq Indonesia", "19", "Bouraq Indonesia Airlines sering disingkat menjadi Bouraq Airlines atau hanya Bouraq adalah maskapai penerbangan swasta Indonesia yang pernah beroperasi.");
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
    }
}
