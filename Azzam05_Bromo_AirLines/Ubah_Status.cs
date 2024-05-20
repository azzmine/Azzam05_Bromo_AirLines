using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Azzam05_Bromo_AirLines
{
    public partial class Ubah_Status : Form
    {
        public Ubah_Status()
        {
            InitializeComponent();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Ubah_Status_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("IU - 0696", "Super Airlines", "Soekarno - Hatta", "Supadio", "21 - 04 - 2024", "07:25","01 jam 30 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("IU - 0697", "Super Airlines", "Supadio", "Soekarno - Hatta", "27 - 04 - 2024", "09:40", "01 jam 20 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("ID - 7508", "Batik Airlines", "Juanda", "Halim Perdanakusumah", "22 - 05 - 2024", "05:00", "01 jam 10 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("ID - 6589", "Batik Airlines", "Juanda", "Soekarno - Hatta", "22 - 05 - 2024", "05:00", "01 jam 20 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("JT - 0786", "Lion Airlines", "Juanda", "Soekarno - Hatta", "22 - 05 - 2024", "05:00", "01 jam 30 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("JT-0646", "Lion Airlines", "Juanda", "Soekarno-Hatta", "22 - 05 - 2024", "05:55", "01 jam 05 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("QG - 0725", "Citilink", "Juanda", "Soekarno - Hatta", "22 - 05 - 2024", "06:00", "01 jam 35 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("IU - 0706", "Super Airlines", "Juanda", "Soekarno - Hatta", "22 - 05 - 2024", "06:00", "00 jam 45 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("IU - 0333", "Super Airlines", "Juanda", "Soekarno - Hatta", "22 - 05 - 2024", "06:00", "01 jam 25 menit", "Sesuai Jadwal", "-");
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
