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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            label1.Text = Model.name;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bDashboard_Click(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
        }

        private void bMasterSiswa_Click(object sender, EventArgs e)
        {
            masterSiswa1.BringToFront();
        }

        private void bMasterBuku_Click(object sender, EventArgs e)
        {
            masterBuku1.BringToFront();
        }

        private void bPeminjamanBuku_Click(object sender, EventArgs e)
        {
            peminjamanBuku1.BringToFront();
        }

        private void bPengembalianBuku_Click(object sender, EventArgs e)
        {
            pengembalianBuku1.BringToFront();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            Form1 window = new Form1();
            this.Close();
            window.Show();
        }

        private void pengembalianBuku1_Load(object sender, EventArgs e)
        {

        }

        private void masterBuku1_Load(object sender, EventArgs e)
        {

        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
