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
    public partial class list_Penerbangan : Form
    {
        public list_Penerbangan()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column8")
            {
                Beli_Tiket beli_Tiket = new Beli_Tiket();
                beli_Tiket.Show();
                this.Hide();
            }
        }

        private void list_Penerbangan_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(" IP - 0209", "Pelita Air", "Juanda", "Soekarno Hatta", "634000", "24-05-2023", "15:10 - 16:45");
            dataGridView1.Rows.Add(" IP - 0298", "garuda indonesia", "Juanda", "Soekarno Hatta", "634000", "24-05-2023", "19:10 - 21:45");
            dataGridView1.Rows.Add(" IP - 0309", "lion Air", "Juanda", "Soekarno Hatta", "726000", "24-05-2023", "06:00 - 10:45");
            dataGridView1.Rows.Add(" IP - 0298", "citilink", "Juanda", "Soekarno Hatta", "725000", "24-05-2023", "17:10 - 19:40");
            dataGridView1.Rows.Add(" IP - 0099", "Pelita Air", "Juanda", "Soekarno Hatta", "634000", "24-05-2023", "15:10 - 17:45");
            dataGridView1.Rows.Add(" IP - 0749", "transnusa", "Juanda", "Soekarno Hatta", "725000", "24-05-2023", "10:10 - 11:45");
            dataGridView1.Rows.Add(" IP - 0276", "air asia", "Juanda", "Soekarno Hatta", "634000", "24-05-2023", "08:10 - 09:00");
            dataGridView1.Rows.Add(" IP - 0709", "garuda indonesia", "Juanda", "Soekarno Hatta", "634000", "24-05-2023", "20:46 - 121:55");
        }
    }
    
}
