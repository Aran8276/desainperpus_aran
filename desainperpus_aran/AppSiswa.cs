using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desainperpus_aran
{
    public partial class AppSiswa : Form
    {
        public AppSiswa()
        {
            InitializeComponent();
            label1.Text = Model.name;
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            Form1 window = new Form1();
            this.Hide();
            window.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AppSiswa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bCariBuku_Click(object sender, EventArgs e)
        {
            cariBuku1.BringToFront();
        }

        private void bRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            riwayatPeminjaman1.BringToFront();
        }

        private void bRiwayatPengambilan_Click(object sender, EventArgs e)
        {
            riwayatPengembalian1.BringToFront();
        }
    }
}
