using Microsoft.Data.SqlClient;
using System.Data;

namespace desainperpus_aran
{
    public partial class Form1 : Form
    {
        public SqlConnection connection = new SqlConnection(Koneksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            connection.Open();

            string username = tUsername.Text;
            string password = tPassword.Text;

            string sql = "SELECT * FROM [user] WHERE username = '" + username + "' AND PASSWORD = '" + password + "'";

            command = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command);
            tabel = new DataTable();
            adapter.Fill(tabel);

            if (tabel.Rows.Count > 0)
            {
                foreach (DataRow row in tabel.Rows)
                {
                    if (row["role"].ToString() == "admin")
                    {
                        reader = command.ExecuteReader();
                        reader.Read();
                        Model.name = reader.GetString(1);

                        this.Hide();
                        App window = new App();
                        window.Show();
                    }
                    else if (row["role"].ToString() == "siswa")
                    {
                        reader = command.ExecuteReader();
                        reader.Read();
                        Model.name = reader.GetString(1);

                        this.Hide();
                        AppSiswa windows = new AppSiswa();
                        windows.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Username atau password salah", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            connection.Close();


            //App window = new App();
            //this.Hide();
            //window.Show();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
