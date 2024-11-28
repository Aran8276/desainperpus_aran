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
    public partial class CariBuku : UserControl
    {
        public SqlConnection connection = new SqlConnection(Koneksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        public CariBuku()
        {
            InitializeComponent();
            showData();
        }

        public void showData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = "SELECT * from [buku]";

                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                dataGridView1.DataSource = tabel;

                //0 = id_buku
                //1 = judul_buku
                //2 = pengarang
                //3 = penerbit
                //4 = tahun_terbit
                //5 = stok

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Judul Buku";
                dataGridView1.Columns[2].HeaderText = "Pengarang";
                dataGridView1.Columns[3].HeaderText = "Penerbit";
                dataGridView1.Columns[4].HeaderText = "Tahun Terbit";
                dataGridView1.Columns[5].HeaderText = "Stok";


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchData()
        {
            if (!string.IsNullOrEmpty(search.Text))
            {
                try
                {
                    //0 = id_buku
                    //1 = judul_buku
                    //2 = pengarang
                    //3 = penerbit
                    //4 = tahun_terbit
                    //5 = stok

                    connection.Close();
                    connection.Open();
                    string sql = "SELECT * FROM [buku] " +
                        "WHERE [judul_buku] LIKE '%' + @search + '%' " +
                        "OR [pengarang] LIKE '%' + @search + '%' " +
                        "OR [penerbit] LIKE '%' + @search + '%' " +
                        "OR [tahun_terbit] LIKE '%' + @search + '%' " +
                        "OR [stok] LIKE '%' + @search + '%'";

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@search", search.Text);
                    adapter = new SqlDataAdapter(command);
                    tabel = new DataTable();
                    adapter.Fill(tabel);

                    dataGridView1.DataSource = tabel;

                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "Judul Buku";
                    dataGridView1.Columns[2].HeaderText = "Pengarang";
                    dataGridView1.Columns[3].HeaderText = "Penerbit";
                    dataGridView1.Columns[4].HeaderText = "Tahun Terbit";
                    dataGridView1.Columns[5].HeaderText = "Stok";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Gagal",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                showData(); // Tampilkan data jika input kosong
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }
    }
}
