using Microsoft.Data.SqlClient;
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
    public partial class Dashboard : UserControl
    {
        public SqlConnection connection = new SqlConnection(Koneksi.conn);
        public SqlCommand command;
        public SqlCommand command1;
        public SqlDataReader reader;


        public Dashboard()
        {
            InitializeComponent();
            getReport();
        }

        public void getReport()
        {
            try
            {
                connection.Open();
                string sqlSiswa = "SELECT COUNT(*) AS [siswa] FROM [siswa]";
                string sqlBuku = "SELECT COUNT(*) AS [buku] FROM [buku]";

                command = new SqlCommand(sqlSiswa, connection);
                command1 = new SqlCommand(sqlBuku, connection);

                reader = command.ExecuteReader();
                reader.Read();
                labelSiswa.Text = reader["siswa"].ToString();
                reader.Close();

                reader = command1.ExecuteReader();
                reader.Read();
                labelBuku.Text = reader["buku"].ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
 
        }
    }
}
