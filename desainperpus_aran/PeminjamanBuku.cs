using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace desainperpus_aran
{
    public partial class PeminjamanBuku : UserControl
    {
        public SqlConnection connection = new SqlConnection(Koneksi.conn);
        public SqlCommand command;
        public SqlCommand command1;
        public SqlCommand command2;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public string unselctedLabel = "Pilih--";
        public int id_buku;
        public int id_peminjaman;
        public int id_peminjaman_buku;
        public int id_user;
        public Dictionary<string, string> siswaDictionary = new Dictionary<string, string>();
        public Dictionary<string, string> bukuDictionary = new Dictionary<string, string>();

        public PeminjamanBuku()
        {
            InitializeComponent();
            showData();
            ambilSiswa();
            ambilBuku();
            nisSiswa.SelectedIndexChanged += new EventHandler(nisSiswa_SelectedIndexChanged);
        }

        public void showData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = @"
                SELECT 
                	[siswa].[nis],
                	[buku].[id_buku],
                	[user].[id_user],
                	[peminjaman_buku].[id_peminjaman_buku],
                	[peminjaman].[id_peminjaman],
                    [user].[nama],
                    [buku].[judul_buku],
                    [peminjaman_buku].[jml_pinjam],
                    [peminjaman].[tgl_pinjam],
                    CASE 
                        WHEN [pengembalian].[tgl_kembali] IS NULL THEN '-' 
                        ELSE CONVERT(VARCHAR, [peminjaman].[durasi_pinjam]) 
                    END AS durasi_pinjam,
                    CASE 
                        WHEN [pengembalian].[tgl_kembali] IS NULL THEN '-' 
                        ELSE CONVERT(VARCHAR, [peminjaman].[tgl_kembali]) 
                    END AS tgl_kembali,
                    CASE 
                        WHEN [pengembalian].[denda] IS NULL THEN '-' 
                        ELSE CONVERT(VARCHAR, [peminjaman].[denda]) 
                    END AS denda
                FROM 
                    [peminjaman]
                JOIN 
                    [peminjaman_buku] ON [peminjaman].[id_peminjaman] = [peminjaman_buku].[id_peminjaman]
                JOIN 
                    [user] ON [peminjaman].[id_user] = [user].[id_user]
                JOIN 
                    [buku] ON [peminjaman_buku].[id_buku] = [buku].[id_buku]
                JOIN
                	[siswa] ON [user].[id_user] = [siswa].[id_user]
                LEFT JOIN 
                    [pengembalian] ON [peminjaman].[id_peminjaman] = [pengembalian].[id_peminjaman]
                ";

                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                dataGridView1.DataSource = tabel;
                // 0 = nis
                // 1 = id_buku
                // 2 = id_user
                // 3 = id_peminjaman_buku
                // 4 = id_peminjaman
                // 5 = nama
                // 6 = judul_buku
                // 7 = jml_pinjam
                // 8 = tgl_pinjam
                // 9 = durasi_pinjam
                // 10 = tgl_kembali
                // 11 = denda

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].HeaderText = "Peminjam";
                dataGridView1.Columns[6].HeaderText = "Judul Buku";
                dataGridView1.Columns[7].HeaderText = "Jumlah Pinjam";
                dataGridView1.Columns[8].HeaderText = "Tanggal Pinjam";
                dataGridView1.Columns[9].HeaderText = "Durasi Pinjam";
                dataGridView1.Columns[10].HeaderText = "Tanggal Kembali";
                dataGridView1.Columns[11].HeaderText = "Denda";

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = "SELECT [stok] FROM [buku] WHERE [id_buku] = " + id_buku;

                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                reader.Read();
                int jumlahPinjam = Convert.ToInt32(jumlahBuku.Value);
                int stokTersedia = Convert.ToInt32(reader["stok"]);
                if (jumlahPinjam > stokTersedia)
                {
                    MessageBox.Show("Stok buku tidak tersedia untuk jumlah ini");
                    return;
                }

                connection.Close();
                connection.Open();

                sql = @"
                INSERT INTO [peminjaman] 
                (id_user, tgl_pinjam, tgl_kembali, durasi_pinjam, denda) 
                VALUES
                (@id_user, GETDATE(), DATEADD(DAY, 7, GETDATE()), 0, 0);
                
                SELECT SCOPE_IDENTITY();
                ";

                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@id_user", id_user);

                int peminjaman_id = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();
                connection.Open();

                sql = @"
                INSERT INTO [peminjaman_buku]
                (id_peminjaman, id_buku, jml_pinjam)
                VALUES
                (@id_peminjaman, @id_buku, @jml_pinjam)

                UPDATE [buku]
                SET [stok] = @stok
                WHERE [id_buku] = @id_buku
                ";

                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@id_peminjaman", peminjaman_id);
                command.Parameters.AddWithValue("@id_buku", id_buku);
                command.Parameters.AddWithValue("@jml_pinjam", jumlahBuku.Value);


                command.Parameters.AddWithValue("@stok", (stokTersedia - jumlahPinjam));


                command.ExecuteNonQuery();

                MessageBox.Show("Data berhasil dimasukan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                showData();
            }
        }

        public void editData()
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin mengedit?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();

                        string sql = "SELECT [stok] FROM [buku] WHERE [id_buku] = " + id_buku;

                        command = new SqlCommand(sql, connection);
                        reader = command.ExecuteReader();
                        reader.Read();
                        int jumlahPinjam = Convert.ToInt32(jumlahBuku.Value);
                        int stokTersedia = Convert.ToInt32(reader["stok"]);
                        if (jumlahPinjam > stokTersedia)
                        {
                            MessageBox.Show("Stok buku tidak tersedia untuk jumlah ini");
                            return;
                        }

                        connection.Close();
                        connection.Open();

                        // Update peminjaman_buku table
                        sql = @"
                        UPDATE [peminjaman_buku]
                        SET id_buku = @id_buku, jml_pinjam = @jml_pinjam
                        WHERE id_peminjaman = @id_peminjaman";

                        command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@id_buku", id_buku);
                        command.Parameters.AddWithValue("@jml_pinjam", jumlahBuku.Value);
                        command.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);

                        command.ExecuteNonQuery();

                        // Update buku table stock
                        sql = "SELECT [stok] FROM [buku] WHERE [id_buku] = @id_buku";
                        command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@id_buku", id_buku);

                        reader = command.ExecuteReader();
                        reader.Read();

                        connection.Close();
                        connection.Open();

                        sql = @"
                        UPDATE [buku]
                        SET [stok] = @stok
                        WHERE [id_buku] = @id_buku";

                        command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@stok", stokTersedia - jumlahPinjam);
                        command.Parameters.AddWithValue("@id_buku", id_buku);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Update berhasil! (PERINGTAN: STOK BUKU JUGA SUDAH DIKURANGI)", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        showData();
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih data yang ingin diedit.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void deleteData()
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus data",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();

                        // Check if there is a record in [pengembalian] with the given id_peminjaman
                        string checkSql = "SELECT COUNT(*) FROM [pengembalian] WHERE [id_peminjaman] = @id_peminjaman";
                        SqlCommand checkCommand = new SqlCommand(checkSql, connection);
                        checkCommand.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count == 0)
                        {
                            // If no record found, update the stok
                            string sql = "SELECT [stok] FROM [buku] WHERE [id_buku] = @id_buku";
                            command = new SqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@id_buku", id_buku);
                            reader = command.ExecuteReader();
                            reader.Read();
                            int stokTersedia = Convert.ToInt32(reader["stok"]);
                            reader.Close();

                            sql = "SELECT [jml_pinjam] FROM [peminjaman_buku] WHERE [id_peminjaman] = @id_peminjaman";
                            command = new SqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);
                            reader = command.ExecuteReader();
                            reader.Read();
                            int jumlahPinjam = Convert.ToInt32(reader["jml_pinjam"]);
                            reader.Close();

                            sql = @"
                    UPDATE [buku] SET
                    [stok] = @stok
                    WHERE [id_buku] = @id_buku;

                    DELETE FROM [pengembalian] WHERE [id_peminjaman] = @id_peminjaman;
                    DELETE FROM [peminjaman_buku] WHERE [id_peminjaman_buku] = @id_peminjaman_buku;
                    DELETE FROM [peminjaman] WHERE [id_peminjaman] = @id_peminjaman;
                    ";

                            command = new SqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);
                            command.Parameters.AddWithValue("@id_peminjaman_buku", id_peminjaman_buku);
                            command.Parameters.AddWithValue("@id_buku", id_buku);
                            command.Parameters.AddWithValue("@stok", stokTersedia + jumlahPinjam);
                        }
                        else
                        {
                            // If record found, only delete the records
                            string sql = @"
                    DELETE FROM [pengembalian] WHERE [id_peminjaman] = @id_peminjaman;
                    DELETE FROM [peminjaman_buku] WHERE [id_peminjaman_buku] = @id_peminjaman_buku;
                    DELETE FROM [peminjaman] WHERE [id_peminjaman] = @id_peminjaman;
                    ";

                            command = new SqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);
                            command.Parameters.AddWithValue("@id_peminjaman_buku", id_peminjaman_buku);
                            command.Parameters.AddWithValue("@id_buku", id_buku);
                        }

                        command.ExecuteNonQuery();

                        MessageBox.Show("Hapus berhasil", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Gagal hapus",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        showData();
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Silahkan pilih data terlebihdahulu", "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void ambilSiswa()
        {
            try
            {
                nisSiswa.Items.Clear();
                connection.Close();
                connection.Open();

                string sql = @"
                SELECT [siswa].[nis], [user].[nama]
                FROM [user]
                JOIN [siswa] ON [siswa].[id_user] = [user].[id_user]
                ";

                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nis = reader["nis"].ToString();
                    string nama = reader["nama"].ToString();
                    nisSiswa.Items.Add(nis + " (" + nama + ")");
                    siswaDictionary[nis] = nama;
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ambilBuku()
        {
            try
            {
                idBuku.Items.Clear();
                connection.Close();
                connection.Open();

                string sql = "SELECT [buku].[id_buku], " +
                    "[buku].[judul_buku], [buku].[stok] FROM [buku]";

                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string idBukuValue = reader["id_buku"].ToString();
                    string judulBuku = reader["judul_buku"].ToString();
                    string stokBuku = reader["stok"].ToString();
                    idBuku.Items.Add(idBukuValue + " (" + judulBuku + ", Stok: " + stokBuku + ")");
                    bukuDictionary[idBukuValue] = judulBuku;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nisSiswa_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();

            string selectedNis = nisSiswa.SelectedItem.ToString().Split(' ')[0];
            string sql = @"
            SELECT [user].[id_user]
            FROM [user] 
            JOIN [siswa] ON [siswa].[id_user] = [user].[id_user]
            AND [siswa].[nis] = '" + selectedNis + "'";

            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            reader.Read();

            id_user = Convert.ToInt32(reader["id_user"]);

            if (siswaDictionary.ContainsKey(selectedNis))
            {
                namaSiswa.Text = siswaDictionary[selectedNis];
            }

            connection.Close();
        }

        private void idBuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIdBuku = idBuku.SelectedItem.ToString().Split(' ')[0];
            id_buku = Convert.ToInt32(selectedIdBuku);

            if (bukuDictionary.ContainsKey(selectedIdBuku))
            {
                judulBuku.Text = bukuDictionary[selectedIdBuku];
            }

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Method ini digunakan utk mengisi inputan sesuai kolum yg kita klik nanti

            dataGridView1.CurrentRow.Selected = true;

            // 0 = nis
            // 1 = id_buku
            // 2 = id_user
            // 3 = id_peminjaman_buku
            // 4 = id_peminjaman
            // 5 = nama
            // 6 = judul_buku
            // 7 = jml_pinjam
            // 8 = tgl_pinjam
            // 9 = durasi_pinjam
            // 10 = tgl_kembali
            // 11 = denda

            id_buku = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            id_peminjaman_buku = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            id_peminjaman = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            id_user = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);

            idBuku.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            judulBuku.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            nisSiswa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            namaSiswa.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            jumlahBuku.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            //nis.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            editData();
        }
    }
}
