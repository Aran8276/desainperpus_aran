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
    public partial class MasterSiswa : UserControl
    {
        public SqlConnection connection = new SqlConnection(Koneksi.conn);
        public SqlCommand command;
        public SqlCommand command1;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        // unselectedLabel adalah teks yg kita gunakan jika comboBox belum dipilih
        public string unselectedLabel = "Pilih--";
        public string unselectedErrorWarning = "Silahkan memilih data terlebih dahulu";
        public int id_siswa;
        public int id_user;


        public MasterSiswa()
        {
            InitializeComponent();

            kelas.Text = unselectedLabel;
            showData();
        }

        public void showData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = "SELECT * from [siswa] " +
                    "INNER JOIN [user] ON [siswa].id_user = [user].id_user";
                
                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                dataGridView1.DataSource = tabel;

                dataGridView1.Columns[0].Visible = false; // id_siswa
                dataGridView1.Columns[1].Visible = false; // id_user
                dataGridView1.Columns[2].HeaderText = "NIS"; // nis
                dataGridView1.Columns[3].HeaderText = "Kelas"; // kelas
                dataGridView1.Columns[4].HeaderText = "Alamat"; // alamat
                dataGridView1.Columns[5].Visible = false; // id_user
                dataGridView1.Columns[6].HeaderText = "Nama Siswa"; // nama
                dataGridView1.Columns[7].Visible = false; // role
                dataGridView1.Columns[8].HeaderText = "Email"; // email
                dataGridView1.Columns[9].HeaderText = "Nomor Telepon"; // no_telp
                dataGridView1.Columns[10].HeaderText = "Username"; // usernaem
                dataGridView1.Columns[11].HeaderText = "Password"; // password

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

                    string sql = "INSERT INTO [user] (nama, role, email, no_telp, username, password) " +
                        "VALUES (@nama, @role, @email, @no_telp, @username, @password)";

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@nama", nama.Text);
                    command.Parameters.AddWithValue("@role", "siswa"); // Role akan selalu menjadi siswa
                    command.Parameters.AddWithValue("@email", email.Text);
                    command.Parameters.AddWithValue("@no_telp", notelp.Text);
                    command.Parameters.AddWithValue("@username", username.Text);
                    command.Parameters.AddWithValue("@password", password.Text);

                    command.ExecuteNonQuery();

                    sql = "SELECT id_user FROM [user] WHERE username = '" + username.Text + "' " +
                        "AND password = '" + password.Text + "'";

                    command = new SqlCommand(sql, connection);

                    reader = command.ExecuteReader();
                    reader.Read();
                    int id = reader.GetInt32(0); // dapatkan id dari SQL Query diatas

                    connection.Close();
                    connection.Open();

                    sql = "INSERT INTO [siswa] (id_user, nis, kelas, alamat) " +
                        "VALUES (@id, @nis, @kelas, @alamat)";

                    command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nis", nis.Text);
                    command.Parameters.AddWithValue("@kelas", kelas.SelectedItem);
                    command.Parameters.AddWithValue("@alamat", alamat.Text);

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
                    string sql = "UPDATE [siswa] SET " +
                        "nis = @nis, " +
                        "kelas = @kelas, " +
                        "alamat = @alamat " +
                        "WHERE [id_siswa] = " + id_siswa;

                    string sql1 = "UPDATE [user] SET " +
                        "nama = @nama, " +
                        "email = @email, " +
                        "no_telp = @no_telp, " +
                        "username = @username, " +
                        "password = @password " +
                        "WHERE [id_user] = " + id_user;

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@nis", nis.Text);
                    command.Parameters.AddWithValue("@kelas", kelas.Text);
                    command.Parameters.AddWithValue("@alamat", alamat.Text);

                    command1 = new SqlCommand(sql1, connection);
                    command1.Parameters.AddWithValue("@nama", nama.Text);
                    command1.Parameters.AddWithValue("@email", email.Text);
                    command1.Parameters.AddWithValue("@no_telp", notelp.Text);
                    command1.Parameters.AddWithValue("@username", username.Text);
                    command1.Parameters.AddWithValue("@password", password.Text);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        command1.ExecuteNonQuery();
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
                        string sql = "DELETE FROM [siswa] WHERE id_siswa = " + id_siswa;
                        string sql1 = "DELETE FROM [user] WHERE id_user = " + id_user;

                        command = new SqlCommand(sql, connection);
                        command1 = new SqlCommand(sql1, connection);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            command1.ExecuteNonQuery();
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
                    connection.Close();
                    connection.Open();
                    string sql = "SELECT * FROM [siswa] INNER JOIN [user] ON " +
                        "siswa.id_user = [user].id_user " +
                        "WHERE [nis] LIKE '%' + @search + '%' " +
                        "OR [kelas] LIKE '%' + @search + '%' " +
                        "OR [alamat] LIKE '%' + @search + '%' " +

                        "OR [nama] LIKE '%' + @search + '%' " +
                        "OR [role] LIKE '%' + @search + '%' " +
                        "OR [email] LIKE '%' + @search + '%' " +
                        "OR [no_telp] LIKE '%' + @search + '%' " +
                        "OR [username] LIKE '%' + @search + '%' " +
                        "OR [password] LIKE '%' + @search + '%'";

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@search", search.Text);
                    adapter = new SqlDataAdapter(command);
                    tabel = new DataTable();
                    adapter.Fill(tabel);

                    dataGridView1.DataSource = tabel;

                    dataGridView1.Columns[0].Visible = false; // id_siswa
                    dataGridView1.Columns[1].Visible = false; // id_user
                    dataGridView1.Columns[2].HeaderText = "NIS"; // nis
                    dataGridView1.Columns[3].HeaderText = "Kelas"; // kelas
                    dataGridView1.Columns[4].HeaderText = "Alamat"; // alamat
                    dataGridView1.Columns[5].Visible = false; // id_user
                    dataGridView1.Columns[6].HeaderText = "Nama Siswa"; // nama
                    dataGridView1.Columns[7].Visible = false; // role
                    dataGridView1.Columns[8].HeaderText = "Email"; // email
                    dataGridView1.Columns[9].HeaderText = "Nomor Telepon"; // no_telp
                    dataGridView1.Columns[10].HeaderText = "Username"; // usernaem
                    dataGridView1.Columns[11].HeaderText = "Password"; // password
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
            nis.Text = "";
            nama.Text = "";
            kelas.Text = unselectedLabel;
            alamat.Text = "";
            notelp.Text = "";
            email.Text = "";
            username.Text = "";
            password.Text = "";
        }

        public bool isInputFilled()
        {
            if (
                !string.IsNullOrEmpty(nis.Text) // jika textbox nis tidak kosong atau null 
                && !string.IsNullOrEmpty(nama.Text) // jika textbox nama tidak kosong atau null 
                && !string.IsNullOrEmpty(kelas.Text) // jika combobox kelas tidak kosong atau null 
                && kelas.Text != unselectedLabel // jika combobox kelas isinya bukan sama dengan label 
                && !string.IsNullOrEmpty(alamat.Text) // jika textbox alamat tidak kosong atau null 
                && !string.IsNullOrEmpty(notelp.Text) // dst
                && !string.IsNullOrEmpty(email.Text)
                && !string.IsNullOrEmpty(username.Text)
                && !string.IsNullOrEmpty(password.Text)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Method ini digunakan utk mengisi inputan sesuai kolum yg kita klik nanti

            dataGridView1.CurrentRow.Selected = true;

            // Buat Refrensi Table Dari showData()
            //dataGridView1.Columns[0].Visible = false; // id_siswa
            //dataGridView1.Columns[1].Visible = false; // id_user
            //dataGridView1.Columns[2].HeaderText = "NIS"; // nis
            //dataGridView1.Columns[3].HeaderText = "Kelas"; // kelas
            //dataGridView1.Columns[4].HeaderText = "Alamat"; // alamat
            //dataGridView1.Columns[5].Visible = false; // id_user
            //dataGridView1.Columns[6].HeaderText = "Nama Siswa"; // nama
            //dataGridView1.Columns[7].Visible = false; // role
            //dataGridView1.Columns[8].HeaderText = "Email"; // email
            //dataGridView1.Columns[9].HeaderText = "Nomor Telepon"; // no_telp
            //dataGridView1.Columns[10].HeaderText = "Username"; // usernaem
            //dataGridView1.Columns[11].HeaderText = "Password"; // password

            id_siswa = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            id_user = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);

            nis.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            nama.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            kelas.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            notelp.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            email.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            username.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            password.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            alamat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }
    }
}
