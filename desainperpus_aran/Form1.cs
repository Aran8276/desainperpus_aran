namespace desainperpus_aran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            App window = new App();
            window.Show();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
