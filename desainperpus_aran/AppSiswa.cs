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
            this.Close();
            window.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
