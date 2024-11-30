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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace desainperpus_aran
{
    public partial class MasterBuku : UserControl
    {
        public SqlConnection connection = new SqlConnection(Koneksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public string unselectedErrorWarning = "Silahkan memilih data terlebih dahulu";
        public int id_buku;

        public MasterBuku()
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

        public void insertData()
        {
            if (isInputFilled())
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    //0 = id_buku
                    //1 = judul_buku
                    //2 = pengarang
                    //3 = penerbit
                    //4 = tahun_terbit
                    //5 = stok

                    string sql = "INSERT INTO [buku] (judul_buku, pengarang, penerbit, tahun_terbit, stok) " +
                        "VALUES (@judul_buku, @pengarang, @penerbit, @tahun_terbit, @stok)";

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@judul_buku", judul.Text);
                    command.Parameters.AddWithValue("@pengarang", pengarang.Text);
                    command.Parameters.AddWithValue("@penerbit", penerbit.Text);
                    command.Parameters.AddWithValue("@tahun_terbit", tahun.Text);
                    command.Parameters.AddWithValue("@stok", stok.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dimasukan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                    clearInput();
                    showData();
                }
            }
        }

        public void editData()
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin mengedit?", "Konfirmasi"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string sql = "UPDATE [buku] SET " +
                        "judul_buku = @judul_buku, " +
                        "pengarang = @pengarang, " +
                        "penerbit = @penerbit, " +
                        "tahun_terbit = @tahun_terbit, " +
                        "stok = @stok " +
                        "WHERE [id_buku] = " + id_buku;

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@judul_buku", judul.Text);
                    command.Parameters.AddWithValue("@pengarang", pengarang.Text);
                    command.Parameters.AddWithValue("@penerbit", penerbit.Text);
                    command.Parameters.AddWithValue("@tahun_terbit", tahun.Text);
                    command.Parameters.AddWithValue("@stok", stok.Text);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Update berhasil!", "Berhasil", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex, "Gagal", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        clearInput();
                        showData();
                        connection.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show(unselectedErrorWarning, "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void deleteData()
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                if (isInputFilled())
                {
                    DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus data",
                        "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string sql = "DELETE FROM [buku] WHERE id_buku = " + id_buku;

                        command = new SqlCommand(sql, connection);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Hapus berhasil", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Gagal hapus",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            clearInput();
                            showData();
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(unselectedErrorWarning, "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        public void clearInput()
        {
            //0 = id_buku
            //1 = judul_buku
            //2 = pengarang
            //3 = penerbit
            //4 = tahun_terbit
            //5 = stok

            judul.Text = "";
            pengarang.Text = "";
            penerbit.Text = "";
            tahun.Text = "";
            stok.Text = "";
        }

        public bool isInputFilled()
        {
            //0 = id_buku
            //1 = judul_buku
            //2 = pengarang
            //3 = penerbit
            //4 = tahun_terbit
            //5 = stok
            if (
                !string.IsNullOrEmpty(judul.Text) // jika textbox nis tidak kosong atau null 
                && !string.IsNullOrEmpty(pengarang.Text) // jika textbox nama tidak kosong atau null 
                && !string.IsNullOrEmpty(penerbit.Text) // jika combobox kelas tidak kosong atau null 
                && !string.IsNullOrEmpty(tahun.Text) // jika textbox alamat tidak kosong atau null 
                && !string.IsNullOrEmpty(stok.Text) // dst
                )
            {
                return true;
            }

            MessageBox.Show("Input tidak boleh ada yang kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Method ini digunakan utk mengisi inputan sesuai kolum yg kita klik nanti

            dataGridView1.CurrentRow.Selected = true;

            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].HeaderText = "Judul Buku";
            //dataGridView1.Columns[2].HeaderText = "Pengarang";
            //dataGridView1.Columns[3].HeaderText = "Penerbit";
            //dataGridView1.Columns[4].HeaderText = "Tahun Terbit";
            //dataGridView1.Columns[5].HeaderText = "Stok";

            id_buku = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            judul.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            pengarang.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            penerbit.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tahun.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            stok.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }
    }
}
